using MyNetworkSniffer.Domain;
using System;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace MyNetworkSniffer;

#pragma warning disable CS8605 // Unboxing a possibly null value.

public static partial class IPHelper
{
    public static string GetMACAddress(string ipAddress)
    {
        if (!ValidateIP(ipAddress))
            return "invalid IP provided";

        System.Net.IPAddress address = System.Net.IPAddress.Parse(ipAddress);

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

    public static FixedInfo GetNetworkParameters()
    {
        IntPtr infoPtr = IntPtr.Zero;

        int infoLen = Marshal.SizeOf(typeof(FixedInfo));

        int ret;

        while (true)
        {
            infoPtr = Marshal.AllocHGlobal(Convert.ToInt32(infoLen));

            ret = GetNetworkParams(infoPtr, ref infoLen);

            if (ret == IPHelperConstants.ERROR_BUFFER_OVERFLOW)
            {
                //try again w/ bigger buffer:
                Marshal.FreeHGlobal(infoPtr);
                continue;
            }

            if (ret == IPHelperConstants.NO_ERROR)
                break;

            //returned ERROR_INVALID_DATA, ERROR_INVALID_PARAMETER, ERROR_NO_DATA or ERROR_NOT_SUPPORTED
            Marshal.FreeHGlobal(infoPtr);
            throw new ApplicationException("An error occurred while fetching network parameters", new Win32Exception(ret));
        }

        return (FixedInfo)Marshal.PtrToStructure(infoPtr, typeof(FixedInfo));
    }

    public static IEnumerable<IPAdapterInfo> GetInfoOfAdapters()
    {
        long structSize = Marshal.SizeOf(typeof(IPAdapterInfo));

        IntPtr infoAdaptersPtr = Marshal.AllocHGlobal(new IntPtr(structSize));

        int result = GetAdaptersInfo(infoAdaptersPtr, ref structSize);

        if (result == IPHelperConstants.ERROR_BUFFER_OVERFLOW)
        {
            infoAdaptersPtr = Marshal.ReAllocHGlobal(infoAdaptersPtr, new IntPtr(structSize));// Retry with bigger buffer

            result = GetAdaptersInfo(infoAdaptersPtr, ref structSize);
        }

        if (result == IPHelperConstants.NO_ERROR)
        {
            IntPtr loopPtr = infoAdaptersPtr;
            var listResult = new List<IPAdapterInfo>();
            do
            {
                IPAdapterInfo adapterInfo = (IPAdapterInfo)Marshal.PtrToStructure(loopPtr, typeof(IPAdapterInfo));

                listResult.Add(adapterInfo);

                loopPtr = adapterInfo.Next; //end of loop.
            }
            while (loopPtr != IntPtr.Zero);

            Marshal.FreeHGlobal(infoAdaptersPtr);

            return listResult;
        }

        //returned ERROR_INVALID_DATA, ERROR_INVALID_PARAMETER, ERROR_NO_DATA or ERROR_NOT_SUPPORTED
        Marshal.FreeHGlobal(infoAdaptersPtr);
        throw new ApplicationException("An error occurred while fetching adapter information.", new Win32Exception(result));
    }

    #region Imported from IP helper DLL

    [DllImport("iphlpapi.dll", ExactSpelling = true)]
    private static extern int SendARP(int DestIP, int SrcIP, [Out] byte[] MacAddr, ref int MacLen);

    [DllImport("iphlpapi.dll", ExactSpelling = true, CharSet = CharSet.Ansi)]
    private static extern int GetNetworkParams(IntPtr pFixedInfo, ref int pBufOutLen);

    [DllImport("iphlpapi.dll", ExactSpelling = true, CharSet = CharSet.Ansi)]
    private static extern int GetAdaptersInfo(IntPtr pAdapterInfo, ref long pBufOutLen);

    #endregion
}

#pragma warning restore CS8605 // Unboxing a possibly null value.
