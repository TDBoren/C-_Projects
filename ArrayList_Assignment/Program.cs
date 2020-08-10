using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] names = { "Jesse", "Troy", "Michael", "Michelle", "Gary", "Sarah" };

                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine("Enter {0} to select {1}", i, names[i]);
                }

                string choice = Console.ReadLine();
                int j = int.Parse(choice);
                Console.WriteLine("You have selected {0} which is {1}", j, names[j]);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please only select a number from the list for your name selection.\nThanks.");
                Console.ReadKey();
            }

            try
            {
                int[] numArray = { 5, 2, 10, 200, 5000, 600, 2300 };

                for (int n = 0; n < numArray.Length; n++)
                {
                    Console.WriteLine("Enter {0} to select {1}", n, numArray[n]);
                }

                string numberChoice = Console.ReadLine();
                int c = int.Parse(numberChoice);
                Console.WriteLine("You have selected {0} which is {1}", c, numArray[c]);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please only select a number from the left to get your number selection.\nThanks.");
                Console.ReadKey();
            }

            try
            {
                List<string> intList = new List<string>();
                intList.Add("a bird");
                intList.Add("a horse");
                intList.Add("a dog");
                intList.Add("a rabbit");
                intList.Add("a turtle");
                intList.Add("a cat");

                for (int n = 0; n < intList.Count; n++)
                {
                    Console.WriteLine("Enter {0} to select {1}", n, intList[n]);
                }

                string numberChoice = Console.ReadLine();
                int c = int.Parse(numberChoice);
                Console.WriteLine("You have selected {1} for your pet.\nThank you.", c, intList[c]);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please only select a number from the left to get your pet.\nThanks.");
                Console.ReadKey();
            }
        }
    }
}
