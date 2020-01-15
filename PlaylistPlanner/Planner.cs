using System;
using System.Collections.Generic;
using System.IO;

namespace YonatanMankovich.PlaylistPlanner
{
    public class Planner
    {
        public delegate void ReportProgress(int fileIndex, int totalFiles);
        public ReportProgress ReportProgressDelegate;

        private MusicFile[] MusicFiles { get; set; }
        private Random Random { get; set; } = new Random();
        private static readonly string[] musicFileExtensions = { "mp3", "ogg", "aac", "wma", "flac", "wav" };

        public void LoadMusicFilesFromDirectory(string directory, bool includeSubfolders)
        {
            List<string> files = new List<string>();
            foreach (string extension in musicFileExtensions)
                files.AddRange(Directory.GetFiles(directory, "*." + extension,
                    includeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
            MusicFiles = new MusicFile[files.Count];
            for (int i = 0; i < files.Count; i++)
            {
                MusicFiles[i] = new MusicFile(files[i]);
                ReportProgressDelegate?.Invoke(i + 1, files.Count);
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
            List<MusicFile> musicFilesList = new List<MusicFile>(MusicFiles);
            while (playlist.GetSize() < MusicFiles.Length && playlist.Duration < duration)
            {
                int randomIndex = Random.Next(musicFilesList.Count);
                playlist.AddMusicFile(musicFilesList[randomIndex]);
                musicFilesList.RemoveAt(randomIndex);
            }
            return playlist;
        }
    }
}