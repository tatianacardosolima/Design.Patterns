using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Behavioral.Patterns.Strategy
{
    internal class SalvarNotaFiscalComoJSONStrategy
    {
        public void Salvar(NotaFiscal notaFiscal)
        {
            
            string jsonString = JsonSerializer.Serialize(notaFiscal);
            File.WriteAllText("notafiscal.json", jsonString);

        }
    }
}
