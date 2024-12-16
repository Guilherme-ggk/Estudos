using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henraca
{
    internal class Bicicleta : Veiculo
    {
        public void Pedalar()
        {
            Console.WriteLine("Pedalando");
        }
        public override void Acelerar() // e trocando o abstract por override
        {
            Console.WriteLine("Acelerou a bicicleta");
        }
    }
}
