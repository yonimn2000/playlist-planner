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

        private void openFolderLLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = musicFolderBrowserDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                MusicLoadingForm loadingForm = new MusicLoadingForm(musicFolderBrowserDialog.SelectedPath, includeSubfoldersCB.Checked);
                DialogResult loadingFormDialogResult = loadingForm.ShowDialog(this);
                if (loadingFormDialogResult == DialogResult.OK)
                {
                    playlistGB.Enabled = true;
                    openFolderLLBL.Text = musicFolderBrowserDialog.SelectedPath;
                    PlaylistPlanner = loadingForm.PlaylistPlanner;
                    regeneratePlaylistBTN.PerformClick();
                    playlistGB.Text = "Generated playlist | Min duration: " +
                        RoundTimeSpanToSeconds(PlaylistPlanner.MinimumPlaylistDuration) +
                        $" | Max duration: " + RoundTimeSpanToSeconds(PlaylistPlanner.MaximumPlaylistDuration);
                }
            }
        }

        private void generateBTN_Click(object sender, EventArgs e)
        {
            PerformLongActionForPlaylistGB(() =>
            {
                Playlist = PlaylistPlanner.GetClosestPlaylistOfDuration(durationPicker.Value.TimeOfDay + TimeSpan.FromDays((double)daysNUD.Value));
                RefreshFilesLB();
                totalLengthLBL.Text = $"Total playlist duration: " +
                    $"{RoundTimeSpanToSeconds(Playlist.Duration)} ({Playlist.GetSize()} songs)";
                filesGB.Text = $"Files ({PlaylistPlanner.GetCountOfLoadedFiles()} loaded)";
            });
        }

        private TimeSpan RoundTimeSpanToSeconds(TimeSpan timeSpan)
        {
            return TimeSpan.FromSeconds(Math.Round(timeSpan.TotalSeconds));
        }

        private void PerformLongActionForPlaylistGB(Action action)
        {
            playlistGB.Enabled = false;
            playlistGB.Cursor = Cursors.WaitCursor;
            action();
            playlistGB.Cursor = Cursors.Default;
            playlistGB.Enabled = true;
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
            if (saveResult == DialogResult.OK)
                PerformLongActionForPlaylistGB(() => { Playlist.Save(savePlaylistDialog.FileName, true); });
        }

        private void playPlaylistBTN_Click(object sender, EventArgs e)
        {
            Playlist.Play();
        }

        private void shufflePlaylistBTN_Click(object sender, EventArgs e)
        {
            PerformLongActionForPlaylistGB(() =>
            {
                Playlist.Shuffle();
                RefreshFilesLB();
            });
        }
    }
}