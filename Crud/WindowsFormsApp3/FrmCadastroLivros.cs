using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FrmCadastroLivros : Form
    {
        Livros livro = new Livros();
        int id;
        public FrmCadastroLivros(int id)
        {
            InitializeComponent();
            this.id = id;   

            if(this.id > 0)
            {
                livro.GetLivro(this.id);

                LblId.Text = livro.Id.ToString();
                TxtIsbn.Text = livro.Isbn;
                TxtTitulo.Text = livro.Titulo;
                TxtAutores.Text = livro.Autores;
                TxtUnitario.Text = livro.Unitario.ToString("N2");
                TxtSaldo.Text = livro.Saldo_inicial.ToString();
                TxtEstoque.Text = livro.Estoque_minimo.ToString();
                if (ChkAtivo.Checked == true) 
                    livro.Ativo = 'S';
            }
        }

        private void FrmCadastroLivros_Load(object sender, EventArgs e)
        {

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
    }
}
