using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unimake.Business.DFe.Servicos;
using Unimake.Business.DFe.Servicos.NFe;
using Unimake.Business.DFe.Xml.NFe;
using Unimake.Security.Platform;


namespace UNIMAKEDFE
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

        private void BtnConsultaServico_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnvioSincrono_Click(object sender, EventArgs e)
        {
            var xml = new EnviNFe
            {
                Versao = "4.00",
                IdLote = "0000000000000001",
                IndSinc = SimNao.Sim,
                NFe = new List<NFe>
                {
                    new NFe
                    {
                        InfNFe = new List<InfNFe>
                        {
                           new InfNFe
                           {
                               Versao = "4.00",
                               Ide = new Ide
                               {
                                   CUF = UFBrasil.PR,
                                   NatOp = "VENDA",
                                   Mod = ModeloDFe.NFe,
                                   Serie = 1,
                                   NNF = 57972,
                                   DhEmi = DateTime.Now,
                                   DhSaiEnt = DateTime.Now,
                                   TpNF = TipoOperacao.Saida,
                                   IdDest = DestinoOperacao.OperacaoInterestadual,
                                   CMunFG = 4118402,
                                   TpImp = FormatoImpressaoDANFE.NormalRetrato,
                                   TpEmis = TipoEmissao.Normal,
                                   TpAmb = TipoAmbiente.Homologacao,
                                   FinNFe = FinalidadeNFe.Normal,
                                   IndFinal = SimNao.Sim,
                                   IndPres = IndicadorPresenca.OperacaoPresencial,
                                   ProcEmi = ProcessoEmissao.AplicativoContribuinte,
                                   VerProc = "TESTE 1.00"
                               },
                               Emit = new Emit
                               {
                                   CNPJ = "",
                                   XNome = "",
                                   XFant = "",
                                   EnderEmit = new EnderEmit
                                   {
                                       XLgr = "",
                                       Nro = "",
                                       XBairro = "",
                                       CMun = 4118402,
                                       XMun = "",
                                       UF = UFBrasil.PR,
                                       CEP = "",
                                       Fone = ""

                                   },
                                   IE = "",
                                   IM = "",
                                   CNAE = "",
                                   CRT = CRT.SimplesNacional

                               },
                               Dest = new Dest
                               {
                                   CNPJ = "",
                                   XNome = "",
                                   EnderDest = new EnderDest
                                   {
                                       XLgr = "",
                                       Nro = "",
                                       XBairro = "",
                                       CMun = 1,
                                       XMun = "",
                                       UF = UFBrasil.PR,
                                       CEP = "",
                                       Fone = ""
                                   },
                                   IndIEDest = IndicadorIEDestinatario.ContribuinteICMS,
                                   IE = "",
                                   Email = ""
                               },
                               Det = new List<Det>
                               {
                                   new Det
                                   {
                                       NItem = 1,
                                       Prod = new Prod
                                       {
                                           CProd = "",
                                           CEAN = "SEM GTIN",
                                           XProd = "",
                                           NCM = "",
                                           CFOP = "",
                                           UCom = "",
                                           QCom = 1.00m,
                                           VUnCom = 84.9000000000m,
                                           VProd = 84.90,
                                           CEANTrib = "SEM GTIN",
                                           UTrib = "",
                                           QTrib = 1.00m,
                                           VUnTrib = 84.90000000000m,
                                           IndTot = SimNao.Sim,
                                           XPed = "",
                                           NItemPed = "",

                                       }, Imposto = new Imposto
                                       {
                                           VTotTrib = 12.63,
                                           ICMS = new List<ICMS>
                                           {
                                               new ICMS
                                               {
                                                   ICMSSN101 = new ICMSSN101
                                                   {
                                                       Orig = OrigemMercadoria.Nacional,
                                                       PCredSN = 2.8225,
                                                       VCredICMSSN = 2.40,
                                                   }
                                               }
                                           },
                                           PIS = new PIS
                                           {

                                           }
                                       }
                                   }
                               }

                           }
                        }
                    }
                }

            };
        }
    }
}
