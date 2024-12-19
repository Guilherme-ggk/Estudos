using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Forma
    {
        public int X { get; private set; }

        public int Y { get; private set; }

        public int altura { get; set; }

        public int largura { get; set; }

        public int raio { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando para desenhar");
        }

        public virtual void Area()
        {
            int area = altura * largura;
            Console.WriteLine($"Area: {area}");
        }
        
    }

    class Circulo: Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando circulo");
            
        }

        public override void Area()
        {
            double area = 3.14 * (raio * raio);
            Console.WriteLine($"Area circulo {area}");
        }
    }
    class Retangulo : Forma
    {
        public override void Desenhar()
        {
           
            Console.WriteLine("Desenhando retangulo");
            base.Desenhar();

        }

        public override void Area()
        {
            base.Area();
        }
    }
    class Triangulo : Forma
    {
        public override void Desenhar()
        {

            Console.WriteLine("Desenhando triangulo");
            base.Desenhar();

        }

        public override void Area()
        {
            int area = (altura * largura) / 2;
            Console.WriteLine($"Area triangulo {area}");
        }
    }
}
