namespace Client
{
    partial class Client
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mniRSA = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKeySize = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKeySize512 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKeySize1024 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKeySize2048 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKeySize5096 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlRSA = new System.Windows.Forms.Panel();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.lblPublicKey = new System.Windows.Forms.Label();
            this.lblKeySizeValue = new System.Windows.Forms.Label();
            this.lblKeySize = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHienThi = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.txtUs = new System.Windows.Forms.TextBox();
            this.btnDk = new System.Windows.Forms.Button();
            this.btnDn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.mnuMain.SuspendLayout();
            this.pnlRSA.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniRSA});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(1041, 28);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mniRSA
            // 
            this.mniRSA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniKeySize,
            this.toolStripSeparator1,
            this.mniGenerate});
            this.mniRSA.Name = "mniRSA";
            this.mniRSA.Size = new System.Drawing.Size(48, 24);
            this.mniRSA.Text = "RSA";
            // 
            // mniKeySize
            // 
            this.mniKeySize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniKeySize512,
            this.mniKeySize1024,
            this.mniKeySize2048,
            this.mniKeySize5096});
            this.mniKeySize.Name = "mniKeySize";
            this.mniKeySize.Size = new System.Drawing.Size(172, 26);
            this.mniKeySize.Text = "Key Size";
            // 
            // mniKeySize512
            // 
            this.mniKeySize512.Checked = true;
            this.mniKeySize512.CheckOnClick = true;
            this.mniKeySize512.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mniKeySize512.Name = "mniKeySize512";
            this.mniKeySize512.Size = new System.Drawing.Size(116, 26);
            this.mniKeySize512.Tag = "512";
            this.mniKeySize512.Text = "512";
            // 
            // mniKeySize1024
            // 
            this.mniKeySize1024.CheckOnClick = true;
            this.mniKeySize1024.Name = "mniKeySize1024";
            this.mniKeySize1024.Size = new System.Drawing.Size(116, 26);
            this.mniKeySize1024.Tag = "1024";
            this.mniKeySize1024.Text = "1024";
            // 
            // mniKeySize2048
            // 
            this.mniKeySize2048.CheckOnClick = true;
            this.mniKeySize2048.Name = "mniKeySize2048";
            this.mniKeySize2048.Size = new System.Drawing.Size(116, 26);
            this.mniKeySize2048.Tag = "2048";
            this.mniKeySize2048.Text = "2048";
            // 
            // mniKeySize5096
            // 
            this.mniKeySize5096.CheckOnClick = true;
            this.mniKeySize5096.Name = "mniKeySize5096";
            this.mniKeySize5096.Size = new System.Drawing.Size(116, 26);
            this.mniKeySize5096.Tag = "5096";
            this.mniKeySize5096.Text = "5096";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // mniGenerate
            // 
            this.mniGenerate.Name = "mniGenerate";
            this.mniGenerate.Size = new System.Drawing.Size(172, 26);
            this.mniGenerate.Text = "Generate Pair";
            this.mniGenerate.Click += new System.EventHandler(this.mniGenerate_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlRSA
            // 
            this.pnlRSA.BackColor = System.Drawing.Color.Transparent;
            this.pnlRSA.Controls.Add(this.txtPrivateKey);
            this.pnlRSA.Controls.Add(this.lblPrivateKey);
            this.pnlRSA.Controls.Add(this.txtPublicKey);
            this.pnlRSA.Controls.Add(this.lblPublicKey);
            this.pnlRSA.Controls.Add(this.lblKeySizeValue);
            this.pnlRSA.Controls.Add(this.lblKeySize);
            this.pnlRSA.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRSA.Location = new System.Drawing.Point(0, 28);
            this.pnlRSA.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRSA.Name = "pnlRSA";
            this.pnlRSA.Padding = new System.Windows.Forms.Padding(4);
            this.pnlRSA.Size = new System.Drawing.Size(200, 597);
            this.pnlRSA.TabIndex = 3;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrivateKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrivateKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrivateKey.Location = new System.Drawing.Point(4, 338);
            this.txtPrivateKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.Size = new System.Drawing.Size(192, 255);
            this.txtPrivateKey.TabIndex = 9;
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.BackColor = System.Drawing.Color.DimGray;
            this.lblPrivateKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivateKey.ForeColor = System.Drawing.Color.White;
            this.lblPrivateKey.Location = new System.Drawing.Point(4, 322);
            this.lblPrivateKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(192, 16);
            this.lblPrivateKey.TabIndex = 8;
            this.lblPrivateKey.Text = "Private Key";
            this.lblPrivateKey.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPublicKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPublicKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPublicKey.Location = new System.Drawing.Point(4, 70);
            this.txtPublicKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ReadOnly = true;
            this.txtPublicKey.Size = new System.Drawing.Size(192, 252);
            this.txtPublicKey.TabIndex = 7;
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.BackColor = System.Drawing.Color.DimGray;
            this.lblPublicKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicKey.ForeColor = System.Drawing.Color.White;
            this.lblPublicKey.Location = new System.Drawing.Point(4, 54);
            this.lblPublicKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(192, 16);
            this.lblPublicKey.TabIndex = 6;
            this.lblPublicKey.Text = "Public Key";
            this.lblPublicKey.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblKeySizeValue
            // 
            this.lblKeySizeValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKeySizeValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKeySizeValue.Location = new System.Drawing.Point(4, 29);
            this.lblKeySizeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKeySizeValue.Name = "lblKeySizeValue";
            this.lblKeySizeValue.Size = new System.Drawing.Size(192, 25);
            this.lblKeySizeValue.TabIndex = 5;
            this.lblKeySizeValue.Text = "512";
            this.lblKeySizeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeySize
            // 
            this.lblKeySize.BackColor = System.Drawing.Color.DimGray;
            this.lblKeySize.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKeySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeySize.ForeColor = System.Drawing.Color.White;
            this.lblKeySize.Location = new System.Drawing.Point(4, 4);
            this.lblKeySize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKeySize.Name = "lblKeySize";
            this.lblKeySize.Size = new System.Drawing.Size(192, 25);
            this.lblKeySize.TabIndex = 4;
            this.lblKeySize.Text = "Key Size";
            this.lblKeySize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(745, 82);
            this.lbPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(38, 17);
            this.lbPort.TabIndex = 38;
            this.lbPort.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Địa chỉ IP:";
            // 
            // txtPort
            // 
            this.txtPort.AutoCompleteCustomSource.AddRange(new string[] {
            "9095"});
            this.txtPort.Location = new System.Drawing.Point(792, 78);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.ReadOnly = true;
            this.txtPort.Size = new System.Drawing.Size(177, 22);
            this.txtPort.TabIndex = 34;
            this.txtPort.Text = "9050";
            // 
            // txtIP
            // 
            this.txtIP.AutoCompleteCustomSource.AddRange(new string[] {
            "127.0.0.1"});
            this.txtIP.Location = new System.Drawing.Point(441, 78);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(263, 22);
            this.txtIP.TabIndex = 33;
            this.txtIP.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(363, 32);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(167, 39);
            this.btnConnect.TabIndex = 35;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(804, 32);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(167, 39);
            this.btnDisconnect.TabIndex = 36;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 32;
            // 
            // txtBM
            // 
            this.txtBM.Location = new System.Drawing.Point(477, 366);
            this.txtBM.Name = "txtBM";
            this.txtBM.ReadOnly = true;
            this.txtBM.Size = new System.Drawing.Size(494, 22);
            this.txtBM.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Bản Mã:";
            // 
            // lbHienThi
            // 
            this.lbHienThi.FormattingEnabled = true;
            this.lbHienThi.HorizontalScrollbar = true;
            this.lbHienThi.ItemHeight = 16;
            this.lbHienThi.Location = new System.Drawing.Point(362, 136);
            this.lbHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.lbHienThi.Name = "lbHienThi";
            this.lbHienThi.Size = new System.Drawing.Size(607, 180);
            this.lbHienThi.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Username";
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(477, 498);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(176, 22);
            this.txtPw.TabIndex = 48;
            // 
            // txtUs
            // 
            this.txtUs.Location = new System.Drawing.Point(477, 432);
            this.txtUs.Name = "txtUs";
            this.txtUs.Size = new System.Drawing.Size(176, 22);
            this.txtUs.TabIndex = 47;
            // 
            // btnDk
            // 
            this.btnDk.Location = new System.Drawing.Point(441, 566);
            this.btnDk.Name = "btnDk";
            this.btnDk.Size = new System.Drawing.Size(164, 39);
            this.btnDk.TabIndex = 51;
            this.btnDk.Text = "Đăng ký";
            this.btnDk.UseVisualStyleBackColor = true;
            this.btnDk.Click += new System.EventHandler(this.btnDk_Click);
            // 
            // btnDn
            // 
            this.btnDn.Location = new System.Drawing.Point(768, 569);
            this.btnDn.Name = "btnDn";
            this.btnDn.Size = new System.Drawing.Size(164, 39);
            this.btnDn.TabIndex = 56;
            this.btnDn.Text = "Đăng nhập";
            this.btnDn.UseVisualStyleBackColor = true;
            this.btnDn.Click += new System.EventHandler(this.btnDn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Username";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(804, 501);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(176, 22);
            this.txtMK.TabIndex = 53;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(804, 435);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(176, 22);
            this.txtTK.TabIndex = 52;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 625);
            this.Controls.Add(this.btnDn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.btnDk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtUs);
            this.Controls.Add(this.lbHienThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBM);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlRSA);
            this.Controls.Add(this.mnuMain);
            this.Name = "Client";
            this.Text = "Client";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlRSA.ResumeLayout(false);
            this.pnlRSA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mniRSA;
        private System.Windows.Forms.ToolStripMenuItem mniKeySize;
        private System.Windows.Forms.ToolStripMenuItem mniKeySize512;
        private System.Windows.Forms.ToolStripMenuItem mniKeySize1024;
        private System.Windows.Forms.ToolStripMenuItem mniKeySize2048;
        private System.Windows.Forms.ToolStripMenuItem mniKeySize5096;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mniGenerate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlRSA;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.Label lblKeySizeValue;
        private System.Windows.Forms.Label lblKeySize;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbHienThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.TextBox txtUs;
        private System.Windows.Forms.Button btnDk;
        private System.Windows.Forms.Button btnDn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
    }
}

