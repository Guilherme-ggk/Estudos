namespace Coleções
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
            this.BtnLista = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnHashSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLista
            // 
            this.BtnLista.Location = new System.Drawing.Point(791, 16);
            this.BtnLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLista.Name = "BtnLista";
            this.BtnLista.Size = new System.Drawing.Size(253, 58);
            this.BtnLista.TabIndex = 0;
            this.BtnLista.Text = "List";
            this.BtnLista.UseVisualStyleBackColor = true;
            this.BtnLista.Click += new System.EventHandler(this.BtnLista_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(11, 16);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(761, 454);
            this.listBox1.TabIndex = 1;
            // 
            // BtnHashSet
            // 
            this.BtnHashSet.Location = new System.Drawing.Point(791, 82);
            this.BtnHashSet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHashSet.Name = "BtnHashSet";
            this.BtnHashSet.Size = new System.Drawing.Size(253, 58);
            this.BtnHashSet.TabIndex = 2;
            this.BtnHashSet.Text = "HashSet";
            this.BtnHashSet.UseVisualStyleBackColor = true;
            this.BtnHashSet.Click += new System.EventHandler(this.BtnHashSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnHashSet);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnLista);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coleções";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLista;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnHashSet;
    }
}

