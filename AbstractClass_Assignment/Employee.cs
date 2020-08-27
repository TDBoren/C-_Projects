using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Assignment
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            throw new NotImplementedException();
        }

        public static void SayName(string firstName, string lastName)
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.ReadLine();
        }

        public void Quit()
        {
            Console.WriteLine("I quit!");
            Console.ReadLine();
        }
    }
}
