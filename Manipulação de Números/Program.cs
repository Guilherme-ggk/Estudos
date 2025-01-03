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
            // Math

            double PI = Math.PI; // PI
            double Seno = Math.Sin(3);
            double Coseno = Math.Cos(3);
            double Truncate = Math.Truncate(32.75); // usa o valor integral
            double Ceil = Math.Ceiling(52.20); // usa valor baixo
            double Floor = Math.Floor(52.90); // usa valor alto
            double RaizQuadrada = Math.Sqrt(49);
            double E = Math.E;
            double Potencia = Math.Pow(4, 4);
            double arrendonda = Math.Round(150.51);

            Console.WriteLine(arrendonda);

            //To string

            double valor = 120.542;

            Console.WriteLine(valor.ToString("#.00"));

            int valor1 = 254;

            Console.WriteLine(valor1.ToString("C")); // Monetario
            Console.WriteLine(valor1.ToString("D")); // Decimal
            Console.WriteLine(valor1.ToString("D5")); // Decimal
            Console.WriteLine(valor1.ToString("X")); // Hexa
            Console.WriteLine(valor1.ToString("X5")); // Hexa com mais digitos


            Console.WriteLine(Convert.ToString(valor1, 16));



            //Try Parse

            int num;

            bool resposta = int.TryParse("1985", out num);

            if(resposta)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Erro na conversão");
            }

            //Format

            decimal numD = 120.2m;

            Console.WriteLine($"O valor do produto é {numD}");

            Console.WriteLine($"Hoje é {DateTime.Now:D} e são {DateTime.Now:t}");

            Console.ReadLine(); 
        }
    }
}
