using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Sample";
            string lastName = "Student";
            Employee.SayName(firstName, lastName);
            IQuittable Iquit = new Employee();
            Iquit.Quit();
        }
    }
}
