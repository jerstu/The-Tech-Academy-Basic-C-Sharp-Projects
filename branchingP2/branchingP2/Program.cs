using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branchingP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomTemperature = 70;

            Console.WriteLine("Hi, what is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temperature where you are? ");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exact room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (currentTemperature < roomTemperature)
            {
                Console.WriteLine("It is cooler than room temperature.");
            }
            else
            {
                Console.WriteLine("Uhhhh... something went wrong.");
            }
            Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum % 2 == 0 ? "Your favorite number is even!" : "Your favorite number is odd!";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
