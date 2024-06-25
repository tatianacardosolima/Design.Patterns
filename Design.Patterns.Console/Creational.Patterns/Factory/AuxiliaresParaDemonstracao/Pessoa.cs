using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Console.Creational.Patterns.Factory.AuxiliaresParaDemonstracao
{
    internal class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }


    }
}
