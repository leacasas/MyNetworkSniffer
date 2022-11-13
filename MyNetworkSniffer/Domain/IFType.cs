namespace MyNetworkSniffer.Domain;

public enum IFTYPE : uint
{
    /// <summary>Some other type of network interface.</summary>
    IF_TYPE_OTHER = 1,

    IF_TYPE_REGULAR_1822 = 2,

    IF_TYPE_HDH_1822 = 3,

    IF_TYPE_DDN_X25 = 4,

    IF_TYPE_RFC877_X25 = 5,

    /// <summary>An Ethernet network interface.</summary>
    IF_TYPE_ETHERNET_CSMACD = 6,

    IF_TYPE_IS088023_CSMACD = 7,

    IF_TYPE_ISO88024_TOKENBUS = 8,

    /// <summary>A token ring network interface.</summary>
    IF_TYPE_ISO88025_TOKENRING = 9,

    IF_TYPE_ISO88026_MAN = 10,

    IF_TYPE_STARLAN = 11,

    IF_TYPE_PROTEON_10MBIT = 12,

    IF_TYPE_PROTEON_80MBIT = 13,

    IF_TYPE_HYPERCHANNEL = 14,

    /// <summary>A Fiber Distributed Data Interface (FDDI) network interface.</summary>
    IF_TYPE_FDDI = 15,

    IF_TYPE_LAP_B = 16,

    IF_TYPE_SDLC = 17,

    /// <summary>DS1-MIB</summary>
    IF_TYPE_DS1 = 18,

    /// <summary>Obsolete; see DS1-MIB</summary>
    IF_TYPE_E1 = 19,

    /// <summary/>
    IF_TYPE_BASIC_ISDN = 20,
    /// <summary/>
    IF_TYPE_PRIMARY_ISDN = 21,

    /// <summary>proprietary serial</summary>
    IF_TYPE_PROP_POINT2POINT_SERIAL = 22,

    /// <summary>A PPP network interface.</summary>
    IF_TYPE_PPP = 23,

    /// <summary>A software loopback network interface.</summary>
    IF_TYPE_SOFTWARE_LOOPBACK = 24,

    /// <summary>CLNP over IP</summary>
    IF_TYPE_EON = 25,

    /// <summary/>
    IF_TYPE_ETHERNET_3MBIT = 26,

    /// <summary>XNS over IP</summary>
    IF_TYPE_NSIP = 27,

    /// <summary>Generic Slip</summary>
    IF_TYPE_SLIP = 28,

    /// <summary>ULTRA Technologies</summary>
    IF_TYPE_ULTRA = 29,

    /// <summary>DS3-MIB</summary>
    IF_TYPE_DS3 = 30,

    /// <summary>SMDS, coffee</summary>
    IF_TYPE_SIP = 31,

    /// <summary>DTE only</summary>
    IF_TYPE_FRAMERELAY = 32,

    IF_TYPE_RS232 = 33,

    /// <summary>Parallel port</summary>
    IF_TYPE_PARA = 34,

    IF_TYPE_ARCNET = 35,

    IF_TYPE_ARCNET_PLUS = 36,

    /// <summary>An ATM network interface.</summary>
    IF_TYPE_ATM = 37,

    IF_TYPE_MIO_X25 = 38,

    /// <summary>SONET or SDH</summary>
    IF_TYPE_SONET = 39,

    IF_TYPE_X25_PLE = 40,

    IF_TYPE_ISO88022_LLC = 41,

    IF_TYPE_LOCALTALK = 42,

    IF_TYPE_SMDS_DXI = 43,

    /// <summary>FRNETSERV-MIB</summary>
    IF_TYPE_FRAMERELAY_SERVICE = 44,

    IF_TYPE_V35 = 45,

    IF_TYPE_HSSI = 46,

    IF_TYPE_HIPPI = 47,

    /// <summary>Generic Modem</summary>
    IF_TYPE_MODEM = 48,

    /// <summary>AAL5 over ATM</summary>
    IF_TYPE_AAL5 = 49,

    IF_TYPE_SONET_PATH = 50,

    IF_TYPE_SONET_VT = 51,

    /// <summary>SMDS InterCarrier Interface</summary>
    IF_TYPE_SMDS_ICIP = 52,

    /// <summary>Proprietary virtual/internal</summary>
    IF_TYPE_PROP_VIRTUAL = 53,

    /// <summary>Proprietary multiplexing</summary>
    IF_TYPE_PROP_MULTIPLEXOR = 54,

    /// <summary>100BaseVG</summary>
    IF_TYPE_IEEE80212 = 55,

    IF_TYPE_FIBRECHANNEL = 56,

    IF_TYPE_HIPPIINTERFACE = 57,

    /// <summary>Obsolete, use 32 or 44</summary>
    IF_TYPE_FRAMERELAY_INTERCONNECT = 58,

    /// <summary>ATM Emulated LAN for 802.3</summary>
    IF_TYPE_AFLANE_8023 = 59,

    /// <summary>ATM Emulated LAN for 802.5</summary>
    IF_TYPE_AFLANE_8025 = 60,

    /// <summary>ATM Emulated circuit</summary>
    IF_TYPE_CCTEMUL = 61,

    /// <summary>Fast Ethernet (100BaseT)</summary>
    IF_TYPE_FASTETHER = 62,

    /// <summary>ISDN and X.25</summary>
    IF_TYPE_ISDN = 63,

    /// <summary>CCITT V.11/X.21</summary>
    IF_TYPE_V11 = 64,

    /// <summary>CCITT V.36</summary>
    IF_TYPE_V36 = 65,

    /// <summary>CCITT G703 at 64Kbps</summary>
    IF_TYPE_G703_64K = 66,

    /// <summary>Obsolete; see DS1-MIB</summary>
    IF_TYPE_G703_2MB = 67,

    /// <summary>SNA QLLC</summary>
    IF_TYPE_QLLC = 68,

    /// <summary>Fast Ethernet (100BaseFX)</summary>
    IF_TYPE_FASTETHER_FX = 69,

    /// <summary/>
    IF_TYPE_CHANNEL = 70,

    /// <summary>An IEEE 802.11 wireless network interface.</summary>
    IF_TYPE_IEEE80211 = 71,

    /// <summary>IBM System 360/370 OEMI Channel</summary>
    IF_TYPE_IBM370PARCHAN = 72,

    /// <summary>IBM Enterprise Systems Connection</summary>
    IF_TYPE_ESCON = 73,

    /// <summary>Data Link Switching</summary>
    IF_TYPE_DLSW = 74,

    /// <summary>ISDN S/T interface</summary>
    IF_TYPE_ISDN_S = 75,

    /// <summary>ISDN U interface</summary>
    IF_TYPE_ISDN_U = 76,

    /// <summary>Link Access Protocol D</summary>
    IF_TYPE_LAP_D = 77,

    /// <summary>IP Switching Objects</summary>
    IF_TYPE_IPSWITCH = 78,

    /// <summary>Remote Source Route Bridging</summary>
    IF_TYPE_RSRB = 79,

    /// <summary>ATM Logical Port</summary>
    IF_TYPE_ATM_LOGICAL = 80,

    /// <summary>Digital Signal Level 0</summary>
    IF_TYPE_DS0 = 81,

    /// <summary>Group of ds0s on the same ds1</summary>
    IF_TYPE_DS0_BUNDLE = 82,

    /// <summary>Bisynchronous Protocol</summary>
    IF_TYPE_BSC = 83,

    /// <summary>Asynchronous Protocol</summary>
    IF_TYPE_ASYNC = 84,

    /// <summary>Combat Net Radio</summary>
    IF_TYPE_CNR = 85,

    /// <summary>ISO 802.5r DTR</summary>
    IF_TYPE_ISO88025R_DTR = 86,

    /// <summary>Ext Pos Loc Report Sys</summary>
    IF_TYPE_EPLRS = 87,

    /// <summary>Appletalk Remote Access Protocol</summary>
    IF_TYPE_ARAP = 88,

    /// <summary>Proprietary Connectionless Proto</summary>
    IF_TYPE_PROP_CNLS = 89,

    /// <summary>CCITT-ITU X.29 PAD Protocol</summary>
    IF_TYPE_HOSTPAD = 90,

    /// <summary>CCITT-ITU X.3 PAD Facility</summary>
    IF_TYPE_TERMPAD = 91,

    /// <summary>Multiproto Interconnect over FR</summary>
    IF_TYPE_FRAMERELAY_MPI = 92,

    /// <summary>CCITT-ITU X213</summary>
    IF_TYPE_X213 = 93,

    /// <summary>Asymmetric Digital Subscrbr Loop</summary>
    IF_TYPE_ADSL = 94,

    /// <summary>Rate-Adapt Digital Subscrbr Loop</summary>
    IF_TYPE_RADSL = 95,

    /// <summary>Symmetric Digital Subscriber Loop</summary>
    IF_TYPE_SDSL = 96,

    /// <summary>Very H-Speed Digital Subscrb Loop</summary>
    IF_TYPE_VDSL = 97,

    /// <summary>ISO 802.5 CRFP</summary>
    IF_TYPE_ISO88025_CRFPRINT = 98,

    /// <summary>Myricom Myrinet</summary>
    IF_TYPE_MYRINET = 99,

    /// <summary>Voice recEive and transMit</summary>
    IF_TYPE_VOICE_EM = 100,

    /// <summary>Voice Foreign Exchange Office</summary>
    IF_TYPE_VOICE_FXO = 101,

    /// <summary>Voice Foreign Exchange Station</summary>
    IF_TYPE_VOICE_FXS = 102,

    /// <summary>Voice encapsulation</summary>
    IF_TYPE_VOICE_ENCAP = 103,

    /// <summary>Voice over IP encapsulation</summary>
    IF_TYPE_VOICE_OVERIP = 104,

    /// <summary>ATM DXI</summary>
    IF_TYPE_ATM_DXI = 105,

    /// <summary>ATM FUNI</summary>
    IF_TYPE_ATM_FUNI = 106,

    /// <summary>ATM IMA</summary>
    IF_TYPE_ATM_IMA = 107,

    /// <summary>PPP Multilink Bundle</summary>
    IF_TYPE_PPPMULTILINKBUNDLE = 108,

    /// <summary>IBM ipOverCdlc</summary>
    IF_TYPE_IPOVER_CDLC = 109,

    /// <summary>IBM Common Link Access to Workstn</summary>
    IF_TYPE_IPOVER_CLAW = 110,

    /// <summary>IBM stackToStack</summary>
    IF_TYPE_STACKTOSTACK = 111,

    /// <summary>IBM VIPA</summary>
    IF_TYPE_VIRTUALIPADDRESS = 112,

    /// <summary>IBM multi-proto channel support</summary>
    IF_TYPE_MPC = 113,

    /// <summary>IBM ipOverAtm</summary>
    IF_TYPE_IPOVER_ATM = 114,

    /// <summary>ISO 802.5j Fiber Token Ring</summary>
    IF_TYPE_ISO88025_FIBER = 115,

    /// <summary>IBM twinaxial data link control</summary>
    IF_TYPE_TDLC = 116,


    IF_TYPE_GIGABITETHERNET = 117,

    IF_TYPE_HDLC = 118,

    IF_TYPE_LAP_F = 119,

    IF_TYPE_V37 = 120,

    /// <summary>Multi-Link Protocol</summary>
    IF_TYPE_X25_MLP = 121,

    /// <summary>X.25 Hunt Group</summary>
    IF_TYPE_X25_HUNTGROUP = 122,

    /// <summary/>
    IF_TYPE_TRANSPHDLC = 123,

    /// <summary>Interleave channel</summary>
    IF_TYPE_INTERLEAVE = 124,

    /// <summary>Fast channel</summary>
    IF_TYPE_FAST = 125,

    /// <summary>IP (for APPN HPR in IP networks)</summary>
    IF_TYPE_IP = 126,

    /// <summary>CATV Mac Layer</summary>
    IF_TYPE_DOCSCABLE_MACLAYER = 127,

    /// <summary>CATV Downstream interface</summary>
    IF_TYPE_DOCSCABLE_DOWNSTREAM = 128,

    /// <summary>CATV Upstream interface</summary>
    IF_TYPE_DOCSCABLE_UPSTREAM = 129,

    /// <summary>Avalon Parallel Processor</summary>
    IF_TYPE_A12MPPSWITCH = 130,

    /// <summary>A tunnel type encapsulation network interface.</summary>
    IF_TYPE_TUNNEL = 131, // Encapsulation interface

    /// <summary>Coffee pot</summary>
    IF_TYPE_COFFEE = 132,

    /// <summary>Circuit Emulation Service</summary>
    IF_TYPE_CES = 133,

    /// <summary>ATM Sub Interface</summary>
    IF_TYPE_ATM_SUBINTERFACE = 134,

    /// <summary>Layer 2 Virtual LAN using 802.1Q</summary>
    IF_TYPE_L2_VLAN = 135,

    /// <summary>Layer 3 Virtual LAN using IP</summary>
    IF_TYPE_L3_IPVLAN = 136,

    /// <summary>Layer 3 Virtual LAN using IPX</summary>
    IF_TYPE_L3_IPXVLAN = 137,

    /// <summary>IP over Power Lines</summary>
    IF_TYPE_DIGITALPOWERLINE = 138,

    /// <summary>Multimedia Mail over IP</summary>
    IF_TYPE_MEDIAMAILOVERIP = 139,

    /// <summary>Dynamic syncronous Transfer Mode</summary>
    IF_TYPE_DTM = 140,

    /// <summary>Data Communications Network</summary>
    IF_TYPE_DCN = 141,

    /// <summary>IP Forwarding Interface</summary>
    IF_TYPE_IPFORWARD = 142,

    /// <summary>Multi-rate Symmetric DSL</summary>
    IF_TYPE_MSDSL = 143,

    /// <summary>An IEEE 1394 (Firewire) high performance serial bus network interface.</summary>
    IF_TYPE_IEEE1394 = 144, // IEEE1394 High Perf Serial Bus


    IF_TYPE_IF_GSN = 145,

    IF_TYPE_DVBRCC_MACLAYER = 146,

    IF_TYPE_DVBRCC_DOWNSTREAM = 147,

    IF_TYPE_DVBRCC_UPSTREAM = 148,

    IF_TYPE_ATM_VIRTUAL = 149,

    IF_TYPE_MPLS_TUNNEL = 150,

    IF_TYPE_SRP = 151,

    IF_TYPE_VOICEOVERATM = 152,

    IF_TYPE_VOICEOVERFRAMERELAY = 153,

    IF_TYPE_IDSL = 154,

    IF_TYPE_COMPOSITELINK = 155,

    IF_TYPE_SS7_SIGLINK = 156,

    IF_TYPE_PROP_WIRELESS_P2P = 157,

    IF_TYPE_FR_FORWARD = 158,

    IF_TYPE_RFC1483 = 159,

    IF_TYPE_USB = 160,

    IF_TYPE_IEEE8023AD_LAG = 161,

    IF_TYPE_BGP_POLICY_ACCOUNTING = 162,

    IF_TYPE_FRF16_MFR_BUNDLE = 163,

    IF_TYPE_H323_GATEKEEPER = 164,

    IF_TYPE_H323_PROXY = 165,

    IF_TYPE_MPLS = 166,

    IF_TYPE_MF_SIGLINK = 167,

    IF_TYPE_HDSL2 = 168,

    IF_TYPE_SHDSL = 169,

    IF_TYPE_DS1_FDL = 170,

    IF_TYPE_POS = 171,

    IF_TYPE_DVB_ASI_IN = 172,

    IF_TYPE_DVB_ASI_OUT = 173,

    IF_TYPE_PLC = 174,

    IF_TYPE_NFAS = 175,

    IF_TYPE_TR008 = 176,

    IF_TYPE_GR303_RDT = 177,

    IF_TYPE_GR303_IDT = 178,

    IF_TYPE_ISUP = 179,

    IF_TYPE_PROP_DOCS_WIRELESS_MACLAYER = 180,

    IF_TYPE_PROP_DOCS_WIRELESS_DOWNSTREAM = 181,

    IF_TYPE_PROP_DOCS_WIRELESS_UPSTREAM = 182,

    IF_TYPE_HIPERLAN2 = 183,

    IF_TYPE_PROP_BWA_P2MP = 184,

    IF_TYPE_SONET_OVERHEAD_CHANNEL = 185,

    IF_TYPE_DIGITAL_WRAPPER_OVERHEAD_CHANNEL = 186,

    IF_TYPE_AAL2 = 187,

    IF_TYPE_RADIO_MAC = 188,

    IF_TYPE_ATM_RADIO = 189,

    IF_TYPE_IMT = 190,

    IF_TYPE_MVL = 191,

    IF_TYPE_REACH_DSL = 192,

    IF_TYPE_FR_DLCI_ENDPT = 193,

    IF_TYPE_ATM_VCI_ENDPT = 194,

    IF_TYPE_OPTICAL_CHANNEL = 195,

    IF_TYPE_OPTICAL_TRANSPORT = 196,

    /// <summary> A mobile broadband interface for WiMax devices. <note type="note">This interface type is supported on Windows 7, Windows Server 2008 R2, and later.</note></summary>
    IF_TYPE_IEEE80216_WMAN = 237,

    /// <summary> A mobile broadband interface for GSM-based devices. <note type="note">This interface type is supported on Windows 7, Windows Server 2008 R2, and later.</note></summary>
    IF_TYPE_WWANPP = 243,

    /// <summary> A mobile broadband interface for CDMA-based devices. <note type="note">This interface type is supported on Windows 7, Windows Server 2008 R2, and later.</note></summary>
    IF_TYPE_WWANPP2 = 244,

    /// <summary>IEEE 802.15.4 WPAN interface</summary>
    IF_TYPE_IEEE802154 = 259,

    IF_TYPE_XBOX_WIRELESS = 281,
}