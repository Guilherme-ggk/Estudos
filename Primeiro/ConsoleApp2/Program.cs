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
            Console.WriteLine("Digite o seu peso:");
            double peso = double.Parse(Console.ReadLine());

            if(peso <= 24)
            {
                Console.WriteLine("Magro");
            }
            else if(peso == 24)
            {
                Console.WriteLine("peso ideal");
            }
            else if(peso >= 24 && peso <= 29)
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }

            Console.ReadLine();
        }
    }
}
