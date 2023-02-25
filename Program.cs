using System;

namespace MoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MoodAnalyser Programm");
            string message=Console.ReadLine();
            MoodAnalyzer mood = new MoodAnalyzer();
            Console.WriteLine(mood.moodAnalyzer(message));
            Console.ReadLine();
        }
    }
}
