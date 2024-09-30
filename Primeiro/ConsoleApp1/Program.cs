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

            auxiliar = nome1;  // joga o n1 no auxiliar 
            nome1 = nome4; // n1 recebe n4

            nome4 = auxiliar; // n4 recebe auxiliar que esta com o n1
            auxiliar = nome2; // aux recebe n2

            nome2 = nome3; // n2 recebe n3 
            nome3 = auxiliar; // n3 recebe aux que estáq com n2


            

            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);
            Console.ReadLine();



        }
    }
}
