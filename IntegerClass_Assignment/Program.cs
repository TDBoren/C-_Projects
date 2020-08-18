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
            int Integer1 = Convert.ToInt32(Console.ReadLine());
            Integer Multiply = new Integer();
            Multiply.Multiply = Integer1 * 10;
            Integer Add = new Integer();
            Add.Add = Integer1 + 100;
            Integer Divide = new Integer();
            Divide.Divide = Integer1 / 50;
            Integer Subtract = new Integer();
            Subtract.Subtract = Integer1 - 5;
            Console.WriteLine(Multiply.Multiply);
            Console.WriteLine(Add.Add);
            Console.WriteLine(Divide.Divide);
            Console.WriteLine(Subtract.Subtract);
            Console.ReadLine();
        }
    }
}
