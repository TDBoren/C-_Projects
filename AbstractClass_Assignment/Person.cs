using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Assignment
{
    public abstract class Person
    {
        public List<String> firstName { get; set; }
        public List<String> lastName { get; set; }

        public abstract void SayName();
    }
}
