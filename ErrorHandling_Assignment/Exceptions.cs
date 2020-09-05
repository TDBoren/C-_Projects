using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling_Assignment
{
    public class Exceptions
    {
        public class ZeroException : Exception
        {
            public ZeroException()
                : base() { }
            public ZeroException(string message)
                : base(message) { }
        }
        public class NegativeException : Exception
        {
            public NegativeException()
                : base() { }
            public NegativeException(string message)
                : base(message) { }
        }
    }
}
