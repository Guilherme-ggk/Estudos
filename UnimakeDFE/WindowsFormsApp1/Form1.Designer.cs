namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.BtnConfiguracoes = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelPrincipal.Controls.Add(this.BtnSair);
            this.PanelPrincipal.Controls.Add(this.BtnConfiguracoes);
            this.PanelPrincipal.Controls.Add(this.BtnProdutos);
            this.PanelPrincipal.Controls.Add(this.button2);
            this.PanelPrincipal.Controls.Add(this.BtnClientes);
            this.PanelPrincipal.Controls.Add(this.BtnHome);
            this.PanelPrincipal.Controls.Add(this.panel1);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(197, 450);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 84);
            this.panel1.TabIndex = 1;
            // 
            // PanelForm
            // 
            this.PanelForm.Controls.Add(this.label1);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(197, 0);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(603, 450);
            this.PanelForm.TabIndex = 1;
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.BtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(0, 84);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnHome.Size = new System.Drawing.Size(197, 61);
            this.BtnHome.TabIndex = 5;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnClientes.Image")));
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(0, 145);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnClientes.Size = new System.Drawing.Size(197, 61);
            this.BtnClientes.TabIndex = 6;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 206);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(197, 61);
            this.button2.TabIndex = 7;
            this.button2.Text = "Fornecedores";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProdutos.FlatAppearance.BorderSize = 0;
            this.BtnProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.BtnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("BtnProdutos.Image")));
            this.BtnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProdutos.Location = new System.Drawing.Point(0, 267);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnProdutos.Size = new System.Drawing.Size(197, 61);
            this.BtnProdutos.TabIndex = 8;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.UseVisualStyleBackColor = false;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // BtnConfiguracoes
            // 
            this.BtnConfiguracoes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.BtnConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfiguracoes.Image")));
            this.BtnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracoes.Location = new System.Drawing.Point(0, 328);
            this.BtnConfiguracoes.Name = "BtnConfiguracoes";
            this.BtnConfiguracoes.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnConfiguracoes.Size = new System.Drawing.Size(197, 61);
            this.BtnConfiguracoes.TabIndex = 9;
            this.BtnConfiguracoes.Text = "Configurações";
            this.BtnConfiguracoes.UseVisualStyleBackColor = false;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.Location = new System.Drawing.Point(0, 389);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnSair.Size = new System.Drawing.Size(197, 61);
            this.BtnSair.TabIndex = 10;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(174, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Principal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnConfiguracoes;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

