using System;

namespace YonatanMankovich.PlaylistPlanner
{
    public class MediaDurationNotFoundException : Exception
    {
        public string PathToMedia { get; }

        public MediaDurationNotFoundException(string pathToMedia) :
            base($"Unable to determine the duration of the media file {pathToMedia}.")
        {
            PathToMedia = pathToMedia;
        }
    }

    public class UnforgivablePlaylistDurationException : Exception // LOL
    {
        public TimeSpan Duration { get; }
        public TimeSpan Forgiveness { get; }

        public UnforgivablePlaylistDurationException(TimeSpan duration, TimeSpan forgiveness) :
            base($"Unable to generate a playlist of {duration} duration with {forgiveness} forgiveness.")
        {
            Duration = duration;
            Forgiveness = forgiveness;
        }
    }

    public class PlaylistEmptyException : InvalidOperationException
    {
        public PlaylistEmptyException() : base("The playlist is empty.") { }
    }
}