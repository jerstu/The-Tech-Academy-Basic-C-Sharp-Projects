using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursFromNow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a number: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In {0} hours it will be {1}.", hours, DateTime.Now.AddHours(hours).ToShortTimeString());
            Console.Read();
        }
    }
}
