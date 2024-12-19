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
            string nome = args[0];

            Console.WriteLine($"olá {nome}");

            Console.ReadKey();
        }
    }
}
