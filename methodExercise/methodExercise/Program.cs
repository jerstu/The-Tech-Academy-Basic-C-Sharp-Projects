using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an integer: ");
            int userInt = Convert.ToInt32(Console.ReadLine());

            // create an instance of mathOperand class
            mathOperand squareFactor = new mathOperand();
            // Assign userInt to Operand property
            squareFactor.Operand = userInt;
            // pass class instance to method and assign return to variable
            int squareResult = mathOperand.Square(squareFactor);
            // display result
            Console.WriteLine(userInt + " squared = " + squareResult);

            mathOperand cubeFactor = new mathOperand();
            cubeFactor.Operand = userInt;
            int cubeResult = mathOperand.Cube(cubeFactor);
            Console.WriteLine(userInt + " cubed = " + cubeResult);

            mathOperand add1000 =  new mathOperand();
            add1000.Operand = userInt;
            int add1000Result = mathOperand.AddThousand(add1000);
            Console.WriteLine(userInt + " + 1000 = " + add1000Result);


            Console.ReadLine();




            



        }

        
    }
}
