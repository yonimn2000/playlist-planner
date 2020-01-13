using System;
using System.Windows.Forms;
using YonatanMankovich.PlaylistPlanner;

namespace YonatanMankovich.PlaylistPlannerUI
{
    public partial class MainForm : Form
    {
        private Planner PlaylistPlanner { get; set; }
        private Playlist Playlist { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void openFolderBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = musicFolderBrowserDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                LoadingForm loadingForm = new LoadingForm(musicFolderBrowserDialog.SelectedPath);
                DialogResult loadingFormDialogResult = loadingForm.ShowDialog(this);
                if (loadingFormDialogResult == DialogResult.OK)
                {
                    openFolderLBL.Text = "Current folder: " + musicFolderBrowserDialog.SelectedPath;
                    PlaylistPlanner = loadingForm.PlaylistPlanner;
                }
            }
        }

        private void recalculateBTN_Click(object sender, EventArgs e)
        {
            Playlist = PlaylistPlanner.GetPlaylistOfDuration(new TimeSpan(1, 0, 0, 0));
            foreach (MusicFile musicFile in Playlist.GetMusicFiles())
                filesLB.Items.Add(musicFile);
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            Playlist.Save("Playlist.m3u", true);
        }
    }
}