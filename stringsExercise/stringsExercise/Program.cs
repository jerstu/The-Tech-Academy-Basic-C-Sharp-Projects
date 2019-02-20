using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "My name is Jeremy. ";
            string string2 = "I have too many coffee gadgets. ";
            string string3 = "Maybe I should get rid of some. \n";

            Console.WriteLine(string1 + string2 + string3);

            StringBuilder paragraph = new StringBuilder("\tI don't think it's a problem though. ");
            paragraph.Append("Whenever I move, I have a big box labeled ");
            string string4 = "\"coffee\". ";            
            paragraph.Append(string4.ToUpper());
            paragraph.Append("It gets bigger and heavier each time. ");
            paragraph.Append("There is a coffee maker for each day of the week. ");
            paragraph.Append("I can roast coffee at home with an electric roaster. ");
            paragraph.Append("Maybe I'm taking it too far when I roast over the campfire.");

            Console.WriteLine(paragraph);

            Console.ReadLine();
         
        }
    }
}
