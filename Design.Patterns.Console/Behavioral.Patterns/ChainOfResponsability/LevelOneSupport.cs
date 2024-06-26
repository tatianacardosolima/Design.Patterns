using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.ChainOfResponsability
{
    public class LevelOneSupport : SupportHandler
    {
        public override void HandleRequest(SuportRequest request)
        {
            if (request.IsSystemOnline && !request.IsSystemSlow)
            {
               // Put here the rules
            }
            else if (nextHandler != null)
            {
                
                nextHandler.HandleRequest(request);
            }
            else
            {
                throw new Exception("Não existe outro nível configurado");
            }
        }
    }
}
