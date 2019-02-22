using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] funnyQuotes = {    "A day without sunshine is like, you know, night. \n\t-Steve Martin",
                                        "Behind every great man is a woman rolling her eyes. \n\t-Jim Carrey",
                                        "If love is the answer, could you please rephrase the question? \n\t-Lily Tomlin",
                                        "Happiness is having a large, loving, caring, close-knit family in another city. \n\t-George Burns",
                                        "If you're going to do something tonight that you'll be sorry for tomorrow morning, sleep late. \n\t-Henny Youngman",
                                        "Age is something that doesn't matter, unless you are a cheese. \n\t-Luis Bunuel",
                                        "To succeed in life, you need three things: a wishbone, a backbone and a funny bone. \n\t-Reba McEntire",
                                        "Do not take life too seriously. You will never get out of it alive. \n\t-Elbert Hubbard",
                                        "No man has a good enough memory to be a successful liar. \n\tAbraham Lincoln"
            };

            bool display = true;
            int selected;

            while (display)
            {
                Console.Write("Select a index, 0 - " + funnyQuotes.Length + ", for a somewhat funny, slightly inspiration quote: ");

                selected = Convert.ToInt16(Console.ReadLine());
                if (selected >= 0 && selected < funnyQuotes.Length)
                {
                    Console.WriteLine(funnyQuotes[selected]);
                }
                else
                {
                    Console.WriteLine("Not a valid choice.");

                };
                Console.WriteLine("Press 'y' to try again");
                string tryAgain = Console.ReadLine();
                if (tryAgain != "y")
                {
                    display = false;
                };

            };

            int[] intArray = { 2, 51, 326, 1008, 67, 88, 21, 4721 };
            display = true;

            while (display)
            {
                Console.Write("Select an index, 0 - " + intArray.Length + ", of the array: ");

                selected = Convert.ToInt16(Console.ReadLine());
                if (selected >= 0 && selected < intArray.Length)
                {
                    Console.WriteLine(intArray[selected]);
                }
                else
                {
                    Console.WriteLine("Not a valid choice.");
                };
                Console.WriteLine("Press 'y' to try again");
                string tryAgain = Console.ReadLine();
                if (tryAgain != "y")
                {
                    display = false;
                };

            };

            List<string> quotes = new List<string>();
            for (int i = 0; i < funnyQuotes.Length; i++)
            {
                quotes.Add(funnyQuotes[i]);
            };

            display = true;
            while (display)
            {
                Console.WriteLine("Select an index 0 - " + (quotes.Count - 1) + ", to display one more quote: ");

                selected = Convert.ToInt16(Console.ReadLine());
                if (selected >= 0 && selected < quotes.Count)
                {
                    Console.WriteLine(quotes[selected]);
                }
                else
                {
                    Console.WriteLine("Not a valid choice.");
                };
                Console.WriteLine("Press 'y' to try again");
                string tryAgain = Console.ReadLine();
                if (tryAgain != "y")
                {
                    display = false;
                };

            };
           
            
            
        }




          
    }
}
