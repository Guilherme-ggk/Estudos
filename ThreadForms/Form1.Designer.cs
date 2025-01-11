namespace ThreadForms
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
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnPrincipal = new System.Windows.Forms.Button();
            this.BtnContador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblResultado
            // 
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(7, 4);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(781, 245);
            this.LblResultado.TabIndex = 0;
            this.LblResultado.Text = "Resultado:";
            // 
            // BtnPrincipal
            // 
            this.BtnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrincipal.Location = new System.Drawing.Point(17, 271);
            this.BtnPrincipal.Name = "BtnPrincipal";
            this.BtnPrincipal.Size = new System.Drawing.Size(178, 120);
            this.BtnPrincipal.TabIndex = 1;
            this.BtnPrincipal.Text = "Principal";
            this.BtnPrincipal.UseVisualStyleBackColor = true;
            this.BtnPrincipal.Click += new System.EventHandler(this.BtnPrincipal_Click);
            // 
            // BtnContador
            // 
            this.BtnContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContador.Location = new System.Drawing.Point(592, 271);
            this.BtnContador.Name = "BtnContador";
            this.BtnContador.Size = new System.Drawing.Size(178, 120);
            this.BtnContador.TabIndex = 2;
            this.BtnContador.Text = "Contador";
            this.BtnContador.UseVisualStyleBackColor = true;
            this.BtnContador.Click += new System.EventHandler(this.BtnContador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnContador);
            this.Controls.Add(this.BtnPrincipal);
            this.Controls.Add(this.LblResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnPrincipal;
        private System.Windows.Forms.Button BtnContador;
    }
}

