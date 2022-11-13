using System.Runtime.InteropServices;

namespace MyNetworkSniffer.Domain;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
internal struct FixedInfo
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = IPHelperConstants.MAX_HOSTNAME_LEN + 4)]
    internal string HostName;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = IPHelperConstants.MAX_HOSTNAME_LEN + 4)]
    internal string DomainName;
    internal IntPtr CurrentDnsServer;
    internal IPAddress DnsServerList;
    internal uint NodeType;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = IPHelperConstants.MAX_HOSTNAME_LEN + 4)]
    internal string ScopeId;
    internal uint EnableRouting;
    internal uint EnableProxy;
    internal uint EnableDns;
}
