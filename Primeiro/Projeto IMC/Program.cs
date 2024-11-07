using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando IMC");

            Console.WriteLine("Qual o seu peso?");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua altura?");
            double altura = double.Parse(Console.ReadLine());

            double resultado = peso / (altura * altura);

            if(resultado < 20)
            {
                Console.WriteLine($"IMC = {resultado}, você está abaixo do peso.");
            }
            else if((resultado >= 20) && (resultado <= 24))
            {
                Console.WriteLine($"IMC = {resultado}, você está com um peso normal.");
            }
            else if ((resultado >= 25) && (resultado <= 29))
            {
                Console.WriteLine($"IMC = {resultado}, você está sobre peso.");
            }
            else if ((resultado >= 30) && (resultado <= 34))
            {
                Console.WriteLine($"IMC = {resultado}, você está obeso.");
            }
            else
            {
                Console.WriteLine($"IMC = {resultado}!!!");
                Console.WriteLine("           ______");
                Console.WriteLine("        .-\"      \"-.");
                Console.WriteLine("       /            \\");
                Console.WriteLine("      |              |");
                Console.WriteLine("      |,  .-.  .-.  ,|");
                Console.WriteLine("      | )(__/  \\__)( |");
                Console.WriteLine("      |/     /\\     \\|");
                Console.WriteLine("      (_     ^^     _)");
                Console.WriteLine("       \\__|IIIIII|__/");
                Console.WriteLine("        | \\IIIIII/ |");
                Console.WriteLine("        \\          /");
                Console.WriteLine("         `--------`");
                Console.Write("           ______");
                Console.WriteLine("        .-\"      \"-.");
                Console.WriteLine("       /            \\");
                Console.WriteLine("      |              |");
                Console.WriteLine("      |,  .-.  .-.  ,|");
                Console.WriteLine("      | )(__/  \\__)( |");
                Console.WriteLine("      |/     /\\     \\|");
                Console.WriteLine("      (_     ^^     _)");
                Console.WriteLine("       \\__|IIIIII|__/");
                Console.WriteLine("        | \\IIIIII/ |");
                Console.WriteLine("        \\          /");
                Console.WriteLine("         `--------`");
                Console.ReadLine();

            }

        }
    }
}
