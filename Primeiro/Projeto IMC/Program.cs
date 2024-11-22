using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando IMC");

            Console.WriteLine("Peso:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Altura:");
            double altura = double.Parse(Console.ReadLine());

            double resultado = peso / (altura * altura);

            if (resultado < 20)
            {
                Console.WriteLine($"{resultado}, magro.");
            }
            else if (resultado >= 20 && resultado <= 24)
            {
                Console.WriteLine($"{resultado}, normal.");
            }
            else if(resultado >= 25 && resultado <= 29)
            {
                Console.WriteLine($"{resultado}, sobre peso.");
            }
            else if (resultado >= 30 && resultado <= 34)
            {
                Console.WriteLine($"{resultado}, obeso.");
            }
            else if (resultado > 35)
            {
                Console.WriteLine($"{resultado}, obeso grave.");
                Console.ReadKey();
            }
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();


        }
      
    }
}
