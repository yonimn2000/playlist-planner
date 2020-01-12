using System;
using System.Collections.Generic;

namespace YonatanMankovich.PlaylistPlanner
{
    public class Playlist
    {
        public TimeSpan Duration { get; private set; }
        private List<MusicFile> MusicFiles { get; set; } = new List<MusicFile>();

        public void AddMusicFile(MusicFile musicFile)
        {
            if (!MusicFiles.Contains(musicFile))
            {
                MusicFiles.Add(musicFile);
                Duration += musicFile.Duration;
            }
        }

        public void RemoveMusicFile(MusicFile musicFile)
        {
            if (MusicFiles.Contains(musicFile))
            {
                MusicFiles.Remove(musicFile);
                Duration -= musicFile.Duration;
            }
        }

        public int GetSize()
        {
            return MusicFiles.Count;
        }

        public IEnumerable<MusicFile> GetMusicFiles()
        {
            foreach (MusicFile musicFile in MusicFiles)
                yield return musicFile;
        }
    }
}