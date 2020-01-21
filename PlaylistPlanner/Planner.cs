using System;
using System.Collections.Generic;
using System.IO;

namespace YonatanMankovich.PlaylistPlanner
{
    public class Planner
    {
        public delegate void ReportProgress(int fileIndex, int totalFiles);

        /// <summary>
        /// Reports progress when loading multiple files.
        /// </summary>
        public ReportProgress ReportProgressDelegate;

        /// <summary>
        /// Gets the maximum possible playlist duration with the currently loaded files.
        /// </summary>
        public TimeSpan MaximumPlaylistDuration { get; private set; }

        /// <summary>
        /// Gets the minimum possible playlist duration with the currently loaded files.
        /// </summary>
        public TimeSpan MinimumPlaylistDuration { get; private set; } = TimeSpan.MaxValue;

        private List<MusicFile> MusicFiles { get; set; } = new List<MusicFile>();
        private Random Random { get; set; } = new Random();
        private static readonly string[] musicFileExtensions = { "mp3", "ogg", "aac", "wma", "flac", "wav" };

        /// <summary>
        /// Adds music files from the specified directory and returns a list of files with unknown durations.
        /// Invokes the ReportProgress delegate.
        /// </summary>
        /// <param name="directory">A path to a folder with music files.</param>
        /// <param name="includeSubfolders">Specifies whether the program should include subfolders with music files.</param>
        public string[] AddMusicFilesFromDirectory(string directory, bool includeSubfolders)
        {
            List<string> files = new List<string>();
            foreach (string extension in musicFileExtensions)
                files.AddRange(Directory.GetFiles(directory, "*." + extension,
                    includeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
            return AddMusicFiles(files);
        }

        /// <summary>
        /// Adds music files from the specified collection of file paths and returns a list of files with unknown durations.
        /// Invokes the ReportProgress delegate.
        /// </summary>
        /// <param name="files">A collection of music file paths.</param>
        private string[] AddMusicFiles(ICollection<string> files)
        {
            List<string> unknownDurationFiles = new List<string>();
            int currentFile = 1;
            System.Threading.Tasks.Parallel.ForEach(files, (file) =>
            {
                try
                {
                    AddMusicFile(file);
                }
                catch (MediaDurationNotFoundException e)
                {
                    unknownDurationFiles.Add(e.PathToMedia);
                }
                catch (Exception e)
                {
                    throw e;
                }
                ReportProgressDelegate?.Invoke(currentFile++, files.Count);
            });
            return unknownDurationFiles.ToArray();
        }

        /// <summary>
        /// Adds a music file from the specified path.
        /// Invokes the ReportProgress delegate.
        /// </summary>
        /// <param name="file">A path to a music file.</param>
        public void AddMusicFile(string file)
        {
            TimeSpan duration = MusicFile.GetDuration(file);
            MusicFiles.Add(new MusicFile(file, duration));
            MaximumPlaylistDuration += duration;
            if (duration < MinimumPlaylistDuration)
                MinimumPlaylistDuration = duration;
        }

        /// <summary>
        /// Creates a playlist of a duration as close to the desired one as possible.
        /// </summary>
        /// <param name="duration">The desired duration of the playlist.</param>
        /// <param name="tries">The number of tries the program should make. A higher number means greater accuracy.</param>
        public Playlist GetClosestPlaylistOfDuration(TimeSpan duration, uint tries = 1000)
        {
            Playlist[] playlists = new Playlist[tries];
            int closestPlaylistIndex = 0; // The closest to the wanted duration.
            for (int i = 0; i < tries; i++)
            {
                playlists[i] = GetPlaylistOfApproximateDuration(duration, TimeSpan.FromSeconds(1));
                if (Math.Abs((playlists[i].Duration - duration).Ticks)
                    < Math.Abs((playlists[closestPlaylistIndex].Duration - duration).Ticks))
                    closestPlaylistIndex = i;
            }
            return playlists[closestPlaylistIndex];
        }

        /// <summary>
        /// Creates a playlist of a desired duration or throws an <see cref="UnforgivablePlaylistDurationException"/>.
        /// </summary>
        /// <param name="duration">The desired duration of the playlist.</param>
        /// <param name="forgiveness">The accepted error of ± the <paramref name="duration"/>.</param>
        /// <param name="tries">The number of tries the program should make before giving up.</param>
        /// <returns></returns>
        public Playlist GetPlaylistOfDuration(TimeSpan duration, TimeSpan forgiveness, uint tries = 1000)
        {
            if (IsPlaylistOfDurationPossible(duration, forgiveness))
            {
                Playlist[] playlists = new Playlist[tries];
                for (int i = 0; i < tries; i++)
                {
                    playlists[i] = GetPlaylistOfApproximateDuration(duration, forgiveness);
                    if (IsTimeSpanWithinRange(playlists[i].Duration, duration, forgiveness))
                        return playlists[i];
                }
            }
            throw new UnforgivablePlaylistDurationException(duration, forgiveness);
        }

        private Playlist GetPlaylistOfApproximateDuration(TimeSpan duration, TimeSpan forgiveness = default)
        {
            Playlist playlist = new Playlist();
            List<MusicFile> musicFilesList = new List<MusicFile>(MusicFiles);
            while (musicFilesList.Count > 0
                && playlist.Duration < duration + forgiveness
                && !IsTimeSpanWithinRange(playlist.Duration, duration, forgiveness))
            {
                int randomIndex = Random.Next(musicFilesList.Count);
                playlist.AddMusicFile(musicFilesList[randomIndex]);
                musicFilesList.RemoveAt(randomIndex);
            }
            return playlist;
        }

        /// <summary>
        /// Determines if the <paramref name="duration"/> and <paramref name="forgiveness"/>
        /// are within minimum and maximum possible playlist durations.
        /// </summary>
        public bool IsPlaylistOfDurationPossible(TimeSpan duration, TimeSpan forgiveness = default)
        {
            return (duration - forgiveness > MinimumPlaylistDuration && duration + forgiveness < MaximumPlaylistDuration)
                || IsTimeSpanWithinRange(MinimumPlaylistDuration, duration, forgiveness)
                || IsTimeSpanWithinRange(MaximumPlaylistDuration, duration, forgiveness);
        }

        private bool IsTimeSpanWithinRange(TimeSpan timeSpan, TimeSpan rangeBase, TimeSpan range)
        {
            return rangeBase - range <= timeSpan && timeSpan <= rangeBase + range;
        }

        public int GetCountOfLoadedFiles()
        {
            return MusicFiles.Count;
        }
    }
}