using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            Console.WriteLine("Anonymous Income Comparison Program.");
            Console.ReadLine();

            //Get person1
            Console.WriteLine("\n\nPlease enter the name of Person 1:");
            string person1 = Console.ReadLine();
            Console.WriteLine("Person 1 is: "+ person1);

            //Get Hours Worked for person1
            Console.WriteLine("\nPlease enter how many hours " + person1 + " worked:");
            decimal hours1 = Convert.ToDecimal(Console.ReadLine());
            Console.ReadLine();

            //Get Rate of person1
            Console.WriteLine("\nPlease enter the pay rate of: " + person1);
            decimal rate1 = Convert.ToDecimal(Console.ReadLine());
            Console.ReadLine();

            //Annual Salary of person1
            Console.WriteLine("\nThe annual salary of " + person1 + " is: ");
            decimal salary1 = Convert.ToDecimal(hours1 * rate1 * 52);
            Console.WriteLine(salary1);
            Console.ReadLine();

            //Get person2
            Console.WriteLine("\n\nPlease enter the name of Person 2:");
            string person2 = Console.ReadLine();
            Console.WriteLine("\nPerson 2 is: " + person2);
            Console.ReadLine();

            //Get Hours Worked for person2
            Console.WriteLine("\nPlease enter how many hours " + person2 + " worked:");
            decimal hours2 = Convert.ToDecimal(Console.ReadLine());
            Console.ReadLine();

            //Get Rate of person2
            Console.WriteLine("\nPlease enter the pay rate of: " + person2);
            decimal rate2 = Convert.ToDecimal(Console.ReadLine());
            Console.ReadLine();

            //Annual Salary of person2
            Console.WriteLine("\nThe annual salary of " + person2 + " is: ");
            decimal salary2 = Convert.ToDecimal(hours2 * rate2 * 52);
            Console.WriteLine(salary2);
            Console.ReadLine();

            //Compare Salaries
            Console.WriteLine("\n\nDoes " + person1 + " make more money than " + person2 + "?");
            bool compare = salary1 > salary2;
            Console.WriteLine(compare);
            Console.ReadLine();
        }
    }
}
