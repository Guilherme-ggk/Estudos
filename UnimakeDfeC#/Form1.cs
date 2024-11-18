using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unimake.Business.Security;


namespace UnimakeDfeC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConsultaStatus_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsultaSituacao_Click(object sender, EventArgs e)
        {

        }

        #region Certificado digital

        //Caminho do certificado digital A1
        private static string PathCertificadoDigital { get; set; } = @"C:\Unimake\UnimakePV.pfx";

        //Senha do certificado digital 
        private static string SenhaCertificadoDigital { get; set; } = "123456789";

        private static X509Certificate2 CertificadoSelecionadoField; // Todo certificado digital alimenta essa propriedade
        

        public static X509Certificate2 CertificadoSelecionado // trabalho de carregar o certificado
        {
            get // pega 
            {
                if (CertificadoSelecionadoField == null) // se for nulo ele carrega o certificado e senha
                {
                    CertificadoSelecionadoField = new CertificadoDigital().CarregarCertificadoDigitalA1(PathCertificadoDigital, SenhaCertificadoDigital);
                }

                return CertificadoSelecionadoField;
            }

            //diz que não pode carregar manualmente por que ele já vai resgatar de forma automatica
            private set => throw new Exception("Não é possivel atribuir um certificado digital! Somente resgate o valor da propriedade que o certificado é definido automaticamente.");
        }



        #endregion
    }
}
