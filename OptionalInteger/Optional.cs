using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalInteger
{
    class Optional
    {
        public static int Add(int IntegerA, int IntegerB = 100)
        {
            return IntegerA + IntegerB;
        }
    }
}
