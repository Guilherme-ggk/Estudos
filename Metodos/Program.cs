using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // string nome = args[0];
            string senha = "30755";

            if(senha != args[1])
            {
                Console.WriteLine("acesso negado");
            }
            else
            {
                Console.WriteLine($"olá {args[0]}");
            }
        }
    }
}
