using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarChain
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string type = "person";

            List<Account> Accounts = new List<Account>();


            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Account acc1 = new Account(name, type);
            Accounts.Add(acc1);

            Console.Write("Company name: ");
            name = Console.ReadLine();

            Account acc2 = new Account(name);
            Accounts.Add(acc2);

            foreach (Account account in Accounts)
            {
                Console.WriteLine("Name: {0}\t\t\tAccount type: {1}", account.Name, account.Type);
            }
            Console.Read();
        }
    }

    class Account
    {
        public Account(string name) : this(name, "business")
        {

        }
        public Account(string name, string type)
        {
            Name = name;
            Type = type;            
        }
        public string Name { get; set; }
        public string Type { get; set; }

    }
}
