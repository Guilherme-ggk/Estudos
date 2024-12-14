using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_GetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();

            t.Nome = "Guilherme";
            t.Idade = 21;

            Console.WriteLine($"{t.Nome} {t.Sobrenome}\n {t.Idade}");
            
            Console.ReadLine();

        }
    }
}
