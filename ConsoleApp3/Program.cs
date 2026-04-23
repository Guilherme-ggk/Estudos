using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite seu CPF:");

            string CPF = Console.ReadLine();

            bool valido = ValidaCPF(CPF);

            if(valido)
            {
                Console.WriteLine("CPF válido!");
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }
        }

        static bool ValidaCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if(cpf.Length != 11)
                return false;

            if(TodosIguais(cpf))
                return false;

            string baseCpf = cpf.Substring(0, 9);

            int digito1 = CalculaDigito(baseCpf, 10);
            int digito2 = CalculaDigito(baseCpf + digito1, 11);

            string cpfGerado = baseCpf + digito1.ToString() + digito2.ToString();

            return cpf == cpfGerado;
        }

        static int CalculaDigito(string cpf, int pesoInicial)
        {
            int soma = 0;

            for(int i = 0; i < cpf.Length; i++)
            {
                int numero = int.Parse(cpf[i].ToString());
                soma += numero * (pesoInicial - i);
            }

            int resto = soma % 11;

            if(resto < 2)
            {
                return 0;
            }
            else
            {
                return 11 - resto;
            }
        }

        static bool TodosIguais(string cpf)
        {
            for(int i = 0; i < cpf.Length; i++)
            {
                if (cpf[i] != cpf[0])
                    return false;
            }
            return true;
        }
    }
}
