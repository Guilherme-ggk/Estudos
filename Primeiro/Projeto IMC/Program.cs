using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_IMC
{
    internal class Program
    {
        enum Menu { soma = 1, sub, mult, div, pot, raiz, sair };
        static void Main(string[] args)
        {
            bool EscolheuSair = false;
            while (!EscolheuSair)
            {
                Console.WriteLine("Calculuadora no Console");
                Console.WriteLine("1-soma\n2-subtração\n3-multplicação\n4-divisão\n5-potência\n6-raiz\n7-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;

                switch (opcao)
                {
                    case Menu.soma:
                        break;
                    case Menu.sub:
                        break;
                    case Menu.mult:
                        break;
                    case Menu.div:
                        break;
                    case Menu.pot:
                        break;
                    case Menu.raiz:
                        break;
                    case Menu.sair:
                        EscolheuSair = true;
                        break;
                }
            }
           
        }
        static void Soma()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1 + n2;

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1 - n2;

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1 * n2;

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());

            float resultado = (float)n1 / (float)n2;

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Digite o número base:");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número expoente:");
            int e2 = int.Parse(Console.ReadLine());

            int resultado = (int)Math.Pow(b1, e2);

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Digite o número que deseja saber a raiz:");
            int n1 = int.Parse(Console.ReadLine());

            int resultado = (int)Math.Sqrt(n1);

            Console.WriteLine(resultado);
            Console.ReadLine();
        }

    }
}
