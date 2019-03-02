using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Overload OL1 = new Overload();
            OL1.PassInt = 25;
            OL1.PassInt = Overload.Method(TakeInt: OL1.PassInt);
            Console.WriteLine("Integer: " + OL1.PassInt);

            Overload OL2 = new Overload();
            OL2.PassDec = 333.333m;
            OL2.PassDec = Overload.Method(TakeDec: OL2.PassDec);
            Console.WriteLine("Decimal: " + OL2.PassDec);

            Overload OL3 = new Overload();
            OL3.PassString = "123";
            Console.WriteLine("String: " + Overload.Method(TakeString: OL3.PassString));

            Console.ReadLine();
        }
    }
}
