using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeMethods
{
    public class Overload
    {
        public Overload()
        {
            PassInt = 1;
            PassDec = 1.0m;
            PassString = "1";
        }
        public int PassInt { get; set; }
        public decimal PassDec { get; set; }
        public string PassString { get; set; }

        public static int Method(int TakeInt)
        {
            TakeInt = TakeInt + 3456;
            return TakeInt;
        }

        public static decimal Method(decimal TakeDec)
        {
            TakeDec = TakeDec + 55.55m;
            return TakeDec;
        }

        public static int Method(string TakeString)
        {
            int StringNum = Convert.ToInt32(TakeString);
            StringNum = StringNum * 40;
            return StringNum;
        }

    }
}
