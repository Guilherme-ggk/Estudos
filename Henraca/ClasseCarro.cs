﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henraca
{
    internal class ClasseCarro : Veiculo
    {
        public int VelocidadeMaxima {get; set;}
        public void LigarMotor()
        {
            Console.WriteLine("Motor ligado");
        }
        public override void Acelerar()
        {
            Console.WriteLine("Acelerou o carro!");
        }
    }
}