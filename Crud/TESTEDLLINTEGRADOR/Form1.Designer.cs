namespace TESTEDLLINTEGRADOR
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
            this.BtnGerarToken = new System.Windows.Forms.Button();
            this.TxtToken = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGerarToken
            // 
            this.BtnGerarToken.Location = new System.Drawing.Point(171, 86);
            this.BtnGerarToken.Name = "BtnGerarToken";
            this.BtnGerarToken.Size = new System.Drawing.Size(75, 27);
            this.BtnGerarToken.TabIndex = 0;
            this.BtnGerarToken.Text = "Gerar Token";
            this.BtnGerarToken.UseVisualStyleBackColor = true;
            this.BtnGerarToken.Click += new System.EventHandler(this.BtnGerarToken_Click);
            // 
            // TxtToken
            // 
            this.TxtToken.Location = new System.Drawing.Point(128, 128);
            this.TxtToken.Name = "TxtToken";
            this.TxtToken.Size = new System.Drawing.Size(163, 20);
            this.TxtToken.TabIndex = 1;
            this.TxtToken.TextChanged += new System.EventHandler(this.TxtToken_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.BtnSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 219);
            this.panel1.TabIndex = 2;
            // 
            // BtnSair
            // 
            this.BtnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSair.Location = new System.Drawing.Point(0, 192);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(64, 27);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 219);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtToken);
            this.Controls.Add(this.BtnGerarToken);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGerarToken;
        private System.Windows.Forms.TextBox TxtToken;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSair;
    }
}

