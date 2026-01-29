namespace CRUD_JANEIRO
{
    partial class Form1
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
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLivros
            // 
            this.DgvLivros.AllowUserToAddRows = false;
            this.DgvLivros.AllowUserToDeleteRows = false;
            this.DgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLivros.Location = new System.Drawing.Point(3, 103);
            this.DgvLivros.Name = "DgvLivros";
            this.DgvLivros.ReadOnly = true;
            this.DgvLivros.Size = new System.Drawing.Size(794, 342);
            this.DgvLivros.TabIndex = 0;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(12, 21);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(111, 31);
            this.BtnAdicionar.TabIndex = 1;
            this.BtnAdicionar.Text = "ADICIONAR";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(152, 21);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(111, 31);
            this.BtnAlterar.TabIndex = 3;
            this.BtnAlterar.Text = "ALTERAR";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(664, 21);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(111, 31);
            this.BtnFechar.TabIndex = 4;
            this.BtnFechar.Text = "FECHAR";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click_1);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(285, 21);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(111, 31);
            this.BtnExcluir.TabIndex = 5;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(414, 21);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(111, 31);
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(3, 72);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(794, 20);
            this.TxtBuscar.TabIndex = 7;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnFechar);
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
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
    }
}