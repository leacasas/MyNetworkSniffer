using System.ComponentModel;

namespace MyNetworkSniffer;

partial class NetworkSniffer
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkSniffer));
            this.IPcomboBox = new System.Windows.Forms.ComboBox();
            this.MaskBitsTrackBar = new System.Windows.Forms.TrackBar();
            this.IPClassTextBox = new System.Windows.Forms.TextBox();
            this.RecommendLabel = new System.Windows.Forms.Label();
            this.EnterIpRadioButton = new System.Windows.Forms.RadioButton();
            this.ChooseIpRadioButton = new System.Windows.Forms.RadioButton();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.MaskBitsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MaskBitsSuffixLabel = new System.Windows.Forms.Label();
            this.SubnetMaskLabel = new System.Windows.Forms.Label();
            this.MaxHostsCountLabel = new System.Windows.Forms.Label();
            this.MaxIDCountLabel = new System.Windows.Forms.Label();
            this.IPClassLabel = new System.Windows.Forms.Label();
            this.NetIDLabel = new System.Windows.Forms.Label();
            this.FirstIPLabel = new System.Windows.Forms.Label();
            this.MaxIDTextBox = new System.Windows.Forms.TextBox();
            this.MaxHostsCountTextBox = new System.Windows.Forms.TextBox();
            this.SubnetMaskTextBox = new System.Windows.Forms.TextBox();
            this.NetIDTextBox = new System.Windows.Forms.TextBox();
            this.FirstIPTextBox = new System.Windows.Forms.TextBox();
            this.LastIPTextBox = new System.Windows.Forms.TextBox();
            this.BroadcastTextBox = new System.Windows.Forms.TextBox();
            this.LastIPLabel = new System.Windows.Forms.Label();
            this.BroadcastLabel = new System.Windows.Forms.Label();
            this.MaskLabel = new System.Windows.Forms.Label();
            this.NetworkGroupBox = new System.Windows.Forms.GroupBox();
            this.MaskTextLabel = new System.Windows.Forms.Label();
            this.ProcessGroupBox = new System.Windows.Forms.GroupBox();
            this.EnableVerboseLlabel = new System.Windows.Forms.Label();
            this.EnableVerboseButton = new System.Windows.Forms.Button();
            this.AutoTimeoutLabel = new System.Windows.Forms.Label();
            this.AutoTimeoutButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.TimeoutLabel = new System.Windows.Forms.Label();
            this.TimeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FoundDevicesLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FoundIPTreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LogGroupBox = new System.Windows.Forms.GroupBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.PingerBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.ParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.DNSServersListView = new System.Windows.Forms.ListView();
            this.DNSServersLabel = new System.Windows.Forms.Label();
            this.ScopeNameLabel = new System.Windows.Forms.Label();
            this.ScopeNameTextBox = new System.Windows.Forms.TextBox();
            this.DomainNameLabel = new System.Windows.Forms.Label();
            this.DomainNameTextBox = new System.Windows.Forms.TextBox();
            this.NodeTypeLabel = new System.Windows.Forms.Label();
            this.NodeTypeTextBox = new System.Windows.Forms.TextBox();
            this.HostNameLabel = new System.Windows.Forms.Label();
            this.HostNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MaskBitsTrackBar)).BeginInit();
            this.NetworkGroupBox.SuspendLayout();
            this.ProcessGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.LogGroupBox.SuspendLayout();
            this.ParametersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPcomboBox
            // 
            this.IPcomboBox.FormattingEnabled = true;
            this.IPcomboBox.Location = new System.Drawing.Point(146, 71);
            this.IPcomboBox.Name = "IPcomboBox";
            this.IPcomboBox.Size = new System.Drawing.Size(269, 23);
            this.IPcomboBox.TabIndex = 0;
            this.IPcomboBox.SelectedIndexChanged += new System.EventHandler(this.IPcomboBox_SelectedIndexChanged);
            // 
            // MaskBitsTrackBar
            // 
            this.MaskBitsTrackBar.Enabled = false;
            this.MaskBitsTrackBar.LargeChange = 1;
            this.MaskBitsTrackBar.Location = new System.Drawing.Point(23, 194);
            this.MaskBitsTrackBar.Maximum = 32;
            this.MaskBitsTrackBar.Name = "MaskBitsTrackBar";
            this.MaskBitsTrackBar.Size = new System.Drawing.Size(604, 45);
            this.MaskBitsTrackBar.TabIndex = 1;
            this.MaskBitsTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.MaskBitsTrackBar.Scroll += new System.EventHandler(this.MaskBitsTrackBar_Scroll);
            // 
            // IPClassTextBox
            // 
            this.IPClassTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.IPClassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPClassTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IPClassTextBox.Location = new System.Drawing.Point(144, 332);
            this.IPClassTextBox.Name = "IPClassTextBox";
            this.IPClassTextBox.ReadOnly = true;
            this.IPClassTextBox.Size = new System.Drawing.Size(188, 27);
            this.IPClassTextBox.TabIndex = 2;
            // 
            // RecommendLabel
            // 
            this.RecommendLabel.AutoSize = true;
            this.RecommendLabel.Location = new System.Drawing.Point(503, 539);
            this.RecommendLabel.Name = "RecommendLabel";
            this.RecommendLabel.Size = new System.Drawing.Size(0, 15);
            this.RecommendLabel.TabIndex = 3;
            // 
            // EnterIpRadioButton
            // 
            this.EnterIpRadioButton.AutoSize = true;
            this.EnterIpRadioButton.Checked = true;
            this.EnterIpRadioButton.Location = new System.Drawing.Point(42, 37);
            this.EnterIpRadioButton.Name = "EnterIpRadioButton";
            this.EnterIpRadioButton.Size = new System.Drawing.Size(65, 19);
            this.EnterIpRadioButton.TabIndex = 4;
            this.EnterIpRadioButton.TabStop = true;
            this.EnterIpRadioButton.Text = "Enter IP";
            this.EnterIpRadioButton.UseVisualStyleBackColor = true;
            this.EnterIpRadioButton.CheckedChanged += new System.EventHandler(this.EnterIpRadioButton_CheckedChanged);
            // 
            // ChooseIpRadioButton
            // 
            this.ChooseIpRadioButton.AutoSize = true;
            this.ChooseIpRadioButton.Location = new System.Drawing.Point(42, 72);
            this.ChooseIpRadioButton.Name = "ChooseIpRadioButton";
            this.ChooseIpRadioButton.Size = new System.Drawing.Size(78, 19);
            this.ChooseIpRadioButton.TabIndex = 5;
            this.ChooseIpRadioButton.Text = "Choose IP";
            this.ChooseIpRadioButton.UseVisualStyleBackColor = true;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(146, 37);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(269, 23);
            this.IPTextBox.TabIndex = 6;
            this.IPTextBox.TextChanged += new System.EventHandler(this.IPTextBox_TextChanged);
            // 
            // MaskBitsRichTextBox
            // 
            this.MaskBitsRichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MaskBitsRichTextBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaskBitsRichTextBox.Location = new System.Drawing.Point(42, 135);
            this.MaskBitsRichTextBox.Name = "MaskBitsRichTextBox";
            this.MaskBitsRichTextBox.ReadOnly = true;
            this.MaskBitsRichTextBox.Size = new System.Drawing.Size(588, 58);
            this.MaskBitsRichTextBox.TabIndex = 7;
            this.MaskBitsRichTextBox.Text = "00000000000000000000000000000000";
            this.MaskBitsRichTextBox.TextChanged += new System.EventHandler(this.MaskBitsRichTextBox_TextChanged);
            // 
            // MaskBitsSuffixLabel
            // 
            this.MaskBitsSuffixLabel.AutoSize = true;
            this.MaskBitsSuffixLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaskBitsSuffixLabel.Location = new System.Drawing.Point(621, 196);
            this.MaskBitsSuffixLabel.Name = "MaskBitsSuffixLabel";
            this.MaskBitsSuffixLabel.Size = new System.Drawing.Size(39, 28);
            this.MaskBitsSuffixLabel.TabIndex = 8;
            this.MaskBitsSuffixLabel.Text = "/ 0";
            // 
            // SubnetMaskLabel
            // 
            this.SubnetMaskLabel.AutoSize = true;
            this.SubnetMaskLabel.Location = new System.Drawing.Point(63, 251);
            this.SubnetMaskLabel.Name = "SubnetMaskLabel";
            this.SubnetMaskLabel.Size = new System.Drawing.Size(78, 15);
            this.SubnetMaskLabel.TabIndex = 9;
            this.SubnetMaskLabel.Text = "Subnet Mask:";
            // 
            // MaxHostsCountLabel
            // 
            this.MaxHostsCountLabel.AutoSize = true;
            this.MaxHostsCountLabel.Location = new System.Drawing.Point(43, 280);
            this.MaxHostsCountLabel.Name = "MaxHostsCountLabel";
            this.MaxHostsCountLabel.Size = new System.Drawing.Size(98, 15);
            this.MaxHostsCountLabel.TabIndex = 10;
            this.MaxHostsCountLabel.Text = "Max hosts count:";
            // 
            // MaxIDCountLabel
            // 
            this.MaxIDCountLabel.AutoSize = true;
            this.MaxIDCountLabel.Location = new System.Drawing.Point(60, 309);
            this.MaxIDCountLabel.Name = "MaxIDCountLabel";
            this.MaxIDCountLabel.Size = new System.Drawing.Size(81, 15);
            this.MaxIDCountLabel.TabIndex = 11;
            this.MaxIDCountLabel.Text = "Max ID count:";
            // 
            // IPClassLabel
            // 
            this.IPClassLabel.AutoSize = true;
            this.IPClassLabel.Location = new System.Drawing.Point(91, 338);
            this.IPClassLabel.Name = "IPClassLabel";
            this.IPClassLabel.Size = new System.Drawing.Size(50, 15);
            this.IPClassLabel.TabIndex = 12;
            this.IPClassLabel.Text = "IP Class:";
            // 
            // NetIDLabel
            // 
            this.NetIDLabel.AutoSize = true;
            this.NetIDLabel.Location = new System.Drawing.Point(394, 251);
            this.NetIDLabel.Name = "NetIDLabel";
            this.NetIDLabel.Size = new System.Drawing.Size(43, 15);
            this.NetIDLabel.TabIndex = 13;
            this.NetIDLabel.Text = "Net ID:";
            // 
            // FirstIPLabel
            // 
            this.FirstIPLabel.AutoSize = true;
            this.FirstIPLabel.Location = new System.Drawing.Point(392, 280);
            this.FirstIPLabel.Name = "FirstIPLabel";
            this.FirstIPLabel.Size = new System.Drawing.Size(45, 15);
            this.FirstIPLabel.TabIndex = 14;
            this.FirstIPLabel.Text = "First IP:";
            // 
            // MaxIDTextBox
            // 
            this.MaxIDTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MaxIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxIDTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxIDTextBox.Location = new System.Drawing.Point(144, 303);
            this.MaxIDTextBox.Name = "MaxIDTextBox";
            this.MaxIDTextBox.ReadOnly = true;
            this.MaxIDTextBox.Size = new System.Drawing.Size(188, 27);
            this.MaxIDTextBox.TabIndex = 17;
            // 
            // MaxHostsCountTextBox
            // 
            this.MaxHostsCountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MaxHostsCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxHostsCountTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxHostsCountTextBox.Location = new System.Drawing.Point(144, 274);
            this.MaxHostsCountTextBox.Name = "MaxHostsCountTextBox";
            this.MaxHostsCountTextBox.ReadOnly = true;
            this.MaxHostsCountTextBox.Size = new System.Drawing.Size(188, 27);
            this.MaxHostsCountTextBox.TabIndex = 18;
            // 
            // SubnetMaskTextBox
            // 
            this.SubnetMaskTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SubnetMaskTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubnetMaskTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubnetMaskTextBox.Location = new System.Drawing.Point(144, 245);
            this.SubnetMaskTextBox.Name = "SubnetMaskTextBox";
            this.SubnetMaskTextBox.ReadOnly = true;
            this.SubnetMaskTextBox.Size = new System.Drawing.Size(188, 27);
            this.SubnetMaskTextBox.TabIndex = 19;
            this.SubnetMaskTextBox.Text = "0.0.0.0";
            // 
            // NetIDTextBox
            // 
            this.NetIDTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.NetIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NetIDTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NetIDTextBox.Location = new System.Drawing.Point(442, 245);
            this.NetIDTextBox.Name = "NetIDTextBox";
            this.NetIDTextBox.ReadOnly = true;
            this.NetIDTextBox.Size = new System.Drawing.Size(188, 27);
            this.NetIDTextBox.TabIndex = 23;
            this.NetIDTextBox.Text = "0.0.0.0";
            // 
            // FirstIPTextBox
            // 
            this.FirstIPTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.FirstIPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstIPTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstIPTextBox.Location = new System.Drawing.Point(442, 274);
            this.FirstIPTextBox.Name = "FirstIPTextBox";
            this.FirstIPTextBox.ReadOnly = true;
            this.FirstIPTextBox.Size = new System.Drawing.Size(188, 27);
            this.FirstIPTextBox.TabIndex = 22;
            this.FirstIPTextBox.Text = "0.0.0.0";
            // 
            // LastIPTextBox
            // 
            this.LastIPTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.LastIPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastIPTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastIPTextBox.Location = new System.Drawing.Point(442, 303);
            this.LastIPTextBox.Name = "LastIPTextBox";
            this.LastIPTextBox.ReadOnly = true;
            this.LastIPTextBox.Size = new System.Drawing.Size(188, 27);
            this.LastIPTextBox.TabIndex = 21;
            this.LastIPTextBox.Text = "0.0.0.0";
            // 
            // BroadcastTextBox
            // 
            this.BroadcastTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.BroadcastTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BroadcastTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BroadcastTextBox.Location = new System.Drawing.Point(442, 332);
            this.BroadcastTextBox.Name = "BroadcastTextBox";
            this.BroadcastTextBox.ReadOnly = true;
            this.BroadcastTextBox.Size = new System.Drawing.Size(188, 27);
            this.BroadcastTextBox.TabIndex = 20;
            this.BroadcastTextBox.Text = "0.0.0.0";
            // 
            // LastIPLabel
            // 
            this.LastIPLabel.AutoSize = true;
            this.LastIPLabel.Location = new System.Drawing.Point(392, 309);
            this.LastIPLabel.Name = "LastIPLabel";
            this.LastIPLabel.Size = new System.Drawing.Size(44, 15);
            this.LastIPLabel.TabIndex = 24;
            this.LastIPLabel.Text = "Last IP:";
            // 
            // BroadcastLabel
            // 
            this.BroadcastLabel.AutoSize = true;
            this.BroadcastLabel.Location = new System.Drawing.Point(374, 338);
            this.BroadcastLabel.Name = "BroadcastLabel";
            this.BroadcastLabel.Size = new System.Drawing.Size(62, 15);
            this.BroadcastLabel.TabIndex = 25;
            this.BroadcastLabel.Text = "Broadcast:";
            // 
            // MaskLabel
            // 
            this.MaskLabel.AutoSize = true;
            this.MaskLabel.Location = new System.Drawing.Point(43, 111);
            this.MaskLabel.Name = "MaskLabel";
            this.MaskLabel.Size = new System.Drawing.Size(38, 15);
            this.MaskLabel.TabIndex = 26;
            this.MaskLabel.Text = "Mask:";
            // 
            // NetworkGroupBox
            // 
            this.NetworkGroupBox.Controls.Add(this.MaskTextLabel);
            this.NetworkGroupBox.Location = new System.Drawing.Point(12, 5);
            this.NetworkGroupBox.Name = "NetworkGroupBox";
            this.NetworkGroupBox.Size = new System.Drawing.Size(757, 372);
            this.NetworkGroupBox.TabIndex = 27;
            this.NetworkGroupBox.TabStop = false;
            this.NetworkGroupBox.Text = "Network";
            // 
            // MaskTextLabel
            // 
            this.MaskTextLabel.AutoSize = true;
            this.MaskTextLabel.Location = new System.Drawing.Point(660, 200);
            this.MaskTextLabel.Name = "MaskTextLabel";
            this.MaskTextLabel.Size = new System.Drawing.Size(86, 15);
            this.MaskTextLabel.TabIndex = 0;
            this.MaskTextLabel.Text = "Mask bit depth";
            // 
            // ProcessGroupBox
            // 
            this.ProcessGroupBox.Controls.Add(this.EnableVerboseLlabel);
            this.ProcessGroupBox.Controls.Add(this.EnableVerboseButton);
            this.ProcessGroupBox.Controls.Add(this.AutoTimeoutLabel);
            this.ProcessGroupBox.Controls.Add(this.AutoTimeoutButton);
            this.ProcessGroupBox.Controls.Add(this.StartButton);
            this.ProcessGroupBox.Controls.Add(this.TimeoutLabel);
            this.ProcessGroupBox.Controls.Add(this.TimeoutNumericUpDown);
            this.ProcessGroupBox.Controls.Add(this.FoundDevicesLabel);
            this.ProcessGroupBox.Controls.Add(this.panel1);
            this.ProcessGroupBox.Location = new System.Drawing.Point(12, 383);
            this.ProcessGroupBox.Name = "ProcessGroupBox";
            this.ProcessGroupBox.Size = new System.Drawing.Size(757, 409);
            this.ProcessGroupBox.TabIndex = 28;
            this.ProcessGroupBox.TabStop = false;
            this.ProcessGroupBox.Text = "Process";
            // 
            // EnableVerboseLlabel
            // 
            this.EnableVerboseLlabel.AutoSize = true;
            this.EnableVerboseLlabel.Location = new System.Drawing.Point(634, 154);
            this.EnableVerboseLlabel.Name = "EnableVerboseLlabel";
            this.EnableVerboseLlabel.Size = new System.Drawing.Size(51, 15);
            this.EnableVerboseLlabel.TabIndex = 8;
            this.EnableVerboseLlabel.Text = "Verbose:";
            // 
            // EnableVerboseButton
            // 
            this.EnableVerboseButton.FlatAppearance.BorderSize = 0;
            this.EnableVerboseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnableVerboseButton.Image = ((System.Drawing.Image)(resources.GetObject("EnableVerboseButton.Image")));
            this.EnableVerboseButton.Location = new System.Drawing.Point(634, 169);
            this.EnableVerboseButton.Name = "EnableVerboseButton";
            this.EnableVerboseButton.Size = new System.Drawing.Size(108, 29);
            this.EnableVerboseButton.TabIndex = 7;
            this.EnableVerboseButton.Tag = "false";
            this.EnableVerboseButton.UseVisualStyleBackColor = true;
            this.EnableVerboseButton.Click += new System.EventHandler(this.EnableVerboseButton_Click);
            // 
            // AutoTimeoutLabel
            // 
            this.AutoTimeoutLabel.AutoSize = true;
            this.AutoTimeoutLabel.Location = new System.Drawing.Point(634, 97);
            this.AutoTimeoutLabel.Name = "AutoTimeoutLabel";
            this.AutoTimeoutLabel.Size = new System.Drawing.Size(83, 15);
            this.AutoTimeoutLabel.TabIndex = 6;
            this.AutoTimeoutLabel.Text = "Auto-timeout:";
            // 
            // AutoTimeoutButton
            // 
            this.AutoTimeoutButton.FlatAppearance.BorderSize = 0;
            this.AutoTimeoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoTimeoutButton.Image = ((System.Drawing.Image)(resources.GetObject("AutoTimeoutButton.Image")));
            this.AutoTimeoutButton.Location = new System.Drawing.Point(634, 112);
            this.AutoTimeoutButton.Name = "AutoTimeoutButton";
            this.AutoTimeoutButton.Size = new System.Drawing.Size(108, 29);
            this.AutoTimeoutButton.TabIndex = 5;
            this.AutoTimeoutButton.Tag = "true";
            this.AutoTimeoutButton.UseVisualStyleBackColor = true;
            this.AutoTimeoutButton.Click += new System.EventHandler(this.AutoTimeoutButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.StartButton.Location = new System.Drawing.Point(634, 354);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(108, 38);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TimeoutLabel
            // 
            this.TimeoutLabel.AutoSize = true;
            this.TimeoutLabel.Location = new System.Drawing.Point(630, 31);
            this.TimeoutLabel.Name = "TimeoutLabel";
            this.TimeoutLabel.Size = new System.Drawing.Size(54, 15);
            this.TimeoutLabel.TabIndex = 3;
            this.TimeoutLabel.Text = "Timeout:";
            // 
            // TimeoutNumericUpDown
            // 
            this.TimeoutNumericUpDown.Enabled = false;
            this.TimeoutNumericUpDown.Location = new System.Drawing.Point(634, 49);
            this.TimeoutNumericUpDown.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.TimeoutNumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TimeoutNumericUpDown.Name = "TimeoutNumericUpDown";
            this.TimeoutNumericUpDown.Size = new System.Drawing.Size(108, 23);
            this.TimeoutNumericUpDown.TabIndex = 2;
            this.TimeoutNumericUpDown.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // FoundDevicesLabel
            // 
            this.FoundDevicesLabel.AutoSize = true;
            this.FoundDevicesLabel.Location = new System.Drawing.Point(30, 31);
            this.FoundDevicesLabel.Name = "FoundDevicesLabel";
            this.FoundDevicesLabel.Size = new System.Drawing.Size(86, 15);
            this.FoundDevicesLabel.TabIndex = 1;
            this.FoundDevicesLabel.Text = "Found devices:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.FoundIPTreeView);
            this.panel1.Location = new System.Drawing.Point(11, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 343);
            this.panel1.TabIndex = 0;
            // 
            // FoundIPTreeView
            // 
            this.FoundIPTreeView.BackColor = System.Drawing.SystemColors.Window;
            this.FoundIPTreeView.ImageIndex = 0;
            this.FoundIPTreeView.ImageList = this.imageList1;
            this.FoundIPTreeView.Location = new System.Drawing.Point(18, 18);
            this.FoundIPTreeView.Name = "FoundIPTreeView";
            this.FoundIPTreeView.SelectedImageIndex = 0;
            this.FoundIPTreeView.Size = new System.Drawing.Size(571, 307);
            this.FoundIPTreeView.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "desktop-classic.png");
            this.imageList1.Images.SetKeyName(1, "devices.png");
            this.imageList1.Images.SetKeyName(2, "cellphone-link.png");
            this.imageList1.Images.SetKeyName(3, "desktop-classic.png");
            this.imageList1.Images.SetKeyName(4, "devices.png");
            this.imageList1.Images.SetKeyName(5, "ip.png");
            this.imageList1.Images.SetKeyName(6, "ip-network.png");
            this.imageList1.Images.SetKeyName(7, "ip-network-outline.png");
            this.imageList1.Images.SetKeyName(8, "ip-outline.png");
            this.imageList1.Images.SetKeyName(9, "lan.png");
            this.imageList1.Images.SetKeyName(10, "lan-connect.png");
            this.imageList1.Images.SetKeyName(11, "laptop.png");
            this.imageList1.Images.SetKeyName(12, "router-network.png");
            // 
            // LogGroupBox
            // 
            this.LogGroupBox.Controls.Add(this.LogTextBox);
            this.LogGroupBox.Controls.Add(this.progressBar);
            this.LogGroupBox.Location = new System.Drawing.Point(783, 383);
            this.LogGroupBox.Name = "LogGroupBox";
            this.LogGroupBox.Size = new System.Drawing.Size(668, 409);
            this.LogGroupBox.TabIndex = 29;
            this.LogGroupBox.TabStop = false;
            this.LogGroupBox.Text = "Log";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(15, 52);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(636, 340);
            this.LogTextBox.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 23);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(636, 23);
            this.progressBar.TabIndex = 0;
            // 
            // PingerBackgroundWorker
            // 
            this.PingerBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PingerBackgroundWorker_DoWork);
            // 
            // ParametersGroupBox
            // 
            this.ParametersGroupBox.Controls.Add(this.DNSServersListView);
            this.ParametersGroupBox.Controls.Add(this.DNSServersLabel);
            this.ParametersGroupBox.Controls.Add(this.ScopeNameLabel);
            this.ParametersGroupBox.Controls.Add(this.ScopeNameTextBox);
            this.ParametersGroupBox.Controls.Add(this.DomainNameLabel);
            this.ParametersGroupBox.Controls.Add(this.DomainNameTextBox);
            this.ParametersGroupBox.Controls.Add(this.NodeTypeLabel);
            this.ParametersGroupBox.Controls.Add(this.NodeTypeTextBox);
            this.ParametersGroupBox.Controls.Add(this.HostNameLabel);
            this.ParametersGroupBox.Controls.Add(this.HostNameTextBox);
            this.ParametersGroupBox.Location = new System.Drawing.Point(783, 5);
            this.ParametersGroupBox.Name = "ParametersGroupBox";
            this.ParametersGroupBox.Size = new System.Drawing.Size(668, 372);
            this.ParametersGroupBox.TabIndex = 30;
            this.ParametersGroupBox.TabStop = false;
            this.ParametersGroupBox.Text = "Local Network Parameters";
            // 
            // DNSServersListView
            // 
            this.DNSServersListView.AutoArrange = false;
            this.DNSServersListView.GridLines = true;
            this.DNSServersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.DNSServersListView.Location = new System.Drawing.Point(336, 54);
            this.DNSServersListView.MultiSelect = false;
            this.DNSServersListView.Name = "DNSServersListView";
            this.DNSServersListView.ShowGroups = false;
            this.DNSServersListView.Size = new System.Drawing.Size(300, 110);
            this.DNSServersListView.TabIndex = 9;
            this.DNSServersListView.UseCompatibleStateImageBehavior = false;
            this.DNSServersListView.View = System.Windows.Forms.View.List;
            // 
            // DNSServersLabel
            // 
            this.DNSServersLabel.AutoSize = true;
            this.DNSServersLabel.Location = new System.Drawing.Point(336, 34);
            this.DNSServersLabel.Name = "DNSServersLabel";
            this.DNSServersLabel.Size = new System.Drawing.Size(76, 15);
            this.DNSServersLabel.TabIndex = 8;
            this.DNSServersLabel.Text = "DNS Servers: ";
            // 
            // ScopeNameLabel
            // 
            this.ScopeNameLabel.AutoSize = true;
            this.ScopeNameLabel.Location = new System.Drawing.Point(15, 141);
            this.ScopeNameLabel.Name = "ScopeNameLabel";
            this.ScopeNameLabel.Size = new System.Drawing.Size(112, 15);
            this.ScopeNameLabel.TabIndex = 7;
            this.ScopeNameLabel.Text = "DHCP scope name: ";
            // 
            // ScopeNameTextBox
            // 
            this.ScopeNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ScopeNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScopeNameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScopeNameTextBox.Location = new System.Drawing.Point(132, 137);
            this.ScopeNameTextBox.Name = "ScopeNameTextBox";
            this.ScopeNameTextBox.ReadOnly = true;
            this.ScopeNameTextBox.Size = new System.Drawing.Size(192, 27);
            this.ScopeNameTextBox.TabIndex = 6;
            // 
            // DomainNameLabel
            // 
            this.DomainNameLabel.AutoSize = true;
            this.DomainNameLabel.Location = new System.Drawing.Point(15, 106);
            this.DomainNameLabel.Name = "DomainNameLabel";
            this.DomainNameLabel.Size = new System.Drawing.Size(90, 15);
            this.DomainNameLabel.TabIndex = 5;
            this.DomainNameLabel.Text = "Domain Name: ";
            // 
            // DomainNameTextBox
            // 
            this.DomainNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DomainNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DomainNameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DomainNameTextBox.Location = new System.Drawing.Point(132, 102);
            this.DomainNameTextBox.Name = "DomainNameTextBox";
            this.DomainNameTextBox.ReadOnly = true;
            this.DomainNameTextBox.Size = new System.Drawing.Size(192, 27);
            this.DomainNameTextBox.TabIndex = 4;
            // 
            // NodeTypeLabel
            // 
            this.NodeTypeLabel.AutoSize = true;
            this.NodeTypeLabel.Location = new System.Drawing.Point(15, 71);
            this.NodeTypeLabel.Name = "NodeTypeLabel";
            this.NodeTypeLabel.Size = new System.Drawing.Size(109, 15);
            this.NodeTypeLabel.TabIndex = 3;
            this.NodeTypeLabel.Text = "NetBios Node type:";
            // 
            // NodeTypeTextBox
            // 
            this.NodeTypeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.NodeTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NodeTypeTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NodeTypeTextBox.Location = new System.Drawing.Point(132, 67);
            this.NodeTypeTextBox.Name = "NodeTypeTextBox";
            this.NodeTypeTextBox.ReadOnly = true;
            this.NodeTypeTextBox.Size = new System.Drawing.Size(192, 27);
            this.NodeTypeTextBox.TabIndex = 2;
            // 
            // HostNameLabel
            // 
            this.HostNameLabel.AutoSize = true;
            this.HostNameLabel.Location = new System.Drawing.Point(15, 36);
            this.HostNameLabel.Name = "HostNameLabel";
            this.HostNameLabel.Size = new System.Drawing.Size(73, 15);
            this.HostNameLabel.TabIndex = 1;
            this.HostNameLabel.Text = "Host Name: ";
            // 
            // HostNameTextBox
            // 
            this.HostNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.HostNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HostNameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HostNameTextBox.Location = new System.Drawing.Point(132, 32);
            this.HostNameTextBox.Name = "HostNameTextBox";
            this.HostNameTextBox.ReadOnly = true;
            this.HostNameTextBox.Size = new System.Drawing.Size(192, 27);
            this.HostNameTextBox.TabIndex = 0;
            // 
            // NetworkSniffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 804);
            this.Controls.Add(this.ParametersGroupBox);
            this.Controls.Add(this.LogGroupBox);
            this.Controls.Add(this.ProcessGroupBox);
            this.Controls.Add(this.MaskLabel);
            this.Controls.Add(this.BroadcastLabel);
            this.Controls.Add(this.LastIPLabel);
            this.Controls.Add(this.NetIDTextBox);
            this.Controls.Add(this.FirstIPTextBox);
            this.Controls.Add(this.LastIPTextBox);
            this.Controls.Add(this.BroadcastTextBox);
            this.Controls.Add(this.SubnetMaskTextBox);
            this.Controls.Add(this.MaxHostsCountTextBox);
            this.Controls.Add(this.MaxIDTextBox);
            this.Controls.Add(this.FirstIPLabel);
            this.Controls.Add(this.NetIDLabel);
            this.Controls.Add(this.IPClassLabel);
            this.Controls.Add(this.MaxIDCountLabel);
            this.Controls.Add(this.MaxHostsCountLabel);
            this.Controls.Add(this.SubnetMaskLabel);
            this.Controls.Add(this.MaskBitsSuffixLabel);
            this.Controls.Add(this.MaskBitsRichTextBox);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.ChooseIpRadioButton);
            this.Controls.Add(this.EnterIpRadioButton);
            this.Controls.Add(this.RecommendLabel);
            this.Controls.Add(this.IPClassTextBox);
            this.Controls.Add(this.MaskBitsTrackBar);
            this.Controls.Add(this.IPcomboBox);
            this.Controls.Add(this.NetworkGroupBox);
            this.Name = "NetworkSniffer";
            this.Text = "NetworkSniffer";
            ((System.ComponentModel.ISupportInitialize)(this.MaskBitsTrackBar)).EndInit();
            this.NetworkGroupBox.ResumeLayout(false);
            this.NetworkGroupBox.PerformLayout();
            this.ProcessGroupBox.ResumeLayout(false);
            this.ProcessGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.LogGroupBox.ResumeLayout(false);
            this.LogGroupBox.PerformLayout();
            this.ParametersGroupBox.ResumeLayout(false);
            this.ParametersGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private ComboBox IPcomboBox;
    private TrackBar MaskBitsTrackBar;
    private TextBox IPClassTextBox;
    private Label RecommendLabel;
    private RadioButton EnterIpRadioButton;
    private RadioButton ChooseIpRadioButton;
    private TextBox IPTextBox;
    private RichTextBox MaskBitsRichTextBox;
    private Label MaskBitsSuffixLabel;
    private Label SubnetMaskLabel;
    private Label MaxHostsCountLabel;
    private Label MaxIDCountLabel;
    private Label IPClassLabel;
    private Label NetIDLabel;
    private Label FirstIPLabel;
    private TextBox MaxIDTextBox;
    private TextBox MaxHostsCountTextBox;
    private TextBox SubnetMaskTextBox;
    private TextBox NetIDTextBox;
    private TextBox FirstIPTextBox;
    private TextBox LastIPTextBox;
    private TextBox BroadcastTextBox;
    private Label LastIPLabel;
    private Label BroadcastLabel;
    private Label MaskLabel;
    private GroupBox NetworkGroupBox;
    private Label MaskTextLabel;
    private GroupBox ProcessGroupBox;
    private Label FoundDevicesLabel;
    private Panel panel1;
    private TreeView FoundIPTreeView;
    private ImageList imageList1;
    private Label TimeoutLabel;
    private NumericUpDown TimeoutNumericUpDown;
    private Button StartButton;
    private Label AutoTimeoutLabel;
    private Button AutoTimeoutButton;
    private GroupBox LogGroupBox;
    private ProgressBar progressBar;
    private TextBox LogTextBox;
    private BackgroundWorker PingerBackgroundWorker;
    private GroupBox ParametersGroupBox;
    private Label HostNameLabel;
    private TextBox HostNameTextBox;
    private Label ScopeNameLabel;
    private TextBox ScopeNameTextBox;
    private Label DomainNameLabel;
    private TextBox DomainNameTextBox;
    private Label NodeTypeLabel;
    private TextBox NodeTypeTextBox;
    private Label DNSServersLabel;
    private ListView DNSServersListView;
    private Label EnableVerboseLlabel;
    private Button EnableVerboseButton;
}