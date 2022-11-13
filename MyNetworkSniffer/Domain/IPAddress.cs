using System.Runtime.InteropServices;

namespace MyNetworkSniffer.Domain;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct IPAddress
{
    public IntPtr Next;
    public IPAddressString IpAddress;
    public IPAddressString IpMask;
    public uint Context;
    public IPAddress? GetNext() => Next == IntPtr.Zero ? null : (IPAddress)Marshal.PtrToStructure(Next, typeof(IPAddress));
}

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct IPAddressString
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string String;
}

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct LinkedIPAddressString
{
    public IntPtr Next;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string String;

    public LinkedIPAddressString? GetNext() => Next == IntPtr.Zero ? null : (LinkedIPAddressString)Marshal.PtrToStructure(Next, typeof(LinkedIPAddressString));
}