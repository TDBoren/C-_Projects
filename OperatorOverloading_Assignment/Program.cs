using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees Employee1 = new Employees();
            Employees Employee2 = new Employees();
            Employee1.ID = 1;
            Employee2.ID = 2;
            Employee1.EmployeeComparison();
            Console.WriteLine(Employee1.ID == Employee2.ID); //Calls == operator
            Console.WriteLine(Employee1.ID != Employee2.ID); //Calls != operator
            Console.ReadLine();
        }
    }
}
