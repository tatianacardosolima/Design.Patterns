using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.Interpreter
{
    public class AddExpression : Expression
    {
        private readonly Expression _leftExpression;
        private readonly Expression _rightExpression;

        public AddExpression(Expression leftExpression, Expression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            return _leftExpression.Interpret(context) + _rightExpression.Interpret(context);
        }
    }
}
