using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGuessed = false;
            int number;
            while (!isGuessed)
            {
                Console.WriteLine("Guess a number?");
                number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        break;
                }
            }
            
            Console.ReadLine();
        }
    }
}
