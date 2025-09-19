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
        public FormCadastro(int id)
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
                TxtUnitario.Text = livro.Unitario.ToString("n2");
                TxtSaldo.Text = livro.Saldo_inicial.ToString();
                TxtEstoque.Text = livro.Estoque_minimo.ToString();
                livro.Ativo = 'S';
                ChkAtivo.Checked = true;



            }
        }
    }
}
