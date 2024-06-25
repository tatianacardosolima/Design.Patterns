using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design.Patterns.Console.Creational.Patterns.Factory.AuxiliaresParaDemonstracao;

namespace Design.Patterns.Console.Creational.Patterns.Factory
{
    internal class PessoaFisicaFactory : PessoaAbstractFactory
    {
        public override Pessoa Create(PessoaRequest request)
        {
            var pessoa = new Pessoa(request.Nome);
            pessoa.Tipo = "F";
            // imagine que aqui pode todas as regras para 
            // uma pessoa Fisica
            return pessoa;


        }
    }
}
