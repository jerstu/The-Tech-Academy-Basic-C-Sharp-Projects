using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreMethods2
{
    public class Llama
    {
        public Llama(string name)
        {
            Name = name;
            Number = 1;
        }
        public string Name { get; set; }
        public int Number { get; set; }

        public void Spit() // Llamas stick their tongue out and spit when they are unhappy with you.
        {
            Console.WriteLine(Number / 2);
            Console.ReadLine();
        }

        public void Humm(out string string1, out string string2) //Apparently they like to humm too.
        {
            Console.WriteLine("Input Text: ");
            string1 = Console.ReadLine();

            Console.WriteLine("Input More Text: ");
            string2 = Console.ReadLine();
        }

        public void Humm(out int Num1, out int Num2)
        {
            Num1 = Number * 5;
            Num2 = Number * Number;
        }
    }
}
