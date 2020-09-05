using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static ErrorHandling_Assignment.Exceptions;

namespace ErrorHandling_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge == 0)
                {
                    throw new ZeroException();
                }
                if (userAge < 0)
                {
                    throw new NegativeException();
                }
                DateTime year = DateTime.Now;
                DateTime yearOnly = year.AddYears(-userAge);
                int yearBorn = yearOnly.Year;
                Console.WriteLine("You were born in the year: " + yearBorn);
                Console.ReadLine();
            }
            catch (ZeroException)
            {
                Console.WriteLine("A person cannot be 0 years old!");
                Console.ReadLine();
                return;
            }
            catch (NegativeException)
            {
                Console.WriteLine("How can you be less than zero years old?");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Can an age be anything but a number?");
                Console.ReadLine();
                return;
            }
        }
    }
}
