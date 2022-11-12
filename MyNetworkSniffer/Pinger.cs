using MyNetworkSniffer.Domain;
using System.Net;

namespace MyNetworkSniffer
{
    internal class Pinger
    {
        internal async void SendPingAsync(string hostNameOrAddress, bool autoTimeout, int timeoutInMillis, PingDeviceCompletedEventHandler eventHandler)
        {
            PingDeviceCompletedEventArgs args = new();

            try
            {
                args.Status = PingStatus.Pending;

                IPHostEntry ipHostEntry = autoTimeout
                    ? await Dns.GetHostEntryAsync(hostNameOrAddress).WaitAsync(new TimeSpan(0, 0, 0, 0, timeoutInMillis))
                    : await Dns.GetHostEntryAsync(hostNameOrAddress);

                if (ipHostEntry == null)
                {
                    args.Status = PingStatus.Timeout;
                    args.IP = string.Empty;

                    eventHandler?.Invoke(this, args);
                }
                else
                {
                    args.Status = PingStatus.Completed;
                    args.IP = hostNameOrAddress;

                    eventHandler?.Invoke(this, args);
                }
            }
            catch (Exception ex)
            {
                args.Status = PingStatus.InvalidHost;
                args.IP = string.Empty;

                eventHandler?.Invoke(this, args);
            }
        }
    }

    internal delegate void PingDeviceCompletedEventHandler(object sender, PingDeviceCompletedEventArgs e);
}
