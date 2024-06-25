using Design.Patterns.Console.Creational.Patterns.Builder.AuxiliaresParaDemonstracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Creational.Patterns.Builder
{
    
    internal class EmailBuilder
    {
        protected Email _email;
        protected StringBuilder _corpo;

        public EmailBuilder()
        {
            _email = new Email();
            _corpo = new StringBuilder();
        }
        public void BuildRemetente(string remetente)
        {
            _email.Remetente = remetente;
        }

        public void BuildDestinatarios(List<string> destinatarios)
        {
            _email.Destinatarios.AddRange(destinatarios);
        }
        public void BuildDestinatario(string destinatario)
        {
            _email.Destinatarios.Add(destinatario);
        }

        public void BuildAssunto(string assunto)
        {
            _email.Assunto = assunto;
        }

        public void BuildAddLinhaAoConteudo(string corpo)
        {
            _corpo.AppendLine(corpo);
            _email.Corpo = _corpo.ToString();
        }

        public void AddAnexo(Anexo anexo)
        {
            _email.Anexos.Add(anexo);
        }
    }
}
