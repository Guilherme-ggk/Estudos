using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Recursivo
    {
        public void Executar(string msg, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(msg, 5);
            }
        }
        public void ExecutarRecursivo(string msg, int n)
        {
            if(n > 0)
            {
                Console.WriteLine(msg);
                ExecutarRecursivo(msg, n - 1);
            }
           
        }
    }
}
