using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public Employee(string fn, string ln, int id)
        {
            FirstName = fn;
            LastName = ln;
            Id = id;
        }

        public void SayEmployee()
        {
            Console.WriteLine("{0}:\t{1} {2}", Id, FirstName, LastName);
        }

        
    }
}
