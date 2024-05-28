using System;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ag_taramasi
{
    public partial class IPScanner : Form
    {
        private int progress;

        public IPScanner()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.WorkerReportsProgress = true;
            txtIP.KeyPress += new KeyPressEventHandler(txtIP_KeyPress);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            taramaBar.Value = e.ProgressPercentage;
        }

        public object dataGridView1 { get; private set; }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string baseIP = txtIP.Text;
            progress = 0;

            Parallel.For(1, 255, new ParallelOptions { MaxDegreeOfParallelism = 50 }, i =>
            {
                string ip = $"{baseIP}.{i}";
                Ping ping = new Ping();
                try
                {
                    PingReply reply = ping.Send(ip);
                    if (reply.Status == IPStatus.Success)
                    {
                        string hostname = GetHostName(ip);
                        this.BeginInvoke((Action)delegate
                        {
                            veriAktarma.Rows.Add(ip, hostname, "Aktif");
                        });
                    }
                }
                catch (Exception)
                {
                }
                progress++;
                backgroundWorker1.ReportProgress(progress * 100 / 254);
            });
        }

        private string GetHostName(string ip)
        {
            try
            {
                IPHostEntry host = Dns.GetHostEntry(ip);
                return host.HostName;
            }
            catch (Exception)
            {
                return "Bilinmeyen Cihaz";
            }
        }

        private void btnTara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIP.Text))
            {
                MessageBox.Show("Bu alan boþ býrakýlamaz", "IPScanner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            veriAktarma.Rows.Clear();
            progress = 0;
            taramaBar.Value = 0;
            btnTara.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (veriAktarma.Rows.Count == 0)
            {
                MessageBox.Show("Cihaz Bulunamadý", "IPScanner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tarama Tamamlandý", "IPScanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            taramaBar.Value = 0;
            progress = 0;
            btnTara.Enabled = true;
        }

        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}