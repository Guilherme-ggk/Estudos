using System;

namespace WindowsFormsApp2
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
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnConfig = new System.Windows.Forms.Button();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelPrincipal.SuspendLayout();
            this.PanelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelPrincipal.Controls.Add(this.BtnConfig);
            this.PanelPrincipal.Controls.Add(this.BtnSair);
            this.PanelPrincipal.Controls.Add(this.BtnHome);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(116, 450);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(116, 29);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(0, 421);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(116, 29);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnConfig
            // 
            this.BtnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConfig.FlatAppearance.BorderSize = 0;
            this.BtnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfig.ForeColor = System.Drawing.Color.White;
            this.BtnConfig.Location = new System.Drawing.Point(0, 29);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(116, 29);
            this.BtnConfig.TabIndex = 2;
            this.BtnConfig.Text = "Config";
            this.BtnConfig.UseVisualStyleBackColor = true;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // PanelForm
            // 
            this.PanelForm.Controls.Add(this.label1);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(116, 0);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(684, 450);
            this.PanelForm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
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
            this.PanelForm.ResumeLayout(false);
            this.PanelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.Label label1;
    }
}

