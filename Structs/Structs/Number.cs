﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Number
    {
        public decimal Amount { get; set; }     
        
        public Number(decimal amt)
        {
            Amount = amt;
        }

        public void PrintAmount()
        {
            Console.WriteLine(Amount);
        }
    }


}
