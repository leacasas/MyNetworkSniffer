using MyNetworkSniffer.Domain;

namespace MyNetworkSniffer.Tests;

public class IPHelperTests
{
    [Theory]
    [InlineData("192.168.1.1", true)]
    [InlineData("999.168.1.1", false)]
    [InlineData("192.168.1", false)]
    [InlineData("19216811", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void ValidateIPTest(string ip, bool expected)
    {
        //Arrange
        //Act
        var result = IPHelper.ValidateIP(ip);

        //Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1.1.1.1", IPClass.A)]
    [InlineData("127.0.0.0", IPClass.A)]
    [InlineData("172.0.0.1", IPClass.B)]
    [InlineData("192.168.1.1", IPClass.C)]
    [InlineData("224.0.0.1", IPClass.D)]
    [InlineData("240.0.0.1", IPClass.E)]
    [InlineData("127.0.0.1", IPClass.NetworkTest)]
    [InlineData("999.168.1.1", IPClass.notDetected)]
    [InlineData("192.168.1", IPClass.notDetected)]
    [InlineData("19216811", IPClass.notDetected)]
    [InlineData("", IPClass.notDetected)]
    [InlineData(null, IPClass.notDetected)]
    public void GetIPClassTest(string ip, IPClass expected)
    {
        //Arrange - Inline Data
        //Act
        var result = IPHelper.GetIPClass(ip);

        //Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1.1.1.1", 8)]
    [InlineData("127.0.0.0", 8)]
    [InlineData("172.0.0.1", 16)]
    [InlineData("192.168.1.1", 24)]
    [InlineData("224.0.0.1", 31)]
    [InlineData("240.0.0.1", 32)]
    [InlineData("127.0.0.1", 0)]
    [InlineData("999.168.1.1", -1)]
    [InlineData("192.168.1", -1)]
    [InlineData("19216811", -1)]
    [InlineData("", -1)]
    [InlineData(null, -1)]
    public void GetSubnetMaskBitsCountTest(string ip, int expected)
    {
        //Arrange - Inline Data
        //Act
        var result = IPHelper.GetSubnetMaskBitsCount(ip);

        //Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    //class A with full mask
    [InlineData("1.1.1.1", 8, 32, "11111111111111111111111111111111", false, false, "1.1.1.1")]
    [InlineData("1.1.1.1", 8, 32, "11111111111111111111111111111111", true, false, "1.1.1.1")]
    [InlineData("1.1.1.1", 8, 32, "11111111111111111111111111111111", false, true, "1.1.1.1")]
    //class B with current masks smaller than standard
    [InlineData("172.168.0.200", 16, 16, "11111111111111110000000000000000", false, false, "172.168.0.1")]
    [InlineData("172.168.0.200", 16, 8, "11111111000000000000000000000000", false, false, "172.0.0.1")]
    [InlineData("172.168.0.200", 16, 8, "11111111000000000000000000000000", true, false, "172.255.255.254")]
    [InlineData("172.168.0.200", 16, 8, "11111111000000000000000000000000", false, true, "172.255.255.255")]
    //class C with equal standard and current masks
    [InlineData("192.168.0.237", 24, 24, "11111111111111111111111100000000", false, false, "192.168.0.1")]
    [InlineData("192.168.0.237", 24, 24, "11111111111111111111111100000000", true, false, "192.168.0.254")]
    [InlineData("192.168.0.237", 24, 24, "11111111111111111111111100000000", true, true, "192.168.0.255")]
    public void GetHostIPAddressTest(string ipAddress, int standardSubnetMaskBitsCount, int currentSubnetMaskBitsCount, string currentSubnetMaskInBinaryFormat, bool isLastIP, bool isBroadcast, string expected)
    {
        //Arrange - Inline Data
        //Act
        var result = IPHelper.GetHostIPAddress(ipAddress, standardSubnetMaskBitsCount, currentSubnetMaskBitsCount, currentSubnetMaskInBinaryFormat, isLastIP, isBroadcast);

        //Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("192.168.22.237", "", "192.168.22.237")]
    [InlineData("192.168.22.237", "0.0.0.0", "0.0.0.0")]
    [InlineData("192.168.22.237", "255.0.0.0", "192.0.0.0")]
    [InlineData("192.168.22.237", "255.255.0.0", "192.168.0.0")]
    [InlineData("192.168.22.237", "255.255.255.0", "192.168.22.0")]
    [InlineData("192.168.22.237", "255.255.255.255", "192.168.22.237")]
    public void GetNetIDTest(string ip, string subnetMask, string expected)
    {
        //Arrange - Inline Data
        //Act
        var result = IPHelper.GetNetID(ip, subnetMask);

        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetNetIDTest_ShouldThrowArgumentExeption()
    {
        //Arrange
        string ip = "";
        string subnetMask = "";

        //Act and Assert
        ArgumentException ex = Assert.Throws<ArgumentException>(() => IPHelper.GetNetID(ip, subnetMask));

        //Assert
        Assert.Equal("Invalid value for IP (Parameter 'ip')", ex.Message);
        Assert.Equal("ip", ex.ParamName);
    }

    [Theory]
    [InlineData("0.0.0.0", "0000 0000 0000 0000 0000 0000 0000 0000")]
    [InlineData("1.1.1.1", "0000 0001 0000 0001 0000 0001 0000 0001")]
    [InlineData("255.255.255.255", "1111 1111 1111 1111 1111 1111 1111 1111")]
    public void IPToBitStringTest(string ip, string expected)
    {
        //Arrange - Inline Data
        string newExpected = expected.Replace(" ", ""); //for easier reading of the test cases

        //Act
        var result = IPHelper.IPToBitString(ip);

        //Assert
        Assert.Equal(newExpected, result);
    }

    [Fact]
    public void IPToBitStringTest_ShouldThrowArgumentExeption()
    {
        //Arrange
        string ip = "";

        //Act and Assert
        ArgumentException ex = Assert.Throws<ArgumentException>(() => IPHelper.IPToBitString(ip));

        //Assert
        Assert.Equal("Invalid value for IP (Parameter 'ip')", ex.Message);
        Assert.Equal("ip", ex.ParamName);
    }

    [Theory]
    [InlineData("0000 0000 0000 0000 0000 0000 0000 0000", "0.0.0.0")]
    [InlineData("1111 1111 1111 1111 0000 0000 0000 0000", "255.255.0.0")]
    [InlineData("1111 1111 1111 1111 1111 1111 1111 1111", "255.255.255.255")]
    public void GetSubnetMaskTests(string subnetMask, string expected)
    {
        //Arrange - Inline Data
        string properSubnetMask = subnetMask.Replace(" ", "");

        //Act
        var result = IPHelper.GetSubnetMask(properSubnetMask);

        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetSubnetMaskTests_ShouldThrowArgumentException()
    {
        //Arrange
        string subnetMask = "";

        //Act and Assert
        ArgumentException ex = Assert.Throws<ArgumentException>(() => IPHelper.GetSubnetMask(subnetMask));

        //Assert
        Assert.Equal("Invalid value for mask (Parameter 'maskBits')", ex.Message);
        Assert.Equal("maskBits", ex.ParamName);
    }

    [Theory]
    [InlineData(32, 0)]
    [InlineData(31, 0)]
    [InlineData(30, 2)]
    [InlineData(0, 4294967294)]
    public void GetHostcountTests(int currentSubnetMaskBitcount, long expected)
    {
        //Arrange - Inline Data
        //Act
        long result = IPHelper.GetHostcount(currentSubnetMaskBitcount);

        //Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(24, (int)IPClass.C, 1)]
    [InlineData(32, (int)IPClass.C, 0)]
    public void GetNetCountTests(int IPClassStandardSubnetMaskBitsCount, int currentSubnetMaskBitcount, long expected)
    {
        //Arrange - Inline Data
        //Act
        long result = IPHelper.GetNetCount(IPClassStandardSubnetMaskBitsCount, currentSubnetMaskBitcount);

        //Assert
        Assert.Equal(expected, result);
    }
}