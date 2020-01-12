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
            for (int i = 0; i < 50; i++)
            {
                Show(planner);
            }

            Console.ReadLine();
        }

        private static void Show(Planner planner)
        {
            Playlist playlist = planner.GetPlaylistOfDuration(1000);
            foreach (string file in playlist.GetFiles())
                Console.WriteLine(file);
            Console.WriteLine("Total duration: " + playlist.Duration);
        }

        static void ProgressReported(int i, int total)
        {
            Console.Title = i.ToString() + "/" + total.ToString() + " (" + Math.Round(100 * (double)i / total).ToString() + "%)";
        }
    }
}