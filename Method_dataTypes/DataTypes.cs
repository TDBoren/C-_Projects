using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_dataTypes
{
    class DataTypes
    {
        // part 1
        public static int Math(int IntegerA)
        {
            return IntegerA + 100;
        }
        // part 3
        public static decimal Math(decimal DecimalD)
        {
            return (DecimalD / 10);
        }
        // part 5
        public static int Math(string StringS)
        {
            var IntegerS = Convert.ToInt32(StringS);
            IntegerS = IntegerS *10;
            return IntegerS;
        }
    }
}
