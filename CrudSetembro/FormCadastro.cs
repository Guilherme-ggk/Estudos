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
            {
                LblId.Text = this.id.ToString();
                TxtIsbn.Text = livro.Isbn;
                TxtTitulo.Text = livro.Titulo;
                TxtAutores.Text = livro.Autores;
                TxtUnitario.Text = livro.Unitario.ToString("n2");
                TxtSaldo.Text = livro.Saldo_inicial.ToString();
                TxtEstoque.Text = livro.Estoque_minimo.ToString();
                if(livro.Ativo == 'S')
                    ChkAtivo.Checked = true;
            }
        }
    }
}
