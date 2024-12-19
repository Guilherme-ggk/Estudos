using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
           // Forma a = new Forma();
            Forma b = new Triangulo();
            Forma c = new Circulo();
            Forma d = new Retangulo();

           // Console.WriteLine("Forma");
            //a.Desenhar();
            Console.WriteLine("Triangulo");
            b.Desenhar();
            Console.WriteLine("Circulo");
            c.Desenhar();
            Console.WriteLine("Retangulo");
            d.Desenhar();

            Console.ReadLine();
        }
    }
}
