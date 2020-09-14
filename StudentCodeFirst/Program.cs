using System;
using System.Data.Entity;

namespace StudentCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Bill" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
            Console.WriteLine("Student Added.");
            Console.ReadLine();
        }
    }
}
