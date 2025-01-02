using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulação_de_Números
{
    internal class Program
    {
        static void Main(string[] args)
        {
       


           
              string nomes = "Guilherme Henrique Maximo dos Santos Almeida";

              char[] separador = { ' ' };

            string[] resultado = nomes.Split(separador);

              foreach (string nome in resultado)
              {
                Console.WriteLine($"{nome} \n");
              }

              Console.ReadLine();
        }
    }
}
