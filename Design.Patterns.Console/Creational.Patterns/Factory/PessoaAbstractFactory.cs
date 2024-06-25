using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design.Patterns.Console.Creational.Patterns.Factory.AuxiliaresParaDemonstracao;

namespace Design.Patterns.Console.Creational.Patterns.Factory
{
    internal abstract class PessoaAbstractFactory
    {        
        public abstract Pessoa Create(PessoaRequest request);
        
    }
}
