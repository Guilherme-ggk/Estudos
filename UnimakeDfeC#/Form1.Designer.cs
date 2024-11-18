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
            this.BtnConsultaStatus = new System.Windows.Forms.Button();
            this.BtnConsultaSituacao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConsultaStatus
            // 
            this.BtnConsultaStatus.Location = new System.Drawing.Point(6, 34);
            this.BtnConsultaStatus.Name = "BtnConsultaStatus";
            this.BtnConsultaStatus.Size = new System.Drawing.Size(220, 23);
            this.BtnConsultaStatus.TabIndex = 0;
            this.BtnConsultaStatus.Text = "Consulta Status";
            this.BtnConsultaStatus.UseVisualStyleBackColor = true;
            this.BtnConsultaStatus.Click += new System.EventHandler(this.BtnConsultaStatus_Click);
            // 
            // BtnConsultaSituacao
            // 
            this.BtnConsultaSituacao.Location = new System.Drawing.Point(6, 63);
            this.BtnConsultaSituacao.Name = "BtnConsultaSituacao";
            this.BtnConsultaSituacao.Size = new System.Drawing.Size(220, 23);
            this.BtnConsultaSituacao.TabIndex = 1;
            this.BtnConsultaSituacao.Text = "Consulta Situação";
            this.BtnConsultaSituacao.UseVisualStyleBackColor = true;
            this.BtnConsultaSituacao.Click += new System.EventHandler(this.BtnConsultaSituacao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnConsultaStatus);
            this.groupBox1.Controls.Add(this.BtnConsultaSituacao);
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 433);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NFe";
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

        private System.Windows.Forms.Button BtnConsultaStatus;
        private System.Windows.Forms.Button BtnConsultaSituacao;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

