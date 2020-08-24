using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int Integer1 = 400;
            int Integer2 = 1000;
            int Integer3 = Void_Method.VoidMethod(Integer1, Integer2);
            Console.WriteLine("This in an integer " + Integer3);
            Console.ReadLine();
        }
    }
}
