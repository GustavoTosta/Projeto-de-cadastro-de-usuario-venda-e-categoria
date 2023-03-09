namespace Integracao_SQL
{
    partial class frm_produto
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
            this.grupo_1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.NumericUpDown();
            this.bto_codigo = new System.Windows.Forms.Button();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.grupo_2 = new System.Windows.Forms.GroupBox();
            this.cbo_nomeCategoria = new System.Windows.Forms.ComboBox();
            this.cbo_IDCategoria = new System.Windows.Forms.ComboBox();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_nomeCategoria = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.NumericUpDown();
            this.txt_datahora = new System.Windows.Forms.MaskedTextBox();
            this.lbl_datahora = new System.Windows.Forms.Label();
            this.txt_UnidadeMedida = new System.Windows.Forms.TextBox();
            this.lbl_unidadeMedida = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_codigoCategoria = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.grupo_3 = new System.Windows.Forms.GroupBox();
            this.txt_valorVenda = new System.Windows.Forms.TextBox();
            this.lbl_valorVenda = new System.Windows.Forms.Label();
            this.txt_valorcusto = new System.Windows.Forms.TextBox();
            this.lbl_valorCusto = new System.Windows.Forms.Label();
            this.grupo_4 = new System.Windows.Forms.GroupBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.lbl_obs = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bto_excluirCategoria = new System.Windows.Forms.Button();
            this.bto_CadastrarCategoria = new System.Windows.Forms.Button();
            this.bto_AlterarCategoria = new System.Windows.Forms.Button();
            this.bto_limparCategoria = new System.Windows.Forms.Button();
            this.bto_sairCategoria = new System.Windows.Forms.Button();
            this.grupo_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo)).BeginInit();
            this.grupo_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantidade)).BeginInit();
            this.grupo_3.SuspendLayout();
            this.grupo_4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo_1
            // 
            this.grupo_1.Controls.Add(this.button1);
            this.grupo_1.Controls.Add(this.button2);
            this.grupo_1.Controls.Add(this.txt_codigo);
            this.grupo_1.Controls.Add(this.bto_codigo);
            this.grupo_1.Controls.Add(this.lbl_codigo);
            this.grupo_1.Location = new System.Drawing.Point(18, 7);
            this.grupo_1.Name = "grupo_1";
            this.grupo_1.Size = new System.Drawing.Size(501, 74);
            this.grupo_1.TabIndex = 0;
            this.grupo_1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(13, 34);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(93, 23);
            this.txt_codigo.TabIndex = 5;
            this.txt_codigo.ValueChanged += new System.EventHandler(this.txt_codigo_ValueChanged);
            // 
            // bto_codigo
            // 
            this.bto_codigo.Location = new System.Drawing.Point(119, 34);
            this.bto_codigo.Name = "bto_codigo";
            this.bto_codigo.Size = new System.Drawing.Size(75, 23);
            this.bto_codigo.TabIndex = 2;
            this.bto_codigo.Text = "Pesquisar";
            this.bto_codigo.UseVisualStyleBackColor = true;
            this.bto_codigo.Click += new System.EventHandler(this.bto_codigo_Click);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(13, 17);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(46, 15);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código";
            // 
            // grupo_2
            // 
            this.grupo_2.Controls.Add(this.cbo_nomeCategoria);
            this.grupo_2.Controls.Add(this.cbo_IDCategoria);
            this.grupo_2.Controls.Add(this.cbo_status);
            this.grupo_2.Controls.Add(this.lbl_status);
            this.grupo_2.Controls.Add(this.lbl_nomeCategoria);
            this.grupo_2.Controls.Add(this.txt_quantidade);
            this.grupo_2.Controls.Add(this.txt_datahora);
            this.grupo_2.Controls.Add(this.lbl_datahora);
            this.grupo_2.Controls.Add(this.txt_UnidadeMedida);
            this.grupo_2.Controls.Add(this.lbl_unidadeMedida);
            this.grupo_2.Controls.Add(this.txt_peso);
            this.grupo_2.Controls.Add(this.lbl_peso);
            this.grupo_2.Controls.Add(this.lbl_quantidade);
            this.grupo_2.Controls.Add(this.lbl_codigoCategoria);
            this.grupo_2.Controls.Add(this.txt_nome);
            this.grupo_2.Controls.Add(this.lbl_nome);
            this.grupo_2.Location = new System.Drawing.Point(18, 101);
            this.grupo_2.Name = "grupo_2";
            this.grupo_2.Size = new System.Drawing.Size(522, 147);
            this.grupo_2.TabIndex = 1;
            this.grupo_2.TabStop = false;
            this.grupo_2.Enter += new System.EventHandler(this.grupo_2_Enter);
            // 
            // cbo_nomeCategoria
            // 
            this.cbo_nomeCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nomeCategoria.FormattingEnabled = true;
            this.cbo_nomeCategoria.Location = new System.Drawing.Point(389, 35);
            this.cbo_nomeCategoria.Name = "cbo_nomeCategoria";
            this.cbo_nomeCategoria.Size = new System.Drawing.Size(121, 23);
            this.cbo_nomeCategoria.TabIndex = 16;
            // 
            // cbo_IDCategoria
            // 
            this.cbo_IDCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_IDCategoria.FormattingEnabled = true;
            this.cbo_IDCategoria.Location = new System.Drawing.Point(244, 35);
            this.cbo_IDCategoria.Name = "cbo_IDCategoria";
            this.cbo_IDCategoria.Size = new System.Drawing.Size(121, 23);
            this.cbo_IDCategoria.TabIndex = 15;
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbo_status.Location = new System.Drawing.Point(389, 95);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(121, 23);
            this.cbo_status.TabIndex = 1;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(389, 77);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(39, 15);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "Status";
            // 
            // lbl_nomeCategoria
            // 
            this.lbl_nomeCategoria.AutoSize = true;
            this.lbl_nomeCategoria.Location = new System.Drawing.Point(389, 17);
            this.lbl_nomeCategoria.Name = "lbl_nomeCategoria";
            this.lbl_nomeCategoria.Size = new System.Drawing.Size(92, 15);
            this.lbl_nomeCategoria.TabIndex = 14;
            this.lbl_nomeCategoria.Text = "Nome categoria";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(131, 35);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(86, 23);
            this.txt_quantidade.TabIndex = 12;
            // 
            // txt_datahora
            // 
            this.txt_datahora.Location = new System.Drawing.Point(256, 95);
            this.txt_datahora.Mask = "00/00/0000 90:00";
            this.txt_datahora.Name = "txt_datahora";
            this.txt_datahora.Size = new System.Drawing.Size(100, 23);
            this.txt_datahora.TabIndex = 11;
            this.txt_datahora.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_datahora
            // 
            this.lbl_datahora.AutoSize = true;
            this.lbl_datahora.Location = new System.Drawing.Point(241, 77);
            this.lbl_datahora.Name = "lbl_datahora";
            this.lbl_datahora.Size = new System.Drawing.Size(133, 15);
            this.lbl_datahora.TabIndex = 10;
            this.lbl_datahora.Text = "Data e hora de Cadastro";
            // 
            // txt_UnidadeMedida
            // 
            this.txt_UnidadeMedida.Location = new System.Drawing.Point(131, 95);
            this.txt_UnidadeMedida.MaxLength = 30;
            this.txt_UnidadeMedida.Name = "txt_UnidadeMedida";
            this.txt_UnidadeMedida.Size = new System.Drawing.Size(66, 23);
            this.txt_UnidadeMedida.TabIndex = 9;
            this.txt_UnidadeMedida.TextChanged += new System.EventHandler(this.txt_UnidadeMedida_TextChanged);
            // 
            // lbl_unidadeMedida
            // 
            this.lbl_unidadeMedida.AutoSize = true;
            this.lbl_unidadeMedida.Location = new System.Drawing.Point(119, 77);
            this.lbl_unidadeMedida.Name = "lbl_unidadeMedida";
            this.lbl_unidadeMedida.Size = new System.Drawing.Size(110, 15);
            this.lbl_unidadeMedida.TabIndex = 8;
            this.lbl_unidadeMedida.Text = "Unidade de Medida";
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(13, 95);
            this.txt_peso.MaxLength = 13;
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 23);
            this.txt_peso.TabIndex = 7;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(13, 77);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(32, 15);
            this.lbl_peso.TabIndex = 6;
            this.lbl_peso.Text = "Peso";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(128, 16);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(69, 15);
            this.lbl_quantidade.TabIndex = 4;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // lbl_codigoCategoria
            // 
            this.lbl_codigoCategoria.AutoSize = true;
            this.lbl_codigoCategoria.Location = new System.Drawing.Point(244, 16);
            this.lbl_codigoCategoria.Name = "lbl_codigoCategoria";
            this.lbl_codigoCategoria.Size = new System.Drawing.Size(130, 15);
            this.lbl_codigoCategoria.TabIndex = 2;
            this.lbl_codigoCategoria.Text = "Código ID da Categoria";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(13, 35);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(13, 17);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(40, 15);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // grupo_3
            // 
            this.grupo_3.Controls.Add(this.txt_valorVenda);
            this.grupo_3.Controls.Add(this.lbl_valorVenda);
            this.grupo_3.Controls.Add(this.txt_valorcusto);
            this.grupo_3.Controls.Add(this.lbl_valorCusto);
            this.grupo_3.Location = new System.Drawing.Point(558, 101);
            this.grupo_3.Name = "grupo_3";
            this.grupo_3.Size = new System.Drawing.Size(130, 147);
            this.grupo_3.TabIndex = 2;
            this.grupo_3.TabStop = false;
            // 
            // txt_valorVenda
            // 
            this.txt_valorVenda.Location = new System.Drawing.Point(12, 95);
            this.txt_valorVenda.Name = "txt_valorVenda";
            this.txt_valorVenda.Size = new System.Drawing.Size(100, 23);
            this.txt_valorVenda.TabIndex = 3;
            // 
            // lbl_valorVenda
            // 
            this.lbl_valorVenda.AutoSize = true;
            this.lbl_valorVenda.Location = new System.Drawing.Point(12, 77);
            this.lbl_valorVenda.Name = "lbl_valorVenda";
            this.lbl_valorVenda.Size = new System.Drawing.Size(39, 15);
            this.lbl_valorVenda.TabIndex = 2;
            this.lbl_valorVenda.Text = "Venda";
            // 
            // txt_valorcusto
            // 
            this.txt_valorcusto.Location = new System.Drawing.Point(12, 41);
            this.txt_valorcusto.Name = "txt_valorcusto";
            this.txt_valorcusto.Size = new System.Drawing.Size(100, 23);
            this.txt_valorcusto.TabIndex = 1;
            this.txt_valorcusto.TextChanged += new System.EventHandler(this.txt_valorcusto_TextChanged);
            // 
            // lbl_valorCusto
            // 
            this.lbl_valorCusto.AutoSize = true;
            this.lbl_valorCusto.Location = new System.Drawing.Point(12, 23);
            this.lbl_valorCusto.Name = "lbl_valorCusto";
            this.lbl_valorCusto.Size = new System.Drawing.Size(65, 15);
            this.lbl_valorCusto.TabIndex = 0;
            this.lbl_valorCusto.Text = "Valor custo";
            // 
            // grupo_4
            // 
            this.grupo_4.Controls.Add(this.txt_obs);
            this.grupo_4.Controls.Add(this.lbl_obs);
            this.grupo_4.Location = new System.Drawing.Point(18, 268);
            this.grupo_4.Name = "grupo_4";
            this.grupo_4.Size = new System.Drawing.Size(670, 147);
            this.grupo_4.TabIndex = 3;
            this.grupo_4.TabStop = false;
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(119, 40);
            this.txt_obs.MaxLength = 255;
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(391, 90);
            this.txt_obs.TabIndex = 3;
            // 
            // lbl_obs
            // 
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Location = new System.Drawing.Point(281, 19);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(69, 15);
            this.lbl_obs.TabIndex = 2;
            this.lbl_obs.Text = "Observação";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bto_excluirCategoria);
            this.groupBox1.Controls.Add(this.bto_CadastrarCategoria);
            this.groupBox1.Controls.Add(this.bto_AlterarCategoria);
            this.groupBox1.Controls.Add(this.bto_limparCategoria);
            this.groupBox1.Controls.Add(this.bto_sairCategoria);
            this.groupBox1.Location = new System.Drawing.Point(18, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 62);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // bto_excluirCategoria
            // 
            this.bto_excluirCategoria.Location = new System.Drawing.Point(119, 21);
            this.bto_excluirCategoria.Name = "bto_excluirCategoria";
            this.bto_excluirCategoria.Size = new System.Drawing.Size(75, 32);
            this.bto_excluirCategoria.TabIndex = 7;
            this.bto_excluirCategoria.Text = "Excluir";
            this.bto_excluirCategoria.UseVisualStyleBackColor = true;
            // 
            // bto_CadastrarCategoria
            // 
            this.bto_CadastrarCategoria.Location = new System.Drawing.Point(577, 21);
            this.bto_CadastrarCategoria.Name = "bto_CadastrarCategoria";
            this.bto_CadastrarCategoria.Size = new System.Drawing.Size(75, 32);
            this.bto_CadastrarCategoria.TabIndex = 9;
            this.bto_CadastrarCategoria.Text = "Cadastrar";
            this.bto_CadastrarCategoria.UseVisualStyleBackColor = true;
            this.bto_CadastrarCategoria.Click += new System.EventHandler(this.bto_CadastrarCategoria_Click);
            // 
            // bto_AlterarCategoria
            // 
            this.bto_AlterarCategoria.Location = new System.Drawing.Point(478, 21);
            this.bto_AlterarCategoria.Name = "bto_AlterarCategoria";
            this.bto_AlterarCategoria.Size = new System.Drawing.Size(75, 32);
            this.bto_AlterarCategoria.TabIndex = 8;
            this.bto_AlterarCategoria.Text = "Alterar";
            this.bto_AlterarCategoria.UseVisualStyleBackColor = true;
            // 
            // bto_limparCategoria
            // 
            this.bto_limparCategoria.Location = new System.Drawing.Point(299, 21);
            this.bto_limparCategoria.Name = "bto_limparCategoria";
            this.bto_limparCategoria.Size = new System.Drawing.Size(75, 32);
            this.bto_limparCategoria.TabIndex = 6;
            this.bto_limparCategoria.Text = "Limpar";
            this.bto_limparCategoria.UseVisualStyleBackColor = true;
            this.bto_limparCategoria.Click += new System.EventHandler(this.bto_limparCategoria_Click);
            // 
            // bto_sairCategoria
            // 
            this.bto_sairCategoria.Location = new System.Drawing.Point(13, 21);
            this.bto_sairCategoria.Name = "bto_sairCategoria";
            this.bto_sairCategoria.Size = new System.Drawing.Size(75, 32);
            this.bto_sairCategoria.TabIndex = 5;
            this.bto_sairCategoria.Text = "Sair";
            this.bto_sairCategoria.UseVisualStyleBackColor = true;
            this.bto_sairCategoria.Click += new System.EventHandler(this.bto_sairCategoria_Click);
            // 
            // frm_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(726, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupo_4);
            this.Controls.Add(this.grupo_3);
            this.Controls.Add(this.grupo_2);
            this.Controls.Add(this.grupo_1);
            this.Name = "frm_produto";
            this.Text = "frm_produto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_produto_FormClosed);
            this.Load += new System.EventHandler(this.frm_produto_Load);
            this.grupo_1.ResumeLayout(false);
            this.grupo_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo)).EndInit();
            this.grupo_2.ResumeLayout(false);
            this.grupo_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantidade)).EndInit();
            this.grupo_3.ResumeLayout(false);
            this.grupo_3.PerformLayout();
            this.grupo_4.ResumeLayout(false);
            this.grupo_4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grupo_1;
        private Button bto_codigo;
        private Label lbl_codigo;
        private GroupBox grupo_2;
        private TextBox txt_nome;
        private Label lbl_nome;
        private MaskedTextBox txt_datahora;
        private Label lbl_datahora;
        private TextBox txt_UnidadeMedida;
        private Label lbl_unidadeMedida;
        private TextBox txt_peso;
        private Label lbl_peso;
        private Label lbl_quantidade;
        private Label lbl_codigoCategoria;
        private GroupBox grupo_3;
        private TextBox txt_valorVenda;
        private Label lbl_valorVenda;
        private TextBox txt_valorcusto;
        private Label lbl_valorCusto;
        private GroupBox grupo_4;
        private TextBox txt_obs;
        private Label lbl_obs;
        private ComboBox cbo_status;
        private Label lbl_status;
        private GroupBox groupBox1;
        private Button bto_excluirCategoria;
        private Button bto_CadastrarCategoria;
        private Button bto_AlterarCategoria;
        private Button bto_limparCategoria;
        private Button bto_sairCategoria;
        private NumericUpDown txt_codigo;
        private NumericUpDown txt_quantidade;
        private Button button1;
        private Button button2;
        private Label lbl_nomeCategoria;
        private ComboBox cbo_nomeCategoria;
        private ComboBox cbo_IDCategoria;
    }
}