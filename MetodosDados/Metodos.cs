using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDados
{
    internal class Metodos
    {
        //metodo simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, seja bem vindo");
        }

        public void Soma(int n1, int n2)
        {
            int res = n1 + n2;

            Console.WriteLine(res);
        }

        public void Aprensentar(string nome, int idade)
        {
            Console.WriteLine($"Me chamo {nome} e tenho {idade} anos");

        }

        public void AumentarValor (int valor)
        {
            valor += 10;
            Console.WriteLine($"Valor final por valor é: {valor}");
            Console.ReadLine();
        }
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine($"Valor final por valor é: {valor}");
            Console.ReadLine();
        }

        

    }
}
