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
        Livros livro = new Livros();
        bool excluirLivros = false;
        public FormCadastro(int id, bool excluirLivros = false)
        {
            InitializeComponent();
            this.id = id;
            this.excluirLivros = excluirLivros;

            if(this.id > 0)
            {

                livro.GetLivro(this.id);

                LblId.Text = livro.Id.ToString();
                TxtIsbn.Text = livro.Isbn;
                TxtTitulo.Text = livro.Titulo;
                TxtAutores.Text = livro.Autores;
                TxtUnitario.Text = livro.Unitario.ToString("n2");
                TxtSaldo.Text = livro.Saldo_inicial.ToString();
                TxtEstoque.Text = livro.Estoque_minimo.ToString();
                if(livro.Ativo == 'S')
                    ChkAtivo.Checked = true;
            }




            if(this.excluirLivros)
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
           
            
                livro.Isbn = TxtIsbn.Text;
                livro.Titulo = TxtTitulo.Text;
                livro.Autores = TxtAutores.Text;
                livro.Unitario = Convert.ToDecimal("0" + TxtUnitario.Text);
                livro.Saldo_inicial = Convert.ToInt32("0" + TxtSaldo.Text);
                livro.Estoque_minimo = Convert.ToInt32("0" + TxtEstoque.Text);
                if (ChkAtivo.Checked == true)
                    livro.Ativo = 'S';
                else
                    livro.Ativo = 'N';

                livro.SalvarLivro();
                this.Close();
            
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            livro.ExcluirLivro();
            this.Close();
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
            if (TxtIsbn.Text == "")
            {
                MessageBox.Show("Insira ISBN", Program.sistema);
                TxtIsbn.Focus();
                return false;
            }
            else if(TxtTitulo.Text == "")
            {
                MessageBox.Show("Insira TITULO", Program.sistema);
                TxtTitulo.Focus();
                return false;
            }
            else if(TxtAutores.Text == "")
            {
                MessageBox.Show("Insira AUTORES", Program.sistema);
                TxtAutores.Focus();
                return false;
            }
            else if (Convert.ToDecimal("0" +TxtUnitario.Text) == 0)
            {
                MessageBox.Show("Insira PREÇO", Program.sistema);
                TxtUnitario.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
