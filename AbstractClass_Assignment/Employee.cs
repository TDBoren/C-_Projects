using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Assignment
{
    public class Employee : Person
    {
        public override void SayName()
        {
            throw new NotImplementedException();
        }

        internal static void SayName(string firstName, string lastName)
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.ReadLine();
        }
    }
}
