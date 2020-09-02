using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current time is: " + currentTime);
            Console.ReadLine();
            Console.WriteLine("Please enter a number: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The time it will be with the number you added is: " + currentTime.AddHours(userNumber));
            Console.ReadLine();
        }
    }
}
