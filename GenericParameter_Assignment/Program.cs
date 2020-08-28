using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameter_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee<int> Age = new Employee<int>();
            Age.AddNode(21);
            Age.AddNode(46);
            Age.AddNode(36);
            Age.AddNode(67);
            Age.AddNode(55);

            Age.ProcessAllNodes();

            Employee<string> Name = new Employee<string>();
            Name.AddNode("Lory");
            Name.AddNode("Julia");
            Name.AddNode("Lerman");
            Name.AddNode("James");

            Name.ProcessAllNodes();
            Console.ReadLine();
        }
    }
}
