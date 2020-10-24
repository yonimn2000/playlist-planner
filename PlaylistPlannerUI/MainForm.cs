using System;
using System.Windows.Forms;
using YonatanMankovich.PlaylistPlanner;

namespace YonatanMankovich.PlaylistPlannerUI
{
    public partial class MainForm : Form
    {
        private Planner PlaylistPlanner { get; set; }
        private Playlist Playlist { get; set; }

        public MainForm(string[] args)
        {
            InitializeComponent();
            if (args.Length >= 2) // arg1 = folder path; arg2 = play until DateTime; arg3 = seconds offset
            {
                Show();
                LoadFilesIntoPlanner(args[0]);
                TimeSpan duration = DateTime.Parse(args[1]) - DateTime.Now;
                if (args.Length >= 3)
                    duration += TimeSpan.FromSeconds(int.Parse(args[2]));
                daysNUD.Value = duration.Days;
                durationPicker.Value = new DateTime(2000, 1, 1, duration.Hours, duration.Minutes, duration.Seconds);
                regeneratePlaylistBTN.PerformClick();
                playPlaylistBTN.PerformClick();
            }
        }

        private void openFolderLLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = musicFolderBrowserDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                LoadFilesIntoPlanner(musicFolderBrowserDialog.SelectedPath);
                regeneratePlaylistBTN.PerformClick();
            }
        }

        private void LoadFilesIntoPlanner(string path)
        {
            MusicLoadingForm loadingForm = new MusicLoadingForm(path);
            DialogResult loadingFormDialogResult = loadingForm.ShowDialog(this);
            if (loadingFormDialogResult == DialogResult.OK)
            {
                playlistGB.Enabled = true;
                openFolderLLBL.Text = path;
                PlaylistPlanner = loadingForm.PlaylistPlanner;
                filesInfoLBL.Text = $"{PlaylistPlanner.CountOfLoadedFiles} files | Min: " +
                    RoundTimeSpanToSeconds(PlaylistPlanner.MinimumPlaylistDuration) +
                    $" | Max: " + RoundTimeSpanToSeconds(PlaylistPlanner.MaximumPlaylistDuration);
            }
        }

        private void generateBTN_Click(object sender, EventArgs e)
        {
            PerformLongActionForPlaylistGB(() =>
            {
                Playlist = PlaylistPlanner.GetClosestPlaylistOfDuration(durationPicker.Value.TimeOfDay + TimeSpan.FromDays((double)daysNUD.Value));
                RefreshFilesLB();
                totalLengthLBL.Text = $"Total playlist duration: " +
                $"{RoundTimeSpanToSeconds(Playlist.Duration)} ({Playlist.Size} songs)";
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