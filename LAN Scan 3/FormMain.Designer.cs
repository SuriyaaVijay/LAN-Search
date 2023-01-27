namespace lanscan
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lANScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFeatured = new System.Windows.Forms.Panel();
            this.btnFeaturedCopy = new System.Windows.Forms.Button();
            this.btnFeaturedOpenContaining = new System.Windows.Forms.Button();
            this.btnFeaturedOpen = new System.Windows.Forms.Button();
            this.lblFeatName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picFeatured = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statApp = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoVideo = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoAudio = new System.Windows.Forms.RadioButton();
            this.rdoImages = new System.Windows.Forms.RadioButton();
            this.rdoDocuments = new System.Windows.Forms.RadioButton();
            this.rdoCode = new System.Windows.Forms.RadioButton();
            this.rdoSoftware = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaxSize = new System.Windows.Forms.TextBox();
            this.txtMinSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.conMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openContainingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.nevermindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.statSearch = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.prgbrSearch = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnlFeatured.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFeatured)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.conMenu.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lANScanToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "LAN Scan";
            // 
            // lANScanToolStripMenuItem
            // 
            this.lANScanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearListToolStripMenuItem,
            this.killThreadsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.lANScanToolStripMenuItem.Name = "lANScanToolStripMenuItem";
            this.lANScanToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.lANScanToolStripMenuItem.Text = "&LAN Scan";
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.clearListToolStripMenuItem.Text = "&Clear list";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // killThreadsToolStripMenuItem
            // 
            this.killThreadsToolStripMenuItem.Name = "killThreadsToolStripMenuItem";
            this.killThreadsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.killThreadsToolStripMenuItem.Text = "&Kill Threads";
            this.killThreadsToolStripMenuItem.Click += new System.EventHandler(this.killThreadsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.advancedToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.preferencesToolStripMenuItem.Text = "&Configure";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.advancedToolStripMenuItem.Text = "&Advanced";
            this.advancedToolStripMenuItem.Click += new System.EventHandler(this.advancedToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pnlFeatured
            // 
            this.pnlFeatured.BackColor = System.Drawing.SystemColors.Info;
            this.pnlFeatured.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFeatured.Controls.Add(this.btnFeaturedCopy);
            this.pnlFeatured.Controls.Add(this.btnFeaturedOpenContaining);
            this.pnlFeatured.Controls.Add(this.btnFeaturedOpen);
            this.pnlFeatured.Controls.Add(this.lblFeatName);
            this.pnlFeatured.Controls.Add(this.label1);
            this.pnlFeatured.Controls.Add(this.picFeatured);
            this.pnlFeatured.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFeatured.Location = new System.Drawing.Point(0, 24);
            this.pnlFeatured.Name = "pnlFeatured";
            this.pnlFeatured.Size = new System.Drawing.Size(630, 0);
            this.pnlFeatured.TabIndex = 1;
            // 
            // btnFeaturedCopy
            // 
            this.btnFeaturedCopy.Location = new System.Drawing.Point(309, 65);
            this.btnFeaturedCopy.Name = "btnFeaturedCopy";
            this.btnFeaturedCopy.Size = new System.Drawing.Size(112, 23);
            this.btnFeaturedCopy.TabIndex = 2;
            this.btnFeaturedCopy.Text = "Copy To Clipboard";
            this.btnFeaturedCopy.UseVisualStyleBackColor = true;
            this.btnFeaturedCopy.Click += new System.EventHandler(this.btnFeaturedCopy_Click);
            // 
            // btnFeaturedOpenContaining
            // 
            this.btnFeaturedOpenContaining.Location = new System.Drawing.Point(198, 65);
            this.btnFeaturedOpenContaining.Name = "btnFeaturedOpenContaining";
            this.btnFeaturedOpenContaining.Size = new System.Drawing.Size(105, 23);
            this.btnFeaturedOpenContaining.TabIndex = 1;
            this.btnFeaturedOpenContaining.Text = "Open Containing";
            this.btnFeaturedOpenContaining.UseVisualStyleBackColor = true;
            this.btnFeaturedOpenContaining.Click += new System.EventHandler(this.btnFeaturedOpenContaining_Click);
            // 
            // btnFeaturedOpen
            // 
            this.btnFeaturedOpen.Location = new System.Drawing.Point(117, 65);
            this.btnFeaturedOpen.Name = "btnFeaturedOpen";
            this.btnFeaturedOpen.Size = new System.Drawing.Size(75, 23);
            this.btnFeaturedOpen.TabIndex = 0;
            this.btnFeaturedOpen.Text = "Open";
            this.btnFeaturedOpen.UseVisualStyleBackColor = true;
            this.btnFeaturedOpen.Click += new System.EventHandler(this.btnFeaturedOpen_Click);
            // 
            // lblFeatName
            // 
            this.lblFeatName.AutoSize = true;
            this.lblFeatName.Location = new System.Drawing.Point(114, 38);
            this.lblFeatName.Name = "lblFeatName";
            this.lblFeatName.Size = new System.Drawing.Size(135, 13);
            this.lblFeatName.TabIndex = 2;
            this.lblFeatName.Text = "South Park ( Season 1 - 9 )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Featured Link :";
            // 
            // picFeatured
            // 
            this.picFeatured.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.picFeatured.Location = new System.Drawing.Point(3, 3);
            this.picFeatured.Name = "picFeatured";
            this.picFeatured.Size = new System.Drawing.Size(105, 105);
            this.picFeatured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFeatured.TabIndex = 0;
            this.picFeatured.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statApp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(630, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statApp
            // 
            this.statApp.Name = "statApp";
            this.statApp.Size = new System.Drawing.Size(125, 17);
            this.statApp.Text = "Welcome to LAN Scan";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnGo);
            this.panel2.Controls.Add(this.txtKeyword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 409);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoVideo);
            this.groupBox2.Controls.Add(this.rdoAll);
            this.groupBox2.Controls.Add(this.rdoAudio);
            this.groupBox2.Controls.Add(this.rdoImages);
            this.groupBox2.Controls.Add(this.rdoDocuments);
            this.groupBox2.Controls.Add(this.rdoCode);
            this.groupBox2.Controls.Add(this.rdoSoftware);
            this.groupBox2.Location = new System.Drawing.Point(13, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 112);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // rdoVideo
            // 
            this.rdoVideo.AutoSize = true;
            this.rdoVideo.Location = new System.Drawing.Point(6, 42);
            this.rdoVideo.Name = "rdoVideo";
            this.rdoVideo.Size = new System.Drawing.Size(52, 17);
            this.rdoVideo.TabIndex = 3;
            this.rdoVideo.Text = "Video";
            this.rdoVideo.UseVisualStyleBackColor = true;
            this.rdoVideo.CheckedChanged += new System.EventHandler(this.rdoVideo_CheckedChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(6, 19);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(112, 17);
            this.rdoAll.TabIndex = 2;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All files and folders";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // rdoAudio
            // 
            this.rdoAudio.AutoSize = true;
            this.rdoAudio.Location = new System.Drawing.Point(6, 65);
            this.rdoAudio.Name = "rdoAudio";
            this.rdoAudio.Size = new System.Drawing.Size(52, 17);
            this.rdoAudio.TabIndex = 5;
            this.rdoAudio.Text = "Audio";
            this.rdoAudio.UseVisualStyleBackColor = true;
            this.rdoAudio.CheckedChanged += new System.EventHandler(this.rdoAudio_CheckedChanged);
            // 
            // rdoImages
            // 
            this.rdoImages.AutoSize = true;
            this.rdoImages.Location = new System.Drawing.Point(6, 88);
            this.rdoImages.Name = "rdoImages";
            this.rdoImages.Size = new System.Drawing.Size(59, 17);
            this.rdoImages.TabIndex = 7;
            this.rdoImages.Text = "Images";
            this.rdoImages.UseVisualStyleBackColor = true;
            this.rdoImages.CheckedChanged += new System.EventHandler(this.rdoImages_CheckedChanged);
            // 
            // rdoDocuments
            // 
            this.rdoDocuments.AutoSize = true;
            this.rdoDocuments.Location = new System.Drawing.Point(90, 89);
            this.rdoDocuments.Name = "rdoDocuments";
            this.rdoDocuments.Size = new System.Drawing.Size(79, 17);
            this.rdoDocuments.TabIndex = 8;
            this.rdoDocuments.Text = "Documents";
            this.rdoDocuments.UseVisualStyleBackColor = true;
            this.rdoDocuments.CheckedChanged += new System.EventHandler(this.rdoDocuments_CheckedChanged);
            // 
            // rdoCode
            // 
            this.rdoCode.AutoSize = true;
            this.rdoCode.Location = new System.Drawing.Point(90, 42);
            this.rdoCode.Name = "rdoCode";
            this.rdoCode.Size = new System.Drawing.Size(50, 17);
            this.rdoCode.TabIndex = 4;
            this.rdoCode.Text = "Code";
            this.rdoCode.UseVisualStyleBackColor = true;
            this.rdoCode.CheckedChanged += new System.EventHandler(this.rdoCode_CheckedChanged);
            // 
            // rdoSoftware
            // 
            this.rdoSoftware.AutoSize = true;
            this.rdoSoftware.Location = new System.Drawing.Point(90, 65);
            this.rdoSoftware.Name = "rdoSoftware";
            this.rdoSoftware.Size = new System.Drawing.Size(67, 17);
            this.rdoSoftware.TabIndex = 6;
            this.rdoSoftware.Text = "Software";
            this.rdoSoftware.UseVisualStyleBackColor = true;
            this.rdoSoftware.CheckedChanged += new System.EventHandler(this.rdoSoftware_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaxSize);
            this.groupBox1.Controls.Add(this.txtMinSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 75);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Size";
            // 
            // txtMaxSize
            // 
            this.txtMaxSize.Location = new System.Drawing.Point(90, 48);
            this.txtMaxSize.Name = "txtMaxSize";
            this.txtMaxSize.Size = new System.Drawing.Size(81, 20);
            this.txtMaxSize.TabIndex = 3;
            this.txtMaxSize.Text = "-1";
            this.toolTip.SetToolTip(this.txtMaxSize, "-1 indicates infinite max size");
            this.txtMaxSize.TextChanged += new System.EventHandler(this.txtMaxSize_TextChanged);
            // 
            // txtMinSize
            // 
            this.txtMinSize.Location = new System.Drawing.Point(90, 19);
            this.txtMinSize.Name = "txtMinSize";
            this.txtMinSize.Size = new System.Drawing.Size(81, 20);
            this.txtMinSize.TabIndex = 2;
            this.txtMinSize.Text = "0";
            this.txtMinSize.TextChanged += new System.EventHandler(this.txtMinSize_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Max size ( MB ) : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Min size ( MB ) : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(115, 55);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "&Go...";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(13, 29);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(177, 20);
            this.txtKeyword.TabIndex = 0;
            this.txtKeyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search what ?";
            // 
            // pnlResults
            // 
            this.pnlResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlResults.Controls.Add(this.dgvResult);
            this.pnlResults.Controls.Add(this.statusStrip2);
            this.pnlResults.Controls.Add(this.toolStrip1);
            this.pnlResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResults.Location = new System.Drawing.Point(205, 24);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(425, 409);
            this.pnlResults.TabIndex = 4;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.ContextMenuStrip = this.conMenu;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(0, 25);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.Size = new System.Drawing.Size(421, 358);
            this.dgvResult.TabIndex = 2;
            this.dgvResult.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvResult_CellContextMenuStripNeeded);
            this.dgvResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellDoubleClick);
            this.dgvResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvResult_KeyUp);
            // 
            // conMenu
            // 
            this.conMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openContainingFolderToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem,
            this.toolStripMenuItem2,
            this.nevermindToolStripMenuItem});
            this.conMenu.Name = "conMenu";
            this.conMenu.Size = new System.Drawing.Size(202, 98);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openContainingFolderToolStripMenuItem
            // 
            this.openContainingFolderToolStripMenuItem.Name = "openContainingFolderToolStripMenuItem";
            this.openContainingFolderToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.openContainingFolderToolStripMenuItem.Text = "Open Containing &Folder";
            this.openContainingFolderToolStripMenuItem.Click += new System.EventHandler(this.openContainingFolderToolStripMenuItem_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.copyToClipboardToolStripMenuItem.Text = "&Copy to Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(198, 6);
            // 
            // nevermindToolStripMenuItem
            // 
            this.nevermindToolStripMenuItem.Name = "nevermindToolStripMenuItem";
            this.nevermindToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.nevermindToolStripMenuItem.Text = "&Nevermind...";
            this.nevermindToolStripMenuItem.Click += new System.EventHandler(this.nevermindToolStripMenuItem_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statSearch});
            this.statusStrip2.Location = new System.Drawing.Point(0, 383);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(421, 22);
            this.statusStrip2.TabIndex = 1;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // statSearch
            // 
            this.statSearch.Name = "statSearch";
            this.statSearch.Size = new System.Drawing.Size(63, 17);
            this.statSearch.Text = "No results.";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.prgbrSearch,
            this.toolStripSeparator1,
            this.btnStop,
            this.btnCopy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(421, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(82, 22);
            this.toolStripLabel1.Text = "Search Results";
            // 
            // prgbrSearch
            // 
            this.prgbrSearch.AutoSize = false;
            this.prgbrSearch.Name = "prgbrSearch";
            this.prgbrSearch.Size = new System.Drawing.Size(100, 16);
            this.prgbrSearch.Step = 1;
            this.prgbrSearch.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgbrSearch.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(35, 22);
            this.btnStop.Text = "&Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(39, 22);
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnFeaturedOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 455);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlFeatured);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.Text = "LAN Scan 3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlFeatured.ResumeLayout(false);
            this.pnlFeatured.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFeatured)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.conMenu.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lANScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFeatured;
        private System.Windows.Forms.Label lblFeatName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picFeatured;
        private System.Windows.Forms.Button btnFeaturedCopy;
        private System.Windows.Forms.Button btnFeaturedOpenContaining;
        private System.Windows.Forms.Button btnFeaturedOpen;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killThreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statApp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoAudio;
        private System.Windows.Forms.RadioButton rdoVideo;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RadioButton rdoDocuments;
        private System.Windows.Forms.RadioButton rdoSoftware;
        private System.Windows.Forms.RadioButton rdoCode;
        private System.Windows.Forms.RadioButton rdoImages;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ContextMenuStrip conMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openContainingFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nevermindToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txtMaxSize;
        private System.Windows.Forms.TextBox txtMinSize;
        public System.Windows.Forms.ToolStripStatusLabel statSearch;
        public System.Windows.Forms.DataGridView dgvResult;
        public System.Windows.Forms.ToolStripProgressBar prgbrSearch;
        private System.Windows.Forms.ToolStripButton btnCopy;
    }
}

