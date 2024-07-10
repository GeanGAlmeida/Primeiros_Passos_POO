using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassoPoo
{
    internal class ExemploConstrutor4
    {
        public string nomeDCarro;
        public string modeloDCarro;
        public int anoDCarro;
        public string corDCarro;
        public string combustivelDCarro;

        public ExemploConstrutor4(string nomeCarro, string modeloCarro, int anoCarro, string corCarro, string combustivelCarro)
        {
            nomeDCarro = nomeCarro;
            modeloDCarro = modeloCarro;
            anoDCarro = anoCarro;
            corDCarro = corCarro;
            combustivelDCarro = combustivelCarro;
        }

        public static void Main(string[] args)
        {
            ExemploConstrutor4 byd = new ExemploConstrutor4("BYD", "Dolphin", 2025, "vermelho", "elétrico");
            Console.WriteLine("O nome do carro é " + byd.nomeDCarro);
            Console.WriteLine("O modelo do carro é " + byd.modeloDCarro);
            Console.WriteLine(" O ano do carro é : " + byd.anoDCarro);
            Console.WriteLine(" A cor do carro é : " + byd.corDCarro);
            Console.WriteLine(" O combustível do carro é : " + byd.combustivelDCarro);
        }
    }
}

