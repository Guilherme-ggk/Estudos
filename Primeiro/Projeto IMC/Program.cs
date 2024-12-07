using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_IMC
{
    [System.Serializable]
    internal class Program
    {
        static List<IEstoque> produtos = new List<IEstoque>();
        enum Menu { lista = 1, adicionar, remover, entrada, saida, sair };
        static void Main()
        {
            Carregar();
            bool EscolheuSair = false;
            while (!EscolheuSair)
            {
                Console.WriteLine("Gestor de Produtos");
                Console.WriteLine("1-listagem\n2-adicionar\n3-remover\n4-Entrada\n5-saida\n6-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;
                if(intop > 0 && intop < 7)
                {
                    switch (opcao)
                    {
                        case Menu.lista:
                            Listagem();
                            break;
                        case Menu.adicionar:
                            Adicionar();
                            break;
                        case Menu.remover:
                            Remover();
                            break;
                        case Menu.entrada:
                            Entrada();
                            break;
                        case Menu.saida:
                            Saida();
                            break;
                        case Menu.sair:
                            EscolheuSair = true;
                            break;
                    }
                    Console.Clear();
                }
                else
                {
                    EscolheuSair = true;
                }
            }
        }
        static void Listagem()
        {
            if(produtos.Count > 0)
            {
                int id = 0;
                foreach (IEstoque produto in produtos)
                {
                    Console.WriteLine($"ID = {id}");
                    produto.Exibir();
                    id++;
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto cadastrado");
            }
            Console.ReadLine();
        }
        static void Remover()
        {
            Listagem();
            Console.WriteLine("qual produto deseja remover? (id)");
            int id = int.Parse(Console.ReadLine());
            
            if( produtos.Count > 0 && id >= 0 && produtos.Count > id)
            {
                produtos.RemoveAt(id);
                
                Salvar();
            }

            Console.ReadLine();
       }
        static void Entrada()
        {
            Listagem();
            Console.WriteLine("qual produto deseja dar entrada? (id)");
            int id = int.Parse(Console.ReadLine());

            if (produtos.Count > 0 && id >= 0 && produtos.Count > id)
            {
                produtos[id].AddEntrada();

                Salvar();
            }

            Console.ReadLine();
        }
        static void Saida()
        {
            Listagem();
            Console.WriteLine("qual produto deseja dar saida? (id)");
            int id = int.Parse(Console.ReadLine());

            if (produtos.Count > 0 && id >= 0 && produtos.Count > id)
            {
                produtos[id].AddSaida();

                Salvar();
            }
            Console.ReadLine();
        }
        static void Adicionar()
        {
            Console.WriteLine("1-Ebook\n2-Curso\n3-Produto Fisico");
            int intop = int.Parse(Console.ReadLine());

            switch (intop)
            {
                case 1:
                    AdcEbook();
                    break;
                case 2:
                    AdcCurso();
                    break;
                case 3:
                    AdcProdutoFisico();
                    break;
            }
            
        }
        static void AdcEbook()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Autor:");
            string autor = Console.ReadLine();

            Ebook eb = new Ebook(nome, preco, autor);

            produtos.Add(eb);
            Salvar();
        }
        static void AdcCurso()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Autor:");
            string autor = Console.ReadLine();

            Curso cs = new Curso(nome, preco, autor);

            produtos.Add(cs);
            Salvar();
        }
        static void AdcProdutoFisico()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("frete:");
            float frete = float.Parse(Console.ReadLine());

            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);

            produtos.Add(pf);
            Salvar();
        }

        static void Salvar()
        {
            FileStream stream = new FileStream("clientes.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, produtos);

            stream.Close();
        }
        static void Carregar()
        {
            FileStream stream = new FileStream("clientes.dat", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter encoder = new BinaryFormatter();

                produtos = (List<IEstoque>)encoder.Deserialize(stream);

                if(produtos == null)
                {
                    produtos = new List<IEstoque>();
                }
            }
            catch(Exception)
            {
                produtos = new List<IEstoque>();
            }
            stream.Close();
        }
    }
}
