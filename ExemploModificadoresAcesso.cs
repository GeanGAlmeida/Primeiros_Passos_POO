using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassoPoo
{
    internal class ExemploModificadoresAcesso
    {
        private string model = "Mustang";

        public static void Main(string[] args)
        {
            ExemploModificadoresAcesso mododPrivado = new ExemploModificadoresAcesso();

            Console.WriteLine(mododPrivado.model);
        }
    }
}
