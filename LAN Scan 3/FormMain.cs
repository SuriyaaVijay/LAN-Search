using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Diagnostics;
using System.Net.NetworkInformation;
using Trinet.Networking;

namespace lanscan
{
    public partial class FormMain : Form
    {
     //   ThreadQueue queue;

        ArrayList threads = new ArrayList();
        ArrayList threads2 = new ArrayList();

        int dgvindex;

        int featindex=-1;
        string[] featname = new string[10];
        string[] featurl = new string[10];

        public FormMain()
        {
            InitializeComponent();
         //   queue = new ThreadQueue(this);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            statSearch.Text = "Please Wait...";
            if (Search.maxsize != -1)
            {
                if (Search.maxsize < Search.minsize)
                {
                    MessageBox.Show("Now that's a new one. Max size < Min size.\nDude, what were you thinking ? ");
                    txtMinSize.Focus();
                    return;
                }
                
            }

            Search.keyword = txtKeyword.Text.ToLower();

            if (Search.keyword == "" && Search.filters == null)
            {
                MessageBox.Show("Nope. If you select 'All files and folders',\nthen you have to specify a keyword.");
                txtKeyword.Focus();
                return;
            }

            prgbrSearch.Visible = true;

            DataTable table = new DataTable();
            table.Columns.Add("File Name");
            table.Columns.Add("Location");
            table.Columns.Add("Size");
            dgvResult.DataSource = table;
            for (int i = 0; i < dgvResult.Columns.Count; i++)
            {
                dgvResult.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

//            queue.Start();

            prgbrSearch.Style = ProgressBarStyle.Marquee;

            for (int i = 0; i < 4; i++)
            {
                if(Settings.ipranges[i*2]!=""&&Settings.ipranges[i*2+1]!="")
                {
                    IP ipstart = new IP(Settings.ipranges[i * 2]);
                    IP ipend = new IP(Settings.ipranges[(i * 2)+1]);

                    for (IP ip = ipstart; ip <= ipend; ip++)
                    {                        
                        Thread thread = new Thread(new ParameterizedThreadStart(LocateSearch));
                        threads2.Add(thread);
                        thread.Start(ip.ToString());
                    }
                }
            }
           

            for (int i = 0; i < 15; i++)
            {
                if (Settings.individualips[i] != "")
                {
                    Thread thread = new Thread(new ParameterizedThreadStart(LocateSearch));
                    threads2.Add(thread);
                    thread.Start(Settings.individualips[i].ToString());
                }       
            }          
            txtKeyword.Text = "";
        }

        private void txtKeyword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnGo_Click(null, null);                
            }           
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfigure frm = new FormConfigure();
            frm.ShowDialog();
        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdvanced frm = new FormAdvanced();
            frm.ShowDialog();
        }

        private void UpdateThread()
        {
            try
            {
                TcpClient client = new TcpClient(Settings.serverip, 12345);
                NetworkStream ns = client.GetStream();
                StreamReader sr = new StreamReader(ns);
                string version = sr.ReadLine();
                string[] cur = Application.ProductVersion.Split(new char[] { '.' });
                string[] nw = version.Split(new char[] { '.' });
                int i;
                for (i = 0; i < 4; i++)
                {
                    if (Int32.Parse(cur[i]) < Int32.Parse(nw[i]))
                        break;
                }
                if (i == 4)
                    return;
                string message = sr.ReadLine();
                string address = sr.ReadLine();
                if (MessageBox.Show("New Version available : " + version + "\n\n" + message + "\n\nYour current version is :" + Application.ProductVersion + "\n\n" + "Do you want to download it?", "Update Lan Scan to " + version, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Thread thread = new Thread(new ParameterizedThreadStart(ProcessThread));
                    thread.Start(@"\\" + Settings.serverip + @"\" + address);
                    threads.Add(thread);
                }
                sr.Close();
                ns.Close();
                client.Close();               
            }
            catch
            {

            }
            finally
            {
                threads.Remove(Thread.CurrentThread);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (File.Exists("ips.dat"))
            {
                FileStream fs = new FileStream("ips.dat", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                for (int i = 0; i < 15; i++)
                {
                    string s = sr.ReadLine();
                    if (s == "" || s == null)
                        break;
                    Settings.individualips[i] = s;
                }
                sr.Close();
                fs.Close();
            }

            if (File.Exists("filter.dat"))
            {
                FileStream fs = new FileStream("filter.dat", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                Settings.videoFilter = sr.ReadLine();
                Settings.audioFilter = sr.ReadLine();
                Settings.imagesFilter = sr.ReadLine();
                Settings.codeFilter = sr.ReadLine();
                Settings.softwareFilter = sr.ReadLine();
                Settings.documentsFilter = sr.ReadLine();
                sr.Close();
                fs.Close();
            }
            else
            {
                Settings.videoFilter = Default.videoFilter;
                Settings.audioFilter = Default.audioFilter;
                Settings.imagesFilter = Default.imagesFilter;
                Settings.codeFilter = Default.codeFilter;
                Settings.softwareFilter = Default.softwareFilter;
                Settings.documentsFilter = Default.documentsFilter;
            }

            if (File.Exists("advanced.dat"))
            {
                FileStream fs = new FileStream("advanced.dat", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                Settings.serverip = sr.ReadLine();
                string s = sr.ReadLine();
                Settings.searchDepth = Int32.Parse(s);
                Settings.threads = Int32.Parse(sr.ReadLine());
                Settings.pingTimeout = Int32.Parse(sr.ReadLine());
                sr.Close();
                fs.Close();
            }
            else
            {
                Settings.serverip = Default.serverip;
                Settings.searchDepth = Default.searchDepth;
                Settings.threads = Default.threads;
                Settings.pingTimeout = Default.pingTimeout;
            }

            if (File.Exists("iprange.dat"))
            {
                FileStream fs = new FileStream("iprange.dat", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                for (int i = 0; i < 8; i++)
                {
                    string s = sr.ReadLine();
                    if (s == "" || s == null)
                        break;
                    Settings.ipranges[i] = s;
                }
                sr.Close();
                fs.Close();
            }
            else
            {
                this.Show();
                FormConfigure frm = new FormConfigure();
                frm.ShowDialog();
            }
            
            Thread thread = new Thread(new ThreadStart(UpdateThread));
            thread.Start();
            threads.Add(thread);
            
            thread = new Thread(new ThreadStart(FeaturedThread));
            thread.Start();
            threads.Add(thread);
            
        }

        private void FeaturedThread()
        {
            Ping pingSender = new Ping();
            PingReply reply = null;
            try
            {
                reply = pingSender.Send(Settings.serverip, Settings.pingTimeout);
                if (reply != null && reply.Status == IPStatus.Success)
                {
                    ShareCollection sc = new ShareCollection(Settings.serverip);
                    bool found = false;
                    foreach (Share share in sc)
                    {
                        if (share.NetName == "featured")
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found)
                    {
                        if (Directory.Exists("featured"))
                            Directory.Delete("featured", true);
                        if (!Directory.Exists("featured"))
                            Directory.CreateDirectory("featured");
                        DirectoryInfo di = new DirectoryInfo(@"\\" + Settings.serverip + @"\" + "featured");

                        foreach (FileInfo file in di.GetFiles())
                        {
                            file.CopyTo(@"featured\" + file.Name);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Functions.ErrorReport(e.ToString());
            }          
            
            if (Directory.Exists(Application.StartupPath+@"\featured"))
            {
                int i;
                FileStream fs = new FileStream("featured\\links.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                for (i = 0; i < 10; i++)
                {
                    featname[i] = @sr.ReadLine();
                    featurl[i] = @sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                for (i = 0; i < 10; i++)
                {
                    if (featindex != -1)
                        break;
                    Thread thread = new Thread(new ParameterizedThreadStart(FeatCheckThread));
                    thread.Start(i);
                    threads.Add(thread);
                    Thread.Sleep(Settings.pingTimeout);
                    thread.Abort();
                }
            }
            else
            {
                pnlFeatured.Height = 0;
            }
            threads.Remove(Thread.CurrentThread);
          
        }

        private void FeatCheckThread(object o)
        {
            int i = (int)o;
            if (Directory.Exists(@featurl[i]) || File.Exists(@featurl[i]))
            {
                featindex = i;
                FeatUpdate();               
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout frm = new FormAbout();
            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            Search.filters = null;
        }

        private void rdoVideo_CheckedChanged(object sender, EventArgs e)
        {
            Search.filters = Settings.videoFilter.Split(new char[] { ' ' });
        }

        private void rdoCode_CheckedChanged(object sender, EventArgs e)
        {
            Search.filters = Settings.codeFilter.Split(new char[] { ' ' });
        }

        private void rdoAudio_CheckedChanged(object sender, EventArgs e)
        {
            Search.filters = Settings.audioFilter.Split(new char[] { ' ' });
        }

        private void rdoSoftware_CheckedChanged(object sender, EventArgs e)
        {
            Search.filters = Settings.softwareFilter.Split(new char[] { ' ' });
        }

        private void rdoImages_CheckedChanged(object sender, EventArgs e)
        {
            Search.filters = Settings.imagesFilter.Split(new char[] { ' ' });
        }

        private void rdoDocuments_CheckedChanged(object sender, EventArgs e)
        {
            Search.filters = Settings.documentsFilter.Split(new char[] { ' ' });
        }

        private void txtMinSize_TextChanged(object sender, EventArgs e)
        {
            int minsize;
            bool result = Int32.TryParse(txtMinSize.Text,out minsize);
            if (result == false || minsize<1)
            {
                MessageBox.Show("Invalid minimum size. Minimum size has to be a non-negative integer");
                txtMinSize.Text = "";
                txtMinSize.Focus();
                return;
            }
            Search.minsize = minsize*1024*1024;
        }

        private void txtMaxSize_TextChanged(object sender, EventArgs e)
        {
            int maxsize;
            bool result = Int32.TryParse(txtMaxSize.Text,out  maxsize);
            if (result == false || maxsize < -1 || maxsize == 0)
            {
                MessageBox.Show("Invalid maximum size. Minimum size has to be a positive integer or -1(Indicating infinite)");
                txtMaxSize.Text = "";
                txtMaxSize.Focus();
                return;
            }
            Search.maxsize = maxsize*1024*1024;
        }

        delegate void SetCallbackAddRow(params object[] objects);

        public void AddRow(params object[] objects)
        {
            try
            {
                if (this.dgvResult.InvokeRequired)
                {
                    SetCallbackAddRow d = new SetCallbackAddRow(AddRow);
                    this.Invoke(d, new object[] { objects });
                }
                else
                {
                    (dgvResult.DataSource as DataTable).Rows.Add(objects);
                }
            }
            catch (Exception e)
            {
                Functions.ErrorReport(e.ToString());
                return;
            }
        }

        delegate void SetCallbackSearchStat(string s);
        public void SetSearchStatus(string s)
        {          
            try
            {
                if (this.InvokeRequired)
                {
                    SetCallbackSearchStat d = new SetCallbackSearchStat(SetSearchStatus);
                    this.Invoke(d,s);
                }
                else
                {
                    this.statSearch.Text=s;
                }
            }
            catch (Exception e)
            {
                Functions.ErrorReport(e.ToString());
                return;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        delegate void NoArgs();
        public void FeatUpdate()
        {
            try
            {
                if (this.InvokeRequired)
                {
                    NoArgs d = new NoArgs(FeatUpdate);
                    this.Invoke(d);
                }
                else
                {
                    pnlFeatured.Height = 117;
                    picFeatured.Image = new Bitmap("featured\\" + (featindex + 1) + ".jpg");
                    lblFeatName.Text = @featname[featindex];                           
                }
            }
            catch (Exception e)
            {
                Functions.ErrorReport(e.ToString());
                return;
            }
        }
        public void  StopProgBar()
        {
            try
            {
                if (this.InvokeRequired)
                {
                    NoArgs d = new NoArgs(StopProgBar);
                    this.Invoke(d);
                }
                else
                {
                    this.prgbrSearch.Visible = false;
                }
            }
            catch (Exception e)
            {
                Functions.ErrorReport(e.ToString());
                return;
            }
        }

        public void StartProcess(string command)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(ProcessThread));
            thread.Start(command);
            threads.Add(thread);
        }

        public void ProcessThread(object command)
        {
            try
            {
                Process.Start(command as string);
            }
            catch (Exception ex)
            {
                Functions.ErrorReport(ex.ToString());
            }
            threads.Remove(Thread.CurrentThread);
        }

        private void dgvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResult.DataSource == null)
                return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

           

            DataTable table = dgvResult.DataSource as DataTable;

            string s = table.Rows[e.RowIndex][1] as string; 

            if (e.ColumnIndex == 1)
            {
                try
                {
                    StartProcess(s);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    StartProcess(s+"\\"+(table.Rows[e.RowIndex][0] as string));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartProcess((dgvResult.DataSource as DataTable).Rows[dgvindex][1].ToString() + "\\" + (dgvResult.DataSource as DataTable).Rows[dgvindex][0].ToString());
            }
            catch (Exception ex)
            {
                Functions.ErrorReport(ex.ToString());
            }       
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
            /*
            try
            {
                foreach (Thread t in threads)
                {
                    try
                    {
                        if (t.ThreadState == System.Threading.ThreadState.Running)
                            t.Abort();
                    }
                    catch (Exception ex)
                    {
                        Functions.ErrorReport(ex.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Functions.ErrorReport(ex.ToString());
            }  */          
        }

        private void dgvResult_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {

            dgvindex = e.RowIndex;
        }

        private void openContainingFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartProcess((dgvResult.DataSource as DataTable).Rows[dgvindex][1].ToString());
            }
            catch (Exception ex)
            {
                Functions.ErrorReport(ex.ToString());
            } 
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StringCollection sc = new StringCollection();
                sc.Add((dgvResult.DataSource as DataTable).Rows[dgvindex][1].ToString() + "\\" + (dgvResult.DataSource as DataTable).Rows[dgvindex][0].ToString());
                Clipboard.SetFileDropList(sc);
            }
            catch(Exception ex)
            {
                Functions.ErrorReport(ex.ToString());
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            StringCollection sc = new StringCollection();
            DataTable table = dgvResult.DataSource as DataTable;
            foreach (DataGridViewCell cell in dgvResult.SelectedCells)
            {
                string s = table.Rows[cell.RowIndex][1] + "\\" + table.Rows[cell.RowIndex][0];
                if (!sc.Contains(s))
                {
                    sc.Add(s);
                }
            }

            try
            {
                Clipboard.SetFileDropList(sc);
            }
            catch(Exception ex)
            {
                Functions.ErrorReport(ex.ToString());
            }
        }

        private void dgvResult_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Control)
            {
                btnCopy_Click(null, null);
            }
        }

        private void btnFeaturedOpen_Click(object sender, EventArgs e)
        {
            ProcessThread(featurl[featindex]);
        }

        private void btnFeaturedOpenContaining_Click(object sender, EventArgs e)
        {
            string s = featurl[featindex].Substring(0,featurl[featindex].LastIndexOf('\\'));
            ProcessThread(s);
        }

        private void btnFeaturedCopy_Click(object sender, EventArgs e)
        {
            StringCollection sc = new StringCollection();
            sc.Add(featurl[featindex]);
            Clipboard.SetFileDropList(sc);
        }

        private void nevermindToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }        

        public void Stop()
        {
            Thread stop = new Thread(new ThreadStart(StopThread));
            stop.Start();
        }

        public void StopThread()
        {
            /*
            if(monitorThread!=null&&monitorThread.ThreadState==ThreadState.Running)
                monitorThread.Abort();
            
            queue.Clear();
            */
            try
            {
                foreach (Thread thread in threads2)
                {
                    try
                    {
                        if (thread.ThreadState == System.Threading.ThreadState.Running)
                            thread.Abort();
                    }
                    catch (Exception e)
                    {
                        Functions.ErrorReport(e.ToString());
                        continue;
                    }
                }
                SetSearchStatus("File(s)/Folder(s) found : " + (dgvResult.DataSource as DataTable).Rows.Count);
                StopProgBar();
            }
            catch
            {

            }
            try
            {
                foreach (Thread thread in threads)
                {
                    try
                    {
                        if (thread.ThreadState == System.Threading.ThreadState.Running)
                            thread.Abort();
                    }
                    catch (Exception e)
                    {
                        Functions.ErrorReport(e.ToString());
                        continue;
                    }
                }
            }
            catch
            {

            }
            finally
            {
                threads.Remove(Thread.CurrentThread);
            }
        }
        public void LocateSearch(object IP)
        {
            Ping pingSender = new Ping();
            PingReply reply = null;
            try
            {
                reply = pingSender.Send(IP as string, Settings.pingTimeout);
            }
            catch (Exception e)
            {
                Functions.ErrorReport(e.ToString());
            }

            // IP Address is active now search
            if (reply != null && reply.Status == IPStatus.Success)
            {
                ShareCollection sc = new ShareCollection(IP as string);
                foreach (Share share in sc)
                {
                    if (share.ShareType != ShareType.Disk)
                        continue;

                    try
                    {
                        RecursiveSearch(share.ToString(), 0);
                    }
                    catch (Exception e)
                    {
                        Functions.ErrorReport(e.ToString());
                    }
                }
            }

            threads2.Remove(Thread.CurrentThread);

            if (threads2.Count == 0)
            {
                try
                {
                    StopProgBar();
                    SetSearchStatus("File(s)/Folder(s) found : " + (dgvResult.DataSource as DataTable).Rows.Count);
                }
                catch (Exception e)
                {
                    Functions.ErrorReport(e.ToString());
                }
            }
            
        }

        public void RecursiveSearch(string url, int depth)
        {
            DirectoryInfo di = new DirectoryInfo(url);
            if (!di.Exists)
                return;

            if (depth > Settings.searchDepth)
                return;
            depth++;

            SetSearchStatus("Searching " + url);

            if (Search.filters == null)
            {
                if (di.Name.ToLower().Contains(Search.keyword))
                {
                    string dirname;
                    if (di.Parent == null)
                        dirname = di.FullName.Substring(0, di.FullName.LastIndexOf(@"\"));
                    else
                        dirname = di.Parent.FullName;
                    AddRow(di.Name, dirname, "-");
                    /*Hmm parent directory ka panga*/
                }
            }

            foreach (FileInfo fi in di.GetFiles())
            {
                string filename = fi.Name.ToLower();

                if (filename.Contains(Search.keyword))
                {
                    if (Search.filters != null)
                    {
                        foreach (string s in Search.filters)
                        {
                            if (filename.EndsWith(s))
                            {
                                if (fi.Length > Search.minsize && (Search.maxsize == -1 || fi.Length < Search.maxsize))
                                {
                                    long length = fi.Length;
                                    string slen;
                                    if (length > 1073741824)
                                    {
                                        slen = (length / 1073741824) + " GB";
                                    }
                                    else
                                    {
                                        if (length > 1048576)
                                        {
                                            slen = (length / 1048576) + " MB";
                                        }
                                        else
                                        {
                                            if (length > 1024)
                                            {
                                                slen = (length / 1024) + " KB";
                                            }
                                            else
                                                slen = length + " B";
                                        }
                                    }
                                    
                                    AddRow(fi.Name, di.FullName, slen);
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (fi.Length > Search.minsize && (Search.maxsize == -1 || fi.Length < Search.maxsize))
                        {                            
                            long length = fi.Length;
                            string slen;
                            if (length > 1073741824)
                            {
                                slen = (length / 1073741824) + " GB";
                            }
                            else
                            {
                                if (length > 1048576)
                                {
                                    slen = (length / 1048576) + " MB";
                                }
                                else
                                {
                                    if (length > 1024)
                                    {
                                        slen = (length / 1024) + " KB";
                                    }
                                    else
                                        slen = length + " B";
                                }
                            }
                            AddRow(fi.Name, di.FullName, slen);
                        }
                    }
                }
            }

            foreach (DirectoryInfo subdir in di.GetDirectories())
            {
                try
                {
                    RecursiveSearch(subdir.FullName, depth);
                }
                catch (Exception e)
                {
                    Functions.ErrorReport(e.ToString());
                }
            }
        }

        private void killThreadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (dgvResult.DataSource as DataTable).Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}