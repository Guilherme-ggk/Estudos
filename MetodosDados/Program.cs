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

         
            string NomeCompleto = m.FormaNome("Guilherme", "Henrique");

            double ValorPi = m.ValorDePi();
            int Codigo = m.CodigoChar('a');

           
            int valor2 = 100;

            
            m.AumentarRef(ref valor2);
            m.Cumprimentar();

            m.Soma(5, 15);

            m.Aprensentar("Guilheme", 21);





            Console.WriteLine(NomeCompleto);
            Console.WriteLine(ValorPi);
            Console.WriteLine(Codigo);
            Console.ReadKey();
        }
    }
}
