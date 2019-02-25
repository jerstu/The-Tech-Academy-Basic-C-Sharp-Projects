using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int> { 1, 3, 4, 22, 33, 55, 75, 101, 240, 6000 };
                Console.Write("Divide by: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                foreach (int integer in intList)
                {
                    Console.WriteLine(integer + " / " + divisor + " = " + integer / divisor + " carry " + integer%divisor);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please type a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            Console.WriteLine("Program has continued to execute.");
            Console.ReadLine();
        }
    }
}
