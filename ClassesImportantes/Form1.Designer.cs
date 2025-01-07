namespace ClassesImportantes
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.BtnMessageBox = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnAleatorio = new System.Windows.Forms.Button();
            this.BtnTimeSpan = new System.Windows.Forms.Button();
            this.BtnDateTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMessageBox
            // 
            this.BtnMessageBox.Location = new System.Drawing.Point(605, 12);
            this.BtnMessageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMessageBox.Name = "BtnMessageBox";
            this.BtnMessageBox.Size = new System.Drawing.Size(181, 66);
            this.BtnMessageBox.TabIndex = 0;
            this.BtnMessageBox.Text = "Message Box";
            this.BtnMessageBox.UseVisualStyleBackColor = true;
            this.BtnMessageBox.Click += new System.EventHandler(this.BtnMessageBox_Click);
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(12, 9);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(84, 20);
            this.LblResultado.TabIndex = 1;
            this.LblResultado.Text = "resultado";
            // 
            // BtnAleatorio
            // 
            this.BtnAleatorio.Location = new System.Drawing.Point(605, 117);
            this.BtnAleatorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAleatorio.Name = "BtnAleatorio";
            this.BtnAleatorio.Size = new System.Drawing.Size(181, 66);
            this.BtnAleatorio.TabIndex = 3;
            this.BtnAleatorio.Text = "Aleatorio";
            this.BtnAleatorio.UseVisualStyleBackColor = true;
            this.BtnAleatorio.Click += new System.EventHandler(this.BtnAleatorio_Click);
            // 
            // BtnTimeSpan
            // 
            this.BtnTimeSpan.Location = new System.Drawing.Point(605, 203);
            this.BtnTimeSpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTimeSpan.Name = "BtnTimeSpan";
            this.BtnTimeSpan.Size = new System.Drawing.Size(181, 66);
            this.BtnTimeSpan.TabIndex = 4;
            this.BtnTimeSpan.Text = "TIme Span";
            this.BtnTimeSpan.UseVisualStyleBackColor = true;
            this.BtnTimeSpan.Click += new System.EventHandler(this.BtnTimeSpan_Click);
            // 
            // BtnDateTime
            // 
            this.BtnDateTime.Location = new System.Drawing.Point(605, 293);
            this.BtnDateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDateTime.Name = "BtnDateTime";
            this.BtnDateTime.Size = new System.Drawing.Size(181, 66);
            this.BtnDateTime.TabIndex = 7;
            this.BtnDateTime.Text = "Date Time";
            this.BtnDateTime.UseVisualStyleBackColor = true;
            this.BtnDateTime.Click += new System.EventHandler(this.BtnDateTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDateTime);
            this.Controls.Add(this.BtnTimeSpan);
            this.Controls.Add(this.BtnAleatorio);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.BtnMessageBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button BtnMessageBox;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnAleatorio;
        private System.Windows.Forms.Button BtnTimeSpan;
        private System.Windows.Forms.Button BtnDateTime;
    }
}

