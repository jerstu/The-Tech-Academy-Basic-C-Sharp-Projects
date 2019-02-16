using System;

namespace insurance
{
    class Program
    {
        static void Main()
        {
            Console.Write("What is your age ? ");
            int age = Convert.ToByte(Console.ReadLine());
            Console.Write("\nHave you ever had a DUI (true or false)? ");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.Write("\nHow many speeding tickets do you have? ");
            int tickets = Convert.ToByte(Console.ReadLine());

            Console.Write("\nQualified? " + Convert.ToString((age > 15) && (dui == false) && (tickets <= 3)));
            Console.Read();
        }
    }
}
