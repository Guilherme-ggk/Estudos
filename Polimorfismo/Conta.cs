using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class CaixaEletronico : IConta
    {
        public string Conta { get; set; }

        public void Depositar()
        {
            throw new NotImplementedException();
        }

        public void Sacar()
        {
            throw new NotImplementedException();
        }

        public void Saldo()
        {
            throw new NotImplementedException();
        }
    }

    interface IConta // por padrão são todos abstratos
    {
        string Conta { get; set; }

        void Depositar();
        void Sacar();
        void Saldo();
    }
}
