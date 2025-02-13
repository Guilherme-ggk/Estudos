using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideMenuC_
{
    public partial class FrmPrincipal : Form
    {
        private Form FrmAtivo; // Declara o objeto, vai controlar o form filho que está aberto dentro do formúlario principal
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FormShow(Form frm) // Método que vai mostrar o formúlario
        {
            ActiveFormClose(); // fecha o formúlario ativo
            FrmAtivo = frm; // recebe o frm que é passado do método Form frm
            frm.TopLevel = false; // precisa ser false para que o PanelForm possa adicionar o frm
           // PanelForm.Controls.Add(frm); // adiciona
            FrmAtivo.BringToFront(); // traz o FrmAtivo para frente 
            frm.Show(); // exibe o frm
        }

        private void ActiveFormClose()
        {
            if(FrmAtivo != null) // verifica se tem outro frm aberto e o fecha para exibir o principal
                FrmAtivo.Close();
            var soma = 1;
        }

        private void ActiveButton(Button FrmAtivo)
        {
            foreach(Control ctrl in PanelPrincipal.Controls) // vai percorrer todos os controles/botões que estão dentro do PanelPrincipal
                ctrl.ForeColor = Color.White; // os controles passam a ser brancos

            FrmAtivo.ForeColor = Color.Red; // quando o botao for acionado vai ficar vermelho
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(BtnHome);
            ActiveFormClose();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            ActiveButton(BtnProdutos);
            FormShow(new FrmProdutos());
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ActiveButton(BtnClientes);
            FormShow(new FrmClientes());
        }

        private void BtnVendedores_Click(object sender, EventArgs e)
        {
            ActiveButton(BtnVendedores);
            FormShow(new FrmVendedores());
        }

        private void opção1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void opção1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FrmVendedores>().Count() == 0)
            {
                FrmVendedores frm = new FrmVendedores();
                frm.MdiParent = this;
                frm.Show(this);
            }
            else
            {
                Application.OpenForms.OfType<FrmVendedores>().First().WindowState = FormWindowState.Normal;
                Application.OpenForms.OfType<FrmVendedores>().First().BringToFront();
            }
        }

        private void opção2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmClientes>().Count() == 0)
            {
                FrmClientes frm = new FrmClientes();
                frm.MdiParent = this;
                frm.Show(this);
            }
            else
            {
                Application.OpenForms.OfType<FrmClientes>().First().WindowState = FormWindowState.Normal;
                Application.OpenForms.OfType<FrmClientes>().First().BringToFront();
            }
        }
    }
}
