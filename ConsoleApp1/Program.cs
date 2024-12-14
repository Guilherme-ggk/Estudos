using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 m = new Class1();


            int valor1 = 100;
            int valor2 = 100;

            m.AumentarValor(valor1);
            m.AumetarRef(ref valor2);

            Console.WriteLine("valor1: " + valor1);
            Console.WriteLine("valor2: " + valor2);

            Pessoa p1 = new Pessoa("Guilherme", 21);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.anonascimento);

            Pessoa.maioridade = 21;

            Pessoa p5 = new Pessoa();

            p5.nome = "Giovana";
            p5.idade = Pessoa.CalcularIdade(2002);

            Console.WriteLine(p5.nome);
            Console.WriteLine(p5.idade);


            

            


            Console.ReadLine();


        }
    }
}
