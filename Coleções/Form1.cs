using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coleções
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLista_Click(object sender, EventArgs e)
        {   
            listBox1.Items.Clear();

            //Array
            string[] nomes = new string[3];

            nomes[0] = "Guilherme";
            nomes[1] = "A";
            nomes[2] = "Vera";

            //List

            List<string> nomes2 = new List<string>();

            nomes2.Add("Giovana");
            nomes2.Add("Kira");

            nomes2.AddRange(nomes);


            if(nomes2.Remove("Kira"))
            {
                MessageBox.Show("Removido com sucesso");
            }
            else
            {
                MessageBox.Show("Falha em remover Kira");
            }

            if (nomes2.Contains("Giovana"))
            {
                MessageBox.Show("Contém");
            }
            else
            {
                MessageBox.Show("Não contém");
            }

            nomes2.Insert(2, "Marley");

            MessageBox.Show($"A lista contém {nomes2.Count()}");

            MessageBox.Show($"Vera está no indice {nomes2.IndexOf("Vera")}");

            nomes2.Sort();

            /* listBox1.Items.Add(nomes2[0]);
             listBox1.Items.Add(nomes2[1]);
             listBox1.Items.Add(nomes2[2]);
             listBox1.Items.Add(nomes2[3]);
             listBox1.Items.Add(nomes2[4]);*/

           /* foreach (string nome in nomes2)
            {
                listBox1.Items.Add(nome);
            }*/
        }

        private void BtnHashSet_Click(object sender, EventArgs e)
        {
            // HashSet
            // Não deixa repetir itens e nem acessa-los por indices, apenas usando ElementAt

             HashSet<string> veiculos = new HashSet<string>()
              {
                  "carro","moto","avião","barco","helicoptero"
              };

              Console.WriteLine(veiculos.ElementAt(2));
              Console.WriteLine(veiculos.Count());

              if (veiculos.Contains("barco"))
              {
                  Console.WriteLine("Contém");
              }
              else
              {
                  Console.WriteLine("Não Contém");
              }


              if (veiculos.Add("carro"))
              {
                  Console.WriteLine("Adicionado com sucesso");
              }
              else
              {
                  Console.WriteLine("Já existe esse item!");
              }

              foreach (var item in veiculos)
              {
                  Console.WriteLine(item);
              }
        }

        private void BtnDictionary_Click(object sender, EventArgs e)
        {
            //Dictionary

            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                { 80, "Giovana" },
                { 90, "Guilherme" }
            };

            alunos.Add(100, "Kira");

            KeyValuePair<int, string> primeiro = alunos.First();

            MessageBox.Show(primeiro.Key + " " + primeiro.Value);

            if (alunos.ContainsKey(80))
            {
                MessageBox.Show("Contém");
            }
            else
            {
                MessageBox.Show("Não Contém");
            }

            foreach (KeyValuePair<int, string> aluno in alunos)
            {
                listBox1.Items.Add(aluno.Value);
            }
        }

        private void BtnSorted_Click(object sender, EventArgs e)
        {
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                {20,  "C"},
                {15,  "B"},
                {10,  "A"}
            };

            foreach (KeyValuePair<int, string> aluno in alunos.Reverse())
            {
                listBox1.Items.Add(aluno);
            }
        }

        private void BtnSortedDictionary_Click(object sender, EventArgs e)
        {
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            {
                {12,"Giovana"},
                {15,"Guilherme"},
                {20,"Kira" }
            };

            alunos.Add(21, "Cush");

            foreach (KeyValuePair<int, string> aluno in alunos)
            {
                listBox1.Items.Add(aluno);
            }
        }

        private void BtnSortedSet_Click(object sender, EventArgs e)
        {
            SortedSet<string> alunos = new SortedSet<string>()
            {
                "Guilherme",
                "Giovana",
                "Vera"
            };

            alunos.Add("Kira");


             MessageBox.Show( alunos.ElementAt(0));

            foreach(string aluno in alunos.Reverse())
            {
                listBox1.Items.Add(aluno);
            }
        }
    }
}
