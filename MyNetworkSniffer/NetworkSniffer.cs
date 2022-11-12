using MyNetworkSniffer.Domain;
using System.ComponentModel;
using System.Net.Sockets;
using System.Text;

namespace MyNetworkSniffer;

public partial class NetworkSniffer : Form
{
    private int _pingedCount;

    string IP
    {
        get
        {
            if (EnterIpRadioButton.Checked)
                return IPTextBox.Text;
            else
            {
                if (IPcomboBox.SelectedIndex != -1)
                    return IPcomboBox.SelectedItem.ToString();
            }

            return string.Empty;
        }
    }

    public NetworkSniffer()
    {
        InitializeComponent();
        GetLocalIPAddress();
    }

    #region UI events

    private void IPcomboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        RefreshControls(sender, e);
    }

    private void MaskBitsTrackBar_Scroll(object sender, EventArgs e)
    {
        int submask = IPHelper.GetSubnetMaskBitsCount(IP);

        if (submask > MaskBitsTrackBar.Value)
        {
            MaskBitsTrackBar.Value = submask;
        }
        else
        {
            MaskBitsSuffixLabel.Text = $"/ {MaskBitsTrackBar.Value}";

            StringBuilder sb = new();

            for (int i = 0; i < MaskBitsTrackBar.Value; i++)
            {
                sb.Append('1');
            }

            for (int i = MaskBitsTrackBar.Value; i < MaskBitsTrackBar.Maximum; i++)
            {
                sb.Append('0');
            }

            MaskBitsRichTextBox.Text = sb.ToString();

            if (MaskBitsTrackBar.Enabled)
            {
                NetIDTextBox.Text = IPHelper.GetNetID(IP, SubnetMaskTextBox.Text);
                LastIPTextBox.Text = IPHelper.GetHostIPAddress(IP, submask, MaskBitsTrackBar.Value, MaskBitsRichTextBox.Text, true).ToString();
                FirstIPTextBox.Text = IPHelper.GetHostIPAddress(IP, submask, MaskBitsTrackBar.Value, MaskBitsRichTextBox.Text).ToString();
                MaxHostsCountTextBox.Text = IPHelper.GetHostcount(MaskBitsTrackBar.Value).ToString();
                MaxIDTextBox.Text = IPHelper.GetNetCount(submask, MaskBitsTrackBar.Value).ToString();
                BroadcastTextBox.Text = IPHelper.GetHostIPAddress(IP, submask, MaskBitsTrackBar.Value, MaskBitsRichTextBox.Text, false, true).ToString();
            }
        }
    }

    private void EnterIpRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        IPTextBox.Enabled = EnterIpRadioButton.Checked;
        IPcomboBox.Enabled = !EnterIpRadioButton.Checked;

        MaskBitsTrackBar.Value = 0;
        MaskBitsTrackBar.Enabled = IPHelper.ValidateIP(IP);

        MaskBitsTrackBar_Scroll(sender, e);
    }

    private void MaskBitsRichTextBox_TextChanged(object sender, EventArgs e)
    {
        int selection = 0;

        for (int i = 0; i < MaskBitsRichTextBox.Text.Length; i++)
        {
            if (MaskBitsRichTextBox.Text[i] == '1')
                selection++;
        }

        if (selection > 0)
        {
            MaskBitsRichTextBox.Select(0, selection);
            MaskBitsRichTextBox.SelectionColor = Color.White;
            MaskBitsRichTextBox.SelectionBackColor = Color.Red;
        }

        SubnetMaskTextBox.Text = IPHelper.GetSubnetMask(MaskBitsRichTextBox.Text);
    }

    private void IPTextBox_TextChanged(object sender, EventArgs e)
    {
        RefreshControls(sender, e);
    }

    private void PingerBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
        try
        {
            SafeInvoke(this, () =>
            {
                string ip = EnterIpRadioButton.Checked ? IPTextBox.Text : (string)IPcomboBox.SelectedItem;

                PingAllDevices(ip, ParseTag());
            });

            int progressLimit = int.Parse(MaxHostsCountTextBox.Text) * int.Parse(MaxIDTextBox.Text);

            while (true)
            {
                if (progressLimit > 0)
                {
                    SafeInvoke(progressBar, () => { progressBar.Value = (_pingedCount + 1) * 100 / progressLimit; });

                    if (_pingedCount == progressLimit)
                    {
                        SafeInvoke(progressBar, () => progressBar.Value = 0);

                        _pingedCount = 0;

                        SafeInvoke(LogTextBox, () => LogTextBox.AppendText("-Pinged all detected devices-"));

                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
        if (PingerBackgroundWorker.IsBusy)
            return;

        FoundIPTreeView.Nodes.Clear();
        PingerBackgroundWorker.RunWorkerAsync();
    }

    private void AutoTimeoutButton_Click(object sender, EventArgs e)
    {
        bool tag = ParseTag();

        AutoTimeoutButton.Image = tag ? Properties.Resources.switch_off : Properties.Resources.switch_on;
        AutoTimeoutButton.Tag = !tag;
        TimeoutNumericUpDown.Enabled = tag;
    }

    #endregion

    #region Private Methods

    private void GetLocalIPAddress()
    {
        IPcomboBox.Items.Clear();
        IPcomboBox.Items.AddRange(IPHelper.GetIPAddresses(AddressFamily.InterNetwork).ToArray());
    }

    private void RefreshControls(object sender, EventArgs e)
    {
        if (IPHelper.ValidateIP(IP))
        {
            MaskBitsTrackBar.Enabled = true;

            MaskBitsTrackBar.Value = IPHelper.GetSubnetMaskBitsCount(IP);

            MaskBitsTrackBar_Scroll(sender, e);

            IPClass ipClass = IPHelper.GetIPClass(IP);

            IPClassTextBox.Text = ipClass.ToString();

            if (ipClass == IPClass.C)
            {
                RecommendLabel.Text = "Recommended";
                RecommendLabel.BackColor = Color.Green;
            }

            if (ipClass == IPClass.B)
            {
                RecommendLabel.Text = "Recommended but a little slow";
                RecommendLabel.BackColor = Color.Gold;
            }

            if (ipClass == IPClass.A)
            {
                RecommendLabel.Text = "Not Recommended";
                RecommendLabel.BackColor = Color.Red;
            }
        }
        else
        {
            MaskBitsTrackBar.Enabled = false;
        }
    }

    private void SafeInvoke(Control uiElement, Action updater)
    {
        if (uiElement == null)
            throw new ArgumentNullException("uiElement was null");

        if (uiElement.InvokeRequired)
        {
            uiElement.BeginInvoke(() => SafeInvoke(uiElement, updater));
        }
        else
        {
            if (uiElement.IsDisposed)
                throw new ObjectDisposedException($"{uiElement.Name} is already disposed.");

            updater();
        }
    }

    private void PingAllDevices(string ipAddress, bool autoTimeout)
    {
        string[] ipSegments = ipAddress.Split('.');

        IPClass iPClass = IPHelper.GetIPClass(ipAddress);

        if (iPClass == IPClass.D)
            MessageBox.Show("Cannot ping multicast address");

        if (iPClass == IPClass.E)
            MessageBox.Show("Cannot ping address from Class E");

        if (iPClass == IPClass.A)
        {
            SafeInvoke(LogTextBox, () => LogTextBox.AppendText(logPingMessage(ipSegments[0], 0, 0, 0)));

            for (int a = 1; a < 255; a++)
            {
                SafeInvoke(LogTextBox, () => LogTextBox.AppendText(logPingMessage(ipSegments[0], a, 0, 0)));

                for (int b = 1; b < 255; b++)
                {
                    SafeInvoke(LogTextBox, () => LogTextBox.AppendText(logPingMessage(ipSegments[0], a, b, 0)));

                    for (int c = 1; c < 255; c++)
                    {
                        string ipToPing = $"{ipSegments[0]}.{a}.{b}.{c}";

                        PingDevice(ipToPing, autoTimeout, (int)TimeoutNumericUpDown.Value);
                    }
                }

            }
        }

        if (iPClass == IPClass.B)
        {
            SafeInvoke(LogTextBox, () => LogTextBox.AppendText(logPingMessage(ipSegments[0], ipSegments[1], 0, 0)));

            for (int a = 1; a < 255; a++)
            {
                SafeInvoke(LogTextBox, () => LogTextBox.AppendText(logPingMessage(ipSegments[0], ipSegments[1], a, 0)));

                for (int b = 1; b < 255; b++)
                {
                    string ipToPing = $"{ipSegments[0]}.{ipSegments[1]}.{a}.{b}";

                    PingDevice(ipToPing, autoTimeout, (int)TimeoutNumericUpDown.Value);

                }

            }

        }

        if (iPClass == IPClass.C)
        {
            SafeInvoke(LogTextBox, () => LogTextBox.AppendText(logPingMessage(ipSegments[0], ipSegments[1], ipSegments[2], 0)));

            for (int a = 1; a < 255; a++)
            {
                string ipToPing = $"{ipSegments[0]}.{ipSegments[1]}.{ipSegments[2]}.{a}";

                PingDevice(ipToPing, autoTimeout, (int)TimeoutNumericUpDown.Value);
            }
        }

        static string logPingMessage(object a, object b, object c, object d)
        {
            return $"ping all in {a}.{b}.{c}.{d} available devices {Environment.NewLine}";
        }
    }

    private void PingDevice(string host, bool autoTimeout, int timeoutInMillis)
    {
        Thread thread = new(() =>
        {
            try
            {
                Pinger ping = new();

                ping.SendPingAsync(host, autoTimeout, timeoutInMillis, new PingDeviceCompletedEventHandler(PingCompletedIntermediateHandler));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        });

        thread.Start();
    }

    private void PingCompletedIntermediateHandler(object sender, PingDeviceCompletedEventArgs eventArgs)
    {
        SafeInvoke(progressBar, () => _pingedCount++);

        if (eventArgs.IP != null)
        {
            if (eventArgs.Status == PingStatus.Completed)
            {
                try
                {
                    ActiveDevice activeDevice = new(eventArgs.IP, eventArgs.IPV6Address, eventArgs.MACAddress, eventArgs.HostName);

                    SafeInvoke(FoundIPTreeView, () =>
                    {
                        FoundIPTreeView.Nodes.Add(activeDevice.HostAndIPV4, $"Host name: {activeDevice.HostName}", 9);
                        FoundIPTreeView.Nodes[activeDevice.HostAndIPV4].Tag = activeDevice;

                        FoundIPTreeView.Nodes[activeDevice.HostAndIPV4].Nodes.Add(eventArgs.IP, $"ip: {eventArgs.IP}", 6);
                        FoundIPTreeView.Nodes[activeDevice.HostAndIPV4].Nodes[eventArgs.IP].Tag = activeDevice;

                        string device = activeDevice.HostName ?? eventArgs.IP;

                        FoundIPTreeView.Nodes[activeDevice.HostAndIPV4].Nodes[eventArgs.IP].Nodes.Add(device, $"{device}", 1);
                        FoundIPTreeView.Nodes[activeDevice.HostAndIPV4].Nodes[eventArgs.IP].Nodes[device].Tag = activeDevice;

                        FoundIPTreeView.Nodes[activeDevice.HostAndIPV4].Nodes[eventArgs.IP].Nodes.Add(activeDevice.MACAddress, $"MAC: {activeDevice.MACAddress}", 12);
                        FoundIPTreeView.Nodes[activeDevice.HostAndIPV4].Nodes[eventArgs.IP].Nodes[activeDevice.MACAddress].Tag = activeDevice;

                        if (activeDevice.IPV6Address != null)
                        {
                            foreach (string ipv6 in activeDevice.IPV6Address)
                            {
                                FoundIPTreeView.Nodes[activeDevice.HostAndIPV4].Nodes[eventArgs.IP].Nodes.Add(ipv6, ipv6, 7);
                                FoundIPTreeView.Nodes[activeDevice.HostAndIPV4].Nodes[eventArgs.IP].Nodes[ipv6].Tag = activeDevice;
                            }
                        }
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        else
        {
            // MessageBox.Show(e.Reply.Status.ToString());
        }
    }

    private bool ParseTag()
    {
        if (AutoTimeoutButton.Tag is bool boolean)
            return boolean;

        if (AutoTimeoutButton.Tag is string)
        {
            _ = bool.TryParse((string?)AutoTimeoutButton.Tag, out bool result);

            return result;
        }

        return false;
    }

    #endregion
}