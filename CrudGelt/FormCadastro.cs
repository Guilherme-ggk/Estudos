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

        public FormCadastro(int id)
        {
            InitializeComponent();
            this.id = id;
            
        }
    }
}
