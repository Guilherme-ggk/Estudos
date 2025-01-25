namespace CrudMenu
{
    partial class FrmDataBase
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
            this.dvgLivros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgLivros
            // 
            this.dvgLivros.AllowUserToAddRows = false;
            this.dvgLivros.AllowUserToDeleteRows = false;
            this.dvgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLivros.Location = new System.Drawing.Point(12, 63);
            this.dvgLivros.Name = "dvgLivros";
            this.dvgLivros.ReadOnly = true;
            this.dvgLivros.RowHeadersWidth = 51;
            this.dvgLivros.RowTemplate.Height = 24;
            this.dvgLivros.Size = new System.Drawing.Size(1299, 361);
            this.dvgLivros.TabIndex = 0;
            this.dvgLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgLivros_CellContentClick);
            // 
            // FrmDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 507);
            this.Controls.Add(this.dvgLivros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDataBase";
            this.Load += new System.EventHandler(this.FrmDataBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgLivros;
    }
}