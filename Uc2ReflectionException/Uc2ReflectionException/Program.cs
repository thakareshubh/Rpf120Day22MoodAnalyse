using System;

namespace Uc2ReflectionException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string massage=Console.ReadLine();
            Console.WriteLine("Reflection Exception");
            MoodAnalyser mood = new MoodAnalyser(massage);
            mood.AnalyserMood();
        }
    }
}
