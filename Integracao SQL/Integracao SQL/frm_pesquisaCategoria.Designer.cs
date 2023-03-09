namespace Integracao_SQL
{
    partial class frm_pesquisaCategoria
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
            this.DataGrid_categoria = new System.Windows.Forms.DataGridView();
            this.txt_pesquisaData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_categoria
            // 
            this.DataGrid_categoria.AllowUserToAddRows = false;
            this.DataGrid_categoria.AllowUserToDeleteRows = false;
            this.DataGrid_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_categoria.Location = new System.Drawing.Point(12, 39);
            this.DataGrid_categoria.Name = "DataGrid_categoria";
            this.DataGrid_categoria.ReadOnly = true;
            this.DataGrid_categoria.RowTemplate.Height = 25;
            this.DataGrid_categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGrid_categoria.Size = new System.Drawing.Size(882, 409);
            this.DataGrid_categoria.TabIndex = 5;
            this.DataGrid_categoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_categoria_CellContentClick);
            this.DataGrid_categoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_categoria_CellDoubleClick);
            // 
            // txt_pesquisaData
            // 
            this.txt_pesquisaData.Location = new System.Drawing.Point(12, 10);
            this.txt_pesquisaData.Name = "txt_pesquisaData";
            this.txt_pesquisaData.PlaceholderText = "Pesquisa";
            this.txt_pesquisaData.Size = new System.Drawing.Size(882, 23);
            this.txt_pesquisaData.TabIndex = 4;
            this.txt_pesquisaData.TextChanged += new System.EventHandler(this.txt_pesquisaData_TextChanged);
            // 
            // frm_pesquisaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(906, 460);
            this.Controls.Add(this.DataGrid_categoria);
            this.Controls.Add(this.txt_pesquisaData);
            this.Name = "frm_pesquisaCategoria";
            this.Text = "frm_pesquisaCategoria";
            this.Load += new System.EventHandler(this.frm_pesquisaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DataGrid_categoria;
        private TextBox txt_pesquisaData;
    }
}