using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.Command
{
    public class TransactionManager
    {
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
