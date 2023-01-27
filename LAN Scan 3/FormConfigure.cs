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
    public partial class FormConfigure : Form
    {
        public FormConfigure()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("iprange.dat",FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(txtRangeFrom1.Text);
            sw.WriteLine(txtRangeTo1.Text);
            sw.Close();
            fs.Close();


            fs = new FileStream("ips.dat", FileMode.Create);
            sw = new StreamWriter(fs);
            sw.WriteLine(txtIP1.Text);
            sw.WriteLine(txtIP2.Text);
            sw.WriteLine(txtIP3.Text);
            sw.WriteLine(txtIP4.Text);
            sw.WriteLine(txtIP5.Text);
            sw.WriteLine(txtIP6.Text);
            sw.WriteLine(txtIP7.Text);
            sw.WriteLine(txtIP8.Text);
            sw.WriteLine(txtIP9.Text);
            sw.WriteLine(txtIP10.Text);
            sw.WriteLine(txtIP11.Text);
            sw.WriteLine(txtIP12.Text);
            sw.WriteLine(txtIP13.Text);
            sw.WriteLine(txtIP14.Text);
            sw.WriteLine(txtIP15.Text);
            sw.Close();
            fs.Close();

            fs = new FileStream("filter.dat", FileMode.Create);
            sw = new StreamWriter(fs);
            sw.WriteLine(txtVideoFilter.Text);
            sw.WriteLine(txtAudioFilter.Text);
            sw.WriteLine(txtImagesFilter.Text);
            sw.WriteLine(txtCodeFilter.Text);
            sw.WriteLine(txtSoftwareFilter.Text);
            sw.WriteLine(txtDocumentsFilter.Text);
            sw.Close();
            fs.Close();

            Settings.audioFilter = txtAudioFilter.Text;
            Settings.videoFilter = txtVideoFilter.Text;
            Settings.imagesFilter = txtImagesFilter.Text;
            Settings.codeFilter = txtCodeFilter.Text;
            Settings.documentsFilter = txtDocumentsFilter.Text;
            Settings.softwareFilter = txtSoftwareFilter.Text;

            Settings.ipranges[0] = txtRangeFrom1.Text;
            Settings.ipranges[1] = txtRangeTo1.Text;

            Settings.individualips[0] = txtIP1.Text;
            Settings.individualips[1] = txtIP2.Text;
            Settings.individualips[2] = txtIP3.Text;
            Settings.individualips[3] = txtIP4.Text;
            Settings.individualips[4] = txtIP5.Text;
            Settings.individualips[5] = txtIP6.Text;
            Settings.individualips[6] = txtIP7.Text;
            Settings.individualips[7] = txtIP8.Text;
            Settings.individualips[8] = txtIP9.Text;
            Settings.individualips[9] = txtIP10.Text;
            Settings.individualips[10] = txtIP11.Text;
            Settings.individualips[11] = txtIP12.Text;
            Settings.individualips[12] = txtIP13.Text;
            Settings.individualips[13] = txtIP14.Text;
            Settings.individualips[14] = txtIP15.Text;
        }

        private void FormConfigure_Load(object sender, EventArgs e)
        {
            txtAudioFilter.Text=Settings.audioFilter  ;
            txtVideoFilter.Text=Settings.videoFilter ;
            txtImagesFilter.Text=Settings.imagesFilter ;
            txtCodeFilter.Text=Settings.codeFilter ;
            txtDocumentsFilter.Text =Settings.documentsFilter  ;
            txtSoftwareFilter.Text =Settings.softwareFilter ;

            txtRangeFrom1.Text=Settings.ipranges[0];
            txtRangeTo1.Text=Settings.ipranges[1];
            txtIP1.Text=Settings.individualips[0];
            txtIP2.Text=Settings.individualips[1];
            txtIP3.Text=Settings.individualips[2];
            txtIP4.Text=Settings.individualips[3];
            txtIP5.Text=Settings.individualips[4];
            txtIP6.Text=Settings.individualips[5];
            txtIP7.Text=Settings.individualips[6];
            txtIP8.Text=Settings.individualips[7];
            txtIP9.Text=Settings.individualips[8];
            txtIP10.Text=Settings.individualips[9];
            txtIP11.Text=Settings.individualips[10];
            txtIP12.Text=Settings.individualips[11];
            txtIP13.Text=Settings.individualips[12];
            txtIP14.Text=Settings.individualips[13];
            txtIP15.Text=Settings.individualips[14];
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtVideoFilter.Text = Default.videoFilter;
            txtAudioFilter.Text = Default.audioFilter;
            txtImagesFilter.Text = Default.imagesFilter;
            txtCodeFilter.Text = Default.codeFilter;
            txtDocumentsFilter.Text = Default.documentsFilter;
            txtSoftwareFilter.Text = Default.softwareFilter;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnApply_Click(null, null);
        }
    }
}