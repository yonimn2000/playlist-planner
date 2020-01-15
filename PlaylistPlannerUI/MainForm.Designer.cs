namespace YonatanMankovich.PlaylistPlannerUI
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
            this.openFolderBTN = new System.Windows.Forms.Button();
            this.openFolderLBL = new System.Windows.Forms.Label();
            this.musicFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.filesLB = new System.Windows.Forms.ListBox();
            this.regeneratePlaylistBTN = new System.Windows.Forms.Button();
            this.savePlaylistBTN = new System.Windows.Forms.Button();
            this.totalLengthLBL = new System.Windows.Forms.Label();
            this.playPlaylistBTN = new System.Windows.Forms.Button();
            this.durationPicker = new System.Windows.Forms.DateTimePicker();
            this.savePlaylistDialog = new System.Windows.Forms.SaveFileDialog();
            this.daysNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.shufflePlaylistBTN = new System.Windows.Forms.Button();
            this.includeSubfoldersCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.daysNUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFolderBTN
            // 
            this.openFolderBTN.Location = new System.Drawing.Point(145, 23);
            this.openFolderBTN.Name = "openFolderBTN";
            this.openFolderBTN.Size = new System.Drawing.Size(70, 23);
            this.openFolderBTN.TabIndex = 0;
            this.openFolderBTN.Text = "Open folder";
            this.openFolderBTN.UseVisualStyleBackColor = true;
            this.openFolderBTN.Click += new System.EventHandler(this.openFolderBTN_Click);
            // 
            // openFolderLBL
            // 
            this.openFolderLBL.AutoSize = true;
            this.openFolderLBL.Location = new System.Drawing.Point(145, 51);
            this.openFolderLBL.Name = "openFolderLBL";
            this.openFolderLBL.Size = new System.Drawing.Size(89, 13);
            this.openFolderLBL.TabIndex = 3;
            this.openFolderLBL.Text = "No folder opened";
            // 
            // musicFolderBrowserDialog
            // 
            this.musicFolderBrowserDialog.Description = "Select a folder with music files.";
            this.musicFolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // filesLB
            // 
            this.filesLB.FormattingEnabled = true;
            this.filesLB.Location = new System.Drawing.Point(6, 19);
            this.filesLB.Name = "filesLB";
            this.filesLB.Size = new System.Drawing.Size(340, 212);
            this.filesLB.TabIndex = 4;
            // 
            // regeneratePlaylistBTN
            // 
            this.regeneratePlaylistBTN.Location = new System.Drawing.Point(6, 250);
            this.regeneratePlaylistBTN.Name = "regeneratePlaylistBTN";
            this.regeneratePlaylistBTN.Size = new System.Drawing.Size(82, 23);
            this.regeneratePlaylistBTN.TabIndex = 5;
            this.regeneratePlaylistBTN.Text = "Regenerate";
            this.regeneratePlaylistBTN.UseVisualStyleBackColor = true;
            this.regeneratePlaylistBTN.Click += new System.EventHandler(this.generateBTN_Click);
            // 
            // savePlaylistBTN
            // 
            this.savePlaylistBTN.Location = new System.Drawing.Point(190, 250);
            this.savePlaylistBTN.Name = "savePlaylistBTN";
            this.savePlaylistBTN.Size = new System.Drawing.Size(75, 23);
            this.savePlaylistBTN.TabIndex = 6;
            this.savePlaylistBTN.Text = "Save playlist";
            this.savePlaylistBTN.UseVisualStyleBackColor = true;
            this.savePlaylistBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // totalLengthLBL
            // 
            this.totalLengthLBL.AutoSize = true;
            this.totalLengthLBL.Location = new System.Drawing.Point(6, 234);
            this.totalLengthLBL.Name = "totalLengthLBL";
            this.totalLengthLBL.Size = new System.Drawing.Size(112, 13);
            this.totalLengthLBL.TabIndex = 7;
            this.totalLengthLBL.Text = "Total playlist duration: ";
            // 
            // playPlaylistBTN
            // 
            this.playPlaylistBTN.Location = new System.Drawing.Point(271, 250);
            this.playPlaylistBTN.Name = "playPlaylistBTN";
            this.playPlaylistBTN.Size = new System.Drawing.Size(75, 23);
            this.playPlaylistBTN.TabIndex = 8;
            this.playPlaylistBTN.Text = "Play";
            this.playPlaylistBTN.UseVisualStyleBackColor = true;
            this.playPlaylistBTN.Click += new System.EventHandler(this.playPlaylistBTN_Click);
            // 
            // durationPicker
            // 
            this.durationPicker.CustomFormat = "HH:mm:ss";
            this.durationPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.durationPicker.Location = new System.Drawing.Point(55, 32);
            this.durationPicker.Name = "durationPicker";
            this.durationPicker.ShowUpDown = true;
            this.durationPicker.Size = new System.Drawing.Size(66, 20);
            this.durationPicker.TabIndex = 12;
            this.durationPicker.Value = new System.DateTime(2000, 1, 1, 1, 0, 0, 0);
            // 
            // savePlaylistDialog
            // 
            this.savePlaylistDialog.DefaultExt = "m3u";
            this.savePlaylistDialog.FileName = "Playlist";
            this.savePlaylistDialog.Filter = "Playlist files|*.m3u";
            // 
            // daysNUD
            // 
            this.daysNUD.Location = new System.Drawing.Point(9, 32);
            this.daysNUD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.daysNUD.Name = "daysNUD";
            this.daysNUD.Size = new System.Drawing.Size(40, 20);
            this.daysNUD.TabIndex = 14;
            this.daysNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "hh:mm:ss";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.daysNUD);
            this.groupBox1.Controls.Add(this.durationPicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 57);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desired duration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.shufflePlaylistBTN);
            this.groupBox2.Controls.Add(this.filesLB);
            this.groupBox2.Controls.Add(this.regeneratePlaylistBTN);
            this.groupBox2.Controls.Add(this.totalLengthLBL);
            this.groupBox2.Controls.Add(this.playPlaylistBTN);
            this.groupBox2.Controls.Add(this.savePlaylistBTN);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 280);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generated playlist";
            // 
            // shufflePlaylistBTN
            // 
            this.shufflePlaylistBTN.Location = new System.Drawing.Point(95, 250);
            this.shufflePlaylistBTN.Name = "shufflePlaylistBTN";
            this.shufflePlaylistBTN.Size = new System.Drawing.Size(75, 23);
            this.shufflePlaylistBTN.TabIndex = 9;
            this.shufflePlaylistBTN.Text = "Shuffle";
            this.shufflePlaylistBTN.UseVisualStyleBackColor = true;
            this.shufflePlaylistBTN.Click += new System.EventHandler(this.shufflePlaylistBTN_Click);
            // 
            // includeSubfoldersCB
            // 
            this.includeSubfoldersCB.AutoSize = true;
            this.includeSubfoldersCB.Location = new System.Drawing.Point(221, 27);
            this.includeSubfoldersCB.Name = "includeSubfoldersCB";
            this.includeSubfoldersCB.Size = new System.Drawing.Size(112, 17);
            this.includeSubfoldersCB.TabIndex = 19;
            this.includeSubfoldersCB.Text = "Include subfolders";
            this.includeSubfoldersCB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 395);
            this.Controls.Add(this.includeSubfoldersCB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.openFolderLBL);
            this.Controls.Add(this.openFolderBTN);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.daysNUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFolderBTN;
        private System.Windows.Forms.Label openFolderLBL;
        private System.Windows.Forms.FolderBrowserDialog musicFolderBrowserDialog;
        private System.Windows.Forms.ListBox filesLB;
        private System.Windows.Forms.Button regeneratePlaylistBTN;
        private System.Windows.Forms.Button savePlaylistBTN;
        private System.Windows.Forms.Label totalLengthLBL;
        private System.Windows.Forms.Button playPlaylistBTN;
        private System.Windows.Forms.DateTimePicker durationPicker;
        private System.Windows.Forms.SaveFileDialog savePlaylistDialog;
        private System.Windows.Forms.NumericUpDown daysNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button shufflePlaylistBTN;
        private System.Windows.Forms.CheckBox includeSubfoldersCB;
    }
}

