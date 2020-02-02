using System;
using System.ComponentModel;
using System.Windows.Forms;
using YonatanMankovich.PlaylistPlanner;

namespace YonatanMankovich.PlaylistPlannerUI
{
    public partial class MusicLoadingForm : Form
    {
        public Planner PlaylistPlanner { get; } = new Planner();
        public string Path { get; set; }

        public MusicLoadingForm(string selectedPath)
        {
            InitializeComponent();
            Path = selectedPath;
            progressLBL.Text = $"Loading files...";
            musicLoadBW.RunWorkerAsync();
        }

        private void musicLoadBW_DoWork(object sender, DoWorkEventArgs e)
        {
            PlaylistPlanner.ReportProgressDelegate += (currentIndex, totalFiles) =>
            {
                musicLoadBW.ReportProgress((int)Math.Round(100 * (double)currentIndex / totalFiles));
                if (IsHandleCreated)
                    progressLBL.Invoke(new MethodInvoker(() =>
                    { progressLBL.Text = $"Loading file {currentIndex} out of {totalFiles}"; }));
            };
            string[] unknownDurationFiles = PlaylistPlanner.AddMusicFilesFromDirectory(Path);
            if (unknownDurationFiles.Length > 0)
                Invoke(new MethodInvoker(() =>
                {
                    MessageBox.Show($"Unable to determine the duration of the following " +
                        $"{unknownDurationFiles.Length} media file{(unknownDurationFiles.Length == 1 ? "" : "s")}:\n\n" +
                        string.Join("\n\n", unknownDurationFiles), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }));
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