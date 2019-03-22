using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            File.WriteAllText(@"Number.txt", num.ToString());
            Console.WriteLine("Displaying: {0}\\Number.txt", Directory.GetCurrentDirectory());
            Console.Write(File.ReadAllText(@"Number.txt"));
            Console.Read();
        }
    }
}
