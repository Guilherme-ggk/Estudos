using System;  
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //Vetores (array)

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

             Console.WriteLine();

             string[,] nomes = 
             {
                  { "Guilherme", "Giovana", "Kira"}, // column 0
                 { "Viviane", "Samuel", "Micael" } // column 1
             };

             Console.WriteLine(nomes[0, 2]);
             Console.ReadLine();*/


            //Multiplicação de matrizes

            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] resultado = new int[2, 2];

            Console.WriteLine("Preencha a matriz #1:");

            for(int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 3;  coluna++)
                {
                    Console.Write("#1. Posição [" + linha + "][" + coluna + "]");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Preencha a matriz #2:");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("#2. Posição [" + linha + "][" + coluna + "]");
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Resultado de matriz1 * matriz2:");
            resultado[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
            resultado[1, 0] = (matriz1[0, 0] * matriz2[1, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
            resultado[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
            resultado[1, 1] = (matriz1[1, 1] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

            Console.WriteLine("[" + resultado[0, 0]+ "]" +"[" +  resultado[0,1] + "]");
            Console.WriteLine("[" + resultado[1, 0] + "]" + "[" +  resultado[1, 1] + "]");
           
            Console.ReadKey();


            //If e else
            //Condição simples

            int a = 10;

            if(a <= 10)
            {
                Console.WriteLine("Válido");
            }
            else
            {
                Console.WriteLine("Inválido");
            }

            //Condição encadeada

            if(a >= 10)
            {
                Console.WriteLine("Válido");
            }
            else if(a != 6)
            {
                Console.WriteLine("Válido");
            }
            else
            {
                Console.WriteLine("Inválido");
            }
            //
            //Condição aninhada
            if(a > 5)
            {
                Console.WriteLine("O número é mair que 5");

                if(a % 2 == 0)
                {
                    Console.WriteLine("e também é par");
                }
                else
                {
                    Console.WriteLine("e é impar");
                }
            }
            else
            {
                Console.WriteLine("é menor que 5");
            }


            //Hoje aprendi melhor como usar vb6

            Public BtnCalculadora_Click

            Dim numero1 as Integer
            Dim numero2 as Integer
            Dim resultado as Integer

            numero1 = CInt Txtnumero1.Text
            numero2 = TxtNumero2.Text

            resultado = numero1 + numero2

            Txtresultado = CStr resultado

            end 










            

        }
    }
}
