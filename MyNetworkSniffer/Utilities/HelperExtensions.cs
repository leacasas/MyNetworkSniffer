using MyNetworkSniffer.Domain;

namespace MyNetworkSniffer.Utilities;

public static class HelperExtensions
{
    public static IEnumerable<IPAddress> ReturnLinkedList(this IPAddress addressList)
    {
        if (addressList.IpAddress.String != null)
            yield return addressList;

        var next = addressList.GetNext();

        while (next != null)
        {
            yield return next.Value;
            next = next.Value.GetNext();
        }
    }
}