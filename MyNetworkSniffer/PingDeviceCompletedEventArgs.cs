using MyNetworkSniffer.Domain;

namespace MyNetworkSniffer;

internal class PingDeviceCompletedEventArgs : EventArgs
{
    internal PingStatus Status { get; set; }

    internal string IP { get; set; }

    internal IEnumerable<string> IPV6Address { get; set; }

    internal string MACAddress { get; set; }

    internal string HostName { get; set; }

    internal string Message { get; set; }
}