using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassoPoo
{
    internal class ExemploConstrutor2
    {
        public string finalizacao;

        public ExemploConstrutor2()
        {
            finalizacao = "Katagatame";
        }

        public static void Main(string[] args)
        {
            ExemploConstrutor2 makhachev = new ExemploConstrutor2();
            Console.WriteLine("Charlles foi finalizado no " + makhachev.finalizacao);
        }
    }
}
