using Design.Patterns.Console.Creational.Patterns.Builder.AuxiliaresParaDemonstracao;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Creational.Patterns.Builder
{
    
    internal class EmailBuilder
    {
        protected Email _email;
        protected StringBuilder _corpo;

        private List<string> palavrasProibidas = new List<string>();
        private List<string> emailsBloqueado = new List<string>();

        public EmailBuilder()
        {
            _email = new Email();
            _corpo = new StringBuilder();
            AddPalavrasEvitadas();
            AddEmailsBloqueados();
        }

        public Email GetEmail { get; private set; }
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
            ValidarPalavra(assunto);
            _email.Assunto = assunto;
        }

        public void BuildAddLinhaAoConteudo(string corpo)
        {
            ValidarPalavra(corpo);
            _corpo.AppendLine(corpo);
            _email.Corpo = _corpo.ToString();
        }

        public void AddAnexo(Anexo anexo)
        {
            _email.Anexos.Add(anexo);
        }

        private bool ValidarPalavra(string texto)
        {
            texto = texto.Replace(".", "").Replace(",", "");
            var a = texto.Split(' ').ToList();

            bool existePalavraBloqueada = a.Any(palavra => palavrasProibidas.Contains(palavra));

            if (existePalavraBloqueada) throw new Exception("Palavras Proibida!");
            return false;
        }
        private void AddPalavrasEvitadas()
        {
            palavrasProibidas.AddRange(new List<string>() { "droga", "sexo", "grosseiro" });

        }
        private void AddEmailsBloqueados()
        {
            palavrasProibidas.AddRange(new List<string>() { "t@t.com", "t@x.com" });

        }
    }
}
