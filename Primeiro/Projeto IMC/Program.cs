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
            double c, k, f;

            Console.WriteLine("Conversor de temperatura no console");

            Console.WriteLine("Digite a temperatura em graus celcius:");
            c = double.Parse(Console.ReadLine());

            k = 273.15 + c;

            f = (c * 9 / 5) + 32;

            Console.WriteLine($"{c} = {k} graus kelvin.");
            Console.WriteLine($"{c} = {f} graus farenheit.");
         
        }

    }
}
