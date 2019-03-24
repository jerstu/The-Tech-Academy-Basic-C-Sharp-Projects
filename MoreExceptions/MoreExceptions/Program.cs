using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptions
{
    class Program
    {
        static void Main(string[] args)
        { int age;
            Console.Write("Enter your age: ");
            try
            {
                age = Convert.ToInt16(Console.ReadLine());
                if (age == 0) throw new ZeroException();
                if (age < 0) throw new NegativeException();
                bool validAnswer = false;
                while (!validAnswer)
                {
                    Console.Write("And have you had a birthday yet this year? (y or n): ");
                    string answer = Console.ReadLine();
                    if (answer == "y") validAnswer = true;
                    else if (answer == "n")
                    {
                        validAnswer = true;
                        age += 1;
                    }
                    else Console.WriteLine("Please enter y or n!");
                }
                Console.WriteLine("You were born in {0}.", DateTime.Now.Year - age);
                Console.ReadLine();
            }
            catch (ZeroException)
            {
                Console.WriteLine("Your age cannot be zero...");
                Console.ReadLine();
                Console.WriteLine("Unless you are a baby. If you are a baby, how are you reading and using a computer already??");
                Console.ReadLine();
                return;
            }
            catch (NegativeException)
            {
                Console.WriteLine("Your age definetly cannot be negative.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong, did you enter something incorrectly?");
                Console.ReadLine();
                return;
            }
            
        }
    }
}
