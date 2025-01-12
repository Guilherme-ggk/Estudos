using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task parte 1
            //Task t = new Task(Tarefa);
            //t.Start();

            //Task.Factory.StartNew(Tarefa);

            //Task.Run(Tarefa);

            //Task.Run(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Tarefa anonima");
            //    }
            //});

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Principal");
            //}
            #endregion

            #region Task parte 2
            //Task[] tasks =
            //{
            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Tarefa #1");
            //    }),
            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Tarefa #2");
            //    }),
            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Tarefa #3");
            //    })
            //};
            //    Task.WaitAll(tasks);

            //Task t1 = Task.Run(() => { Console.WriteLine("#1"); });
            //Task t2 = Task.Run(() => { Console.WriteLine("#2"); });
            //Task t3 = Task.Run(() => { Console.WriteLine("#3"); });

            //Task.WaitAll(t1, t2, t3);

            //Console.WriteLine("Principal.");
            #endregion

            #region Task parte 3

            //Task<int> tarefa1 = Task.Factory.StartNew(() => Dobro(5));

            //Console.WriteLine(tarefa1.Result);


            Task<int> tarefa2 = Task.Factory.StartNew(() =>
            {
                return new Random().Next(10);
            });

            Task<int> Tarefa3 = tarefa2.ContinueWith((num) =>
            {
                return num.Result * 2;
            });

            Task<string> tarefa4 = Tarefa3.ContinueWith((num) =>
            {
                return "O valor final é:" + num.Result;
            });

            Console.WriteLine(tarefa4.Result);

            #endregion




            Console.ReadKey();
        }
        static int Dobro(int valor)
        {
           return valor * 2;

        }
        static void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa Executada");
            }
        }
    }
}
