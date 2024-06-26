using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.Command
{
    public class TransferCommand : ICommand
    {
        private readonly Account _sourceAccount;
        private readonly Account _destinationAccount;
        private readonly int _amount;

        public TransferCommand(Account sourceAccount, Account destinationAccount, int amount)
        {
            _sourceAccount = sourceAccount;
            _destinationAccount = destinationAccount;
            _amount = amount;
        }

        public void Execute()
        {
            _sourceAccount.Withdraw(_amount);
            _destinationAccount.Deposit(_amount);

        }

        public void Undo()
        {
            _destinationAccount.Withdraw(_amount);
            _sourceAccount.Deposit(_amount);

        }
    }
}
