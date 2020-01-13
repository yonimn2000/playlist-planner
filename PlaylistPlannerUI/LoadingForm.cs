using System;
using System.ComponentModel;
using System.Windows.Forms;
using YonatanMankovich.PlaylistPlanner;

namespace YonatanMankovich.PlaylistPlannerUI
{
    public partial class LoadingForm : Form
    {
        public Planner PlaylistPlanner { get; } = new Planner();

        public LoadingForm(string selectedPath)
        {
            InitializeComponent();
            progressLBL.Text = $"Loading files...";
            musicLoadBW.RunWorkerAsync(selectedPath);
        }

        private void musicLoadBW_DoWork(object sender, DoWorkEventArgs e)
        {
            PlaylistPlanner.ReportProgressDelegate += (currentIndex, totalFiles) =>
            {
                musicLoadBW.ReportProgress((int)Math.Round(100 * (double)currentIndex / totalFiles));
                progressLBL.Invoke(new MethodInvoker(() 
                    => { progressLBL.Text = $"Loading file {currentIndex} out of {totalFiles}"; }));
            };
            PlaylistPlanner.LoadMusicFiles((string)e.Argument);
        }

        private void musicLoadBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadPB.Value = e.ProgressPercentage;
        }

        private void musicLoadBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}