using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate class
            TwoNums twoNums1 = new TwoNums(2, 4);
            
            // Call method using two numbers
            TwoNums.VMethod(3, 5);

            // Call method w/ parameters by name
            TwoNums.VMethod(Int1: 77, Int2: 30);

            // Call method passing TwoNums-instance twoNums
            TwoNums.VMethod(twoNums1.Num1, twoNums1.Num2);
            
        }
    }
}
