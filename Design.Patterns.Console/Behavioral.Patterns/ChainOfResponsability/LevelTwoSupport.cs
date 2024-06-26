using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.ChainOfResponsability
{
    public class LevelTwoSupport : SupportHandler
    {
        public override void HandleRequest(SuportRequest request)
        {
            if (request.IsSystemSlow)
            {
                // Envia o problema para o suporte de nível 2
                // Executa as regras especificas para este nível
            }
            else if (nextHandler != null)
            {                
                nextHandler.HandleRequest(request);
            }
            else
            {
                throw new Exception("Level Two Support: Issue could not be resolved.");
            }
        }
    }
}
