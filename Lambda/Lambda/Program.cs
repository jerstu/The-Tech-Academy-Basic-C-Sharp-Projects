using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Jeremy", "Stewart", 1),
                new Employee("Joe", "Biden", 2),
                new Employee("Joe", "Frazier", 3),
                new Employee("Joe", "Pesci", 4),
                new Employee("Gina", "Marquez", 5),
                new Employee("Hermelinda", "Goddard", 6),
                new Employee("Mary", "Galvan", 7),
                new Employee("Carol", "Huynh", 8),
                new Employee("Minh", "Kearns", 9),
                new Employee("Edward", "Donnell", 10),
                new Employee("Timothy", "Hodge", 11),
                new Employee("James", "Koontz", 12),
                new Employee("Robert", "Long", 13),
                new Employee("Jodi", "Miller", 14),
                new Employee("April", "Miller", 15),
                new Employee("Richard", "Aguilar", 16),
                new Employee("Oscar", "Battle", 17)
            };

            foreach (Employee employee in employees)
            {
                employee.SayEmployee();
            }
            Console.ReadLine();


            List<Employee> foreachJoe = new List<Employee> { };

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    foreachJoe.Add(employee);
                }
            }

            foreach (Employee employee in foreachJoe)
            {
                employee.SayEmployee();
            }
            Console.ReadLine();

            List<Employee> lambdaJoe = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in lambdaJoe)
            {
                employee.SayEmployee();
            }
            Console.ReadLine();

            List<Employee> lambda5 = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in lambda5)
            {
                employee.SayEmployee();
            }
            Console.ReadLine();
        
        }    
    }
}
