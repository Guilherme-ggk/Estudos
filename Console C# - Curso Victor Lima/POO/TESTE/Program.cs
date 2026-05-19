using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE
{
    public class Jogos
    {
        public string Nome { get; set; }
        public int Preco { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | Preço:{Preco:C}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jogos> jogos = new List<Jogos>();

            Jogos jogo = new Jogos();

            jogos.Add(new Jogos { Nome = "teste", Preco = 10 });
            jogos.Add(new Jogos { Nome = "teste1", Preco = 20});

            Console.Write("digite o novo jogo: ");
             jogo.Nome = Console.ReadLine();
             jogo.Preco = int.Parse(Console.ReadLine());

            jogos.Add(jogo);

            //Console.WriteLine(string.Join($"{jogos[0].Nome}"));


            foreach (Jogos jogoG in jogos)
            {
                Console.WriteLine(jogoG);
            }

            bool existeJogo = jogos.Any(x => x.Nome == "teste");

            Console.WriteLine(existeJogo);



            Console.WriteLine("----------------------------------------");

           List<int> numeros = new List<int>();

            numeros.Add(1);
            numeros.Add(1);
            numeros.Add(1);
            numeros.Add(1);

            int somador = numeros.Sum();

            Console.WriteLine(somador);

            Console.ReadLine();

        }
    }
}
