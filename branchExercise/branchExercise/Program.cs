using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
            Console.Write("What is the package weight? ");
            float weight = Convert.ToSingle(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.Write("What is the package width? ");
                float width = Convert.ToSingle(Console.ReadLine());
                Console.Write("What is the package height? ");
                float height = Convert.ToSingle(Console.ReadLine());
                Console.Write("What is the package length? ");
                float length = Convert.ToSingle(Console.ReadLine());

                float dimensions = width + height + length;

                if (dimensions > 50)
                { 
                    Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                }
                else
                {
                    decimal quote = Convert.ToDecimal((dimensions * weight) / 100);

                    //Console.WriteLine("\nYour estimated total for shipping this package is: $" + quote +
                    //    "\n\nThank you for using Package Express.");
                    // It bothered me that this didn't always display like currency should.
                    // Took 5 minutes to Google and fix. I'm sure I'll be glad to know.

                    Console.WriteLine("\nYour estimated total for shipping this package is: " + 
                        quote.ToString("C", System.Globalization.CultureInfo.CurrentCulture) +
                        "\n\nThank you for using Package Express.");
                }
            }
            Console.ReadLine();
        }
    }
}
