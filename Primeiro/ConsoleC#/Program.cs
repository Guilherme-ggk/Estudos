﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleC_
{
    

internal class Program
    {
        static void Main(string[] args)
        {
            #region Comentarios e regions
            //Comentários 
            //são feitos para organizar o código, documentar o que
            //cada parte faz para ajudar possiveis outros programadores de equipe

            //Comentario

            //#Region
            //Feito tbm para organizar os blocos de código
            //documentar e deixar nomes para cada bloco
            #endregion

            #region Executa um linha de comando

            Console.WriteLine("Hello Word!");

            #endregion

            #region Tipos numericos
            //Tipos Numericos

            //Numeros assinados, variaveis que suportando numeros negativos

            int n = 1;
            long t = 1;

            //Numeros sem sinal, variaveis que não suportam numeros negativos

            uint u = 0;
            ulong v = 0;

            // tipo string

            string nome = "Giovana";

            //char = "Representa a quantidade de caracteres de uma palavra";

            //tipo bool 

            bool escolheu_Sair = false;

            bool escolheu_Ficar = true;

            // tipo var 

            var a = 1;
            var b = "nome";
            var verdade = false;
            var flut = 10f;

            // comporta qualquer tipo de dado, fazendo seu papel até
            // o final da execução

            // tipo object

            //originario da lib object, ele é como var, mas ele não os trata como seus tipos, 
            //tudo que vai em object, vira um objeto, ele é a base de todas as variaveis

            object alea = null;
            object num1 = 20;
            #endregion

            //Enum 
             enum Menu
        {
            notaBoa = 1,
            notaMédia = 2, // Usados mais para Menus, e escolhas
            notaZero = 3
        };

        //estruturas ou structs

        struct Clientes
        {
            public string nome;
            public int idade;           //bom para armazenar variaveis e objetos de pequeno uso no  projeto
            public double altura;       //é similar com as classes mas uma struct não trabalha com heranças e variaveis longas
        }

        //Lists 

      
            List<int> numeros = new List<int>();
            numeros.Add(1);
            Console


            //Entrada e Saída de Dados

            in e out
            //entrada > processamento > saida
                      //armazenamento


            // Conversão implicita

            //conversão implicita, desde que o tipo  suporte o valor, vai passar normal
            //exemplo:

            float n = 100f;
            double n2 = n;

            Console.WriteLine(n2);

            //Conversão explicita ou (Quest)

            // a conversão é feita até o maximo que o método suporta, por exemplo, se byte suporta 244, e tentar converter 100, vai dar 100, mas se fo

            enum Menu { };
        int intop = 0;
        int z = (Menu)intop;

        //classe convert

        string num = Convert.ToString(200);

        double num1 = Convert.ToDouble(false);

        int num2 = Convert.ToInt32("C");

        Console.WriteLine(num2);
        Console.ReadKey();

        // a conversão implicita é automatica e não há riscos de perder dados, já a explicite tem esse risco
        // o metodo parse pode converter varios tipos


            //Arrays

            //criando um array

            int[] numeros[2] = 10,11; 


                







    }
}
}
