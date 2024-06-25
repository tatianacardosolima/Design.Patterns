using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.Strategy
{
    internal class SalvarNotaFiscalComoCSVStrategy: ISalvarNotaFiscalStrategy
    {
        public void Salvar(NotaFiscal notaFiscal)
        {
            string path = "NotaFiscal.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(notaFiscal.ToString());
            }

        }
    }
}
