using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassoPoo
{
    internal class ExemploConstrutor3
    {
        public string finalizacao;

        public ExemploConstrutor3(string estragulamento)
        {
            finalizacao = estragulamento;
        }

        public static void Main(string[] args)
        {
            ExemploConstrutor3 JiuJitsu = new ExemploConstrutor3("Guilhotina");
            Console.WriteLine("O nome da finalização é " + JiuJitsu.finalizacao);
        }
    }
}
