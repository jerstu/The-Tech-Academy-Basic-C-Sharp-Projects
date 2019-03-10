using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Employee<T>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<T> Things { get; set; }

        public Employee(string fn, string ln, List<T> things)
        {
            FirstName = fn;
            LastName = ln;
            Things = things;
        }

        public void ListThings()
        {
            Console.WriteLine("{0} {1} has:", FirstName, LastName);
            foreach (var thing in Things)
            {
                Console.WriteLine(thing);
            }
        }

    }
}
