using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "My name is Troy. ";
            string learning = "I am learning about strings";
            string program = " using the C# program.";

            Console.WriteLine(name + learning + program);
            Console.ReadLine();

            string uppercase = "Troy Boren";
            uppercase = uppercase.ToUpper();
            Console.WriteLine(uppercase);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Troy.");
            sb.Append("My birthday is next month.");
            sb.Append("I will graduate next month.");
            sb.Append("I am using this to put a bunch of sentences together.");
            sb.Append("This is for a StringBuilder exercise.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
