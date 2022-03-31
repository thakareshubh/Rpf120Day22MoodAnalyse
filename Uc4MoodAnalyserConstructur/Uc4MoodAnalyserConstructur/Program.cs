using System;

namespace Uc4MoodAnalyserConstructur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg=Console.ReadLine();
            Console.WriteLine("Mood analyser constructor");
            MoodAnalyser mood = new MoodAnalyser(msg);
        }
    }
}
