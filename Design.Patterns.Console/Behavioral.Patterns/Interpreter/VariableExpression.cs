using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.Interpreter
{
    public class VariableExpression : Expression
    {
        private readonly string _variableName;

        public VariableExpression(string variableName)
        {
            _variableName = variableName;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            if (context.ContainsKey(_variableName))
            {
                return context[_variableName];
            }
            throw new KeyNotFoundException($"Variable {_variableName} not found in context");
        }
    }
}
