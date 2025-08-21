using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud3._0
{
    public partial class FormCadastro : Form
    {
        int id;
        Livros livro = new Livros();
        bool Excluir = false;
        public FormCadastro(int id, bool excluir = false)
        {
            InitializeComponent();
            this.id = id;
            Excluir = excluir;

            if(livro.Id > 0)
            {
                livro.GetLivro(this.id);

                LblId.Text = livro.Id.ToString();
                TxtIsbn.Text = livro.Isbn.ToString();
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
            }
            else
            {
                BtnExcluir.Visible = false;
                BtnSalvar.Visible = true;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            livro.ExcluirLivro();
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidarForm())
            {
                livro.Isbn = TxtIsbn.Text;
                livro.Titulo = TxtTitulo.Text;
                livro.Autores = TxtAutores.Text;
                livro.Unitario = Convert.ToDecimal(TxtUnitario.Text + "0");
                livro.Saldo_inicial = Convert.ToInt32(TxtSaldo.Text + "0");
                livro.Estoque_minimo = Convert.ToInt32(TxtEstoque.Text + "0");
                if (ChkAtivo.Checked == true)
                    livro.Ativo = 'S';
                else
                    livro.Ativo = 'N';


                livro.SalvarLivro();
                this.Close();
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
            if(TxtTitulo.Text ==  "")
            {
                MessageBox.Show("Adicione o TITULO do livro", Program.sistema);
                TxtTitulo.Focus();
                return false;
            }
            else if (TxtIsbn.Text == "")
            {
                MessageBox.Show("Adicione o ISBN do livro", Program.sistema);
                TxtIsbn.Focus();
                return false;
            }
            else if(TxtAutores.Text == "")
            {
                MessageBox.Show("Adicione o AUTORES do livro", Program.sistema);
                TxtAutores.Focus();
                return false;
            }
            else if (Convert.ToDecimal("" + TxtUnitario.Text) == 0)
            {
                MessageBox.Show("Adicione o UNITARIO do livro", Program.sistema);
                TxtUnitario.Focus();
                return false;
            }
            return true;
        }
    }
}
