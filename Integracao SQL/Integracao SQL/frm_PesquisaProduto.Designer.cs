namespace Integracao_SQL
{
    partial class frm_PesquisaProduto
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
            this.DataGrid_Produto = new System.Windows.Forms.DataGridView();
            this.txt_pesquisaData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Produto)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Produto
            // 
            this.DataGrid_Produto.AllowUserToAddRows = false;
            this.DataGrid_Produto.AllowUserToDeleteRows = false;
            this.DataGrid_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Produto.Location = new System.Drawing.Point(12, 39);
            this.DataGrid_Produto.Name = "DataGrid_Produto";
            this.DataGrid_Produto.ReadOnly = true;
            this.DataGrid_Produto.RowTemplate.Height = 25;
            this.DataGrid_Produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGrid_Produto.Size = new System.Drawing.Size(776, 399);
            this.DataGrid_Produto.TabIndex = 5;
            this.DataGrid_Produto.DoubleClick += new System.EventHandler(this.DataGrid_Produto_DoubleClick);
            // 
            // txt_pesquisaData
            // 
            this.txt_pesquisaData.Location = new System.Drawing.Point(12, 10);
            this.txt_pesquisaData.Name = "txt_pesquisaData";
            this.txt_pesquisaData.PlaceholderText = "Pesquisa";
            this.txt_pesquisaData.Size = new System.Drawing.Size(776, 23);
            this.txt_pesquisaData.TabIndex = 4;
            // 
            // frm_PesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGrid_Produto);
            this.Controls.Add(this.txt_pesquisaData);
            this.Name = "frm_PesquisaProduto";
            this.Text = "frm_PesquisaProduto";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DataGrid_Produto;
        private TextBox txt_pesquisaData;
    }
}