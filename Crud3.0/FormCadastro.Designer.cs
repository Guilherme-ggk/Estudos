﻿namespace Crud3._0
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
            this.ChkAtivo = new System.Windows.Forms.CheckBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtIsbn = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtUnitario = new System.Windows.Forms.TextBox();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.TxtEstoque = new System.Windows.Forms.TextBox();
            this.TxtAutores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChkAtivo
            // 
            this.ChkAtivo.AutoSize = true;
            this.ChkAtivo.Location = new System.Drawing.Point(12, 196);
            this.ChkAtivo.Name = "ChkAtivo";
            this.ChkAtivo.Size = new System.Drawing.Size(50, 17);
            this.ChkAtivo.TabIndex = 0;
            this.ChkAtivo.Text = "Ativo";
            this.ChkAtivo.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(273, 182);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(63, 31);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.Location = new System.Drawing.Point(50, 43);
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(94, 20);
            this.TxtIsbn.TabIndex = 2;
            // 
            // LblId
            // 
            this.LblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblId.Location = new System.Drawing.Point(36, 8);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(35, 20);
            this.LblId.TabIndex = 3;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(192, 182);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(63, 31);
            this.BtnExcluir.TabIndex = 4;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SALDO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "PREÇO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "TITULO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "AUTORES:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ESTOQUE:";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(61, 85);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(94, 20);
            this.TxtTitulo.TabIndex = 12;
            // 
            // TxtUnitario
            // 
            this.TxtUnitario.Location = new System.Drawing.Point(242, 124);
            this.TxtUnitario.Name = "TxtUnitario";
            this.TxtUnitario.Size = new System.Drawing.Size(94, 20);
            this.TxtUnitario.TabIndex = 13;
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Location = new System.Drawing.Point(229, 82);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(94, 20);
            this.TxtSaldo.TabIndex = 14;
            // 
            // TxtEstoque
            // 
            this.TxtEstoque.Location = new System.Drawing.Point(229, 43);
            this.TxtEstoque.Name = "TxtEstoque";
            this.TxtEstoque.Size = new System.Drawing.Size(94, 20);
            this.TxtEstoque.TabIndex = 15;
            // 
            // TxtAutores
            // 
            this.TxtAutores.Location = new System.Drawing.Point(77, 124);
            this.TxtAutores.Name = "TxtAutores";
            this.TxtAutores.Size = new System.Drawing.Size(94, 20);
            this.TxtAutores.TabIndex = 16;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 222);
            this.Controls.Add(this.TxtAutores);
            this.Controls.Add(this.TxtEstoque);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.TxtUnitario);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.TxtIsbn);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.ChkAtivo);
            this.Name = "FormCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkAtivo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox TxtIsbn;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtUnitario;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.TextBox TxtEstoque;
        private System.Windows.Forms.TextBox TxtAutores;
    }
}