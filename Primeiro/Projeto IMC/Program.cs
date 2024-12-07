using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_IMC
{
    internal class Program
    {
        static void Main()
        {
            double c, k, f;
            Console.WriteLine("Conversor de temperatura:");
            Console.WriteLine("Digite a temperatura em graus celcius:");
            c = double.Parse(Console.ReadLine());

            f = (c * 9 / 5) + 32;
            
            k = c + 273.15;

            Console.WriteLine($"{c} graus celcius = {f} graus farenheit.");

            Console.WriteLine($"{c} graus celcius = {k} graus kelvin.");

            Console.ReadLine();
        }
    }
}
