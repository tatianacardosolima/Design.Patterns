using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.Interpreter
{
    public class NumberExpression : Expression
    {
        private readonly int _number;

        public NumberExpression(int number)
        {
            _number = number;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            return _number;
        }
    }
}
