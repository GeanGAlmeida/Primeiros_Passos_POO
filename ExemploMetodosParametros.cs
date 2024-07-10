using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassoPoo
{
    internal class ExemploMetodosParametros
    {
        public static void Main(string[] args)
        {
            ReiDoMundo("gean");
            ReiDoMundo("Gean Com G");
        }

        static void ReiDoMundo(string nome)
        {
            Console.WriteLine(nome + " é o rei do mundo");
        }
    }
}
