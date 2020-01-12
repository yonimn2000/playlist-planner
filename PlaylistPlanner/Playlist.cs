using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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

        public void Save(string path, bool isRelative)
        {
            StringBuilder sb = new StringBuilder();
            foreach (MusicFile musicFile in MusicFiles)
                sb.AppendLine(isRelative ? Path.GetFileName(musicFile.Path) : musicFile.Path);
            File.WriteAllText(path, sb.ToString());
        }
    }
}