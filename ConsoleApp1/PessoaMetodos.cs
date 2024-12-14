using System;

namespace ConsoleApp1
{
    partial class Pessoa
    {
        public Pessoa()
        {
            nome = "Guilherme";
            anonascimento = 0;
            idade = 0;
        }

        public Pessoa(string nome, int anonascimento)
        {
            this.nome = nome;
            this.anonascimento = anonascimento;
            idade = Idade();
        }


        private int Idade()
        {
            return 2024 - anonascimento;
        }

        public static int maioridade = 18;

        public static int CalcularIdade(int AnoNascimento)
        {
            return DateTime.Now.Year - AnoNascimento;
        }
    }
}
