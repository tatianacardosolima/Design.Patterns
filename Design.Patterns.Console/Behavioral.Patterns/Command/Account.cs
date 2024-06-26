﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.Command
{
    public class Account
    {
        public int Balance { get; private set; }

        public void Deposit(int amount)
        {
            Balance += amount;
            
        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
            
        }
    }   
}
