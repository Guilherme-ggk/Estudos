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
    
    }
}
