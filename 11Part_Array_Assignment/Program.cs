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
            Console.WriteLine("Please choose an item from the list.");
            string userInput = Console.ReadLine();
            foreach (string n in space)
            {
                if (userInput == n)
                {
                    Console.WriteLine("You have chosen " + userInput);
                }
                else 
                {
                    if (userInput != n)
                    {
                        Console.WriteLine("You did not select an item from the list.");
                    }    
                }
            }
            
            List<string> pets = new List<string>();
            pets.Add("a bird");
            pets.Add("a horse");
            pets.Add("a dog");
            pets.Add("a cat");
            pets.Add("a turtle");
            pets.Add("a cat");

            for (int n = 0; n < pets.Count; n++)
            {
                Console.WriteLine("Enter {0} to select {1}", n, pets[n]);
            }
            string numberChoice = Console.ReadLine();
            int c = int.Parse(numberChoice);
            Console.WriteLine("You have selected {1} for your pet.\nThank you.", c, pets[c]);
            Console.ReadLine();


            Console.ReadLine();
        }
    }
}
