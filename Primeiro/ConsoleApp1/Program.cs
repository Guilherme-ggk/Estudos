using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Invertendo os nomes");
            string nome1, nome2, nome3, nome4, auxiliar;
            Console.WriteLine("Digite o número #1:");
            nome1 = Console.ReadLine();

            Console.WriteLine("Digite o número #2:");
            nome2 = Console.ReadLine();

            Console.WriteLine("Digite o número #3:");
            nome3 = Console.ReadLine();

            Console.WriteLine("Digite o número #4:");
            nome4 = Console.ReadLine();

            Console.WriteLine("Nomes invertidos");

            auxiliar = nome1;
            nome1 = nome4;

            nome4 = nome2;
            auxiliar = nome2;

            nome2 = nome3;
            nome3 = auxiliar;

            

            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);
            Console.ReadLine();



        }
    }
}
