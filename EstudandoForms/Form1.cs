﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudandoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Split
            string nomes = "Guilherme Henrique Maximo dos Santos Almeida";

            char[] separador = { ' ' };

            string[] resultado = nomes.Split(separador);

            foreach (string nome in resultado)
            {
                label1.Text = ($"{nome}");
            }


            /*Trim, TrimStart, TrimEnd
            string nome = "      __Guilherme--       ";

            string nova = nome.Trim();

            char[] c = { '_', '-' };


            label1.Text = ">" + nova.Trim(c) + "<";
            */

            /* StartWith, EndWith
            string nome = "Guilherme";
            bool resultado = nome.EndsWith("s", StringComparison.OrdinalIgnoreCase);
            bool resultado2 = nome.StartsWith("s", StringComparison.OrdinalIgnoreCase);

            if(resultado)
            {
                label1.Text = "Positivo";
            }
            else
            {
                label1.Text = "Negativo";
            }*/


            /*string nome = "Guilherme Henrique";

            string parte = nome.Substring(nome.IndexOf(" "), 5);

            label1.Text = parte;

            //int tamanho = nome.Length;

            //label1.Text = $"{tamanho}";

            */


            /*string nome = "Guilherme Henrique";

            string res = nome.Insert(10 , " A ");

            string res2 = nome.Replace("Guilherme", "Giovana");

            label1.Text = res2;*/


            /*string res = "Guilherme Henrique";

           int indice = res.IndexOf('u');
            int indice2 = res.LastIndexOf('u');

            label1.Text = "indice" + indice2;*/




            /* this.Text = "CLICADO";

             int res = 5400;
             bool res2 = false;

             string resultado = res.ToString();
             string resultado2 = res2.ToString();

             label1.Text = resultado2;

             /*if(res.Contains("z"))
             {
                 Console.WriteLine("Contém");
                 label1.Text = "contem";
             }
             else
             {
                 Console.WriteLine("Não contém");
                 label1.Text = "nn contem";
             }*/
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "mudando";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "saiu";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.Text = "entrou";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
