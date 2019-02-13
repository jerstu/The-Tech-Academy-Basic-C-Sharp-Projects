using System;


namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=======================================");  // Some console app ui flair
            Console.WriteLine("| Anonymous Income Comparison Program |");
            Console.WriteLine("=======================================\n");

            // get person 1's info
            Console.WriteLine("Person 1\n========");
            Console.Write("Hourly Rate: ");
            float person1rate = Convert.ToSingle(Console.ReadLine());
            Console.Write("Hours worked per week: ");
            float person1hours = Convert.ToSingle(Console.ReadLine());
            // calculate annual income, assume they work 52 weeks in a year
            double person1income = person1rate * person1hours * 52;

            // get person 2's info
            Console.WriteLine("\nPerson 2\n========");
            Console.Write("Hourly Rate: ");
            float person2rate = Convert.ToSingle(Console.ReadLine());
            Console.Write("Hours worked per week: ");
            float person2hours = Convert.ToSingle(Console.ReadLine());
            // annual income @ 52 weeks/year
            double person2income = person2rate * person2hours * 52;

            Console.WriteLine("\nAnnual salary of Person 1:\n$" + person1income);
            Console.WriteLine("\nAnnual salary of Person 2:\n$" + person2income);

            Console.WriteLine("\nDoes Person 1 make more money that Person 2?\n" + (person1income > person2income)); // who makes more?? not my business
            Console.Read();
        }
    }
}
