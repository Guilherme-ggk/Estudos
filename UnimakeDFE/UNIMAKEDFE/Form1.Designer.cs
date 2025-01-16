namespace UNIMAKEDFE
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnConsultaStatus = new System.Windows.Forms.Button();
            this.BtnConsultaServico = new System.Windows.Forms.Button();
            this.BtnEnvioSincrono = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEnvioSincrono);
            this.groupBox1.Controls.Add(this.BtnConsultaServico);
            this.groupBox1.Controls.Add(this.BtnConsultaStatus);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nfe";
            // 
            // BtnConsultaStatus
            // 
            this.BtnConsultaStatus.Location = new System.Drawing.Point(10, 34);
            this.BtnConsultaStatus.Name = "BtnConsultaStatus";
            this.BtnConsultaStatus.Size = new System.Drawing.Size(178, 31);
            this.BtnConsultaStatus.TabIndex = 0;
            this.BtnConsultaStatus.Text = "Consulta Status";
            this.BtnConsultaStatus.UseVisualStyleBackColor = true;
            this.BtnConsultaStatus.Click += new System.EventHandler(this.BtnConsultaStatus_Click);
            // 
            // BtnConsultaServico
            // 
            this.BtnConsultaServico.Location = new System.Drawing.Point(10, 71);
            this.BtnConsultaServico.Name = "BtnConsultaServico";
            this.BtnConsultaServico.Size = new System.Drawing.Size(178, 31);
            this.BtnConsultaServico.TabIndex = 1;
            this.BtnConsultaServico.Text = "Consulta Serviço";
            this.BtnConsultaServico.UseVisualStyleBackColor = true;
            this.BtnConsultaServico.Click += new System.EventHandler(this.BtnConsultaServico_Click);
            // 
            // BtnEnvioSincrono
            // 
            this.BtnEnvioSincrono.Location = new System.Drawing.Point(8, 202);
            this.BtnEnvioSincrono.Name = "BtnEnvioSincrono";
            this.BtnEnvioSincrono.Size = new System.Drawing.Size(178, 31);
            this.BtnEnvioSincrono.TabIndex = 2;
            this.BtnEnvioSincrono.Text = "EnvioNFe sincrono ";
            this.BtnEnvioSincrono.UseVisualStyleBackColor = true;
            this.BtnEnvioSincrono.Click += new System.EventHandler(this.BtnEnvioSincrono_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnConsultaServico;
        private System.Windows.Forms.Button BtnConsultaStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BtnEnvioSincrono;
    }
}

