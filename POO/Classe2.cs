using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Classe2
    {
        public string nome;
        public string sobrenome;

        public void Cumprimentar()
        {
            Console.WriteLine($"Olá {nome}, seu sobrenome é {sobrenome}");
        }
    }
}
