using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.Command
{
    public class WithdrawCommand : ICommand
    {
        private readonly Account _account;
        private readonly int _amount;

        public WithdrawCommand(Account account, int amount)
        {
            _account = account;
            _amount = amount;
        }

        public void Execute()
        {
            _account.Withdraw(_amount);
        }

        public void Undo()
        {
            _account.Deposit(_amount);
        }
    }
}
