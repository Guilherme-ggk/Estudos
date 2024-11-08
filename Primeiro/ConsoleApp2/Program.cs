using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo IMC");
            Console.WriteLine("Digite seu peso:");

            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura:");
            double altura = double.Parse(Console.ReadLine());

            double resultado = peso / (altura * altura);

            if(resultado < 20)
            {
                Console.WriteLine("IMC: " + resultado + ", abaixo do peso");
            }
            else if((resultado >= 20) && (resultado <= 24))
            {
                Console.WriteLine("IMC: " + resultado + ", peso normal");
            }
            else if ((resultado) >= 25 && (resultado <= 29))
            {
                Console.WriteLine("IMC: " + resultado + ", acima do peso");
            }
            else if ((resultado) >= 30 && (resultado <= 34))
            {
                Console.WriteLine("IMC: " + resultado + ", obeso");
            }
            else
            {
                Console.WriteLine("????????????");
            }
            Console.ReadKey();



        }
    }
}
