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
        Livros livro = new Livros();

        public FrmCadastro(int id)
        {
            InitializeComponent();
            this.id = id;

            if(this.id > 0)
            {
                livro.GetLivro(this.id);
                
                LblId.Text = livro.Id.ToString();
                TxtIsbn.Text = livro.Isbn.ToString();   
                TxtTitulo.Text = livro.Titulo.ToString();
                TxtUnitario.Text = livro.Unitario.ToString();
                TxtSaldo.Text = livro.Saldo_inicial.ToString();
                TxtEstoque.Text = livro.Estoque_minimo.ToString();
                if (livro.Ativo == 'S')
                    ChkAtivo.Checked = true;
            }
        }
    }
}
