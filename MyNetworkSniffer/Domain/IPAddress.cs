using System.Runtime.InteropServices;

namespace MyNetworkSniffer.Domain;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
internal struct IPAddress
{
    internal IntPtr Next;
    internal IPAddressString IpAddress;
    internal IPAddressString IpMask;
    internal uint Context;
}

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
internal struct IPAddressString
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    internal string String;
}