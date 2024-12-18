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
    }

    class Pessoa: Humano
    {
        public override void Cabelos()
        {
            Console.WriteLine("Humano.cabelos");
        }
    }
}
