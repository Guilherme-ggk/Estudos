namespace CRUD_JANEIRO
{
    partial class FrmCadastro
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
            this.LblId = new System.Windows.Forms.Label();
            this.ChkAtivo = new System.Windows.Forms.CheckBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtAutores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEstoque = new System.Windows.Forms.TextBox();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtIsbn = new System.Windows.Forms.TextBox();
            this.TxtUnitario = new System.Windows.Forms.TextBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblId
            // 
            this.LblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblId.Location = new System.Drawing.Point(38, 26);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(37, 20);
            this.LblId.TabIndex = 1;
            // 
            // ChkAtivo
            // 
            this.ChkAtivo.AutoSize = true;
            this.ChkAtivo.Location = new System.Drawing.Point(12, 191);
            this.ChkAtivo.Name = "ChkAtivo";
            this.ChkAtivo.Size = new System.Drawing.Size(49, 17);
            this.ChkAtivo.TabIndex = 2;
            this.ChkAtivo.Text = "ativo";
            this.ChkAtivo.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(152, 177);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(78, 42);
            this.BtnSalvar.TabIndex = 3;
            this.BtnSalvar.Text = "salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtAutores
            // 
            this.TxtAutores.Location = new System.Drawing.Point(169, 24);
            this.TxtAutores.Name = "TxtAutores";
            this.TxtAutores.Size = new System.Drawing.Size(69, 20);
            this.TxtAutores.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "isbn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "autores:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "saldo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "estoque:";
            // 
            // TxtEstoque
            // 
            this.TxtEstoque.Location = new System.Drawing.Point(68, 141);
            this.TxtEstoque.Name = "TxtEstoque";
            this.TxtEstoque.Size = new System.Drawing.Size(69, 20);
            this.TxtEstoque.TabIndex = 13;
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Location = new System.Drawing.Point(161, 101);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(69, 20);
            this.TxtSaldo.TabIndex = 14;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(45, 101);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(69, 20);
            this.TxtTitulo.TabIndex = 15;
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.Location = new System.Drawing.Point(43, 67);
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(69, 20);
            this.TxtIsbn.TabIndex = 16;
            // 
            // TxtUnitario
            // 
            this.TxtUnitario.Location = new System.Drawing.Point(161, 67);
            this.TxtUnitario.Name = "TxtUnitario";
            this.TxtUnitario.Size = new System.Drawing.Size(69, 20);
            this.TxtUnitario.TabIndex = 17;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(67, 177);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(78, 42);
            this.BtnExcluir.TabIndex = 18;
            this.BtnExcluir.Text = "excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 237);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.TxtUnitario);
            this.Controls.Add(this.TxtIsbn);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.TxtEstoque);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAutores);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.ChkAtivo);
            this.Controls.Add(this.LblId);
            this.Name = "FrmCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.CheckBox ChkAtivo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox TxtAutores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEstoque;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtIsbn;
        private System.Windows.Forms.TextBox TxtUnitario;
        private System.Windows.Forms.Button BtnExcluir;
    }
}