using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassoPoo
{
    internal class ExemploMetodosParametroPadrao
    {
        public static void Main(string[] args)
        {
            Pais();
            Pais("Argentina");
            Pais("Colombia");
            Pais("Paraguai");
            Pais();
        }

        static void Pais(string pais = "Brasil")
        {
            Console.WriteLine(pais);
        }
    }
}
