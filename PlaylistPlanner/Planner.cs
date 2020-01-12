using System;
using System.IO;

namespace YonatanMankovich.PlaylistPlanner
{
    public class Planner
    {
        public delegate void ReportProgress(int fileIndex, int totalFiles);
        public ReportProgress ReportProgressDelegate;

        private MusicFile[] MusicFiles { get; set; }
        private Random Random { get; set; } = new Random();

        public void LoadMusicFiles(string directory)
        {
            string[] files = Directory.GetFiles(directory, "*.mp3"); // TODO: Add more file extensions.
            MusicFiles = new MusicFile[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                MusicFiles[i] = new MusicFile(files[i]);
                ReportProgressDelegate?.Invoke(i + 1, files.Length);
            }
        }

        public Playlist GetPlaylistOfDuration(TimeSpan duration, TimeSpan forgiveness = default, uint tries = 1000)
        {
            TimeSpan maxDuration = duration + forgiveness;
            Playlist[] playlists = new Playlist[tries];
            int shortestPlaylistIndex = 0;
            for (int i = 0; i < tries; i++)
            {
                playlists[i] = GetPlaylistOfApproximateDuration(duration);
                if (playlists[i].Duration <= maxDuration)
                    return playlists[i];
                if (playlists[i].Duration < playlists[shortestPlaylistIndex].Duration)
                    shortestPlaylistIndex = i;
            }
            return playlists[shortestPlaylistIndex];
        }

        private Playlist GetPlaylistOfApproximateDuration(TimeSpan duration)
        {
            Playlist playlist = new Playlist();
            while (playlist.GetSize() < MusicFiles.Length && playlist.Duration < duration)
                playlist.AddMusicFile(GetRandomMusicFile());
            return playlist;
        }

        private MusicFile GetRandomMusicFile()
        {
            return MusicFiles[Random.Next(MusicFiles.Length)];
        }
    }
}