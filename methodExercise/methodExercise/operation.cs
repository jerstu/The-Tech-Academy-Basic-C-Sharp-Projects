using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise
{
    class mathOperand
    {
        public mathOperand()
        {
            Operand = 1;
        }
        public int Operand { get; set; }
        

        public static int Square(mathOperand factor)
        {
            int square = factor.Operand * factor.Operand;
            


            return square;
        }

        public static int Cube(mathOperand factor)
        {
            int cube = factor.Operand * factor.Operand * factor.Operand;
            return cube;
        }

        public static int AddThousand(mathOperand operand) 
        {
            int result = operand.Operand + 1000;
            return result;
        }

       
    }

}
