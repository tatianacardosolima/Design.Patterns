using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
