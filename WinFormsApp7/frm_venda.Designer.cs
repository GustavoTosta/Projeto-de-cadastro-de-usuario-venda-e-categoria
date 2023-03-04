namespace WinFormsApp7
{
    partial class frm_venda
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
            this.comBox_Produtos = new System.Windows.Forms.ComboBox();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.bto_Adicionar = new System.Windows.Forms.Button();
            this.bto_Remove = new System.Windows.Forms.Button();
            this.bto_Finalizar = new System.Windows.Forms.Button();
            this.list_Carrinho = new System.Windows.Forms.ListBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.bto_calcular = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comBox_Produtos
            // 
            this.comBox_Produtos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox_Produtos.FormattingEnabled = true;
            this.comBox_Produtos.Items.AddRange(new object[] {
            "Uno",
            "Hot-Wheels",
            "Massinha",
            "Barbie",
            "MaxSteel",
            "Nerf",
            "Cubo Rubrik",
            "Bola",
            "Pião",
            "Arminha d\'Água"});
            this.comBox_Produtos.Location = new System.Drawing.Point(11, 44);
            this.comBox_Produtos.Margin = new System.Windows.Forms.Padding(4);
            this.comBox_Produtos.Name = "comBox_Produtos";
            this.comBox_Produtos.Size = new System.Drawing.Size(154, 29);
            this.comBox_Produtos.TabIndex = 0;
            this.comBox_Produtos.SelectedIndexChanged += new System.EventHandler(this.comBox_Produtos_SelectedIndexChanged);
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Location = new System.Drawing.Point(11, 19);
            this.lbl_produto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(66, 21);
            this.lbl_produto.TabIndex = 1;
            this.lbl_produto.Text = "Produto";
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(250, 44);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(100, 29);
            this.txt_Quantidade.TabIndex = 2;
            this.txt_Quantidade.TextChanged += new System.EventHandler(this.txt_Quantidade_TextChanged);
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(250, 19);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(91, 21);
            this.lbl_quantidade.TabIndex = 3;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // bto_Adicionar
            // 
            this.bto_Adicionar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bto_Adicionar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.bto_Adicionar.FlatAppearance.BorderSize = 0;
            this.bto_Adicionar.Location = new System.Drawing.Point(263, 180);
            this.bto_Adicionar.Name = "bto_Adicionar";
            this.bto_Adicionar.Size = new System.Drawing.Size(110, 46);
            this.bto_Adicionar.TabIndex = 5;
            this.bto_Adicionar.Text = "Adicionar";
            this.bto_Adicionar.UseVisualStyleBackColor = false;
            this.bto_Adicionar.Click += new System.EventHandler(this.bto_Adicionar_Click);
            // 
            // bto_Remove
            // 
            this.bto_Remove.BackColor = System.Drawing.Color.IndianRed;
            this.bto_Remove.Location = new System.Drawing.Point(12, 180);
            this.bto_Remove.Name = "bto_Remove";
            this.bto_Remove.Size = new System.Drawing.Size(110, 46);
            this.bto_Remove.TabIndex = 6;
            this.bto_Remove.Text = "Remover";
            this.bto_Remove.UseVisualStyleBackColor = false;
            this.bto_Remove.Click += new System.EventHandler(this.bto_Remove_Click);
            // 
            // bto_Finalizar
            // 
            this.bto_Finalizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bto_Finalizar.Location = new System.Drawing.Point(278, 426);
            this.bto_Finalizar.Name = "bto_Finalizar";
            this.bto_Finalizar.Size = new System.Drawing.Size(107, 46);
            this.bto_Finalizar.TabIndex = 7;
            this.bto_Finalizar.Text = "Finalizar";
            this.bto_Finalizar.UseVisualStyleBackColor = false;
            this.bto_Finalizar.Click += new System.EventHandler(this.bto_Finalizar_Click);
            // 
            // list_Carrinho
            // 
            this.list_Carrinho.FormattingEnabled = true;
            this.list_Carrinho.ItemHeight = 21;
            this.list_Carrinho.Location = new System.Drawing.Point(7, 249);
            this.list_Carrinho.Name = "list_Carrinho";
            this.list_Carrinho.Size = new System.Drawing.Size(378, 151);
            this.list_Carrinho.TabIndex = 8;
            this.list_Carrinho.SelectedIndexChanged += new System.EventHandler(this.list_Carrinho_SelectedIndexChanged);
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(11, 115);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.ReadOnly = true;
            this.txt_valor.Size = new System.Drawing.Size(153, 29);
            this.txt_valor.TabIndex = 9;
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_TextChanged);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(11, 89);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(106, 21);
            this.lbl_valor.TabIndex = 10;
            this.lbl_valor.Text = "Valor Unitário";
            // 
            // bto_calcular
            // 
            this.bto_calcular.BackColor = System.Drawing.Color.Coral;
            this.bto_calcular.Location = new System.Drawing.Point(140, 180);
            this.bto_calcular.Name = "bto_calcular";
            this.bto_calcular.Size = new System.Drawing.Size(107, 46);
            this.bto_calcular.TabIndex = 12;
            this.bto_calcular.Text = "Calcular";
            this.bto_calcular.UseVisualStyleBackColor = false;
            this.bto_calcular.Click += new System.EventHandler(this.bto_calcular_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(250, 89);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(82, 21);
            this.lbl_total.TabIndex = 13;
            this.lbl_total.Text = "Valor Total";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(250, 115);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(100, 29);
            this.txt_total.TabIndex = 14;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 475);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.bto_calcular);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.list_Carrinho);
            this.Controls.Add(this.bto_Finalizar);
            this.Controls.Add(this.bto_Remove);
            this.Controls.Add(this.bto_Adicionar);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.txt_Quantidade);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.comBox_Produtos);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_venda";
            this.Text = "Venda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_venda_FormClosing);
            this.Load += new System.EventHandler(this.frm_venda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comBox_Produtos;
        private Label lbl_produto;
        private TextBox txt_Quantidade;
        private Label lbl_quantidade;
        private Button bto_Adicionar;
        private Button bto_Remove;
        private Button bto_Finalizar;
        private ListBox list_Carrinho;
        private TextBox txt_valor;
        private Label lbl_valor;
        private Button bto_calcular;
        private Label lbl_total;
        private TextBox txt_total;
    }
}