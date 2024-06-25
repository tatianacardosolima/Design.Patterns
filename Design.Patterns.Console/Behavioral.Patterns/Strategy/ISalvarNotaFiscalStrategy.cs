using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.Strategy
{
    internal interface ISalvarNotaFiscalStrategy
    {
        void Salvar(NotaFiscal notaFiscal);
    }

    public class NotaFiscal
    {
        public object Data { get; internal set; }
        public object Cliente { get; internal set; }
        public object Endereco { get; internal set; }
        public IEnumerable<object> Itens { get; internal set; }
    }
}
