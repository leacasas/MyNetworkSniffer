using MyNetworkSniffer.Utilities;
using System.Runtime.InteropServices;

namespace MyNetworkSniffer.Domain;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct IPAdapterInfo
{
    public IntPtr Next;
    public uint ComboIndex;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = IPHelperConstants.MAX_ADAPTER_NAME_LENGTH + 4)]
    public string AdapterName;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = IPHelperConstants.MAX_ADAPTER_DESCRIPTION_LENGTH + 4)]
    public string AdapterDescription;
    public uint AddressLength;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = IPHelperConstants.MAX_ADAPTER_ADDRESS_LENGTH)]
    public byte[] Address;
    public uint Index;
    public IFTYPE Type;
    [MarshalAs(UnmanagedType.Bool)]
    public bool DhcpEnabled;
    public IntPtr CurrentIpAddress;
    public IPAddress IpAddressList;
    public IPAddress GatewayList;
    public IPAddress DhcpServer;
    [MarshalAs(UnmanagedType.Bool)]
    public bool HaveWins;
    public IPAddress PrimaryWinsServer;
    public IPAddress SecondaryWinsServer;
    public long LeaseObtained;
    public long LeaseExpires;

    public IEnumerable<IPAddress> IpAddresses => HelperExtensions.ReturnLinkedList(IpAddressList).Where(x => !string.IsNullOrWhiteSpace(x.IpAddress.String));

    public IEnumerable<IPAddress> Gateways => HelperExtensions.ReturnLinkedList(GatewayList).Where(x => !string.IsNullOrWhiteSpace(x.IpAddress.String));

    public IEnumerable<IPAddress> DhcpServers => HelperExtensions.ReturnLinkedList(DhcpServer).Where(x => !string.IsNullOrWhiteSpace(x.IpAddress.String));

    public IEnumerable<IPAddress> PrimaryWinsServers => HelperExtensions.ReturnLinkedList(PrimaryWinsServer).Where(x => !string.IsNullOrWhiteSpace(x.IpAddress.String));

    public IEnumerable<IPAddress> SecondaryWinsServers => HelperExtensions.ReturnLinkedList(SecondaryWinsServer).Where(x => !string.IsNullOrWhiteSpace(x.IpAddress.String));

    public IPAdapterInfo? GetNext() => Next == IntPtr.Zero ? null : (IPAdapterInfo)Marshal.PtrToStructure(Next, typeof(IPAdapterInfo));
}