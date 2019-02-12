// C# .net #58 "Daily Report"
// Get into the habit of commenting code, even if it seems trivial.

using System;


namespace dailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy"); // Writes a line to the console
            Console.WriteLine("Student Daily Report\n"); // \n escape code for newline, makes output more readable
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();  // input a string
            Console.WriteLine("\nWhat page number?");
            ushort pageNumber = Convert.ToUInt16(Console.ReadLine()); // expects a positive integer, ushort for small-ish numbers < 65535, byte might not be enough
            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\".");
            bool needHelp = Convert.ToBoolean(Console.ReadLine()); // expects string of "true" or "false" and coverts it to true boolean, pun intended
            Console.WriteLine("\nWere there any positive experiences you'd like to share?\nPlease give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("\nHow many hours did you study today?");
            float hoursStudy = Convert.ToSingle(Console.ReadLine()); // using single float, in case we get a fractional like 2.5
            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
