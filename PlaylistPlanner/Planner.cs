using System;
using System.IO;
using System.Linq;

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

        public Playlist GetPlaylistOfDuration(TimeSpan duration, uint tries = 1000) // TODO: forgiveness lol
        {
            return GetPlaylistOfDuration(duration, new TimeSpan(0, 0, 1), tries);
        }

        public Playlist GetPlaylistOfDuration(TimeSpan duration, TimeSpan forgiveness, uint tries = 1000) // TODO: forgiveness lol
        {
            Playlist[] playlists = new Playlist[tries];
            for (int i = 0; i < tries; i++)
            {
                playlists[i] = GetPlaylistOfApproximateDuration(duration);
                if (playlists[i].Duration <= forgiveness)
                    return playlists[i];
            }
            playlists = playlists.OrderBy(playlist => playlist.Duration).ToArray();
            return playlists[0];
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