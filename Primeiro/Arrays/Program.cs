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
            Console.WriteLine("** Criando arrays **");

            int[] numeros = new int[3] { 1, 2, 3, };
            string[] carros = 
                {
                "Lamborghini",
                "Sena",
                "Bugatti"
                };

            Console.WriteLine(numeros[0]);

            Console.WriteLine(carros[1]);

            Console.ReadKey();
        }
    }
}
