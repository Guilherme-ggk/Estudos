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
        bool excluir = false;
        public FormCadastro(int id, bool excluir = false)
        {
            InitializeComponent();
            this.id = id;
            this.excluir = excluir;

            if(this.id > 0)

                livro.GetLivro(this.id);
            {
                LblId.Text = this.id.ToString();
                TxtIsbn.Text = livro.Isbn;
                TxtTitulo.Text = livro.Titulo;
                TxtAutores.Text = livro.Autores;
                TxtUnitario.Text = livro.Unitario.ToString("N2");
                TxtSaldo.Text = livro.Saldo_inicial.ToString();
                TxtEstoque.Text = livro.Estoque_minimo.ToString();
                if (livro.Ativo == 'S')
                    ChkAtivo.Checked = true;
            }

          



            if (this.excluir)
            {
                TravarControles();
                BtnSalvar.Visible = false;
                BtnExcluir.Visible = true;
            }
            else
            {
                BtnSalvar.Visible = true;
                BtnExcluir.Visible = false;
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
            livro.ExcluirLivro();
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            livro.Isbn = TxtIsbn.Text;
            livro.Titulo = TxtTitulo.Text;
            livro.Autores = TxtAutores.Text;
            livro.Unitario = Convert.ToDecimal("0" + livro.Unitario);
            livro.Saldo_inicial = Convert.ToInt32("0" + livro.Saldo_inicial);
            livro.Estoque_minimo = Convert.ToInt32("0" + livro.Estoque_minimo);
            if (ChkAtivo.Checked == true)
                livro.Ativo = 'S';
            else
                livro.Ativo = 'N';

            livro.SalvarLivro();
            this.Close();





        }
    }
}
