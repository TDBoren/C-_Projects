using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_Assignment
{
    class Program
    {
    
    static void Main(string[] args)
        {
        // Create a list of Employees
        List<Employee> Employees = new List<Employee>();
            {
                // Add Employees to the list.
                Employees.Add(new Employee() { EmployeeFirstName = "Sarah", EmployeeLastName = "McConner", EmployeeId = 1 });
                Employees.Add(new Employee() { EmployeeFirstName = "Ron", EmployeeLastName = "McDonald", EmployeeId = 2 });
                Employees.Add(new Employee() { EmployeeFirstName = "Owen", EmployeeLastName = "Wilson", EmployeeId = 3 });
                Employees.Add(new Employee() { EmployeeFirstName = "Katy", EmployeeLastName = "Perry", EmployeeId = 4 });
                Employees.Add(new Employee() { EmployeeFirstName = "Joe", EmployeeLastName = "Wilson", EmployeeId = 5 });
                Employees.Add(new Employee() { EmployeeFirstName = "Nelson", EmployeeLastName = "Manderra", EmployeeId = 6 });
                Employees.Add(new Employee() { EmployeeFirstName = "Joe", EmployeeLastName = "Harvey", EmployeeId = 7 });
                Employees.Add(new Employee() { EmployeeFirstName = "Ron", EmployeeLastName = "Morgan", EmployeeId = 8 });
                Employees.Add(new Employee() { EmployeeFirstName = "Ray", EmployeeLastName = "Burgens", EmployeeId = 9 });
                Employees.Add(new Employee() { EmployeeFirstName = "Nicole", EmployeeLastName = "Kidman", EmployeeId = 10 });
            };

        foreach (var employee in Employees)
            {
                Console.WriteLine(employee.EmployeeId +" " + employee.EmployeeFirstName + " " + employee.EmployeeLastName);
            }
            List<Employee> JoeEmployees = new List<Employee>(Employees.FindAll("Joe"));
        foreach (var employee in Employees)
        {
                if (Employees.Contains("Joe"))
                {
                    JoeEmployees.Add();
                    Console.WriteLine(JoeEmployees.EmployeeId + " " + JoeEmployees.EmployeeFirstName + " " + JoeEmployees.EmployeeLastName);
                }
        }
            List<Employee> newEmployeeList = Employees.Where(fn => fn.EmployeeFirstName == "Joe").ToList();
            {
                foreach (var employee in newEmployeeList)
                {
                    Console.WriteLine(employee.EmployeeId + " " + employee.EmployeeFirstName + " " + employee.EmployeeLastName);
                }
            }
            List<Employee> newEmployeeList1 = Employees.Where(g => g.EmployeeId > 5).ToList();
            {
                foreach (var employee1 in newEmployeeList1)
                {
                    Console.WriteLine(employee1.EmployeeId + " " + employee1.EmployeeFirstName + " " + employee1.EmployeeLastName);
                }
            }
            Console.ReadLine();
        }
    }
}
