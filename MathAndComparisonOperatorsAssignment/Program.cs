using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiplication
            double multiply;
            double resultOfMultiplication;

            Console.WriteLine("Please enter a number:");
            multiply = Convert.ToInt64(Console.ReadLine());
            resultOfMultiplication = multiply * 50;

            Console.WriteLine(resultOfMultiplication);
            Console.ReadLine();

            //Addition
            int add;
            int resultOfAddition;

            Console.WriteLine("Please enter a number:");
            add = Convert.ToInt32(Console.ReadLine());
            resultOfAddition = add + 25;

            Console.WriteLine(resultOfAddition);
            Console.ReadLine();

            //Division
            decimal divide;
            decimal resultOfDivision;
            
            Console.WriteLine("Please enter a number:");
            divide = Convert.ToDecimal(Console.ReadLine());
            resultOfDivision = divide / 12.5m;

            Console.WriteLine(resultOfDivision);
            Console.ReadLine();

            //Greater Than
            int userInput;
            int comparator = 50;
            
            Console.WriteLine("Please enter a number:");  
            userInput = Convert.ToInt32(Console.ReadLine());
            bool isGreater = userInput > comparator;

            Console.WriteLine(isGreater);
            Console.ReadLine();

            //Remainder
            int userInput1;
            int remainder;

            Console.WriteLine("Please enter a number:");
            userInput1 = Convert.ToInt32(Console.ReadLine());
            remainder = userInput1 % 7;

            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}
