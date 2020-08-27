using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading_Assignment
{
    class Employees
    {
        public int ID { get; set; }

        //public Constructor if int is passed
        public void EmployeeComparison()
        {
            Console.WriteLine("Are these the same employee? ");
            Console.ReadLine();
        }
        public static bool operator ==(Employees x, Employees y)
        {
            Console.WriteLine("Overloading == with Employees, Employees");
            return x.ID == y.ID;
        }

        //OverLoading != operator
        public static bool operator !=(Employees x, Employees y)
        {
            Console.WriteLine("Overloading != with Employees, Employees");
            return x.ID != y.ID;
        }
    }
}
