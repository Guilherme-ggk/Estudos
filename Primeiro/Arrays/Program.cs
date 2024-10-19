using System;  
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;
            Console.WriteLine("Conversor de temperatura");
            c = double.Parse(Console.ReadLine());

            f = (c * 9 / 5) + 32;

            k = (273.15);

            Console.WriteLine();

        }
    }
}
