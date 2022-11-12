namespace MyNetworkSniffer.Domain
{
    internal class ActiveDevice
    {
        internal string IPV4Address { get; set; }
        internal IEnumerable<string> IPV6Address { get; set; }
        internal string MACAddress { get; set; }
        internal string HostName { get; set; }

        internal string HostAndIPV4
        {
            get
            {
                return HostName + IPV4Address;
            }
        }

        internal ActiveDevice(string ipv4, IEnumerable<string> ipv6, string mac, string host)
        {
            IPV4Address = ipv4;
            IPV6Address = ipv6;
            MACAddress = mac;
            HostName = host;
        }
    }
}