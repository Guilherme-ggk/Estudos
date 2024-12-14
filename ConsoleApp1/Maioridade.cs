using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Maioridade
    {
        public static int maioridade = 18;

        public string nome;
        public int idade;

        public void Apresentar()
        {
            Console.WriteLine($"Olá, eu sou {nome}");
        }

        public int CalcularIdade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;
        }


    }
}
