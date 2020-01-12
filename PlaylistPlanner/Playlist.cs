using System.Collections.Generic;

namespace YonatanMankovich.PlaylistPlanner
{
    public class Playlist
    {
        public uint Duration { get; private set; } = 0;
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

        public int GetCount()
        {
            return MusicFiles.Count;
        }

        public IEnumerable<string> GetFiles()
        {
            foreach (MusicFile musicFile in MusicFiles)
                yield return musicFile.Path;
        }
    }
}