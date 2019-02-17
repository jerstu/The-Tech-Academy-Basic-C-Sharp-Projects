using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branchingP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current Temperature: ");
            int currentTemp = Convert.ToInt32(Console.ReadLine());
            int roomTemp = 70;



            string comparisonResult = currentTemp == roomTemp ? "It is room temp." : "It is not room temp.";
            Console.WriteLine(comparisonResult);
            Console.ReadLine();

            if (currentTemp == roomTemp)
            {
                Console.WriteLine("It is exactly room temperature!");
            }
            else if (currentTemp > roomTemp)
            {
                Console.WriteLine("It is warmer than room temp!");
            }
            else if (currentTemp < roomTemp)
            {
                Console.WriteLine("It is cooler that room temp!");
            }
            else
            {
                Console.WriteLine("It is not room temperature!");
            };
            Console.ReadLine();
        }
    }
}
