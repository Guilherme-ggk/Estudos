namespace CrudGelt
{
    partial class FormCadastro
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
            this.TxtIsbn = new System.Windows.Forms.TextBox();
            this.TxtAutores = new System.Windows.Forms.TextBox();
            this.TxtEstoque = new System.Windows.Forms.TextBox();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.TxtUnitario = new System.Windows.Forms.TextBox();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChkAtivo = new System.Windows.Forms.CheckBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.Location = new System.Drawing.Point(53, 18);
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(112, 20);
            this.TxtIsbn.TabIndex = 0;
            // 
            // TxtAutores
            // 
            this.TxtAutores.Location = new System.Drawing.Point(80, 114);
            this.TxtAutores.Name = "TxtAutores";
            this.TxtAutores.Size = new System.Drawing.Size(112, 20);
            this.TxtAutores.TabIndex = 1;
            // 
            // TxtEstoque
            // 
            this.TxtEstoque.Location = new System.Drawing.Point(284, 63);
            this.TxtEstoque.Name = "TxtEstoque";
            this.TxtEstoque.Size = new System.Drawing.Size(112, 20);
            this.TxtEstoque.TabIndex = 2;
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Location = new System.Drawing.Point(267, 18);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(112, 20);
            this.TxtSaldo.TabIndex = 3;
            // 
            // TxtUnitario
            // 
            this.TxtUnitario.Location = new System.Drawing.Point(269, 114);
            this.TxtUnitario.Name = "TxtUnitario";
            this.TxtUnitario.Size = new System.Drawing.Size(112, 20);
            this.TxtUnitario.TabIndex = 4;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(67, 63);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(112, 20);
            this.TxtTitulo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TITULO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "AUTORES:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SALDO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ESTOQUE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "PREÇO:";
            // 
            // ChkAtivo
            // 
            this.ChkAtivo.AutoSize = true;
            this.ChkAtivo.Location = new System.Drawing.Point(25, 191);
            this.ChkAtivo.Name = "ChkAtivo";
            this.ChkAtivo.Size = new System.Drawing.Size(58, 17);
            this.ChkAtivo.TabIndex = 12;
            this.ChkAtivo.Text = "ATIVO";
            this.ChkAtivo.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(236, 170);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(88, 30);
            this.BtnSalvar.TabIndex = 13;
            this.BtnSalvar.Text = "SALVAR";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(332, 170);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(88, 30);
            this.BtnExcluir.TabIndex = 14;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // LblId
            // 
            this.LblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblId.Location = new System.Drawing.Point(39, 153);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(35, 20);
            this.LblId.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID:";
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 220);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.ChkAtivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.TxtUnitario);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.TxtEstoque);
            this.Controls.Add(this.TxtAutores);
            this.Controls.Add(this.TxtIsbn);
            this.Name = "FormCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIsbn;
        private System.Windows.Forms.TextBox TxtAutores;
        private System.Windows.Forms.TextBox TxtEstoque;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.TextBox TxtUnitario;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ChkAtivo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label label7;
    }
}