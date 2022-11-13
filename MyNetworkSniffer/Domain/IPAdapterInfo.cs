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
    public LinkedIPAddressString IpAddressList;
    public LinkedIPAddressString GatewayList;
    public LinkedIPAddressString DhcpServer;
    [MarshalAs(UnmanagedType.Bool)]
    public bool HaveWins;
    public LinkedIPAddressString PrimaryWinsServer;
    public LinkedIPAddressString SecondaryWinsServer;
    public long LeaseObtained;
    public long LeaseExpires;

    public IEnumerable<LinkedIPAddressString> IpAddresses => HelperExtensions.ReturnLinkedList(IpAddressList).Where(x => !string.IsNullOrWhiteSpace(x.String));

    public IEnumerable<LinkedIPAddressString> Gateways => HelperExtensions.ReturnLinkedList(GatewayList).Where(x => !string.IsNullOrWhiteSpace(x.String));

    public IEnumerable<LinkedIPAddressString> DhcpServers => HelperExtensions.ReturnLinkedList(DhcpServer).Where(x => !string.IsNullOrWhiteSpace(x.String));

    public IEnumerable<LinkedIPAddressString> PrimaryWinsServers => HelperExtensions.ReturnLinkedList(PrimaryWinsServer).Where(x => !string.IsNullOrWhiteSpace(x.String));

    public IEnumerable<LinkedIPAddressString> SecondaryWinsServers => HelperExtensions.ReturnLinkedList(SecondaryWinsServer).Where(x => !string.IsNullOrWhiteSpace(x.String));

    public IPAdapterInfo? GetNext() => Next == IntPtr.Zero ? null : (IPAdapterInfo)Marshal.PtrToStructure(Next, typeof(IPAdapterInfo));
}