using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "Jeremy", "Stewart");
            Employee emp2 = new Employee(1, "Jeremy", "Stuart");
            Employee emp3 = new Employee(2, "Pepe", "Le Pew");            

            Console.WriteLine("Are {0} {1} and {2} {3} the same person? " + (emp1 == emp2), emp1.FirstName, emp1.LastName, emp2.FirstName, emp2.LastName);
            Console.ReadLine();

            Console.WriteLine("Are {0} {1} and {2} {3} the different people? " + (emp1 != emp3), emp1.FirstName, emp1.LastName, emp3.FirstName, emp3.LastName);
            Console.ReadLine();

            Console.WriteLine("Are {0} {1} and {2} {3} the same person? " + (emp1 == emp3), emp1.FirstName, emp1.LastName, emp3.FirstName, emp3.LastName);
            Console.ReadLine();
        }
    }
}
