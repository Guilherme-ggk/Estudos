using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_JANEIRO
{
    public partial class FrmCadastro : Form
    {
        int id;
        bool Excluir = false;
        Livros livro = new Livros();
        public FrmCadastro(int id, bool excluir = false)
        {
            InitializeComponent();
            this.id = id;
            this.Excluir = excluir;

            if(this.id > 0)
            {
                livro.GetLivro(this.id);

                LblId.Text = livro.Id.ToString();
                TxtIsbn.Text = livro.Isbn.ToString();
                TxtTitulo.Text = livro.Titulo.ToString();
                TxtAutores.Text = livro.Autores.ToString();
                TxtUnitario.Text = livro.Unitario.ToString("N2");
                TxtSaldo.Text = livro.Saldo_inicial.ToString();
                TxtEstoque.Text = livro.Estoque_minimo.ToString();
                if(livro.Ativo == 'S')
                    ChkAtivo.Checked = true;
            }

            if(this.Excluir)
            {
                BtnExcluir.Visible = true;
                BtnSalvar.Visible = false;
                TravarControles();
            }
            else
            {
                BtnExcluir.Visible = false;
                BtnSalvar.Visible = true;
            }
        }


        private void TravarControles()
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



       private bool ValidarForm()
        {
            if(TxtIsbn.Text == "")
            {
                MessageBox.Show("Adicione o ISBN do livro", Program.Sistema);
                TxtIsbn.Focus();
                return false;
            }
            else if (TxtTitulo.Text == "")
            {
                MessageBox.Show("Adicione o TITULO do livro", Program.Sistema);
                TxtTitulo.Focus();
                return false;
            }
            else if (TxtAutores.Text == "")
            {
                MessageBox.Show("Adicione o AUTORES do livro", Program.Sistema);
                TxtAutores.Focus();
                return false;
            }
            else if (TxtUnitario.Text == "")
            {
                MessageBox.Show("Adicione o UNITARIO do livro", Program.Sistema);
                TxtUnitario.Focus();
                return false;
            }
            else
                return true;

        }


        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidarForm())
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
        }
    }
}
