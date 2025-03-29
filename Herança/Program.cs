using Henraca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ClasseCarro c = new ClasseCarro();
            //Bicicleta b = new Bicicleta();


            Humano a = new Humano();
            Pessoa b = new Pessoa();
            Homem c = new Homem();

            Console.WriteLine("Humano");
            a.Olhos();
            a.Cabelos();

            Console.WriteLine("Pessoa");
            b.Olhos();
            b.Cabelos();

            Console.WriteLine("Homem");
            c.Olhos();
            c.Cabelos();

            Console.ReadKey();

        }
    }
}
