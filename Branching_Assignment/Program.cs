using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \n\nPlease enter the package weight");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. \nHave a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width.");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height.");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length.");
                int length = Convert.ToInt32(Console.ReadLine());

                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express. \nHave a good day.");
                }
                else
                {
                    int quote = (((width * height * length) * weight) / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C", CultureInfo.CurrentCulture) + "\nThank you.");
                }
            }
            Console.ReadLine();
        }
    }
}
