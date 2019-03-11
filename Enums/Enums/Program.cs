using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Enter the current day of the week:");
            
            for (int t = 1; t < 3 ;t++)
            {
                try
                {
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
                    if ((int)day == (int)DateTime.Now.DayOfWeek)
                    {
                        Console.WriteLine("Yes, today is {0}!", day);
                    }
                    else
                    {
                        Console.WriteLine("No, it's not {0}!", day);
                    }
                    
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an actual day of the week: ");
                }
            }
            Console.ReadLine();
            
        }

        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
