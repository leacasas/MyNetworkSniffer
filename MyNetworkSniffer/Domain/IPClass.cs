namespace MyNetworkSniffer.Domain;

/// <summary>
///  Class A, B, and C are used by the majority of devices on the Internet. Class D and class E are for special uses.
/// </summary>
public enum IPClass
{
    A = 8,
    B = 16,
    C = 24,
    D = 31,
    E = 32,
    notDetected = -1,
    NetworkTest = 0
}