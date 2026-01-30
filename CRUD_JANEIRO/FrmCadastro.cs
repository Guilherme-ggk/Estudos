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
        Livros livros = new Livros();
        bool excluirLivro = false;
        public FrmCadastro(int id, bool excluirLivro = false)
        {
            InitializeComponent();
            this.id = id;
            this.excluirLivro = excluirLivro;

            if(this.id > 0)
            {
                livros.GetLivro(id);

                LblId.Text = livros.Id.ToString();
                TxtIsbn.Text = livros.Isbn.ToString();
                TxtTitulo.Text = livros.Titulo.ToString();
                TxtAutores.Text = livros.Autores.ToString();
                TxtUnitario.Text = livros.Unitario.ToString();
                TxtSaldo.Text = livros.Saldo_inicial.ToString();
                TxtEstoque.Text = livros.Estoque_minimo.ToString();
                if (livros.Ativo == 'S')
                    ChkAtivo.Checked = true;
            }

            if(this.excluirLivro)
            {
                ValidarForm();
                BtnExcluir.Visible = true;
                BtnSalvar.Visible = false;
            }
            else
            {
                BtnSalvar.Visible = true;
                BtnExcluir.Visible = false;
            }
        }



        private bool ValidarForm()
        {
            if(TxtIsbn.Text == "")
            {
                MessageBox.Show("");
                TxtIsbn.Focus();
                return false;
            }
            else if (TxtTitulo.Text == "")
            {
                MessageBox.Show("");
                TxtTitulo.Focus();
                return false;
            }
            else if (TxtAutores.Text == "")
            {
                MessageBox.Show("");
                TxtAutores.Focus();
                return false;
            }
            else if (Convert.ToDecimal("" + TxtUnitario.Text) == 0)
            {
                MessageBox.Show("");
                TxtUnitario.Focus();
                return false;
            }
            else
                return true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            livros.Isbn = TxtIsbn.Text;

            if (ChkAtivo.Checked == true)
                livros.Ativo = 'S';
            else
                livros.Ativo = 'N';
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            livros.ExcluirLivro();
            this.Close();
        }
    }
}
