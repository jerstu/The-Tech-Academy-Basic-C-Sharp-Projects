using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee<string> jeremy = new Employee<string>("Jeremy", "Stewart", new List<string> { "phone", "wallet", "keys" });
            Employee<int> pepe = new Employee<int>("Pepe", "Le Pew", new List<int> { 1, 2, 4, 7, 90, 1104 });

            jeremy.ListThings();
            pepe.ListThings();
            Console.ReadLine();
        }
    }
}
