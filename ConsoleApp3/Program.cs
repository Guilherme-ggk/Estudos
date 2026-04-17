using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("< Aumento de Crédito >");

            string nome = Console.ReadLine();
            string cpf = Console.ReadLine();
            int rendaAtual = int.Parse(Console.ReadLine());

            bool limiteUsuario = false;
            

            if(string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || rendaAtual == 0)
            {
                Console.WriteLine("Dados incompletos!");
            }
            else
            {

            }
            



            
        }
    }
}
