using System;

namespace YonatanMankovich.PlaylistPlanner
{
    public class MusicFile
    {
        public TimeSpan Duration { get; }
        public string Path { get; }

        public MusicFile(string path)
        {
            Path = path;
            Duration = GetMediaTimespan();
        }

        private TimeSpan GetMediaTimespan()
        {
            return TimeSpan.FromTicks((long)(ulong)Microsoft.WindowsAPICodePack.Shell.
                            ShellObject.FromParsingName(Path).Properties.System.Media.Duration.ValueAsObject);
        }

        public override string ToString()
        {
            return System.IO.Path.GetFileNameWithoutExtension(Path);
        }
    }
}