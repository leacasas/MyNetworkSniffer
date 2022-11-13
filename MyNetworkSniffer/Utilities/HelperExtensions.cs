using MyNetworkSniffer.Domain;

namespace MyNetworkSniffer.Utilities;

public static class HelperExtensions
{
    public static IEnumerable<LinkedIPAddressString> ReturnLinkedList(this LinkedIPAddressString addressList)
    {
        if (addressList.String != null)
            yield return addressList;

        var next = addressList.GetNext();

        while (next != null)
        {
            yield return next.Value;
            next = next.Value.GetNext();
        }
    }
}