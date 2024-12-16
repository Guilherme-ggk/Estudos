using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henranca
{
    abstract class Veiculo // é definido/implementado aqui e só pode ser chamado
    {
        public string Cor { get; set; }
        public string Marca { get; set; }


        public abstract void Acelerar(); // só pode ser chamado e definido na hora onde vai ser implementado 
     

        public void Parar()
        {
            Console.WriteLine("Parou");
        }
    }
}
