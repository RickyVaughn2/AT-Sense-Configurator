namespace Sense_Configurator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtSubnet = new System.Windows.Forms.TextBox();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.txtDNS1 = new System.Windows.Forms.TextBox();
            this.txtDNS2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApiID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStoreID = new System.Windows.Forms.TextBox();
            this.chkRadio = new System.Windows.Forms.CheckBox();
            this.chkLamp = new System.Windows.Forms.CheckBox();
            this.chkBlink = new System.Windows.Forms.CheckBox();
            this.chkiPad = new System.Windows.Forms.CheckBox();
            this.chkOldestCall = new System.Windows.Forms.CheckBox();
            this.chkAutoUpload = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaxAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCommPort = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOccupancyFilter = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.btnSetAddresses = new System.Windows.Forms.Button();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.tmrDebug = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(67, 72);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(156, 29);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "000.000.000.000";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // txtSubnet
            // 
            this.txtSubnet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubnet.Location = new System.Drawing.Point(67, 103);
            this.txtSubnet.Name = "txtSubnet";
            this.txtSubnet.Size = new System.Drawing.Size(156, 29);
            this.txtSubnet.TabIndex = 1;
            this.txtSubnet.Text = "000.000.000.000";
            this.txtSubnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubnet.TextChanged += new System.EventHandler(this.txtSubnet_TextChanged);
            // 
            // txtGateway
            // 
            this.txtGateway.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGateway.Location = new System.Drawing.Point(67, 134);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(156, 29);
            this.txtGateway.TabIndex = 2;
            this.txtGateway.Text = "000.000.000.000";
            this.txtGateway.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGateway.TextChanged += new System.EventHandler(this.txtGateway_TextChanged);
            // 
            // txtDNS1
            // 
            this.txtDNS1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNS1.Location = new System.Drawing.Point(67, 165);
            this.txtDNS1.Name = "txtDNS1";
            this.txtDNS1.Size = new System.Drawing.Size(156, 29);
            this.txtDNS1.TabIndex = 3;
            this.txtDNS1.Text = "000.000.000.000";
            this.txtDNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDNS1.TextChanged += new System.EventHandler(this.txtDNS1_TextChanged);
            // 
            // txtDNS2
            // 
            this.txtDNS2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNS2.Location = new System.Drawing.Point(67, 196);
            this.txtDNS2.Name = "txtDNS2";
            this.txtDNS2.Size = new System.Drawing.Size(156, 29);
            this.txtDNS2.TabIndex = 4;
            this.txtDNS2.Text = "000.000.000.000";
            this.txtDNS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDNS2.TextChanged += new System.EventHandler(this.txtDNS2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subnet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gateway";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DNS 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DNS 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "API ID";
            // 
            // txtApiID
            // 
            this.txtApiID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApiID.Location = new System.Drawing.Point(67, 247);
            this.txtApiID.Name = "txtApiID";
            this.txtApiID.Size = new System.Drawing.Size(156, 29);
            this.txtApiID.TabIndex = 10;
            this.txtApiID.Text = "000.000.000.000";
            this.txtApiID.TextChanged += new System.EventHandler(this.txtApiID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "API Key";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApiKey.Location = new System.Drawing.Point(67, 282);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(346, 29);
            this.txtApiKey.TabIndex = 12;
            this.txtApiKey.Text = "000.000.000.000";
            this.txtApiKey.TextChanged += new System.EventHandler(this.txtApiKey_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(344, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Brand";
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(402, 72);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(156, 29);
            this.txtBrand.TabIndex = 14;
            this.txtBrand.Text = "XXX";
            this.txtBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBrand.TextChanged += new System.EventHandler(this.txtBrand_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(344, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Store ID";
            // 
            // txtStoreID
            // 
            this.txtStoreID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreID.Location = new System.Drawing.Point(402, 103);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.Size = new System.Drawing.Size(156, 29);
            this.txtStoreID.TabIndex = 16;
            this.txtStoreID.Text = "XXX";
            this.txtStoreID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStoreID.TextChanged += new System.EventHandler(this.txtStoreID_TextChanged);
            // 
            // chkRadio
            // 
            this.chkRadio.AutoSize = true;
            this.chkRadio.Location = new System.Drawing.Point(352, 177);
            this.chkRadio.Name = "chkRadio";
            this.chkRadio.Size = new System.Drawing.Size(54, 17);
            this.chkRadio.TabIndex = 18;
            this.chkRadio.Text = "Radio";
            this.chkRadio.UseVisualStyleBackColor = true;
            this.chkRadio.CheckedChanged += new System.EventHandler(this.chkRadio_CheckedChanged);
            // 
            // chkLamp
            // 
            this.chkLamp.AutoSize = true;
            this.chkLamp.Location = new System.Drawing.Point(352, 200);
            this.chkLamp.Name = "chkLamp";
            this.chkLamp.Size = new System.Drawing.Size(52, 17);
            this.chkLamp.TabIndex = 19;
            this.chkLamp.Text = "Lamp";
            this.chkLamp.UseVisualStyleBackColor = true;
            this.chkLamp.CheckedChanged += new System.EventHandler(this.chkLamp_CheckedChanged);
            // 
            // chkBlink
            // 
            this.chkBlink.AutoSize = true;
            this.chkBlink.Location = new System.Drawing.Point(352, 223);
            this.chkBlink.Name = "chkBlink";
            this.chkBlink.Size = new System.Drawing.Size(49, 17);
            this.chkBlink.TabIndex = 20;
            this.chkBlink.Text = "Blink";
            this.chkBlink.UseVisualStyleBackColor = true;
            this.chkBlink.CheckedChanged += new System.EventHandler(this.chkBlink_CheckedChanged);
            // 
            // chkiPad
            // 
            this.chkiPad.AutoSize = true;
            this.chkiPad.Location = new System.Drawing.Point(412, 177);
            this.chkiPad.Name = "chkiPad";
            this.chkiPad.Size = new System.Drawing.Size(47, 17);
            this.chkiPad.TabIndex = 21;
            this.chkiPad.Text = "iPad";
            this.chkiPad.UseVisualStyleBackColor = true;
            this.chkiPad.CheckedChanged += new System.EventHandler(this.chkiPad_CheckedChanged);
            // 
            // chkOldestCall
            // 
            this.chkOldestCall.AutoSize = true;
            this.chkOldestCall.Location = new System.Drawing.Point(412, 200);
            this.chkOldestCall.Name = "chkOldestCall";
            this.chkOldestCall.Size = new System.Drawing.Size(76, 17);
            this.chkOldestCall.TabIndex = 22;
            this.chkOldestCall.Text = "Oldest Call";
            this.chkOldestCall.UseVisualStyleBackColor = true;
            this.chkOldestCall.CheckedChanged += new System.EventHandler(this.chkOldestCall_CheckedChanged);
            // 
            // chkAutoUpload
            // 
            this.chkAutoUpload.AutoSize = true;
            this.chkAutoUpload.Location = new System.Drawing.Point(412, 223);
            this.chkAutoUpload.Name = "chkAutoUpload";
            this.chkAutoUpload.Size = new System.Drawing.Size(85, 17);
            this.chkAutoUpload.TabIndex = 23;
            this.chkAutoUpload.Text = "Auto Upload";
            this.chkAutoUpload.UseVisualStyleBackColor = true;
            this.chkAutoUpload.CheckedChanged += new System.EventHandler(this.chkAutoUpload_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Max SB Address";
            // 
            // txtMaxAddress
            // 
            this.txtMaxAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxAddress.Location = new System.Drawing.Point(117, 369);
            this.txtMaxAddress.Name = "txtMaxAddress";
            this.txtMaxAddress.Size = new System.Drawing.Size(156, 29);
            this.txtMaxAddress.TabIndex = 26;
            this.txtMaxAddress.Text = "000.000.000.000";
            this.txtMaxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaxAddress.TextChanged += new System.EventHandler(this.txtMaxAddress_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Comm Port";
            // 
            // txtCommPort
            // 
            this.txtCommPort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommPort.Location = new System.Drawing.Point(117, 338);
            this.txtCommPort.Name = "txtCommPort";
            this.txtCommPort.Size = new System.Drawing.Size(156, 29);
            this.txtCommPort.TabIndex = 24;
            this.txtCommPort.Text = "000.000.000.000";
            this.txtCommPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCommPort.TextChanged += new System.EventHandler(this.txtCommPort_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Occupancy Filter";
            // 
            // txtOccupancyFilter
            // 
            this.txtOccupancyFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOccupancyFilter.Location = new System.Drawing.Point(117, 400);
            this.txtOccupancyFilter.Name = "txtOccupancyFilter";
            this.txtOccupancyFilter.Size = new System.Drawing.Size(156, 29);
            this.txtOccupancyFilter.TabIndex = 28;
            this.txtOccupancyFilter.Text = "000.000.000.000";
            this.txtOccupancyFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOccupancyFilter.TextChanged += new System.EventHandler(this.txtOccupancyFilter_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(464, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 43);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Box ID";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxID.Location = new System.Drawing.Point(67, 12);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(403, 29);
            this.txtBoxID.TabIndex = 31;
            this.txtBoxID.Text = "000.000.000.000";
            this.txtBoxID.TextChanged += new System.EventHandler(this.txtBoxID_TextChanged);
            // 
            // btnSetAddresses
            // 
            this.btnSetAddresses.Location = new System.Drawing.Point(464, 351);
            this.btnSetAddresses.Name = "btnSetAddresses";
            this.btnSetAddresses.Size = new System.Drawing.Size(97, 43);
            this.btnSetAddresses.TabIndex = 33;
            this.btnSetAddresses.Text = "Set Addresses";
            this.btnSetAddresses.UseVisualStyleBackColor = true;
            this.btnSetAddresses.Click += new System.EventHandler(this.btnSetAddresses_Click);
            // 
            // txtDebug
            // 
            this.txtDebug.Font = new System.Drawing.Font("Trebuchet MS", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebug.Location = new System.Drawing.Point(599, 12);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDebug.Size = new System.Drawing.Size(445, 431);
            this.txtDebug.TabIndex = 36;
            // 
            // tmrDebug
            // 
            this.tmrDebug.Enabled = true;
            this.tmrDebug.Tick += new System.EventHandler(this.tmrDebug_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(458, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 38;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.btnSetAddresses);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtOccupancyFilter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMaxAddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCommPort);
            this.Controls.Add(this.chkAutoUpload);
            this.Controls.Add(this.chkOldestCall);
            this.Controls.Add(this.chkiPad);
            this.Controls.Add(this.chkBlink);
            this.Controls.Add(this.chkLamp);
            this.Controls.Add(this.chkRadio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStoreID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApiID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDNS2);
            this.Controls.Add(this.txtDNS1);
            this.Controls.Add(this.txtGateway);
            this.Controls.Add(this.txtSubnet);
            this.Controls.Add(this.txtIP);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Sense Configurator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtSubnet;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.TextBox txtDNS1;
        private System.Windows.Forms.TextBox txtDNS2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApiID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStoreID;
        private System.Windows.Forms.CheckBox chkRadio;
        private System.Windows.Forms.CheckBox chkLamp;
        private System.Windows.Forms.CheckBox chkBlink;
        private System.Windows.Forms.CheckBox chkiPad;
        private System.Windows.Forms.CheckBox chkOldestCall;
        private System.Windows.Forms.CheckBox chkAutoUpload;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaxAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCommPort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOccupancyFilter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Button btnSetAddresses;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Timer tmrDebug;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

