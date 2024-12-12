using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pessoa
    {
        public string nome;
        public int anonascimento;
        public int idade;

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

        
    }
}
