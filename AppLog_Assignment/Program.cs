using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace AppLog_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string UserNumber = Console.ReadLine();
            File.WriteAllText("E:\\C#_Projects\\AppLog_Assignment\\log.txt", UserNumber);
            File.ReadAllText("E:\\C#_Projects\\AppLog_Assignment\\log.txt");
            StreamReader sr = new StreamReader("E:\\C#_Projects\\AppLog_Assignment\\log.txt");
            string line = sr.ReadLine();
            Console.WriteLine(line);
            Console.ReadLine();
        }
    }
}
