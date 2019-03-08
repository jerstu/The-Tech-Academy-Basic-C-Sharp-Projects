using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        
        public Employee(int id, string fn, string ln)
        {
            Id = id;
            FirstName = fn;
            LastName = ln;            
        }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }

        // Not really sure yet what this is all about
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
