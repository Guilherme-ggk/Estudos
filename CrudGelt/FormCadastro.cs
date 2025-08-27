using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudGelt
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

            if(this.id > 0)
            {
                livros.GetLivro(this.id);

                LblId.Text = this.id.ToString();
                TxtIsbn.Text = livros.Isbn;
                TxtTitulo.Text = livros.Titulo; 
                TxtAutores.Text = livros.Autores;
                TxtUnitario.Text = livros.Unitario.ToString("N2");
                TxtSaldo.Text = livros.Saldo_inicial.ToString();
                TxtEstoque.Text = livros.Estoque_minimo.ToString();
                if (livros.Ativo == 'S')
                    ChkAtivo.Checked = true;
            }

            if(this.excluir)
            {
                Travar();
                BtnSalvar.Visible = false;
                BtnExcluir.Visible = true;
            }
            else
            {
                BtnSalvar.Visible = true;
                BtnExcluir.Visible = false;
            }
            
        }

        private void Travar()
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
          
            
                livros.Isbn = TxtIsbn.Text;
                livros.Titulo = TxtTitulo.Text;
                livros.Autores = TxtAutores.Text;
                livros.Unitario = Convert.ToDecimal("0" + livros.Unitario);
                livros.Saldo_inicial = Convert.ToInt32("0" + livros.Saldo_inicial);
                livros.Estoque_minimo = Convert.ToInt32("0" + livros.Estoque_minimo);
                if (ChkAtivo.Checked == true)
                    livros.Ativo = 'S';
                else
                    livros.Ativo = 'N';


                livros.SalvarLivro();
                this.Close();
           

           

        }


        private bool ValidarForm()
        {
            if (TxtIsbn.Text == "")
            {
                MessageBox.Show("Informe o ISBN do livro", Program.Sistema);
                TxtIsbn.Focus();
                return false;
            }
            else if (TxtAutores.Text == "")
            {
                MessageBox.Show("Informe o AUTOR do livro", Program.Sistema);
                TxtAutores.Focus();
                return false;
            }
            else if (TxtTitulo.Text == "")
            {
                MessageBox.Show("Informe o TITULO do livro", Program.Sistema);
                TxtTitulo.Focus();
                return false;
            }
            else if (Convert.ToDecimal("0" + TxtUnitario.Text) == 0)
            {
                MessageBox.Show("Informe o UNITARIO do livro", Program.Sistema);
                TxtUnitario.Focus();
                return false;
            }

            else
                return true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            livros.ExcluirLivro();
            this.Close();
        }
    }
}
