﻿namespace YonatanMankovich.PlaylistPlannerUI
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
            this.durationGB = new System.Windows.Forms.GroupBox();
            this.playlistGB = new System.Windows.Forms.GroupBox();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.shufflePlaylistBTN = new System.Windows.Forms.Button();
            this.filesGB = new System.Windows.Forms.GroupBox();
            this.openFolderLLBL = new System.Windows.Forms.LinkLabel();
            this.filesInfoLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.daysNUD)).BeginInit();
            this.durationGB.SuspendLayout();
            this.playlistGB.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.filesGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // musicFolderBrowserDialog
            // 
            this.musicFolderBrowserDialog.Description = "Select a folder with music files.";
            this.musicFolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // filesLB
            // 
            this.filesLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesLB.FormattingEnabled = true;
            this.filesLB.Location = new System.Drawing.Point(6, 19);
            this.filesLB.Name = "filesLB";
            this.filesLB.Size = new System.Drawing.Size(349, 199);
            this.filesLB.TabIndex = 4;
            // 
            // regeneratePlaylistBTN
            // 
            this.regeneratePlaylistBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regeneratePlaylistBTN.Location = new System.Drawing.Point(3, 3);
            this.regeneratePlaylistBTN.Name = "regeneratePlaylistBTN";
            this.regeneratePlaylistBTN.Size = new System.Drawing.Size(81, 24);
            this.regeneratePlaylistBTN.TabIndex = 5;
            this.regeneratePlaylistBTN.Text = "Regenerate";
            this.regeneratePlaylistBTN.UseVisualStyleBackColor = true;
            this.regeneratePlaylistBTN.Click += new System.EventHandler(this.generateBTN_Click);
            // 
            // savePlaylistBTN
            // 
            this.savePlaylistBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savePlaylistBTN.Location = new System.Drawing.Point(177, 3);
            this.savePlaylistBTN.Name = "savePlaylistBTN";
            this.savePlaylistBTN.Size = new System.Drawing.Size(81, 24);
            this.savePlaylistBTN.TabIndex = 6;
            this.savePlaylistBTN.Text = "Save";
            this.savePlaylistBTN.UseVisualStyleBackColor = true;
            this.savePlaylistBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // totalLengthLBL
            // 
            this.totalLengthLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalLengthLBL.AutoSize = true;
            this.totalLengthLBL.Location = new System.Drawing.Point(5, 224);
            this.totalLengthLBL.Name = "totalLengthLBL";
            this.totalLengthLBL.Size = new System.Drawing.Size(112, 13);
            this.totalLengthLBL.TabIndex = 7;
            this.totalLengthLBL.Text = "Total playlist duration: ";
            // 
            // playPlaylistBTN
            // 
            this.playPlaylistBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playPlaylistBTN.Location = new System.Drawing.Point(264, 3);
            this.playPlaylistBTN.Name = "playPlaylistBTN";
            this.playPlaylistBTN.Size = new System.Drawing.Size(82, 24);
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
            // durationGB
            // 
            this.durationGB.Controls.Add(this.label4);
            this.durationGB.Controls.Add(this.label3);
            this.durationGB.Controls.Add(this.daysNUD);
            this.durationGB.Controls.Add(this.durationPicker);
            this.durationGB.Location = new System.Drawing.Point(12, 12);
            this.durationGB.Name = "durationGB";
            this.durationGB.Size = new System.Drawing.Size(127, 57);
            this.durationGB.TabIndex = 17;
            this.durationGB.TabStop = false;
            this.durationGB.Text = "Desired duration";
            // 
            // playlistGB
            // 
            this.playlistGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playlistGB.Controls.Add(this.buttonsPanel);
            this.playlistGB.Controls.Add(this.filesLB);
            this.playlistGB.Controls.Add(this.totalLengthLBL);
            this.playlistGB.Enabled = false;
            this.playlistGB.Location = new System.Drawing.Point(12, 75);
            this.playlistGB.Name = "playlistGB";
            this.playlistGB.Size = new System.Drawing.Size(361, 277);
            this.playlistGB.TabIndex = 18;
            this.playlistGB.TabStop = false;
            this.playlistGB.Text = "Generated playlist";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsPanel.ColumnCount = 4;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.Controls.Add(this.regeneratePlaylistBTN, 0, 0);
            this.buttonsPanel.Controls.Add(this.shufflePlaylistBTN, 1, 0);
            this.buttonsPanel.Controls.Add(this.savePlaylistBTN, 2, 0);
            this.buttonsPanel.Controls.Add(this.playPlaylistBTN, 3, 0);
            this.buttonsPanel.Location = new System.Drawing.Point(6, 240);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.RowCount = 1;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsPanel.Size = new System.Drawing.Size(349, 30);
            this.buttonsPanel.TabIndex = 21;
            // 
            // shufflePlaylistBTN
            // 
            this.shufflePlaylistBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shufflePlaylistBTN.Location = new System.Drawing.Point(90, 3);
            this.shufflePlaylistBTN.Name = "shufflePlaylistBTN";
            this.shufflePlaylistBTN.Size = new System.Drawing.Size(81, 24);
            this.shufflePlaylistBTN.TabIndex = 9;
            this.shufflePlaylistBTN.Text = "Shuffle";
            this.shufflePlaylistBTN.UseVisualStyleBackColor = true;
            this.shufflePlaylistBTN.Click += new System.EventHandler(this.shufflePlaylistBTN_Click);
            // 
            // filesGB
            // 
            this.filesGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesGB.Controls.Add(this.filesInfoLBL);
            this.filesGB.Controls.Add(this.openFolderLLBL);
            this.filesGB.Location = new System.Drawing.Point(145, 12);
            this.filesGB.Name = "filesGB";
            this.filesGB.Size = new System.Drawing.Size(228, 57);
            this.filesGB.TabIndex = 20;
            this.filesGB.TabStop = false;
            this.filesGB.Text = "Files";
            // 
            // openFolderLLBL
            // 
            this.openFolderLLBL.AutoSize = true;
            this.openFolderLLBL.Location = new System.Drawing.Point(6, 16);
            this.openFolderLLBL.Name = "openFolderLLBL";
            this.openFolderLLBL.Size = new System.Drawing.Size(62, 13);
            this.openFolderLLBL.TabIndex = 20;
            this.openFolderLLBL.TabStop = true;
            this.openFolderLLBL.Text = "Open folder";
            this.openFolderLLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openFolderLLBL_LinkClicked);
            // 
            // filesInfoLBL
            // 
            this.filesInfoLBL.AutoSize = true;
            this.filesInfoLBL.Location = new System.Drawing.Point(7, 33);
            this.filesInfoLBL.Name = "filesInfoLBL";
            this.filesInfoLBL.Size = new System.Drawing.Size(77, 13);
            this.filesInfoLBL.TabIndex = 21;
            this.filesInfoLBL.Text = "No files loaded";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.filesGB);
            this.Controls.Add(this.playlistGB);
            this.Controls.Add(this.durationGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "MainForm";
            this.Text = "Playlist Planner";
            ((System.ComponentModel.ISupportInitialize)(this.daysNUD)).EndInit();
            this.durationGB.ResumeLayout(false);
            this.durationGB.PerformLayout();
            this.playlistGB.ResumeLayout(false);
            this.playlistGB.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.filesGB.ResumeLayout(false);
            this.filesGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.GroupBox durationGB;
        private System.Windows.Forms.GroupBox playlistGB;
        private System.Windows.Forms.Button shufflePlaylistBTN;
        private System.Windows.Forms.GroupBox filesGB;
        private System.Windows.Forms.LinkLabel openFolderLLBL;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;
        private System.Windows.Forms.Label filesInfoLBL;
    }
}

