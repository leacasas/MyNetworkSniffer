using MyNetworkSniffer.Domain;

namespace MyNetworkSniffer;

public class PingDeviceCompletedEventArgs : EventArgs
{
    public PingStatus Status { get; set; }

    public string IP { get; set; }

    public string Message { get; set; }
}
