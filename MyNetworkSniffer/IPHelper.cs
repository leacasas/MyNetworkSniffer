using MyNetworkSniffer.Domain;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace MyNetworkSniffer;

public static class IPHelper
{
    public static IPClass GetIPClass(string ip)
    {
        if (ValidateIP(ip))
        {
            string ipClassSegment = ip.Split('.')[0];

            int ipClassNumber = int.Parse(ipClassSegment);

            if ((1 <= ipClassNumber && ipClassNumber <= 126) || ip == "127.0.0.0")
            {
                return IPClass.A;
            }

            if (ipClassNumber == 127)
            {
                return IPClass.NetworkTest;
            }

            if (128 <= ipClassNumber && ipClassNumber <= 191)
            {
                return IPClass.B;
            }

            if (192 <= ipClassNumber && ipClassNumber <= 223)
            {
                return IPClass.C;
            }

            if (224 <= ipClassNumber && ipClassNumber <= 239)
            {
                return IPClass.D;
            }

            if (240 <= ipClassNumber && ipClassNumber <= 255)
            {
                return IPClass.E;
            }
        }
        else
            return IPClass.notDetected;

        return IPClass.notDetected;
    }

    public static int GetSubnetMaskBitsCount(string ip)
    {
        IPClass iPClass = GetIPClass(ip);

        return (int)iPClass;
    }

    public static bool ValidateIP(string ip)
    {
        if (string.IsNullOrEmpty(ip))
            return false;

        var ipParts = ip.Split('.');

        return ipParts.Length == 4
            && !string.IsNullOrEmpty(ipParts[3])
            && IPAddress.TryParse(ip, out _);
    }

    public static string IPToBitString(string ip)
    {
        if (string.IsNullOrWhiteSpace(ip))
            throw new ArgumentException("Invalid value for IP", nameof(ip));

        string[] ipSegments = ip.Split('.');

        StringBuilder stringBuilder = new();

        foreach (string ipSegment in ipSegments)
            stringBuilder.Append(Convert.ToString(int.Parse(ipSegment), 2).PadLeft(8, '0'));

        return stringBuilder.ToString();
    }

    public static string GetNetID(string ip, string subnetMask)
    {
        if (string.IsNullOrWhiteSpace(ip))
            throw new ArgumentException("Invalid value for IP", nameof(ip));

        if (string.IsNullOrWhiteSpace(subnetMask))
            return ip;

        StringBuilder sb = new();

        string[] subnetMaskSegments = subnetMask.Split('.');

        string[] ipSegments = ip.Split('.');

        for (int i = 0; i < subnetMaskSegments.Length; i++)
        {
            if (i == subnetMaskSegments.Length - 1)
                sb.Append(int.Parse(subnetMaskSegments[i]) & int.Parse(ipSegments[i]));
            else
                sb.Append($"{int.Parse(subnetMaskSegments[i]) & int.Parse(ipSegments[i])}.");
        }

        return sb.ToString();
    }

    public static string GetHostIPAddress(string ipAddress, int standardSubnetMaskBitsCount, int currentSubnetMaskBitsCount, string currentSubnetMaskInBinaryFormat, bool isLastIP = false, bool isBroadcast = false)
    {
        int hostLength = 32 - currentSubnetMaskBitsCount;

        int subnetLength = currentSubnetMaskBitsCount - standardSubnetMaskBitsCount;

        string hostPart = currentSubnetMaskInBinaryFormat.Substring(currentSubnetMaskBitsCount, hostLength);

        string ipBits = IPToBitString(ipAddress);

        string netIDplusHost;

        if (isBroadcast)
        {
            int actualMaskBitDepth = Math.Min(standardSubnetMaskBitsCount, currentSubnetMaskBitsCount);

            netIDplusHost = currentSubnetMaskInBinaryFormat.Substring(actualMaskBitDepth, hostLength).Replace('0', '1');
        }
        else
        {
            StringBuilder stringBuilder = new();

            for (int i = 0; i < hostPart.Length; i++)
            {
                if (isLastIP)
                    stringBuilder.Append((i == hostPart.Length - 1) ? '0' : '1');
                else
                    stringBuilder.Append((i == hostPart.Length - 1) ? '1' : '0');
            }

            netIDplusHost = stringBuilder.ToString();
        }

        if (subnetLength > 0)
        {
            string subnetPart = currentSubnetMaskInBinaryFormat.Substring(standardSubnetMaskBitsCount, subnetLength);

            string to_operat_ip_bits = ipBits.Substring(standardSubnetMaskBitsCount, subnetLength);

            StringBuilder sb = new();

            for (int i = 0; i < subnetPart.Length; i++)
                sb.Append(Convert.ToUInt64(to_operat_ip_bits[i].ToString(), 2) & Convert.ToUInt64(subnetPart[i].ToString(), 2));

            for (int i = 0; i < hostPart.Length; i++)
            {
                if (isBroadcast)
                {
                    sb.Append('1');
                    continue;
                }

                if (isLastIP)
                    sb.Append((i == hostPart.Length - 1) ? '0' : '1');
                else
                    sb.Append((i == hostPart.Length - 1) ? '1' : '0');
            }

            netIDplusHost = sb.ToString();
        }

        int IPPartsLength = netIDplusHost.Length / 8;

        string[] ipNewParts = new string[IPPartsLength];

        int j = 0;

        for (int i = 0; i < ipNewParts.Length; i++)
        {
            ipNewParts[i] = netIDplusHost.Substring(j, 8);
            j += 8;
        }

        string[] ipParts = ipAddress.Split('.');

        j = ipParts.Length - 1;

        for (int i = ipNewParts.Length - 1; i >= 0; i--)
            ipParts[j--] = Convert.ToInt64(ipNewParts[i], 2).ToString();

        StringBuilder stringBuilder1 = new();

        for (int i = 0; i < ipParts.Length; i++)
            stringBuilder1.Append((i == ipParts.Length - 1) ? ipParts[i] : ipParts[i] + ".");

        return stringBuilder1.ToString();
    }

    public static long GetHostcount(int currentSubnetMaskBitcount)
    {
        return (long)Math.Max(Math.Pow(2, 32 - currentSubnetMaskBitcount) - 2, 0);
    }

    public static long GetNetCount(int IPClassStandardSubnetMaskBitsCount, int currentSubnetMaskBitcount)
    {
        return (long)Math.Max(Math.Pow(2, currentSubnetMaskBitcount - IPClassStandardSubnetMaskBitsCount), 0);
    }

    public static string GetSubnetMask(string maskBits)
    {
        if (string.IsNullOrWhiteSpace(maskBits))
            throw new ArgumentException("Invalid value for mask", nameof(maskBits));

        string subnetmaskstr = string.Empty;

        int len = maskBits.Length / 8;

        int currentpies = 0;

        for (int i = 0; i < len; i++)
        {
            string targetstr = maskBits.Substring(currentpies, 8);
            string result = Convert.ToInt32(targetstr, 2).ToString();

            if (i == len - 1)
                subnetmaskstr += (result == string.Empty) ? "0" : result;
            else
                subnetmaskstr += (result == string.Empty) ? "0." : result + ".";

            currentpies += 8;
        }

        return subnetmaskstr;
    }

    public static IEnumerable<string> GetIPAddresses(AddressFamily family)
    {
        string hostName = Dns.GetHostName();

        IPHostEntry host = Dns.GetHostEntry(hostName);

        return host.AddressList
            .Where(ip => ip.AddressFamily == family)
            .Select(ip => ip.ToString());
    }

    public static string GetMACAddress(string ipAddress)
    {
        if (!ValidateIP(ipAddress))
            return "invalid IP provided";

        IPAddress address = IPAddress.Parse(ipAddress);

        try
        {
            byte[] MACByte = new byte[6];

            int MACLength = MACByte.Length;

            _ = SendARP((int)address.Address, 0, MACByte, ref MACLength);

            string MACSSTR = BitConverter.ToString(MACByte, 0, 6);

            if (MACSSTR != "00-00-00-00-00-00")
                return PhysicalAddress.Parse(MACSSTR).ToString();
        }
        catch (Exception ex)
        {
            return "not detected";
        }

        return "not detected";
    }

    [DllImport("iphlpapi.dll", ExactSpelling = true)]
    private static extern int SendARP(int DestIP, int SrcIP, [Out] byte[] MacAddr, ref int MacLen);
}