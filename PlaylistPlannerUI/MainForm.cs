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
                MusicLoadingForm loadingForm = new MusicLoadingForm(musicFolderBrowserDialog.SelectedPath, includeSubfoldersCB.Checked);
                DialogResult loadingFormDialogResult = loadingForm.ShowDialog(this);
                if (loadingFormDialogResult == DialogResult.OK)
                {
                    openFolderLBL.Text = "Current folder: " + musicFolderBrowserDialog.SelectedPath;
                    PlaylistPlanner = loadingForm.PlaylistPlanner;
                    regeneratePlaylistBTN.PerformClick();
                }
            }
        }

        private void generateBTN_Click(object sender, EventArgs e)
        {
            Playlist = PlaylistPlanner.GetPlaylistOfDuration(durationPicker.Value.TimeOfDay+TimeSpan.FromDays((double)daysNUD.Value));
            RefreshFilesLB();
            totalLengthLBL.Text = $"Total playlist duration: {Playlist.Duration} ({Playlist.GetSize()} songs)";
        }

        private void RefreshFilesLB()
        {
            filesLB.Items.Clear();
            foreach (MusicFile musicFile in Playlist.GetMusicFiles())
                filesLB.Items.Add(musicFile);
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            DialogResult saveResult = savePlaylistDialog.ShowDialog(this);
            if(saveResult == DialogResult.OK)
               Playlist.Save(savePlaylistDialog.FileName, true);
        }

        private void playPlaylistBTN_Click(object sender, EventArgs e)
        {
            Playlist.Play();
        }

        private void shufflePlaylistBTN_Click(object sender, EventArgs e)
        {
            Playlist.Shuffle();
            RefreshFilesLB();
        }
    }
}