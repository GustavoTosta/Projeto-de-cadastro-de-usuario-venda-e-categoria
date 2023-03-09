namespace Integracao_SQL
{
    partial class mdi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdi));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDeCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDeVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(610, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoDeUsuarioToolStripMenuItem,
            this.gerenciamentoDeCadastroToolStripMenuItem,
            this.gerenciamentoDeVendaToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // gerenciamentoDeUsuarioToolStripMenuItem
            // 
            this.gerenciamentoDeUsuarioToolStripMenuItem.Name = "gerenciamentoDeUsuarioToolStripMenuItem";
            this.gerenciamentoDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.gerenciamentoDeUsuarioToolStripMenuItem.Text = "Gerenciamento de Usuario";
            this.gerenciamentoDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoDeUsuarioToolStripMenuItem_Click);
            // 
            // gerenciamentoDeCadastroToolStripMenuItem
            // 
            this.gerenciamentoDeCadastroToolStripMenuItem.Name = "gerenciamentoDeCadastroToolStripMenuItem";
            this.gerenciamentoDeCadastroToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.gerenciamentoDeCadastroToolStripMenuItem.Text = "Gerenciamento de Categoria";
            this.gerenciamentoDeCadastroToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoDeCadastroToolStripMenuItem_Click);
            // 
            // gerenciamentoDeVendaToolStripMenuItem
            // 
            this.gerenciamentoDeVendaToolStripMenuItem.Name = "gerenciamentoDeVendaToolStripMenuItem";
            this.gerenciamentoDeVendaToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.gerenciamentoDeVendaToolStripMenuItem.Text = "Gerenciamento de Venda";
            this.gerenciamentoDeVendaToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoDeVendaToolStripMenuItem_Click);
            // 
            // mdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(610, 303);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mdi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdi";
            this.TransparencyKey = System.Drawing.Color.Firebrick;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mdi_FormClosed);
            this.Load += new System.EventHandler(this.mdi_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem gerenciamentoDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem gerenciamentoDeCadastroToolStripMenuItem;
        private ToolStripMenuItem gerenciamentoDeVendaToolStripMenuItem;
    }
}



