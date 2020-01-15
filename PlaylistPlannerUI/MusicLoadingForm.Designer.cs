namespace YonatanMankovich.PlaylistPlannerUI
{
    partial class MusicLoadingForm
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
            this.loadPB = new System.Windows.Forms.ProgressBar();
            this.progressLBL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.musicLoadBW = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // loadPB
            // 
            this.loadPB.Location = new System.Drawing.Point(12, 29);
            this.loadPB.Name = "loadPB";
            this.loadPB.Size = new System.Drawing.Size(142, 23);
            this.loadPB.TabIndex = 3;
            // 
            // progressLBL
            // 
            this.progressLBL.AutoSize = true;
            this.progressLBL.Location = new System.Drawing.Point(12, 9);
            this.progressLBL.Name = "progressLBL";
            this.progressLBL.Size = new System.Drawing.Size(111, 13);
            this.progressLBL.TabIndex = 4;
            this.progressLBL.Text = "Loading file X out of X";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // musicLoadBW
            // 
            this.musicLoadBW.WorkerReportsProgress = true;
            this.musicLoadBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.musicLoadBW_DoWork);
            this.musicLoadBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.musicLoadBW_ProgressChanged);
            this.musicLoadBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.musicLoadBW_RunWorkerCompleted);
            // 
            // MusicLoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 92);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressLBL);
            this.Controls.Add(this.loadPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MusicLoadingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Please wait...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar loadPB;
        private System.Windows.Forms.Label progressLBL;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker musicLoadBW;
    }
}