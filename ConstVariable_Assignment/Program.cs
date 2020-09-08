using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVariable_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var mC = new ConstExample(11, 22);
            Console.WriteLine("These are the variables " + ($"x = {mC.x}, y = {mC.y}") +"\nThese are the Constructors " + ($"C1 = {ConstExample.C1}, C2 = {ConstExample.C2}"));
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
