using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(num1 + " x 50 = " + (num1 * 50));

            Console.Write("\nEnter another number: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(num2 + " + 25 = " + (num2 + 25));

            Console.Write("\nEnter another number: ");
            decimal num3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(num3 + " " + (char)247 + " 12.5 = " + (num3 / 12.5m));

            Console.Write("\nEnter another number: ");
            decimal num4 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Is " + num4 + " > 50? " + (num4 > 50));

            Console.Write("\nEnter another number: ");
            decimal num5 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("The remainder of " + num5 + " " + (char)247 + " 7 is " + (num5 % 7));
  
            Console.Read();
        }
    }
}
