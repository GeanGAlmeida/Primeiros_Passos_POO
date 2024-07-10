using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassoPoo
{
    class Car
    {
        private string model = "Mustang";
    }
    internal class ExemploModificadoresAcesso2
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            //Console.WriteLine(car.model);//não ira funcionar porque a classe "model" esta privada
        }
    }
}
