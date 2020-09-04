using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVariable_Assignment
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Dog(string name)
            : this(name, 3)
        {
            Console.WriteLine("This dog's name is " + Name + " and he is {0} years old. ", Age);
            Console.ReadLine();
        }
    }
}
