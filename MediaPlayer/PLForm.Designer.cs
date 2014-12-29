namespace MediaPlayer
{
    partial class PLForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PLForm));
            this.PLNTextBox = new System.Windows.Forms.TextBox();
            this.ANTextBox = new System.Windows.Forms.TextBox();
            this.PLTLabel = new System.Windows.Forms.Label();
            this.ANLabel = new System.Windows.Forms.Label();
            this.NewPLlistBox = new System.Windows.Forms.ListBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.STlabel = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.MoveToGB = new System.Windows.Forms.GroupBox();
            this.Botmbtn = new System.Windows.Forms.Button();
            this.TopBtn = new System.Windows.Forms.Button();
            this.DownBtn = new System.Windows.Forms.Button();
            this.UpBtn = new System.Windows.Forms.Button();
            this.MoveToGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // PLNTextBox
            // 
            this.PLNTextBox.Location = new System.Drawing.Point(92, 290);
            this.PLNTextBox.Name = "PLNTextBox";
            this.PLNTextBox.Size = new System.Drawing.Size(164, 20);
            this.PLNTextBox.TabIndex = 0;
            // 
            // ANTextBox
            // 
            this.ANTextBox.Location = new System.Drawing.Point(92, 264);
            this.ANTextBox.Name = "ANTextBox";
            this.ANTextBox.Size = new System.Drawing.Size(164, 20);
            this.ANTextBox.TabIndex = 1;
            // 
            // PLTLabel
            // 
            this.PLTLabel.AutoSize = true;
            this.PLTLabel.Location = new System.Drawing.Point(12, 293);
            this.PLTLabel.Name = "PLTLabel";
            this.PLTLabel.Size = new System.Drawing.Size(62, 13);
            this.PLTLabel.TabIndex = 2;
            this.PLTLabel.Text = "Playlist Title";
            // 
            // ANLabel
            // 
            this.ANLabel.AutoSize = true;
            this.ANLabel.Location = new System.Drawing.Point(12, 267);
            this.ANLabel.Name = "ANLabel";
            this.ANLabel.Size = new System.Drawing.Size(69, 13);
            this.ANLabel.TabIndex = 3;
            this.ANLabel.Text = "Author Name";
            // 
            // NewPLlistBox
            // 
            this.NewPLlistBox.FormattingEnabled = true;
            this.NewPLlistBox.HorizontalScrollbar = true;
            this.NewPLlistBox.Location = new System.Drawing.Point(92, 13);
            this.NewPLlistBox.Name = "NewPLlistBox";
            this.NewPLlistBox.Size = new System.Drawing.Size(164, 186);
            this.NewPLlistBox.TabIndex = 4;
            this.NewPLlistBox.SelectedIndexChanged += new System.EventHandler(this.NewPLlistBox_SelectedIndexChanged);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseBtn.Location = new System.Drawing.Point(262, 147);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.BrowseBtn.TabIndex = 5;
            this.BrowseBtn.Text = "Add";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Savebtn.Location = new System.Drawing.Point(181, 316);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 6;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Location = new System.Drawing.Point(262, 316);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // STlabel
            // 
            this.STlabel.AutoSize = true;
            this.STlabel.Location = new System.Drawing.Point(12, 13);
            this.STlabel.Name = "STlabel";
            this.STlabel.Size = new System.Drawing.Size(74, 13);
            this.STlabel.TabIndex = 8;
            this.STlabel.Text = "Sound Tracks";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Enabled = false;
            this.RemoveBtn.Location = new System.Drawing.Point(262, 176);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 9;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // MoveToGB
            // 
            this.MoveToGB.Controls.Add(this.Botmbtn);
            this.MoveToGB.Controls.Add(this.TopBtn);
            this.MoveToGB.Controls.Add(this.DownBtn);
            this.MoveToGB.Controls.Add(this.UpBtn);
            this.MoveToGB.Location = new System.Drawing.Point(92, 204);
            this.MoveToGB.Margin = new System.Windows.Forms.Padding(2);
            this.MoveToGB.Name = "MoveToGB";
            this.MoveToGB.Padding = new System.Windows.Forms.Padding(2);
            this.MoveToGB.Size = new System.Drawing.Size(164, 55);
            this.MoveToGB.TabIndex = 10;
            this.MoveToGB.TabStop = false;
            this.MoveToGB.Text = "Move To";
            // 
            // Botmbtn
            // 
            this.Botmbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botmbtn.Enabled = false;
            this.Botmbtn.Image = ((System.Drawing.Image)(resources.GetObject("Botmbtn.Image")));
            this.Botmbtn.Location = new System.Drawing.Point(121, 18);
            this.Botmbtn.Name = "Botmbtn";
            this.Botmbtn.Size = new System.Drawing.Size(25, 25);
            this.Botmbtn.TabIndex = 13;
            this.Botmbtn.UseVisualStyleBackColor = true;
            this.Botmbtn.Click += new System.EventHandler(this.Botmbtn_Click);
            // 
            // TopBtn
            // 
            this.TopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TopBtn.Enabled = false;
            this.TopBtn.Image = ((System.Drawing.Image)(resources.GetObject("TopBtn.Image")));
            this.TopBtn.Location = new System.Drawing.Point(88, 18);
            this.TopBtn.Name = "TopBtn";
            this.TopBtn.Size = new System.Drawing.Size(25, 25);
            this.TopBtn.TabIndex = 12;
            this.TopBtn.UseVisualStyleBackColor = true;
            this.TopBtn.Click += new System.EventHandler(this.TopBtn_Click);
            // 
            // DownBtn
            // 
            this.DownBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownBtn.Enabled = false;
            this.DownBtn.Image = ((System.Drawing.Image)(resources.GetObject("DownBtn.Image")));
            this.DownBtn.Location = new System.Drawing.Point(52, 18);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(25, 25);
            this.DownBtn.TabIndex = 11;
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // UpBtn
            // 
            this.UpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpBtn.Enabled = false;
            this.UpBtn.Image = ((System.Drawing.Image)(resources.GetObject("UpBtn.Image")));
            this.UpBtn.Location = new System.Drawing.Point(17, 18);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(25, 25);
            this.UpBtn.TabIndex = 11;
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // PLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 351);
            this.Controls.Add(this.MoveToGB);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.STlabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.NewPLlistBox);
            this.Controls.Add(this.ANLabel);
            this.Controls.Add(this.PLTLabel);
            this.Controls.Add(this.ANTextBox);
            this.Controls.Add(this.PLNTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(365, 390);
            this.MinimumSize = new System.Drawing.Size(365, 390);
            this.Name = "PLForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist";
            this.MoveToGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PLNTextBox;
        private System.Windows.Forms.TextBox ANTextBox;
        private System.Windows.Forms.Label PLTLabel;
        private System.Windows.Forms.Label ANLabel;
        private System.Windows.Forms.ListBox NewPLlistBox;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label STlabel;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.GroupBox MoveToGB;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Button TopBtn;
        private System.Windows.Forms.Button Botmbtn;
    }
}