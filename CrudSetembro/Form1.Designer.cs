namespace CrudSetembro
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnData = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.TxtApi3 = new System.Windows.Forms.TextBox();
            this.BtnApi3 = new System.Windows.Forms.Button();
            this.TxtApi2 = new System.Windows.Forms.TextBox();
            this.BtnApi2 = new System.Windows.Forms.Button();
            this.TxtApi1 = new System.Windows.Forms.TextBox();
            this.BtnApi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnApi4 = new System.Windows.Forms.Button();
            this.TxtApi4 = new System.Windows.Forms.TextBox();
            this.BtnApi5 = new System.Windows.Forms.Button();
            this.TxtApi5 = new System.Windows.Forms.TextBox();
            this.PanelPrincipal.SuspendLayout();
            this.PanelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.BtnExit);
            this.PanelPrincipal.Controls.Add(this.BtnData);
            this.PanelPrincipal.Controls.Add(this.BtnHome);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(162, 450);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnExit.Location = new System.Drawing.Point(0, 66);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(162, 33);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnData
            // 
            this.BtnData.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnData.Location = new System.Drawing.Point(0, 33);
            this.BtnData.Name = "BtnData";
            this.BtnData.Size = new System.Drawing.Size(162, 33);
            this.BtnData.TabIndex = 1;
            this.BtnData.Text = "data";
            this.BtnData.UseVisualStyleBackColor = true;
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(162, 33);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PanelForm
            // 
            this.PanelForm.Controls.Add(this.TxtApi5);
            this.PanelForm.Controls.Add(this.BtnApi5);
            this.PanelForm.Controls.Add(this.TxtApi4);
            this.PanelForm.Controls.Add(this.BtnApi4);
            this.PanelForm.Controls.Add(this.TxtApi3);
            this.PanelForm.Controls.Add(this.BtnApi3);
            this.PanelForm.Controls.Add(this.TxtApi2);
            this.PanelForm.Controls.Add(this.BtnApi2);
            this.PanelForm.Controls.Add(this.TxtApi1);
            this.PanelForm.Controls.Add(this.BtnApi);
            this.PanelForm.Controls.Add(this.label1);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(162, 0);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(638, 450);
            this.PanelForm.TabIndex = 1;
            // 
            // TxtApi3
            // 
            this.TxtApi3.Location = new System.Drawing.Point(22, 170);
            this.TxtApi3.Name = "TxtApi3";
            this.TxtApi3.Size = new System.Drawing.Size(550, 20);
            this.TxtApi3.TabIndex = 6;
            // 
            // BtnApi3
            // 
            this.BtnApi3.Location = new System.Drawing.Point(22, 134);
            this.BtnApi3.Name = "BtnApi3";
            this.BtnApi3.Size = new System.Drawing.Size(67, 30);
            this.BtnApi3.TabIndex = 5;
            this.BtnApi3.Text = "API 3";
            this.BtnApi3.UseVisualStyleBackColor = true;
            this.BtnApi3.Click += new System.EventHandler(this.BtnApi3_Click);
            // 
            // TxtApi2
            // 
            this.TxtApi2.Location = new System.Drawing.Point(22, 108);
            this.TxtApi2.Name = "TxtApi2";
            this.TxtApi2.Size = new System.Drawing.Size(550, 20);
            this.TxtApi2.TabIndex = 4;
            // 
            // BtnApi2
            // 
            this.BtnApi2.Location = new System.Drawing.Point(22, 72);
            this.BtnApi2.Name = "BtnApi2";
            this.BtnApi2.Size = new System.Drawing.Size(67, 30);
            this.BtnApi2.TabIndex = 3;
            this.BtnApi2.Text = "API 2";
            this.BtnApi2.UseVisualStyleBackColor = true;
            this.BtnApi2.Click += new System.EventHandler(this.BtnApi2_Click);
            // 
            // TxtApi1
            // 
            this.TxtApi1.Location = new System.Drawing.Point(22, 46);
            this.TxtApi1.Name = "TxtApi1";
            this.TxtApi1.Size = new System.Drawing.Size(550, 20);
            this.TxtApi1.TabIndex = 2;
            // 
            // BtnApi
            // 
            this.BtnApi.Location = new System.Drawing.Point(22, 12);
            this.BtnApi.Name = "BtnApi";
            this.BtnApi.Size = new System.Drawing.Size(67, 30);
            this.BtnApi.TabIndex = 1;
            this.BtnApi.Text = "API 1";
            this.BtnApi.UseVisualStyleBackColor = true;
            this.BtnApi.Click += new System.EventHandler(this.BtnApi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crud Setembro";
            // 
            // BtnApi4
            // 
            this.BtnApi4.Location = new System.Drawing.Point(22, 196);
            this.BtnApi4.Name = "BtnApi4";
            this.BtnApi4.Size = new System.Drawing.Size(67, 30);
            this.BtnApi4.TabIndex = 7;
            this.BtnApi4.Text = "API 4";
            this.BtnApi4.UseVisualStyleBackColor = true;
            this.BtnApi4.Click += new System.EventHandler(this.BtnApi4_Click);
            // 
            // TxtApi4
            // 
            this.TxtApi4.Location = new System.Drawing.Point(22, 232);
            this.TxtApi4.Name = "TxtApi4";
            this.TxtApi4.Size = new System.Drawing.Size(550, 20);
            this.TxtApi4.TabIndex = 8;
            // 
            // BtnApi5
            // 
            this.BtnApi5.Location = new System.Drawing.Point(22, 258);
            this.BtnApi5.Name = "BtnApi5";
            this.BtnApi5.Size = new System.Drawing.Size(67, 30);
            this.BtnApi5.TabIndex = 9;
            this.BtnApi5.Text = "API 5";
            this.BtnApi5.UseVisualStyleBackColor = true;
            this.BtnApi5.Click += new System.EventHandler(this.BtnApi5_Click);
            // 
            // TxtApi5
            // 
            this.TxtApi5.Location = new System.Drawing.Point(22, 294);
            this.TxtApi5.Name = "TxtApi5";
            this.TxtApi5.Size = new System.Drawing.Size(550, 20);
            this.TxtApi5.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.PanelPrincipal);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            this.PanelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnData;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtApi1;
        private System.Windows.Forms.Button BtnApi;
        private System.Windows.Forms.TextBox TxtApi2;
        private System.Windows.Forms.Button BtnApi2;
        private System.Windows.Forms.TextBox TxtApi3;
        private System.Windows.Forms.Button BtnApi3;
        private System.Windows.Forms.TextBox TxtApi4;
        private System.Windows.Forms.Button BtnApi4;
        private System.Windows.Forms.TextBox TxtApi5;
        private System.Windows.Forms.Button BtnApi5;
    }
}

