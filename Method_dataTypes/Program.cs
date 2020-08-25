using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's see some different value types. Hit enter to start.");
            Console.ReadLine();

            int IntegerA = 400;
            decimal DecimalD = 10000.1010101010m;
            string StringS = "4000";

            // part 2
            int resultA = DataTypes.Math(IntegerA);
            Console.WriteLine("This in an integer " + resultA);
            Console.ReadLine();

            // part 4
            decimal resultS = DataTypes.Math(DecimalD);
            int IntegerD = Convert.ToInt32(resultS);
            Console.WriteLine("This is a decimal converted to an integer " + IntegerD);
            Console.ReadLine();

            // part 6
            int resultM = DataTypes.Math(StringS);
            Console.WriteLine(resultM);
            Console.ReadLine();
        }
    }
}
