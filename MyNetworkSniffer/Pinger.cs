using MyNetworkSniffer.Domain;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace MyNetworkSniffer
{
    internal class Pinger
    {
        internal async void SendPingAsync(string hostNameOrAddress, bool autoTimeout, int timeoutInMillis, PingDeviceCompletedCallback callbackDelegate)
        {
            PingDeviceCompletedEventArgs args = new();

            try
            {
                args.Status = PingStatus.Pending;

#if DEBUG
                Debug.Print($"Sending ping to {hostNameOrAddress}");
#endif

                IPHostEntry ipHostEntry = autoTimeout
                    ? await Dns.GetHostEntryAsync(hostNameOrAddress)
                    : await Dns.GetHostEntryAsync(hostNameOrAddress).WaitAsync(new TimeSpan(0, 0, 0, 0, timeoutInMillis));

                if (ipHostEntry == null)
                {
#if DEBUG
                    Debug.Print($"{hostNameOrAddress} did not respond");
#endif

                    args.Status = PingStatus.Timeout;
                    args.IP = string.Empty;

                    callbackDelegate?.Invoke(this, args);
                }
                else
                {
#if DEBUG
                    Debug.Print($"received ping from {hostNameOrAddress}");
#endif
                    args.Status = PingStatus.Completed;
                    args.IP = hostNameOrAddress;
                    args.HostName = ipHostEntry.HostName ?? "";
                    args.IPV6Address = ipHostEntry.AddressList.Where(x => x.AddressFamily == AddressFamily.InterNetworkV6).Select(x => x.ToString());
                    args.MACAddress = IPHelper.GetMACAddress(hostNameOrAddress);

                    callbackDelegate?.Invoke(this, args);
                }
            }
            catch (Exception ex)
            {
                args.Status = PingStatus.InvalidHost;
                args.Message = ex.Message;
                args.IP = string.Empty;

                callbackDelegate?.Invoke(this, args);
            }
        }
    }

    internal delegate void PingDeviceCompletedCallback(object sender, PingDeviceCompletedEventArgs e);
}
