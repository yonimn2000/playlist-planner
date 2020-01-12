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
            Playlist playlist = planner.GetPlaylistOfDuration(30*60);
            foreach (string file in playlist.GetFiles())
                Console.WriteLine(file);
            Console.WriteLine("Total duration: " + playlist.Duration);
            Console.ReadLine();
        }

        static void ProgressReported(int i, int total)
        {
            Console.Title = i.ToString() + "/" + total.ToString() + " (" + Math.Round(100 * (double)i / total).ToString() + "%)";
        }
    }
}