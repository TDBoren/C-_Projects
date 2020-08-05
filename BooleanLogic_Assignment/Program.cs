using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Please type 'yes' or 'no'.");
            string DUI = Console.ReadLine();
            bool yes = DUI == "yes";

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            if (age > 15 && yes == false && tickets < 3)
            {
                Console.WriteLine("You are qualified for insurance!");
            }
            else
            {
                Console.WriteLine("You do not qualify for insurance.");
            }
            Console.ReadLine();
        }      
    }
}
