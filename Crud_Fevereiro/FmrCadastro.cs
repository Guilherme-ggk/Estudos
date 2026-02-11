using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Fevereiro
{
    public partial class FmrCadastro : Form
    {
        int id;
        Livros livros = new Livros();
        bool excluirLivro = false;

        public FmrCadastro(int id, bool excluirLivro = false)
        {
            InitializeComponent();
            this.id = id;
            this.excluirLivro = excluirLivro;

            if(this.id > 0)
            {
                livros.GetLivro(this.id);


                LblId.Text = livros.Id.ToString();
                TxtIsbn.Text = livros.Isbn;
                TxtTitulo.Text = livros.Titulo;
                TxtAutores.Text = livros.Autores;
                TxtUnitario.Text = livros.Unitario.ToString("N2");
                TxtSaldo.Text = livros.Saldo_inicial.ToString();
                TxtEstoque.Text = livros.Estoque_minimo.ToString();
                if(livros.Ativo == 'S')
                    ChkAtivo.Checked = true;

                if(this.excluirLivro)
                {
                    TravarControles();
                    BtnExcluir.Visible = true;
                    BtnSalvar.Visible = false;
                }
                else
                {
                    BtnExcluir.Visible = false;
                    BtnSalvar.Visible = true;
                }
            }
        }

        public void TravarControles()
        {
            LblId.Enabled = false;
            TxtIsbn.Enabled = false;
            TxtTitulo.Enabled = false;
            TxtAutores.Enabled = false;
            TxtUnitario.Enabled = false;
            TxtSaldo.Enabled = false;
            TxtEstoque.Enabled = false;
            ChkAtivo.Enabled = false;
        }


        public bool ValidarForm()
        {
            if(TxtIsbn.Text == "")
            {
                MessageBox.Show("Informe o ISBN", Program.Sistema);
                TxtIsbn.Focus();
                return false;
            }
            else if (TxtTitulo.Text == "")
            {
                MessageBox.Show("Informe o TITULO", Program.Sistema);
                TxtTitulo.Focus();
                return false;
            }
            else if (TxtAutores.Text == "")
            {
                MessageBox.Show("Informe o AUTORES", Program.Sistema);
                TxtAutores.Focus();
                return false;
            }
            if (Convert.ToDecimal("" + TxtUnitario.Text) == 0)
            {
                MessageBox.Show("Informe o ISBN", Program.Sistema);
                TxtIsbn.Focus();
                return false;
            }

            return true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidarForm())
            {
                livros.Isbn = TxtIsbn.Text;
                livros.Titulo = TxtTitulo.Text;
                livros.Autores = TxtAutores.Text;
                livros.Unitario = Convert.ToDecimal("0" + TxtUnitario.Text);
                livros.Saldo_inicial = Convert.ToInt32("0" + TxtSaldo.Text);
                livros.Estoque_minimo = Convert.ToInt32("0" + TxtEstoque.Text);
                if (ChkAtivo.Checked == true)
                    livros.Ativo = 'S';
                else
                    livros.Ativo = 'N';

                livros.SalvarLivro();
                this.Close();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            livros.ExcluirLivro();
            this.Close();
        }
    }
}
