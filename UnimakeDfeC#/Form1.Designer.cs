namespace UnimakeDfeC_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConsultaSituacao = new System.Windows.Forms.Button();
            this.BtnConsultaStatus = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnEnviarNFeSincrono = new System.Windows.Forms.Button();
            this.BtnEnviarNFeAssincrono = new System.Windows.Forms.Button();
            this.BtnEnviarNFeAssincronoLote = new System.Windows.Forms.Button();
            this.BtnInutilizacao = new System.Windows.Forms.Button();
            this.BtnConsultaCadastroContribuinte = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnConsultaCadastroContribuinte);
            this.groupBox1.Controls.Add(this.BtnInutilizacao);
            this.groupBox1.Controls.Add(this.BtnEnviarNFeAssincronoLote);
            this.groupBox1.Controls.Add(this.BtnEnviarNFeAssincrono);
            this.groupBox1.Controls.Add(this.BtnEnviarNFeSincrono);
            this.groupBox1.Controls.Add(this.BtnConsultaSituacao);
            this.groupBox1.Controls.Add(this.BtnConsultaStatus);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 620);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NFe";
            // 
            // BtnConsultaSituacao
            // 
            this.BtnConsultaSituacao.Location = new System.Drawing.Point(3, 90);
            this.BtnConsultaSituacao.Name = "BtnConsultaSituacao";
            this.BtnConsultaSituacao.Size = new System.Drawing.Size(241, 38);
            this.BtnConsultaSituacao.TabIndex = 1;
            this.BtnConsultaSituacao.Text = "Consulta Situação";
            this.BtnConsultaSituacao.UseVisualStyleBackColor = true;
            this.BtnConsultaSituacao.Click += new System.EventHandler(this.BtnConsultaSituacao_Click);
            // 
            // BtnConsultaStatus
            // 
            this.BtnConsultaStatus.Location = new System.Drawing.Point(3, 35);
            this.BtnConsultaStatus.Name = "BtnConsultaStatus";
            this.BtnConsultaStatus.Size = new System.Drawing.Size(241, 38);
            this.BtnConsultaStatus.TabIndex = 0;
            this.BtnConsultaStatus.Text = "Consulta Status";
            this.BtnConsultaStatus.UseVisualStyleBackColor = true;
            this.BtnConsultaStatus.Click += new System.EventHandler(this.BtnConsultaStatus_Click);
            // 
            // BtnEnviarNFeSincrono
            // 
            this.BtnEnviarNFeSincrono.Location = new System.Drawing.Point(3, 214);
            this.BtnEnviarNFeSincrono.Name = "BtnEnviarNFeSincrono";
            this.BtnEnviarNFeSincrono.Size = new System.Drawing.Size(241, 38);
            this.BtnEnviarNFeSincrono.TabIndex = 2;
            this.BtnEnviarNFeSincrono.Text = "Enviar NFe Síncrono";
            this.BtnEnviarNFeSincrono.UseVisualStyleBackColor = true;
            // 
            // BtnEnviarNFeAssincrono
            // 
            this.BtnEnviarNFeAssincrono.Location = new System.Drawing.Point(4, 278);
            this.BtnEnviarNFeAssincrono.Name = "BtnEnviarNFeAssincrono";
            this.BtnEnviarNFeAssincrono.Size = new System.Drawing.Size(241, 38);
            this.BtnEnviarNFeAssincrono.TabIndex = 3;
            this.BtnEnviarNFeAssincrono.Text = "Enviar NFe Assíncrono";
            this.BtnEnviarNFeAssincrono.UseVisualStyleBackColor = true;
            // 
            // BtnEnviarNFeAssincronoLote
            // 
            this.BtnEnviarNFeAssincronoLote.Location = new System.Drawing.Point(3, 340);
            this.BtnEnviarNFeAssincronoLote.Name = "BtnEnviarNFeAssincronoLote";
            this.BtnEnviarNFeAssincronoLote.Size = new System.Drawing.Size(241, 38);
            this.BtnEnviarNFeAssincronoLote.TabIndex = 4;
            this.BtnEnviarNFeAssincronoLote.Text = "Enviar NFe Assíncrono em Lote";
            this.BtnEnviarNFeAssincronoLote.UseVisualStyleBackColor = true;
            // 
            // BtnInutilizacao
            // 
            this.BtnInutilizacao.Location = new System.Drawing.Point(4, 488);
            this.BtnInutilizacao.Name = "BtnInutilizacao";
            this.BtnInutilizacao.Size = new System.Drawing.Size(241, 38);
            this.BtnInutilizacao.TabIndex = 5;
            this.BtnInutilizacao.Text = "Inutilização";
            this.BtnInutilizacao.UseVisualStyleBackColor = true;
            // 
            // BtnConsultaCadastroContribuinte
            // 
            this.BtnConsultaCadastroContribuinte.Location = new System.Drawing.Point(4, 561);
            this.BtnConsultaCadastroContribuinte.Name = "BtnConsultaCadastroContribuinte";
            this.BtnConsultaCadastroContribuinte.Size = new System.Drawing.Size(241, 38);
            this.BtnConsultaCadastroContribuinte.TabIndex = 6;
            this.BtnConsultaCadastroContribuinte.Text = "Consulta Cadastro Contribuinte";
            this.BtnConsultaCadastroContribuinte.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 636);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnConsultaSituacao;
        private System.Windows.Forms.Button BtnConsultaStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BtnConsultaCadastroContribuinte;
        private System.Windows.Forms.Button BtnInutilizacao;
        private System.Windows.Forms.Button BtnEnviarNFeAssincronoLote;
        private System.Windows.Forms.Button BtnEnviarNFeAssincrono;
        private System.Windows.Forms.Button BtnEnviarNFeSincrono;
    }
}

