using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassoPoo
{
    internal class ExemploSobreCargaMetodo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Resultado Inteiro: " + Somar(5, 4));
            Console.WriteLine("Resultado Real: " + Somar(5.9, 4.5));
        }

        static int Somar(int num, int num2)
        {
            return num + num2;
        }

        static double Somar(double num, double num2)
        {
            return num + num2;
        }
    }
}
