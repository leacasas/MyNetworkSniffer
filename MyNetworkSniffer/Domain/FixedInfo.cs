using MyNetworkSniffer.Utilities;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace MyNetworkSniffer.Domain;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct FixedInfo
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = IPHelperConstants.MAX_HOSTNAME_LEN + 4)]
    public string HostName;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = IPHelperConstants.MAX_HOSTNAME_LEN + 4)]
    public string DomainName;
    public IntPtr CurrentDnsServer;
    public IPAddress DnsServerList;
    public NetBiosNodeType NodeType;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = IPHelperConstants.MAX_HOSTNAME_LEN + 4)]
    public string ScopeId;
    public uint EnableRouting;
    public uint EnableProxy;
    public uint EnableDns;

    public IEnumerable<IPAddress> DnsServers => HelperExtensions.ReturnLinkedList(DnsServerList).Where(x => !string.IsNullOrWhiteSpace(x.IpAddress.String));
}