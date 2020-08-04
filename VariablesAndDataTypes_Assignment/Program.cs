using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine(course);

            Console.WriteLine("What page number are you on?");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);

            Console.WriteLine("Do you need help withy anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            Console.WriteLine(help);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine(experiences);

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine(feedback);

            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hours);

            Console.WriteLine("Thank you for your answers. \nAn instructor will respond to this shortly. \nHave a great day!");
            string thanks = Console.ReadLine();
            Console.WriteLine(thanks);
        }
    }
}
