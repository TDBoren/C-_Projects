using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek_Enum_Assignment
{

    enum DaysOfTheWeek {  Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day of the Week.");
            string UserDay = Console.ReadLine();

            try
            {
                DaysOfTheWeek dayValue = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), UserDay, true);
                if (Enum.IsDefined(typeof(DaysOfTheWeek), dayValue) | dayValue.ToString().Contains(","))
                    Console.WriteLine("You chose {0} .", UserDay, dayValue.ToString());
                    Console.ReadLine();

            }
            catch (ArgumentException)
            {
                Console.WriteLine("{0} is not a Day of the Week.", UserDay);
                Console.ReadLine();
            }
        }
    }
}
