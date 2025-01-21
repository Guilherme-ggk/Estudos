namespace SideMenuC_
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnConfig = new System.Windows.Forms.Button();
            this.BtnFornecedores = new System.Windows.Forms.Button();
            this.BtnVendedores = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opção1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opção2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelPrincipal.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.PanelPrincipal.Controls.Add(this.BtnSair);
            this.PanelPrincipal.Controls.Add(this.BtnConfig);
            this.PanelPrincipal.Controls.Add(this.BtnFornecedores);
            this.PanelPrincipal.Controls.Add(this.BtnVendedores);
            this.PanelPrincipal.Controls.Add(this.BtnClientes);
            this.PanelPrincipal.Controls.Add(this.BtnProdutos);
            this.PanelPrincipal.Controls.Add(this.BtnHome);
            this.PanelPrincipal.Controls.Add(this.PanelLogo);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 24);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(233, 502);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // BtnSair
            // 
            this.BtnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.Location = new System.Drawing.Point(0, 449);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnSair.Size = new System.Drawing.Size(233, 60);
            this.BtnSair.TabIndex = 7;
            this.BtnSair.Text = "Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnConfig
            // 
            this.BtnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnConfig.FlatAppearance.BorderSize = 0;
            this.BtnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BtnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfig.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConfig.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfig.Image")));
            this.BtnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfig.Location = new System.Drawing.Point(0, 389);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnConfig.Size = new System.Drawing.Size(233, 60);
            this.BtnConfig.TabIndex = 6;
            this.BtnConfig.Text = "Configurações";
            this.BtnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfig.UseVisualStyleBackColor = true;
            // 
            // BtnFornecedores
            // 
            this.BtnFornecedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFornecedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnFornecedores.FlatAppearance.BorderSize = 0;
            this.BtnFornecedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BtnFornecedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFornecedores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFornecedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("BtnFornecedores.Image")));
            this.BtnFornecedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFornecedores.Location = new System.Drawing.Point(0, 329);
            this.BtnFornecedores.Name = "BtnFornecedores";
            this.BtnFornecedores.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnFornecedores.Size = new System.Drawing.Size(233, 60);
            this.BtnFornecedores.TabIndex = 5;
            this.BtnFornecedores.Text = "Fornecedores";
            this.BtnFornecedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFornecedores.UseVisualStyleBackColor = true;
            // 
            // BtnVendedores
            // 
            this.BtnVendedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVendedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnVendedores.FlatAppearance.BorderSize = 0;
            this.BtnVendedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BtnVendedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVendedores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVendedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnVendedores.Image = ((System.Drawing.Image)(resources.GetObject("BtnVendedores.Image")));
            this.BtnVendedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVendedores.Location = new System.Drawing.Point(0, 269);
            this.BtnVendedores.Name = "BtnVendedores";
            this.BtnVendedores.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnVendedores.Size = new System.Drawing.Size(233, 60);
            this.BtnVendedores.TabIndex = 4;
            this.BtnVendedores.Text = "Vendedores";
            this.BtnVendedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVendedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVendedores.UseVisualStyleBackColor = true;
            this.BtnVendedores.Click += new System.EventHandler(this.BtnVendedores_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnClientes.Image")));
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(0, 209);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnClientes.Size = new System.Drawing.Size(233, 60);
            this.BtnClientes.TabIndex = 3;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProdutos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnProdutos.FlatAppearance.BorderSize = 0;
            this.BtnProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BtnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProdutos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("BtnProdutos.Image")));
            this.BtnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProdutos.Location = new System.Drawing.Point(0, 149);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnProdutos.Size = new System.Drawing.Size(233, 60);
            this.BtnProdutos.TabIndex = 2;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProdutos.UseVisualStyleBackColor = true;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(0, 89);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnHome.Size = new System.Drawing.Size(233, 60);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(233, 89);
            this.PanelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.novoToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opção1ToolStripMenuItem,
            this.opção2ToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // opção1ToolStripMenuItem
            // 
            this.opção1ToolStripMenuItem.Name = "opção1ToolStripMenuItem";
            this.opção1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opção1ToolStripMenuItem.Text = "Opção 1";
            this.opção1ToolStripMenuItem.Click += new System.EventHandler(this.opção1ToolStripMenuItem_Click_1);
            // 
            // opção2ToolStripMenuItem
            // 
            this.opção2ToolStripMenuItem.Name = "opção2ToolStripMenuItem";
            this.opção2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opção2ToolStripMenuItem.Text = "Opção 2";
            this.opção2ToolStripMenuItem.Click += new System.EventHandler(this.opção2ToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 526);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Button BtnVendedores;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.Button BtnFornecedores;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opção1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opção2ToolStripMenuItem;
    }
}

