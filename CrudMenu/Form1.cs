using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudMenu
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        
        public Form1()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            dt = Livros.GetLivros(true);
            dgvLivros.DataSource = dt;

        }
    }
}
