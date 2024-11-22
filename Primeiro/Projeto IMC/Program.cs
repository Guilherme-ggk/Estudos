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

            Console.WriteLine("Qual o seu peso?");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua altura?");
            double altura = double.Parse(Console.ReadLine());

            double resultado = peso / (altura * altura);

            if (resultado < 20)
            {
                Console.WriteLine($"{resultado}, magro");
            }
            else if (resultado >= 20 && resultado <= 24)
            {
                Console.WriteLine($"{resultado}, normal");
            }
            else if (resultado >= 24 && resultado < 29)
            {
                Console.WriteLine($"{resultado}, sobre peso");
            }
            else if (resultado >= 30 && resultado < 34)
            {
                Console.WriteLine($"{resultado}, obeso");
            }
            else
            {
                Console.WriteLine("Gordassa");
                Console.ReadLine();
            }
            Console.ReadLine();


        }
    }
}
