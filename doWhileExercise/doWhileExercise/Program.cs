using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string mycolor = "start";

            Console.Write("Guess my favorite color: ");
            mycolor = Console.ReadLine();

            while (mycolor != "orange")
            {
                Console.Write("Wrong! Try again: ");
                mycolor = Console.ReadLine();
            }
            Console.WriteLine("Yeah, orange IS the best color!");

            Console.Write("Guess my second favorite: ");

            do
            {
                mycolor = Console.ReadLine();
                switch (mycolor)
                {
                    case "orange" : Console.Write("Orange is my favorite! You must have a short memory.\nTry again: ");
                        break;
                    case "green": Console.Write("I like green too, but not as much as orange and... ");
                        break;                   
                    case "blue":
                        break;
                    default : Console.Write("Wrong! Try again: ");
                        break;
                }
                
            } while (mycolor != "blue");


            Console.WriteLine("Wow! You must be a psychic!");
            Console.ReadLine();

        
        }
    }
}
