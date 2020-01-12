using System;
using YonatanMankovich.PlaylistPlanner;

namespace PlaylistPlannerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading files...");
            string dir = @"C:\Users\Jonathan\OneDrive\Music";
            Planner planner = new Planner();
            planner.ReportProgressDelegate += ProgressReported;
            planner.LoadMusicFiles(dir);
            Console.Clear();

            while (true)
            {
                Playlist playlist = planner.GetPlaylistOfDuration(new TimeSpan(1, 0, 0, 0));
                foreach (MusicFile musicFile in playlist.GetMusicFiles())
                    Console.WriteLine(musicFile.Duration + "\t" + musicFile);
                Console.WriteLine("Total playlist duration: " + playlist.Duration);
                playlist.Save("Playlist.m3u", true);
                Console.ReadLine();
            }
        }

        static void ProgressReported(int i, int total)
        {
            Console.Title = "Loading files: " + i.ToString() + "/" + total.ToString()
                + " (" + Math.Round(100 * (double)i / total).ToString() + "%)";
        }
    }
}