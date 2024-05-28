namespace ag_taramasi
{
    partial class IPScanner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            btnTara = new Button();
            lblSubnet = new Label();
            txtIP = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            araclarMenu = new ContextMenuStrip(components);
            bağlantıyıKesToolStripMenuItem = new ToolStripMenuItem();
            veriAktarma = new DataGridView();
            ipAdresi = new DataGridViewTextBoxColumn();
            cihazİsmi = new DataGridViewTextBoxColumn();
            durumBaglanti = new DataGridViewTextBoxColumn();
            bağlantıyıKesToolStripMenuItem1 = new ToolStripMenuItem();
            taramaBar = new ProgressBar();
            araclarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)veriAktarma).BeginInit();
            SuspendLayout();
            // 
            // btnTara
            // 
            btnTara.Location = new Point(382, 31);
            btnTara.Name = "btnTara";
            btnTara.Size = new Size(94, 29);
            btnTara.TabIndex = 0;
            btnTara.Text = "Tara";
            btnTara.UseVisualStyleBackColor = true;
            btnTara.Click += btnTara_Click;
            // 
            // lblSubnet
            // 
            lblSubnet.AutoSize = true;
            lblSubnet.Location = new Point(59, 36);
            lblSubnet.Name = "lblSubnet";
            lblSubnet.Size = new Size(111, 20);
            lblSubnet.TabIndex = 1;
            lblSubnet.Text = "Network Adresi";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(176, 33);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(200, 27);
            txtIP.TabIndex = 2;
            txtIP.KeyPress += txtIP_KeyPress;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 68);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 4;
            label1.Text = "e : 192.168.0";
            // 
            // araclarMenu
            // 
            araclarMenu.ImageScalingSize = new Size(20, 20);
            araclarMenu.Items.AddRange(new ToolStripItem[] { bağlantıyıKesToolStripMenuItem });
            araclarMenu.Name = "contextMenuStrip1";
            araclarMenu.Size = new Size(70, 26);
            // 
            // bağlantıyıKesToolStripMenuItem
            // 
            bağlantıyıKesToolStripMenuItem.Name = "bağlantıyıKesToolStripMenuItem";
            bağlantıyıKesToolStripMenuItem.Size = new Size(69, 22);
            // 
            // veriAktarma
            // 
            veriAktarma.AllowUserToAddRows = false;
            veriAktarma.AllowUserToDeleteRows = false;
            veriAktarma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            veriAktarma.Columns.AddRange(new DataGridViewColumn[] { ipAdresi, cihazİsmi, durumBaglanti });
            veriAktarma.Location = new Point(59, 119);
            veriAktarma.Name = "veriAktarma";
            veriAktarma.ReadOnly = true;
            veriAktarma.RowHeadersWidth = 51;
            veriAktarma.Size = new Size(417, 214);
            veriAktarma.TabIndex = 5;
            // 
            // ipAdresi
            // 
            ipAdresi.HeaderText = "IP Adresi";
            ipAdresi.MinimumWidth = 6;
            ipAdresi.Name = "ipAdresi";
            ipAdresi.ReadOnly = true;
            ipAdresi.Width = 125;
            // 
            // cihazİsmi
            // 
            cihazİsmi.HeaderText = "Cihaz İsmi";
            cihazİsmi.MinimumWidth = 6;
            cihazİsmi.Name = "cihazİsmi";
            cihazİsmi.ReadOnly = true;
            cihazİsmi.Width = 125;
            // 
            // durumBaglanti
            // 
            durumBaglanti.HeaderText = "Durum";
            durumBaglanti.MinimumWidth = 6;
            durumBaglanti.Name = "durumBaglanti";
            durumBaglanti.ReadOnly = true;
            durumBaglanti.Width = 125;
            // 
            // bağlantıyıKesToolStripMenuItem1
            // 
            bağlantıyıKesToolStripMenuItem1.Name = "bağlantıyıKesToolStripMenuItem1";
            bağlantıyıKesToolStripMenuItem1.Size = new Size(32, 19);
            // 
            // taramaBar
            // 
            taramaBar.Location = new Point(218, 66);
            taramaBar.Name = "taramaBar";
            taramaBar.Size = new Size(125, 22);
            taramaBar.TabIndex = 6;
            // 
            // IPScanner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 361);
            Controls.Add(taramaBar);
            Controls.Add(veriAktarma);
            Controls.Add(label1);
            Controls.Add(txtIP);
            Controls.Add(lblSubnet);
            Controls.Add(btnTara);
            Name = "IPScanner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IPScanner";
            araclarMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)veriAktarma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTara;
        private Label lblSubnet;
        private TextBox txtIP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private ContextMenuStrip araclarMenu;
        private ToolStripMenuItem bağlantıyıKesToolStripMenuItem;
        private DataGridView veriAktarma;
        private DataGridViewTextBoxColumn ipAdresi;
        private DataGridViewTextBoxColumn cihazİsmi;
        private DataGridViewTextBoxColumn durumBaglanti;
        private ToolStripMenuItem bağlantıyıKesToolStripMenuItem1;
        private ProgressBar taramaBar;
    }
}
