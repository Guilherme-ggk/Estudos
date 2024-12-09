using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            m.Cumprimentar();

            m.Soma(5, 15);

            m.Aprensentar("Guilheme", 21);


            int valor1 = 100;
            int valor2 = 100;

            m.AumentarValor(valor1);
            m.AumentarRef(ref valor2);

            string NomeCompleto = m.FormaNome("Guilherme", "Henrique");

            Console.WriteLine(NomeCompleto);



            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.ReadKey();
        }
    }
}
