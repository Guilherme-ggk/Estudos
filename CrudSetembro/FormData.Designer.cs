namespace CrudSetembro
{
    partial class FormData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvLivros = new System.Windows.Forms.DataGridView();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLivros
            // 
            this.DgvLivros.AllowUserToAddRows = false;
            this.DgvLivros.AllowUserToDeleteRows = false;
            this.DgvLivros.BackgroundColor = System.Drawing.Color.White;
            this.DgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLivros.Location = new System.Drawing.Point(12, 103);
            this.DgvLivros.Name = "DgvLivros";
            this.DgvLivros.ReadOnly = true;
            this.DgvLivros.Size = new System.Drawing.Size(591, 296);
            this.DgvLivros.TabIndex = 0;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(12, 12);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(86, 22);
            this.BtnAdicionar.TabIndex = 1;
            this.BtnAdicionar.Text = "adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(12, 77);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(499, 20);
            this.TxtBuscar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "busque por titulo ou autores:";
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(104, 12);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(86, 22);
            this.BtnAlterar.TabIndex = 4;
            this.BtnAlterar.Text = "alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(196, 12);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(86, 22);
            this.BtnExcluir.TabIndex = 5;
            this.BtnExcluir.Text = "excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(288, 12);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(86, 22);
            this.BtnImprimir.TabIndex = 6;
            this.BtnImprimir.Text = "imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(517, 75);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(86, 22);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 411);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.DgvLivros);
            this.Name = "FormData";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.DgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLivros;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnBuscar;
    }
}