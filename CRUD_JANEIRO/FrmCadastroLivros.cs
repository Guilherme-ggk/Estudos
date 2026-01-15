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
    public partial class FrmCadastroLivros : Form
    {
        int id;
        Livro livros = new Livro();
        public FrmCadastroLivros(int id)
        {
            InitializeComponent();
            this.id = id;

            if (this.id > 0)
            {
                livros.GetLivro(this.id);

                LblId.Text = livros.Id.ToString();
                TxtIsbn.Text = livros.Titulo.ToString();
                TxtTitulo.Text = livros.Titulo.ToString();
                TxtUnitario.Text = livros.Unitario.ToString("N2");
                TxtSaldo.Text = livros.Saldo_inicial.ToString();
                TxtEstoque.Text = livros.Estoque_minimo.ToString();
                if (livros.Ativo == 'S');
                    
            }
        }
    }
}
