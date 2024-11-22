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
            Console.WriteLine("Calculando o IMC");
            Console.WriteLine("Qual o seu peso?");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua altura?");
            double altura = double.Parse(Console.ReadLine());

            double resultado = peso / (altura * altura);

            if(resultado <= 18)
            {
                Console.WriteLine($"Seu IMC consta {resultado}, você está magro.");
                Console.ReadKey();
            }
            else if(resultado >= 18 && resultado <= 24)
            {
                Console.WriteLine($"Seu IMC consta {resultado}, peso ideal.");
                Console.ReadKey();
            }
            else if (resultado >= 25 && resultado <= 29)
            {
                Console.WriteLine($"Seu IMC consta {resultado}, acima do peso.");
                Console.ReadKey();
            }
            else if (resultado >= 30 && resultado <= 39)
            {
                Console.WriteLine($"Seu IMC consta {resultado}, obeso.");
                Console.ReadKey();
            }
            else if (resultado >= 40)
            {
                Console.WriteLine($"Seu IMC consta {resultado}, obesidade grave.");
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
