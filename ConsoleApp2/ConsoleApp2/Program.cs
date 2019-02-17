using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = true || false;
            Console.WriteLine(test);

            if (true && ((true || false) || true) && ((false && false) || (true && true)))
            {
                Console.WriteLine("Wow that was confusing.");
            }
            Console.Read();
        }
    }
}
