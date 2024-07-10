using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassoPoo
{
    internal class ExemploMetodosMultiParametros
    {
        public static void Main(string[] args)
        {
            ReiDoMundo("Gean", 20);
            ReiDoMundo("Deus", int.MaxValue);
        }

        static void ReiDoMundo(string nome, int idade)
        {
            Console.WriteLine(nome + " é o rei do mundo com apenas " + idade + " anos");
        }
    }
}
