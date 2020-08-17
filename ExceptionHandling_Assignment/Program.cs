using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 5, 20, 10, 200, 5000, 600, 2300 };

            for (int n = 0; n < numArray.Length; n++)
            {
                Console.WriteLine(numArray[n]);
            }
            Console.WriteLine("Please type in a number to divide by.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            for (int n = 0; n < numArray.Length; n++)
            {
                var divide = numArray[n] / userNumber;
                Console.WriteLine("Your answers are " + divide);
            }
            try
            {
                int[] numArray2 = { 5, 20, 10, 200, 5000, 600, 2300 };

                for (int n = 0; n < numArray2.Length; n++)
                {
                    Console.WriteLine(numArray2[n]);
                }
                Console.WriteLine("Please type in a number to divide by.");
                int userNumber2 = Convert.ToInt32(Console.ReadLine());

                for (int n = 0; n < numArray2.Length; n++)
                {
                    var divide = numArray2[n] / userNumber2;
                    Console.WriteLine("Your answers are " + divide);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by a zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
               Console.ReadLine();
            }
            Console.WriteLine("You have reached the end of the program.");
            Console.ReadLine();
        }
    }
}
