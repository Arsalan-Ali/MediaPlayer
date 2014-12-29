namespace MediaPlayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelNP = new System.Windows.Forms.TableLayoutPanel();
            this.NPlistbox = new System.Windows.Forms.ListBox();
            this.MoveToGB = new System.Windows.Forms.GroupBox();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.RmvBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPlayL = new System.Windows.Forms.TableLayoutPanel();
            this.PlayBtnPL = new System.Windows.Forms.Button();
            this.DelBtnPL = new System.Windows.Forms.Button();
            this.PLlistBox = new System.Windows.Forms.ListBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.MediaPlayerControl = new AxWMPLib.AxWindowsMediaPlayer();
            this.TopBtn = new System.Windows.Forms.Button();
            this.DownBtn = new System.Windows.Forms.Button();
            this.Botmbtn = new System.Windows.Forms.Button();
            this.UpBtn = new System.Windows.Forms.Button();
            this.FSbtn = new System.Windows.Forms.Button();
            this.AddPLbtn = new System.Windows.Forms.Button();
            this.OpenFilesBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanelNP.SuspendLayout();
            this.MoveToGB.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanelPlayL.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.tabControl1, 3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(686, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(195, 396);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanelNP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(187, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Now Playing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelNP
            // 
            this.tableLayoutPanelNP.ColumnCount = 3;
            this.tableLayoutPanelNP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelNP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelNP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelNP.Controls.Add(this.NPlistbox, 0, 0);
            this.tableLayoutPanelNP.Controls.Add(this.MoveToGB, 0, 2);
            this.tableLayoutPanelNP.Controls.Add(this.PlayBtn, 0, 1);
            this.tableLayoutPanelNP.Controls.Add(this.RmvBtn, 1, 1);
            this.tableLayoutPanelNP.Controls.Add(this.SaveBtn, 2, 1);
            this.tableLayoutPanelNP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelNP.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelNP.Name = "tableLayoutPanelNP";
            this.tableLayoutPanelNP.RowCount = 3;
            this.tableLayoutPanelNP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelNP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelNP.Size = new System.Drawing.Size(181, 364);
            this.tableLayoutPanelNP.TabIndex = 0;
            // 
            // NPlistbox
            // 
            this.tableLayoutPanelNP.SetColumnSpan(this.NPlistbox, 3);
            this.NPlistbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NPlistbox.FormattingEnabled = true;
            this.NPlistbox.HorizontalScrollbar = true;
            this.NPlistbox.Location = new System.Drawing.Point(3, 3);
            this.NPlistbox.Name = "NPlistbox";
            this.NPlistbox.Size = new System.Drawing.Size(175, 278);
            this.NPlistbox.TabIndex = 0;
            this.NPlistbox.SelectedIndexChanged += new System.EventHandler(this.NPlistbox_SelectedIndexChanged);
            this.NPlistbox.DoubleClick += new System.EventHandler(this.NPlistbox_DoubleClick);
            // 
            // MoveToGB
            // 
            this.tableLayoutPanelNP.SetColumnSpan(this.MoveToGB, 3);
            this.MoveToGB.Controls.Add(this.TopBtn);
            this.MoveToGB.Controls.Add(this.DownBtn);
            this.MoveToGB.Controls.Add(this.Botmbtn);
            this.MoveToGB.Controls.Add(this.UpBtn);
            this.MoveToGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveToGB.Location = new System.Drawing.Point(3, 312);
            this.MoveToGB.Name = "MoveToGB";
            this.MoveToGB.Size = new System.Drawing.Size(175, 49);
            this.MoveToGB.TabIndex = 1;
            this.MoveToGB.TabStop = false;
            this.MoveToGB.Text = "Move To";
            // 
            // PlayBtn
            // 
            this.PlayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayBtn.Enabled = false;
            this.PlayBtn.Location = new System.Drawing.Point(1, 284);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(56, 23);
            this.PlayBtn.TabIndex = 2;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // RmvBtn
            // 
            this.RmvBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RmvBtn.Enabled = false;
            this.RmvBtn.Location = new System.Drawing.Point(61, 284);
            this.RmvBtn.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.RmvBtn.Name = "RmvBtn";
            this.RmvBtn.Size = new System.Drawing.Size(56, 23);
            this.RmvBtn.TabIndex = 3;
            this.RmvBtn.Text = "Remove";
            this.RmvBtn.UseVisualStyleBackColor = true;
            this.RmvBtn.Click += new System.EventHandler(this.RmvBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(121, 284);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(56, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanelPlayL);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(187, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Playlists";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelPlayL
            // 
            this.tableLayoutPanelPlayL.ColumnCount = 3;
            this.tableLayoutPanelPlayL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPlayL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPlayL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPlayL.Controls.Add(this.PlayBtnPL, 0, 1);
            this.tableLayoutPanelPlayL.Controls.Add(this.DelBtnPL, 1, 1);
            this.tableLayoutPanelPlayL.Controls.Add(this.PLlistBox, 0, 0);
            this.tableLayoutPanelPlayL.Controls.Add(this.EditBtn, 2, 1);
            this.tableLayoutPanelPlayL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPlayL.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelPlayL.Name = "tableLayoutPanelPlayL";
            this.tableLayoutPanelPlayL.RowCount = 2;
            this.tableLayoutPanelPlayL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPlayL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanelPlayL.Size = new System.Drawing.Size(181, 364);
            this.tableLayoutPanelPlayL.TabIndex = 0;
            // 
            // PlayBtnPL
            // 
            this.PlayBtnPL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayBtnPL.Enabled = false;
            this.PlayBtnPL.Location = new System.Drawing.Point(1, 336);
            this.PlayBtnPL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PlayBtnPL.Name = "PlayBtnPL";
            this.PlayBtnPL.Size = new System.Drawing.Size(56, 23);
            this.PlayBtnPL.TabIndex = 0;
            this.PlayBtnPL.Text = "Play";
            this.PlayBtnPL.UseVisualStyleBackColor = true;
            this.PlayBtnPL.Click += new System.EventHandler(this.PlayBtnPL_Click);
            // 
            // DelBtnPL
            // 
            this.DelBtnPL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelBtnPL.Enabled = false;
            this.DelBtnPL.Location = new System.Drawing.Point(61, 336);
            this.DelBtnPL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DelBtnPL.Name = "DelBtnPL";
            this.DelBtnPL.Size = new System.Drawing.Size(56, 23);
            this.DelBtnPL.TabIndex = 1;
            this.DelBtnPL.Text = "Delete";
            this.DelBtnPL.UseVisualStyleBackColor = true;
            this.DelBtnPL.Click += new System.EventHandler(this.DelBtnPL_Click);
            // 
            // PLlistBox
            // 
            this.tableLayoutPanelPlayL.SetColumnSpan(this.PLlistBox, 3);
            this.PLlistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PLlistBox.FormattingEnabled = true;
            this.PLlistBox.Location = new System.Drawing.Point(3, 3);
            this.PLlistBox.Name = "PLlistBox";
            this.PLlistBox.Size = new System.Drawing.Size(175, 330);
            this.PLlistBox.Sorted = true;
            this.PLlistBox.TabIndex = 2;
            this.PLlistBox.SelectedIndexChanged += new System.EventHandler(this.PLlistBox_SelectedIndexChanged);
            this.PLlistBox.DoubleClick += new System.EventHandler(this.PLlistBox_DoubleClick);
            // 
            // EditBtn
            // 
            this.EditBtn.Enabled = false;
            this.EditBtn.Location = new System.Drawing.Point(121, 336);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(56, 23);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.fullScreenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openFileToolStripMenuItem.Text = "Open File(s)";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.fullScreenToolStripMenuItem.Text = "Full Screen";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanelMain.Controls.Add(this.MediaPlayerControl, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.FSbtn, 3, 0);
            this.tableLayoutPanelMain.Controls.Add(this.AddPLbtn, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.OpenFilesBtn, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tabControl1, 1, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(884, 487);
            this.tableLayoutPanelMain.TabIndex = 8;
            // 
            // MediaPlayerControl
            // 
            this.MediaPlayerControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaPlayerControl.Enabled = true;
            this.MediaPlayerControl.Location = new System.Drawing.Point(3, 3);
            this.MediaPlayerControl.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.MediaPlayerControl.Name = "MediaPlayerControl";
            this.MediaPlayerControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayerControl.OcxState")));
            this.tableLayoutPanelMain.SetRowSpan(this.MediaPlayerControl, 2);
            this.MediaPlayerControl.Size = new System.Drawing.Size(680, 481);
            this.MediaPlayerControl.TabIndex = 2;
            this.MediaPlayerControl.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.MediaPlayerControl_MediaChange);
            // 
            // TopBtn
            // 
            this.TopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TopBtn.Enabled = false;
            this.TopBtn.Image = ((System.Drawing.Image)(resources.GetObject("TopBtn.Image")));
            this.TopBtn.Location = new System.Drawing.Point(93, 18);
            this.TopBtn.Name = "TopBtn";
            this.TopBtn.Size = new System.Drawing.Size(25, 25);
            this.TopBtn.TabIndex = 3;
            this.TopBtn.UseVisualStyleBackColor = true;
            this.TopBtn.Click += new System.EventHandler(this.TopBtn_Click);
            // 
            // DownBtn
            // 
            this.DownBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownBtn.Enabled = false;
            this.DownBtn.Image = ((System.Drawing.Image)(resources.GetObject("DownBtn.Image")));
            this.DownBtn.Location = new System.Drawing.Point(54, 18);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(25, 25);
            this.DownBtn.TabIndex = 2;
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // Botmbtn
            // 
            this.Botmbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botmbtn.Enabled = false;
            this.Botmbtn.Image = ((System.Drawing.Image)(resources.GetObject("Botmbtn.Image")));
            this.Botmbtn.Location = new System.Drawing.Point(130, 18);
            this.Botmbtn.Name = "Botmbtn";
            this.Botmbtn.Size = new System.Drawing.Size(25, 25);
            this.Botmbtn.TabIndex = 1;
            this.Botmbtn.UseVisualStyleBackColor = true;
            this.Botmbtn.Click += new System.EventHandler(this.Botmbtn_Click);
            // 
            // UpBtn
            // 
            this.UpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpBtn.Enabled = false;
            this.UpBtn.Image = ((System.Drawing.Image)(resources.GetObject("UpBtn.Image")));
            this.UpBtn.Location = new System.Drawing.Point(18, 18);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(25, 25);
            this.UpBtn.TabIndex = 0;
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // FSbtn
            // 
            this.FSbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FSbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FSbtn.Image = ((System.Drawing.Image)(resources.GetObject("FSbtn.Image")));
            this.FSbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FSbtn.Location = new System.Drawing.Point(826, 4);
            this.FSbtn.Name = "FSbtn";
            this.FSbtn.Size = new System.Drawing.Size(49, 77);
            this.FSbtn.TabIndex = 5;
            this.FSbtn.Text = "Full Screen";
            this.FSbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FSbtn.UseVisualStyleBackColor = true;
            this.FSbtn.Click += new System.EventHandler(this.FSbtn_Click);
            // 
            // AddPLbtn
            // 
            this.AddPLbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddPLbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPLbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPLbtn.Image = ((System.Drawing.Image)(resources.GetObject("AddPLbtn.Image")));
            this.AddPLbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddPLbtn.Location = new System.Drawing.Point(759, 4);
            this.AddPLbtn.Name = "AddPLbtn";
            this.AddPLbtn.Size = new System.Drawing.Size(49, 77);
            this.AddPLbtn.TabIndex = 6;
            this.AddPLbtn.Text = "Add Playlist";
            this.AddPLbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddPLbtn.UseVisualStyleBackColor = true;
            this.AddPLbtn.Click += new System.EventHandler(this.AddPLbtn_Click);
            // 
            // OpenFilesBtn
            // 
            this.OpenFilesBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenFilesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFilesBtn.Image = ((System.Drawing.Image)(resources.GetObject("OpenFilesBtn.Image")));
            this.OpenFilesBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OpenFilesBtn.Location = new System.Drawing.Point(692, 4);
            this.OpenFilesBtn.Name = "OpenFilesBtn";
            this.OpenFilesBtn.Size = new System.Drawing.Size(49, 77);
            this.OpenFilesBtn.TabIndex = 0;
            this.OpenFilesBtn.Text = "Open File(s)";
            this.OpenFilesBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OpenFilesBtn.UseVisualStyleBackColor = true;
            this.OpenFilesBtn.Click += new System.EventHandler(this.OpenFilesBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(549, 399);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Echo Media Player";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanelNP.ResumeLayout(false);
            this.MoveToGB.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanelPlayL.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFilesBtn;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayerControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button FSbtn;
        private System.Windows.Forms.Button AddPLbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNP;
        private System.Windows.Forms.ListBox NPlistbox;
        private System.Windows.Forms.GroupBox MoveToGB;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button RmvBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Button Botmbtn;
        private System.Windows.Forms.Button TopBtn;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlayL;
        private System.Windows.Forms.Button PlayBtnPL;
        private System.Windows.Forms.Button DelBtnPL;
        private System.Windows.Forms.ListBox PLlistBox;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

