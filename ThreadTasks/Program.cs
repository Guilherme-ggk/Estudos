using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread tarefa = new Thread(Tarefa);
            tarefa.IsBackground = true; //Executa até acabar o principal independente do valor da Tarefa 
            tarefa.Start(); // Inicia a tarefa
            tarefa.Join(); // Dá prioridade primeiro para a Tarefa e deixando a pricipal para depois

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Principal");
                Thread.Sleep(1000);
            }

            
            //Console.ReadKey()
        }

        static void Tarefa()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Tarefa executada");
                Thread.Sleep(500);
            }
        }
    }
}
