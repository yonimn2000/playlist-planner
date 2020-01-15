using System;

namespace YonatanMankovich.PlaylistPlanner
{
	public class MediaDurationNotFoundException : Exception
	{
		public MediaDurationNotFoundException() : base("Unable to determine the media duration.") { }
		public MediaDurationNotFoundException(string pathToMedia) : base($"Unable to determine the duration of the media file {pathToMedia}.") { }
	}

	public class UnforgivablePlaylistDurationException : Exception // LOL
	{
		public UnforgivablePlaylistDurationException() : base("Unable to generate a playlist of the desired duration with the provided forgiveness.") { }
		public UnforgivablePlaylistDurationException(TimeSpan duration, TimeSpan forgiveness) :
			base($"Unable to generate a playlist of {duration} duration with {forgiveness} forgiveness.") { }
	}
}