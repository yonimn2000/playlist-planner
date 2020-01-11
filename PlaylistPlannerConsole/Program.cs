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
            planner.ReadDirectory(dir);
            Console.Clear();
            foreach (MusicFile musicFile in planner.GetFiles())
                Console.WriteLine(musicFile + "\t" + musicFile.Duration);
            Console.ReadLine();
        }
    }
}