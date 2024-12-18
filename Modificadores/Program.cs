using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            t.nome = "";
            t.sobrenome = "";
            t.Metodo1();
            t.Executar();

            Console.ReadLine();
        }
    }
}
