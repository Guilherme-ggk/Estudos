using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        // atributos de um jogo: nome, tipo, tamanho, preço
        // métodos para um jogo: abrir, carregar, executar, atualizar

        #region exemplo de classe jogo

        static class Jogo
        {
            static public string Nome { get; set; }
            static string Genero { get; set; }          // Fortnite - BattleRoyale - R$: 0
            static string Preco { get; set; }


            static void Atualizar()
            {

            }
            static void Abrir()
            {

            }
            static void Executar()
            {

            }
            static void Carregar()
            {

            }
        }

        #endregion


        #region Exemplos de abstração em classes

        class Celular
        {
            public string Nome { get; set; }
            public string Marca { get; set; }
            public int Preco { get; set; }

            public List<string> ListaAcessorios = new List<string>();
        }

        class Jogo
        {
            public string Nome { get; set; }
            public string Genero { get; set; }
            public int Preco { get; set; }
            public string Desenvolvedora { get; set; }
            public string Plataforma { get; set; }
            public int TamanhoDownload { get; set; }
        }

        class PedidoRestaurante
        {
            public string Prato { get; set; }
            public string Bebida { get; set; }
            public int Preco { get; set; }
            public int Comanda { get; set; }

            public List<string> listaDeRefeicoes = new List<string>();
            public int ValorTotal { get; set; }
        }

        class PersonagemRPG
        {
            public string nome { get; set; }
            public int Nivel { get; set; }
            public int PontoVida { get; set; }
            public int PontoPoder { get; set; }

            public List<string> itens = new List<string>();
        }

        class ImovelAluguel
        {
            public string Endereco { get; set; }
            public int ValorAluguel { get; set; }
            public int CEP { get; set; }
        }

        #endregion

        static void Main()
        {
            
        }
    }
}
