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
            this.recalculateBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFolderBTN
            // 
            this.openFolderBTN.Location = new System.Drawing.Point(12, 12);
            this.openFolderBTN.Name = "openFolderBTN";
            this.openFolderBTN.Size = new System.Drawing.Size(75, 23);
            this.openFolderBTN.TabIndex = 0;
            this.openFolderBTN.Text = "Open folder";
            this.openFolderBTN.UseVisualStyleBackColor = true;
            this.openFolderBTN.Click += new System.EventHandler(this.openFolderBTN_Click);
            // 
            // openFolderLBL
            // 
            this.openFolderLBL.AutoSize = true;
            this.openFolderLBL.Location = new System.Drawing.Point(93, 17);
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
            this.filesLB.Location = new System.Drawing.Point(12, 41);
            this.filesLB.Name = "filesLB";
            this.filesLB.Size = new System.Drawing.Size(352, 95);
            this.filesLB.TabIndex = 4;
            // 
            // recalculateBTN
            // 
            this.recalculateBTN.Location = new System.Drawing.Point(13, 143);
            this.recalculateBTN.Name = "recalculateBTN";
            this.recalculateBTN.Size = new System.Drawing.Size(351, 23);
            this.recalculateBTN.TabIndex = 5;
            this.recalculateBTN.Text = "Recalculate";
            this.recalculateBTN.UseVisualStyleBackColor = true;
            this.recalculateBTN.Click += new System.EventHandler(this.recalculateBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(70, 211);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(75, 23);
            this.saveBTN.TabIndex = 6;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.recalculateBTN);
            this.Controls.Add(this.filesLB);
            this.Controls.Add(this.openFolderLBL);
            this.Controls.Add(this.openFolderBTN);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFolderBTN;
        private System.Windows.Forms.Label openFolderLBL;
        private System.Windows.Forms.FolderBrowserDialog musicFolderBrowserDialog;
        private System.Windows.Forms.ListBox filesLB;
        private System.Windows.Forms.Button recalculateBTN;
        private System.Windows.Forms.Button saveBTN;
    }
}

