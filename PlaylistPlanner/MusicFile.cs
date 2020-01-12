namespace YonatanMankovich.PlaylistPlanner
{
    public class MusicFile
    {
        public uint Duration { get; }
        public string Path { get; }

        public MusicFile(string path)
        {
            Path = path;
            Duration = (uint)System.TimeSpan.FromTicks((long)(ulong)Microsoft.WindowsAPICodePack.Shell.
                ShellObject.FromParsingName(Path).Properties.System.Media.Duration.ValueAsObject).TotalSeconds;
        }

        public override string ToString()
        {
            return System.IO.Path.GetFileNameWithoutExtension(Path);
        }
    }
}