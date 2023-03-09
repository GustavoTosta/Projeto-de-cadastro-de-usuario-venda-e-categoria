namespace Integracao_SQL
{
    partial class FrmPesquisaUsuario
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
            this.DataGrid_usuario = new System.Windows.Forms.DataGridView();
            this.txt_pesquisaData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_usuario
            // 
            this.DataGrid_usuario.AllowUserToAddRows = false;
            this.DataGrid_usuario.AllowUserToDeleteRows = false;
            this.DataGrid_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_usuario.Location = new System.Drawing.Point(12, 40);
            this.DataGrid_usuario.Name = "DataGrid_usuario";
            this.DataGrid_usuario.ReadOnly = true;
            this.DataGrid_usuario.RowTemplate.Height = 25;
            this.DataGrid_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGrid_usuario.Size = new System.Drawing.Size(776, 399);
            this.DataGrid_usuario.TabIndex = 3;
            this.DataGrid_usuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_usuario_CellContentClick);
            this.DataGrid_usuario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_usuario_CellContentDoubleClick);
            this.DataGrid_usuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_usuario_CellDoubleClick);
            // 
            // txt_pesquisaData
            // 
            this.txt_pesquisaData.Location = new System.Drawing.Point(12, 11);
            this.txt_pesquisaData.Name = "txt_pesquisaData";
            this.txt_pesquisaData.PlaceholderText = "Pesquisa";
            this.txt_pesquisaData.Size = new System.Drawing.Size(776, 23);
            this.txt_pesquisaData.TabIndex = 2;
            this.txt_pesquisaData.TextChanged += new System.EventHandler(this.txt_pesquisaData_TextChanged);
            // 
            // FrmPesquisaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGrid_usuario);
            this.Controls.Add(this.txt_pesquisaData);
            this.Name = "FrmPesquisaUsuario";
            this.Text = "FrmPesquisaUsuario";
            this.Load += new System.EventHandler(this.FrmPesquisaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DataGrid_usuario;
        private TextBox txt_pesquisaData;
    }
}