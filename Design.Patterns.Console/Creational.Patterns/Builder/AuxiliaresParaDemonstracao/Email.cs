using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Creational.Patterns.Builder.AuxiliaresParaDemonstracao
{
    public class Email
    {
        public string Remetente { get; set; }
        public List<string> Destinatarios { get; set; }
        public string Assunto { get; set; }
        public string Corpo { get; set; }
        public List<Anexo> Anexos { get; set; }

        public Email()
        {
            Destinatarios = new List<string>();
            Anexos = new List<Anexo>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Remetente: {Remetente}");
            sb.AppendLine($"Destinatários: {string.Join(", ", Destinatarios)}");
            sb.AppendLine($"Assunto: {Assunto}");
            sb.AppendLine($"Corpo:\n{Corpo}");
            sb.AppendLine($"Anexos: {Anexos.Count}");
            return sb.ToString();
        }
    }

    public class Anexo
    {
        public string Nome { get; set; }
        public byte[] Conteudo { get; set; }
    }
}
