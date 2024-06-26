using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.ChainOfResponsability
{
    public class LevelThreeSupport : SupportHandler
    {
        public override void HandleRequest(SuportRequest request)
        {
            if (!request.IsSystemOnline)
            {
                // executa as regra do nivel 3
            }
            else
            {
                throw new Exception("Level Three Support: Issue could not be resolved.");
            }
        }
    }
}
