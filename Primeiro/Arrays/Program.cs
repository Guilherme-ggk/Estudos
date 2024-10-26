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
            //Vetores (array)

            int[] numeros = { 1, 2, 3 };

            string[] carros =
            {
                "lamborghini",
                "mitsubishi",
                "volkswagen"
            };

            //matriz (array bimedimensional)

            int[,] numeros2 = new int[2,3];

            numeros2[0, 0] = 1;
            numeros2[0, 1] = 2;
            numeros2[0, 2] = 3;
    

            numeros2[1, 0] = 10;
            numeros2[1, 1] = 20;
            numeros2[1, 2] = 30;

            Console.Write("[" + numeros2[0, 0] + "]");
            Console.Write("[" + numeros2[0, 1] + "]");
            Console.Write("[" + numeros2[0, 2] + "]");

            Console.WriteLine();

            Console.Write("[" + numeros2[1, 0] + "]");
            Console.Write("[" + numeros2[1, 1] + "]");
            Console.Write("[" + numeros2[1, 2] + "]");

            Console.ReadLine();



        }
    }
}
