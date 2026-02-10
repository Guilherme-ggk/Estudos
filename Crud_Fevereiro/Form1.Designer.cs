namespace Crud_Fevereiro
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
            this.DgvLivros = new System.Windows.Forms.DataGridView();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLivros
            // 
            this.DgvLivros.AllowUserToAddRows = false;
            this.DgvLivros.AllowUserToDeleteRows = false;
            this.DgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLivros.Location = new System.Drawing.Point(12, 91);
            this.DgvLivros.Name = "DgvLivros";
            this.DgvLivros.ReadOnly = true;
            this.DgvLivros.Size = new System.Drawing.Size(511, 353);
            this.DgvLivros.TabIndex = 0;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(7, 12);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(86, 25);
            this.BtnAdicionar.TabIndex = 1;
            this.BtnAdicionar.Text = "ADICIONAR";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(108, 12);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(86, 25);
            this.BtnAlterar.TabIndex = 2;
            this.BtnAlterar.Text = "ALTERAR";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(210, 12);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(86, 25);
            this.BtnExcluir.TabIndex = 3;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(311, 12);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(86, 25);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(12, 65);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(506, 20);
            this.TxtBuscar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "busque por titulo ou autores:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.DgvLivros);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.DgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLivros;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
    }
}

