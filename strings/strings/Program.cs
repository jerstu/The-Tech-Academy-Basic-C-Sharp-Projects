using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jeremy";
            //string quote = "The man said, \"Hello\", Jeremy. \n Hello on a new line. \n\t Hello on a tab.";
            //string fileName = "C:\\Users\\Jeremy";

            //bool trueOrFalse = name.Contains("e");
            //Console.WriteLine(trueOrFalse);
            //trueOrFalse = name.EndsWith("y");
            //Console.WriteLine(trueOrFalse);
            //int length = name.Length;
            //Console.WriteLine("Name Length of " + name + " is " + length);

            //name = name.ToUpper();

            //Console.WriteLine(name);
            //Console.WriteLine(quote);
            //Console.WriteLine(fileName);
            //Console.ReadLine();

            //string name2 = "Jeremy";
            //name2 = "Joe";

            StringBuilder sb = new StringBuilder();

            sb.Append("My Name is Jeremy.");
            sb.Append(" I live at 3545 N Borthwick Ave.");

            

            Console.WriteLine(sb);
            Console.ReadLine();
        
        }
    }
}
