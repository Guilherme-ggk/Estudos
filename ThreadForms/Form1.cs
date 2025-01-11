using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForms
{
    public partial class Form1 : Form
    {
        Thread t; // criamos a Thread na raiz da classe para ser utilizada em todo o contexto



        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Tarefa));// inicializada
            t.IsBackground = true;// definida como Background
        }

        private delegate void AtualizarControle(Control controle, string propriedade, object valor); //Cria o delegate e passa o metodo controle, a propriedade e o valor da prorpiedade que vamos alterar
       

        private void BtnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void BtnContador_Click(object sender, EventArgs e)
        {
            /* while (true)
             {
               LblResultado.Text =  DateTime.Now.Second.ToString();
             }*/

            if (!t.IsAlive)
            {
                t.Start();
            }
        }

        private void Tarefa()
        {
            while (true)
            {
                //LblResultado.Text = DateTime.Now.Second.ToString();
                DefineValor(LblResultado, "Text", DateTime.Now.Second.ToString());
            }
        }


        private void DefineValor(Control controle, string propriedade, object valor) //Criamos o metodo 
        {
            if (controle.InvokeRequired)// que verifica se requer o invoke(precisa do invoke para ser atualizado)
            {
                AtualizarControle d = new AtualizarControle(DefineValor); // criamos o objeto delegate, passamos o proprio metodo aqui de forma recursiva no caso a propriedade e o valor
                controle.Invoke(d, new object[] {controle, propriedade, valor }); // objeto
            }
            else // se nn requer o invoke
            {
                Type TipoDoControle = controle.GetType();// verifica o tipo 
                PropertyInfo[] PropriedadesTipo = TipoDoControle.GetProperties();

                foreach (PropertyInfo p in PropriedadesTipo)// passa pelo array propriedades de tipo
                {
                    if (p.Name.ToUpper() == propriedade.ToUpper())
                    {
                        p.SetValue(controle, valor, null); // retorna o valor
                    }

                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
