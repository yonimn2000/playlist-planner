using System;
using System.Collections.Generic;
using System.IO;

namespace YonatanMankovich.PlaylistPlanner
{
    public class Planner
    {
        public List<MusicFile> MusicFiles { get; set; } = new List<MusicFile>();

        public void ReadDirectory(string directory)
        {
            foreach (string file in Directory.EnumerateFiles(directory, "*.mp3")) // TODO: Add more file extensions.
                MusicFiles.Add(new MusicFile(file));
        }

        public IEnumerable<MusicFile> GetFiles()
        {
            foreach (MusicFile musicFile in MusicFiles)
                yield return musicFile;
        }
    }
}