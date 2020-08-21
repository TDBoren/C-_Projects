using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerClass_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please choose a number to do some math on.");
            int IntegerM = Convert.ToInt32(Console.ReadLine());
        
            int resultA = MathOperations.Add(IntegerM);
            Console.WriteLine(resultA);
            Console.ReadLine();

            int resultS = MathOperations.Subtract(IntegerM);
            Console.WriteLine(resultS);
            Console.ReadLine();

            int resultM = MathOperations.Multiply(IntegerM);
            Console.WriteLine(resultM);
            Console.ReadLine();

            int resultD = MathOperations.Divide(IntegerM);
            Console.WriteLine(resultD);
            Console.ReadLine();
        }
    }
}
