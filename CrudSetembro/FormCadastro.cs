using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudSetembro
{
    public partial class FormCadastro : Form
    {
        int id;
        Livros livros = new Livros();
        bool excluir = false;

        public FormCadastro(int id, bool excluir = false)
        {
            InitializeComponent();
            this.id = id;
            this.excluir = excluir;

            if (this.id > 0)
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
            }

            if(this.excluir)
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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            livros.ExcluirLivro();
            this.Close();
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


        private bool ValidarForm()
        {
            if(TxtIsbn.Text == "")
            {
                MessageBox.Show("insira o ISBN do livro!", Program.sistema);
                TxtIsbn.Focus();
                return false;
            }
            else if(TxtTitulo.Text == "")
            {
                MessageBox.Show("insira o TITULO do livro!", Program.sistema);
                TxtTitulo.Focus();
                return false;
            }
            else if (TxtAutores.Text == "")
            {
                MessageBox.Show("insira o AUTORES do livro!", Program.sistema);
                TxtAutores.Focus();
                return false;
            }
            else if (Convert.ToDecimal("0" + TxtUnitario.Text) == 0)
            {
                MessageBox.Show("insira o PREÇO do livro!", Program.sistema);
                TxtUnitario.Focus();
                return false;
            }

            else

                return true;
        }
    }
}
