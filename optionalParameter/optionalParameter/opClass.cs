using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalParameter
{
    public class OPClass
    {
        public OPClass()
        {
            Num1 = 1;
            Num2 = 2;
        }
        public int Num1 { set; get; }
        public int Num2 { set; get; }

        public static int OPMethod(int Int1, int Int2 = 2)
        {
            return Int1 * Int2;            
        }



    }

    
}
