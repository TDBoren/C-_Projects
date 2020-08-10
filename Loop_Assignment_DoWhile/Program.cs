using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Assignment_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess what number I am thinking of?\n\nTake a guess!.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 51;

            do
            {
                switch (number)
                {
                    case 51:
                        Console.WriteLine("You guessed the number 51. Amazing, that is the number I was thinking of!!!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You did not guess the number I am thinking of.");
                        Console.WriteLine("\nTry again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);

            Console.Read();
        }
    }
}
