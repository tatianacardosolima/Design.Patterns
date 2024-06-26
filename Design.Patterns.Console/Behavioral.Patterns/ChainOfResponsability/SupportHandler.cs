using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.ChainOfResponsability
{
    public abstract class SupportHandler
    {
        protected SupportHandler nextHandler;

        public void SetNextHandler(SupportHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public abstract void HandleRequest(SuportRequest request);
    }
}
