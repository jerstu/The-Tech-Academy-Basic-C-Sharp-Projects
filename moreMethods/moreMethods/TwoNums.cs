using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreMethods
{
    class TwoNums
    {
        public TwoNums(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public static void VMethod(int Int1, int Int2)
        {
            Int1++;
            // Console.WriteLine(Int1);
            Console.WriteLine(Int2);
            Console.ReadLine();
        }

    }
}
