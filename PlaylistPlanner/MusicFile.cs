using Microsoft.WindowsAPICodePack.Shell;
using System;

namespace YonatanMankovich.PlaylistPlanner
{
    public class MusicFile
    {
        public uint Duration { get; }
        public string Path { get; }

        public MusicFile(string path)
        {
            Path = path;
            Duration = (uint)TimeSpan.FromTicks((long)(ulong)ShellObject.FromParsingName(Path).Properties.System.Media.Duration.ValueAsObject).TotalSeconds;
        }

        public override string ToString()
        {
            return System.IO.Path.GetFileNameWithoutExtension(Path);
        }
    }
}