using System;

namespace Uc3CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg=Console.ReadLine();
            Console.WriteLine("Custom Exception");
            MoodAnalyser mood = new MoodAnalyser(msg);
        }
    }
}
