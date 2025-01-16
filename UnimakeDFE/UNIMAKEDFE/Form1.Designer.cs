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
            this.BtnEnvioSincrono = new System.Windows.Forms.Button();
            this.BtnConsultaSituacao = new System.Windows.Forms.Button();
            this.BtnConsultaStatus = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEnvioSincrono);
            this.groupBox1.Controls.Add(this.BtnConsultaSituacao);
            this.groupBox1.Controls.Add(this.BtnConsultaStatus);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nfe";
            // 
            // BtnEnvioSincrono
            // 
            this.BtnEnvioSincrono.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEnvioSincrono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnvioSincrono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnvioSincrono.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEnvioSincrono.Location = new System.Drawing.Point(8, 202);
            this.BtnEnvioSincrono.Name = "BtnEnvioSincrono";
            this.BtnEnvioSincrono.Size = new System.Drawing.Size(178, 31);
            this.BtnEnvioSincrono.TabIndex = 2;
            this.BtnEnvioSincrono.Text = "EnvioNFe sincrono ";
            this.BtnEnvioSincrono.UseVisualStyleBackColor = false;
            this.BtnEnvioSincrono.Click += new System.EventHandler(this.BtnEnvioSincrono_Click);
            // 
            // BtnConsultaSituacao
            // 
            this.BtnConsultaSituacao.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnConsultaSituacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaSituacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaSituacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsultaSituacao.Location = new System.Drawing.Point(10, 71);
            this.BtnConsultaSituacao.Name = "BtnConsultaSituacao";
            this.BtnConsultaSituacao.Size = new System.Drawing.Size(178, 31);
            this.BtnConsultaSituacao.TabIndex = 1;
            this.BtnConsultaSituacao.Text = "Consulta Situação";
            this.BtnConsultaSituacao.UseVisualStyleBackColor = false;
            this.BtnConsultaSituacao.Click += new System.EventHandler(this.BtnConsultaSituacao_Click);
            // 
            // BtnConsultaStatus
            // 
            this.BtnConsultaStatus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnConsultaStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsultaStatus.Location = new System.Drawing.Point(10, 34);
            this.BtnConsultaStatus.Name = "BtnConsultaStatus";
            this.BtnConsultaStatus.Size = new System.Drawing.Size(178, 31);
            this.BtnConsultaStatus.TabIndex = 0;
            this.BtnConsultaStatus.Text = "Consulta Status";
            this.BtnConsultaStatus.UseVisualStyleBackColor = false;
            this.BtnConsultaStatus.Click += new System.EventHandler(this.BtnConsultaStatus_Click);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(661, -2);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nightControlBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
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
        private System.Windows.Forms.Button BtnEnvioSincrono;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}

