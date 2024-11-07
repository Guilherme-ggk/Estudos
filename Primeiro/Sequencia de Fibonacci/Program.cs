using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequencia_de_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sequência de Fibonacci");

            Console.WriteLine("Quantos valores?");
            int valor = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;

            
            for (int i = 0; i < valor; i++)
            {
                if (i < valor - 1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                    Console.Write(a);
                }
                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadLine();


        }
    }
}
