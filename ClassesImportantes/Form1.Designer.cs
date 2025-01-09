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
            this.BtnColors = new System.Windows.Forms.Button();
            this.BtnFont = new System.Windows.Forms.Button();
            this.BtnApp = new System.Windows.Forms.Button();
            this.BtnEnvironment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMessageBox
            // 
            this.BtnMessageBox.Location = new System.Drawing.Point(454, 10);
            this.BtnMessageBox.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMessageBox.Name = "BtnMessageBox";
            this.BtnMessageBox.Size = new System.Drawing.Size(136, 54);
            this.BtnMessageBox.TabIndex = 0;
            this.BtnMessageBox.Text = "Message Box";
            this.BtnMessageBox.UseVisualStyleBackColor = true;
            this.BtnMessageBox.Click += new System.EventHandler(this.BtnMessageBox_Click);
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(9, 7);
            this.LblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(84, 20);
            this.LblResultado.TabIndex = 1;
            this.LblResultado.Text = "resultado";
            // 
            // BtnAleatorio
            // 
            this.BtnAleatorio.Location = new System.Drawing.Point(454, 95);
            this.BtnAleatorio.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAleatorio.Name = "BtnAleatorio";
            this.BtnAleatorio.Size = new System.Drawing.Size(136, 54);
            this.BtnAleatorio.TabIndex = 3;
            this.BtnAleatorio.Text = "Aleatorio";
            this.BtnAleatorio.UseVisualStyleBackColor = true;
            this.BtnAleatorio.Click += new System.EventHandler(this.BtnAleatorio_Click);
            // 
            // BtnTimeSpan
            // 
            this.BtnTimeSpan.Location = new System.Drawing.Point(454, 165);
            this.BtnTimeSpan.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTimeSpan.Name = "BtnTimeSpan";
            this.BtnTimeSpan.Size = new System.Drawing.Size(136, 54);
            this.BtnTimeSpan.TabIndex = 4;
            this.BtnTimeSpan.Text = "TIme Span";
            this.BtnTimeSpan.UseVisualStyleBackColor = true;
            this.BtnTimeSpan.Click += new System.EventHandler(this.BtnTimeSpan_Click);
            // 
            // BtnDateTime
            // 
            this.BtnDateTime.Location = new System.Drawing.Point(454, 238);
            this.BtnDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDateTime.Name = "BtnDateTime";
            this.BtnDateTime.Size = new System.Drawing.Size(136, 54);
            this.BtnDateTime.TabIndex = 7;
            this.BtnDateTime.Text = "Date Time";
            this.BtnDateTime.UseVisualStyleBackColor = true;
            this.BtnDateTime.Click += new System.EventHandler(this.BtnDateTime_Click);
            // 
            // BtnColors
            // 
            this.BtnColors.Location = new System.Drawing.Point(454, 301);
            this.BtnColors.Margin = new System.Windows.Forms.Padding(2);
            this.BtnColors.Name = "BtnColors";
            this.BtnColors.Size = new System.Drawing.Size(136, 54);
            this.BtnColors.TabIndex = 8;
            this.BtnColors.Text = "Colors";
            this.BtnColors.UseVisualStyleBackColor = true;
            this.BtnColors.Click += new System.EventHandler(this.BtnColors_Click);
            // 
            // BtnFont
            // 
            this.BtnFont.Location = new System.Drawing.Point(303, 301);
            this.BtnFont.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFont.Name = "BtnFont";
            this.BtnFont.Size = new System.Drawing.Size(136, 54);
            this.BtnFont.TabIndex = 9;
            this.BtnFont.Text = "Font";
            this.BtnFont.UseVisualStyleBackColor = true;
            this.BtnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // BtnApp
            // 
            this.BtnApp.Location = new System.Drawing.Point(149, 301);
            this.BtnApp.Margin = new System.Windows.Forms.Padding(2);
            this.BtnApp.Name = "BtnApp";
            this.BtnApp.Size = new System.Drawing.Size(136, 54);
            this.BtnApp.TabIndex = 10;
            this.BtnApp.Text = "Application";
            this.BtnApp.UseVisualStyleBackColor = true;
            this.BtnApp.Click += new System.EventHandler(this.BtnApp_Click);
            // 
            // BtnEnvironment
            // 
            this.BtnEnvironment.Location = new System.Drawing.Point(303, 243);
            this.BtnEnvironment.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEnvironment.Name = "BtnEnvironment";
            this.BtnEnvironment.Size = new System.Drawing.Size(136, 54);
            this.BtnEnvironment.TabIndex = 11;
            this.BtnEnvironment.Text = "Environment";
            this.BtnEnvironment.UseVisualStyleBackColor = true;
            this.BtnEnvironment.Click += new System.EventHandler(this.BtnEnvironment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BtnEnvironment);
            this.Controls.Add(this.BtnApp);
            this.Controls.Add(this.BtnFont);
            this.Controls.Add(this.BtnColors);
            this.Controls.Add(this.BtnDateTime);
            this.Controls.Add(this.BtnTimeSpan);
            this.Controls.Add(this.BtnAleatorio);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.BtnMessageBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button BtnColors;
        private System.Windows.Forms.Button BtnFont;
        private System.Windows.Forms.Button BtnApp;
        private System.Windows.Forms.Button BtnEnvironment;
    }
}

