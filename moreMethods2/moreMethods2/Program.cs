using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreMethods2
{
    class Program
    {
        static void Main(string[] args)
        {

            Llama Fuzzy = new Llama("Fuzzy");

            Console.WriteLine("Feed {0} a number: ", Fuzzy.Name );
            Fuzzy.Number = (Convert.ToInt32(Console.ReadLine()));
            Fuzzy.Spit();

            Fuzzy.Humm(out int number1, out int number2);
            Console.WriteLine("{0} {1}", number1, number2);
            Console.ReadLine();

            Fuzzy.Humm(out string myString1, out string myString2);
            Console.WriteLine(myString1 + " " + myString2);
            Console.ReadLine();

        }
    }
}
