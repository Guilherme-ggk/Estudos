using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAgosto
{
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
            Inicializar();
        }

        DataTable dt = new DataTable();

        public void Inicializar()
        {
            dt = Livros.GetLivros(true);
            DgvLivros.DataSource = dt;
        }
    }
}
