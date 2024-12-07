using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_IMC
{
    internal class Program
    {
        struct Cliente
        {
            public string nome;
            public int idade;
            public string email;
        }
        static List<Cliente> clientes = new List<Cliente>();
        enum Menu { lista = 1, adicionar, remover, sair };
        static void Main()
        {
            Carregar();
            bool EscolheuSair = false;
            while (!EscolheuSair)
            {
                Console.WriteLine("Gestor de clientes");
                Console.WriteLine("1-listagem\n2-adicionar\n3-remover\n4-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;

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
                    case Menu.sair:
                        EscolheuSair = true;
                        break;
                }
                Console.Clear();
            }
        }
        static void Listagem()
        {
            if(clientes.Count > 0)
            {
                int id = 0;
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"ID: {id}");
                    Console.WriteLine(cliente.nome);
                    Console.WriteLine(cliente.idade);
                    Console.WriteLine(cliente.email);
                    id++;
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado");
            }
            Console.ReadLine();
        }
        static void Remover()
        {
            Listagem();
            Console.WriteLine("qual cliente deseja remover? (id)");
            int id = int.Parse(Console.ReadLine());
            
            if( clientes.Count > 0 && id >= 0 && clientes.Count > id)
            {
                clientes.RemoveAt(id);
                Salvar();
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado");
            }
        }
        static void Adicionar()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Nome:");
            string nome = cliente.nome;

            Console.WriteLine("Idade:");
            int idade = cliente.idade;

            Console.WriteLine("Email:");
            string email = cliente.email;
            Salvar();

            clientes.Add(cliente);
        }

        static void Salvar()
        {
            FileStream stream = new FileStream("clientes.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, clientes);

            stream.Close();
        }
        static void Carregar()
        {
            FileStream stream = new FileStream("clientes.dat", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter encoder = new BinaryFormatter();

                clientes = (List<Cliente>)encoder.Deserialize(stream);

                if(clientes == null)
                {
                    clientes = new List<Cliente>();
                }
            }
            catch(Exception)
            {
                clientes = new List<Cliente>();
            }
            stream.Close();
        }
    }
}
