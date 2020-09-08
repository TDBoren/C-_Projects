using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name.");
            string date = DateTime.Today.ToShortDateString();
            string userName = Console.ReadLine();
            string msg = $"\nWelcome back {userName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"E:\C#_Projects\Scores\StudentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double totalScore = 0.0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach (string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                totalScore += score;
            }

            double avgScore = totalScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score " + avgScore);

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
