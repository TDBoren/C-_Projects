using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalInteger
{
    class Program
    {
        static int AddMethod(int x, int y)
        {
            return x + y;
        }
        static int AddMethod(int x, int y, int z)
        {
            return x + y + z;
        }
        static public void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You can enter a second number now:\nNote: The second number does not have to be chosen.");
            var s = Console.ReadLine();
            if (s != "")
            {
                int z = Convert.ToInt32(s);
                Console.WriteLine(Optional.Add(y, z));
            }
            else
            {
                Console.WriteLine(Optional.Add(y));
            }

            Console.ReadLine();
        }
    }
}
