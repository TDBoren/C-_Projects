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
            var mC = new ConstExample(11,12);
            ConstExample mC1 = new ConstExample(14);
            ConstExample mC2 = new ConstExample(15);
            ConstExample mC3 = new ConstExample(16, 17);
            Console.WriteLine("These are the variables " + ($"x = {mC.x}, y = {mC.y}") +"\nThese are the Constructors " + ($"C1 = {ConstExample.C1}, C2 = {ConstExample.C2}"));
            Console.WriteLine("These are the next variables: \n" + ($" x = {mC1.x}, y = {mC1.y}") + "\n" + ($" x = {mC2.x}, y = {mC2.y}") + "\n" + ($" x = {mC3.x}, y= {mC3.y}"));
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
