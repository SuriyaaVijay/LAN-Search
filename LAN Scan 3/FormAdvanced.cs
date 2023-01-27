using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace lanscan
{
    public partial class FormAdvanced : Form
    {
        public FormAdvanced()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPingTimeout.Text = Default.pingTimeout.ToString();
            txtSearchDepth.Text = Default.searchDepth.ToString();
            txtServerIP.Text = Default.serverip;
            txtThreads.Text = Default.threads.ToString();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("advanced.dat", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(txtServerIP.Text);
            sw.WriteLine(txtSearchDepth.Text);
            sw.WriteLine(txtThreads.Text);
            sw.WriteLine(txtPingTimeout.Text);
            sw.Close();
            fs.Close();

            Settings.serverip = txtServerIP.Text;
            Settings.searchDepth = Int32.Parse(txtSearchDepth.Text);
            Settings.threads = Int32.Parse(txtThreads.Text);
            Settings.pingTimeout = Int32.Parse(txtPingTimeout.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnApply_Click(null, null);
        }

        private void FormAdvanced_Load(object sender, EventArgs e)
        {
            txtServerIP.Text = Settings.serverip;
            txtSearchDepth.Text = Settings.searchDepth.ToString();
            txtThreads.Text = Settings.threads.ToString();
            txtPingTimeout.Text = Settings.pingTimeout.ToString();
        }
    }
}