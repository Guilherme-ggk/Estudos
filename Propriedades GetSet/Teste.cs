using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_GetSet
{
    internal class Teste
    {
        // Definição de um campo

        private string _nome;
        public string Sobrenome { get; } = "Henrique";
        private int _idade;

        // Definição de uma propriedade
        public string Nome
        {
            get // pega e retorna o valor desse campo
            {
                return _nome;
            }

            set // define o valor do campo
            {
                _nome = value;
            }
        }
        public int Idade
        {
            get // pega e retorna o valor desse campo
            {
                return _idade;
            }

            set // define o valor do campo
            {
                if(value < 18)
                {
                    Console.WriteLine("Idade não permitida!");
                }
                else
                {
                    _idade = value;
                }
            }
        }

        public void Apresentar()
        {
            if (_nome != "")
            Console.WriteLine($"Olá {_nome}");
        }
    }
}
