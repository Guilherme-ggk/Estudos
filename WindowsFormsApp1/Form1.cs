﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unimake.Business.DFe.Servicos.NFe;
using Unimake.Business.DFe.Xml.NF3e;
using Unimake.Business.DFe.Xml.NFe;
using Unimake.Security.Platform;
using ConsStatServ = Unimake.Business.DFe.Xml.NFe.ConsStatServ;
using Unimake.Business.DFe.Servicos;

using Unimake.Business.Security;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConsultaStatus_Click(object sender, EventArgs e)
        {
            var xml = new ConsStatServ
            {
                Versao = "4.00",
                TpAmb = Unimake.Business.DFe.Servicos.TipoAmbiente.Homologacao,
                CUF = Unimake.Business.DFe.Servicos.UFBrasil.PR

            };

            var configuracao = new Configuracao
            {
              TipoEmissao = TipoEmissao.Normal,
              CertificadoDigital = CertificadoSelecionado,
              TipoDFe = TipoDFe.NFe
            };

            var StatusServico = new StatusServico(xml, configuracao);
            StatusServico.Executar();

            MessageBox.Show(StatusServico.Result.CStat + " " + StatusServico.Result.XMotivo);

        }

        private void BtnConsultaSituacao_Click(object sender, EventArgs e)
        {
            var xml = new ConsSitNFe
            {
                Versao = "4.00",
                TpAmb = Unimake.Business.DFe.Servicos.TipoAmbiente.Homologacao,
                ChNFe = "41241135547526000170550010000019261000019274"

            };

            var configuracao = new Configuracao
            {
                TipoEmissao = TipoEmissao.Normal,
                CertificadoDigital = CertificadoSelecionado,
                TipoDFe = TipoDFe.NFe
            };

            var ConsultaProtocolo = new ConsultaProtocolo(xml, configuracao);
            ConsultaProtocolo.Executar();

            MessageBox.Show(ConsultaProtocolo.Result.CStat + " " + ConsultaProtocolo.Result.XMotivo);
        }

        #region
        private static string PathCertificadoDigitalField { get; set; } = "C:\\Users\\30755\\Downloads\\file.p12";
        private static string SenhaCertificadoDigital { get; set; } = "30163001";

        private static X509Certificate2 CertificadoDigitalField;

       public static X509Certificate2 CertificadoSelecionado
        {
            get
            {
                if (CertificadoDigitalField == null) 
                {
                    CertificadoDigitalField = new Unimake.Business.Security.CertificadoDigital().CarregarCertificadoDigitalA1(PathCertificadoDigitalField, SenhaCertificadoDigital);
                }
                return CertificadoDigitalField;
            }
            private set => throw new Exception("não é possivel carregar certificado digital, carragado automaticamente!");
        }
        #endregion
    }
}