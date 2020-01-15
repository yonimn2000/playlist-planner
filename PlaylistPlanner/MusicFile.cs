using System;

namespace YonatanMankovich.PlaylistPlanner
{
    public class MusicFile
    {
        public string Path { get; }
        public TimeSpan Duration { get; }

        public MusicFile(string path, TimeSpan duration)
        {
            Path = path;
            Duration = duration;
        }

        public static TimeSpan GetDuration(string path)
        {
            object duration = Microsoft.WindowsAPICodePack.Shell.
                            ShellObject.FromParsingName(path).Properties.System.Media.Duration.ValueAsObject;
            if (duration == null)
                throw new MediaDurationNotFoundException(path);
            return TimeSpan.FromTicks((long)(ulong)duration);
        }

        public override string ToString()
        {
            return System.IO.Path.GetFileNameWithoutExtension(Path);
        }
    }
}