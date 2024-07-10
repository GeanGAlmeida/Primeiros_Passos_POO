using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassoPoo
{
    internal class ExemploConstrutor // criação da classe
    {
        public string modelo; // criação de uma variavel publica que sera um campo/atributo.

        public ExemploConstrutor() // cria uma construtor para a classe ExemploConstrutor
        {
            modelo = "Mustang"; //Define um valor inicial para o modelo
        }

        public static void Main(string[] args)
        {
            ExemploConstrutor Ford = new ExemploConstrutor(); //Cria um objeto da Classe ExemploConstrutor
            //(isso chamará o construtor)

            Console.WriteLine("O modelo do carro é: " + Ford.modelo) ;
        }
    }
}
