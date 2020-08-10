using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Assignment_While
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Can you guess what number I am thinking of?\n\nTake a guess!.");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isGuessed = number == 51;

        while (!isGuessed)
        {
            switch (number)
            {
                case 51:
                    Console.WriteLine("You guessed the number 51. amazing, that is the number I was thinking of!!!");
                    isGuessed = true;
                    break;
                default:
                    Console.WriteLine("You did not guess the number I am thinking of.");
                    Console.WriteLine("\nTry again.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;

            }
        }
        Console.Read();
        }
    }
}

