using System;  
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;
            Console.WriteLine("Conversor de temperatura");
            Console.WriteLine("Digite a temperatura que deseja converter em graus celcius:");
            c = double.Parse(Console.ReadLine());

            f = (c * 9 / 5) + 32;

            k = (c + 273.15);

            Console.WriteLine(c + " graus celcius = " + f + " graus fahrenheit");
            Console.WriteLine(c + " graus celcius = " + k + " graus kelvin");
            Console.ReadKey();

        }
    }
}
