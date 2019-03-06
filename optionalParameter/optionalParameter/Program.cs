using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPClass OP1 = new OPClass() { };

            Console.Write("First Number: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Number (optional): ");
            try
            {
                var Num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result: " + OPClass.OPMethod(Num1, Num2));
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Result: " + OPClass.OPMethod(Num1));
                Console.ReadLine();
            }

           

          

        }
    }
}
