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

            Console.WriteLine($"O valor do produto é {numD:3}");   


            Console.WriteLine($"Hoje é {DateTime.Now:D} e são {DateTime.Now:t}");

            Console.ReadLine();

            Console.ReadLine(); 
        }
    }
}
