using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11Part_Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment part 1

            string[] cars = new string[3];
            for (int counter = 0; counter < cars.Length; counter++)
            {
                Console.WriteLine("Please enter in the name of a car.");
                cars[counter] = Console.ReadLine();
            }
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadLine();
 
            
            
                
            // Assignment part 2 - 5
            // a-- creates the infinite loop
            // a < 50 changed to <= 50 for assignment progression
            for (int a = 0; a <= 50; a++)
            {
                Console.WriteLine("value : {0}", a);
            }
            Console.ReadLine();

            // Assignment part 6 - 8
            List<string> space = new List<string> { "planets", "stars", "comets", "shuttle" };
            for (int n = 0; n < space.Count; n++)
            {
                Console.WriteLine(space[n]);
            }
            Console.ReadLine();
            bool matches = false;
            while (!matches)
            {
                Console.WriteLine("Please choose an item from the list.");
                string userInput = Console.ReadLine();
 
                foreach (string n in space)
                {
                    if (userInput == n)
                    {
                        matches = true;   
                    }
                }
                if (matches)
                {
                    Console.WriteLine("You have chosen " + userInput);
                }
                else
                {
                    Console.WriteLine("You did not select an item from the list.");
                }
            }
            // Assignment part 9 -10
            List<string> gender = new List<string> { "m", "f", "m", "m", "m", "f", "f", "m", "m", "f", "n/a" }; 
            Console.WriteLine("Please choose either male or female by typing an m or f.");
            string choice = Console.ReadLine();

            for (int g = 0; g < gender.Count; g++)
            {
                if (choice == gender[g])
                {
                    Console.WriteLine(" You have chosen gender " + gender[g] + ".  That is located at index " + g);
                }
            }
            if (!gender.Contains(choice))
            {
                Console.WriteLine("You did not choose m or f.");
            }

            // Assignment part 11
            List<string> pets = new List<string>();
            List<string> duplicatePets = new List<string>();
            pets.Add("bird");
            pets.Add("horse");
            pets.Add("dog");
            pets.Add("cat");
            pets.Add("turtle");
            pets.Add("cat");
            pets.Add("horse");

            foreach (string p in pets)
            {
                Console.WriteLine(p);
            }
            foreach (string p in pets)
                if (duplicatePets.Contains(p))
                {
                    Console.WriteLine(p + " is already in the list");
                }
                else
                {
                    duplicatePets.Add(p);
                    Console.WriteLine(p + " is not a duplicate.");
                }
            Console.ReadLine();
        }
    }
}
