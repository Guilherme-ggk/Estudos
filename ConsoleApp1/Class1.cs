using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        
        public void AumentarValor(int valor)
        {
            valor += 10;

            Console.WriteLine($"por valor {valor}");
        }
        public void AumetarRef(ref int valor)
        {
            valor += 10;

            Console.WriteLine($"por ref {valor}");
        }
    }
}
