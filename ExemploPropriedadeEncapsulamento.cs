using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrimeirosPassoPoo
{
    class Pessoa
    {
        private string nome;
        public string Nome {
            get { return nome; } 
            set { nome = value; }
        }
    }
    internal class ExemploPropriedadeEncapsulamento
    {
        public static void Main(string[] args)
        {
            Pessoa nomePessoa = new Pessoa();
            nomePessoa.Nome = "Gean";
            Console.WriteLine(nomePessoa.Nome);
        }
    }
}
