using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.Interpreter
{
    public interface Expression
    {
        int Interpret(Dictionary<string, int> context);
    }
}
