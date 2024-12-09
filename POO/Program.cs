using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aprendendo sobre POO

            MinhaClasse Objeto1 = new MinhaClasse();
            MinhaClasse Objeto2 = Objeto1;


            Classe2 ObjClasse2 = new Classe2();

            //metodo simples

            Classe2 p1 = new Classe2();
            p1.nome = "Guilherme";
            p1.sobrenome = "Henrique";

            p1.Cumprimentar();

            Console.ReadLine();
            
        }


        class MinhaClasse
        {
            
        }



    }
}
