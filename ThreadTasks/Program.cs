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
            tarefa.IsBackground = true; 
            tarefa.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal");
            }


            Console.ReadKey();
        }

        static void Tarefa()
        {
            for (int i = 0; i < 5555; i++)
            {
                Console.WriteLine("Tarefa executada");
            }
        }
    }
}
