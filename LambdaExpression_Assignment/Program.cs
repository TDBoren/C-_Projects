﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_Assignment
{
    class Program
    {
    
    static void Main(string[] args)
        {
        // Create a list of Employees
        var Employees = new List<Employee>();
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
        var Repeat = from e in Employees
            where e.EmployeeFirstName == "Joe"
            select e;
        foreach (var RepeatEmployees in Repeat)
            {
                Console.WriteLine(RepeatEmployees.EmployeeId + " " + RepeatEmployees.EmployeeFirstName + " " + RepeatEmployees.EmployeeLastName);
            }
            foreach (Employee employee in Employees.FindAll(j => j.EmployeeFirstName == "Joe"))
            {
                Console.WriteLine(employee.EmployeeId + " " + employee.EmployeeFirstName + " " + employee.EmployeeLastName);

            }
            foreach (Employee employee in Employees.FindAll(g => g.EmployeeId > 5))
            {
                Console.WriteLine(employee.EmployeeId + " " + employee.EmployeeFirstName + " " + employee.EmployeeLastName);
            }
            Console.ReadLine();
        }
    }
}
