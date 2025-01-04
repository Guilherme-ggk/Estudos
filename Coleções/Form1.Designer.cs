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
            this.BtnDictionary = new System.Windows.Forms.Button();
            this.BtnSorted = new System.Windows.Forms.Button();
            this.BtnSortedDictionary = new System.Windows.Forms.Button();
            this.BtnSortedSet = new System.Windows.Forms.Button();
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
            // BtnDictionary
            // 
            this.BtnDictionary.Location = new System.Drawing.Point(791, 157);
            this.BtnDictionary.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDictionary.Name = "BtnDictionary";
            this.BtnDictionary.Size = new System.Drawing.Size(253, 58);
            this.BtnDictionary.TabIndex = 3;
            this.BtnDictionary.Text = "Dictionary";
            this.BtnDictionary.UseVisualStyleBackColor = true;
            this.BtnDictionary.Click += new System.EventHandler(this.BtnDictionary_Click);
            // 
            // BtnSorted
            // 
            this.BtnSorted.Location = new System.Drawing.Point(791, 236);
            this.BtnSorted.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSorted.Name = "BtnSorted";
            this.BtnSorted.Size = new System.Drawing.Size(253, 58);
            this.BtnSorted.TabIndex = 4;
            this.BtnSorted.Text = "SortedList";
            this.BtnSorted.UseVisualStyleBackColor = true;
            this.BtnSorted.Click += new System.EventHandler(this.BtnSorted_Click);
            // 
            // BtnSortedDictionary
            // 
            this.BtnSortedDictionary.Location = new System.Drawing.Point(791, 302);
            this.BtnSortedDictionary.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSortedDictionary.Name = "BtnSortedDictionary";
            this.BtnSortedDictionary.Size = new System.Drawing.Size(253, 58);
            this.BtnSortedDictionary.TabIndex = 5;
            this.BtnSortedDictionary.Text = "SortedDictionary";
            this.BtnSortedDictionary.UseVisualStyleBackColor = true;
            this.BtnSortedDictionary.Click += new System.EventHandler(this.BtnSortedDictionary_Click);
            // 
            // BtnSortedSet
            // 
            this.BtnSortedSet.Location = new System.Drawing.Point(791, 368);
            this.BtnSortedSet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSortedSet.Name = "BtnSortedSet";
            this.BtnSortedSet.Size = new System.Drawing.Size(253, 58);
            this.BtnSortedSet.TabIndex = 6;
            this.BtnSortedSet.Text = "SortedSet";
            this.BtnSortedSet.UseVisualStyleBackColor = true;
            this.BtnSortedSet.Click += new System.EventHandler(this.BtnSortedSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnSortedSet);
            this.Controls.Add(this.BtnSortedDictionary);
            this.Controls.Add(this.BtnSorted);
            this.Controls.Add(this.BtnDictionary);
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
        private System.Windows.Forms.Button BtnDictionary;
        private System.Windows.Forms.Button BtnSorted;
        private System.Windows.Forms.Button BtnSortedDictionary;
        private System.Windows.Forms.Button BtnSortedSet;
    }
}

