using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henraca
{
    class Humano
    {
        public virtual void Olhos()
        {
            Console.WriteLine("Humano.olhos");
        }
        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.cabelos");
        }
    }

    class Pessoa: Humano
    {
        public sealed override void Olhos() // com o sealed aqui, ele não pode ser herdado diretamente da classe pessoa
        {
            Console.WriteLine("Pessoa.olhos");
        }
        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.cabelos");
        }
    }
    class Homem: Pessoa
    {
        /*public override void Olhos() // com o sealed aqui, ele não pode ser herdado diretamente da classe pessoa
        {
            Console.WriteLine("Humano.olhos");
        }*/
        public override void Cabelos()
        {
            Console.WriteLine("Homem.cabelos");
        }
    }
}
