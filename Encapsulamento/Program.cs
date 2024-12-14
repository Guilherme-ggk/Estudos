using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c = new ContaBancaria();

            c.Cliente = "Guilherme";
            //c.Saldo = 100;

            // ================ OPERAÇÃO DEPOSITO ====================

            double valor = 100;
            c.Depositar(valor);

            // ================ OPERAÇÃO SACAR ====================

            double valor2 = 50;
            c.Sacar(valor2);

            // ================ CLIENTE ====================

            Console.WriteLine($"Cliente: {c.Cliente}");
            Console.WriteLine($"Cliente: {c.Saldo}");

            Console.ReadLine();




        }
    }
}
