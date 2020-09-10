using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVariable_Assignment
{
    class ConstExample
    {
        public int x;
        public int y;
        public const int C1 = 5;
        public const int C2 = C1 + 5;

        public ConstExample(int p1 =0) : this(p1, 100)
        {
        }
        public ConstExample(int p1, int p2 = 10)
        {
            this.x = p1;
            this.y = p2;
        }
    }
}
