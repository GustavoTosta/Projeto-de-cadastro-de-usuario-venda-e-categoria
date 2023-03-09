namespace Integracao_SQL
{
    partial class frm_categoria
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
            this.bto_excluirCategoria = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.NumericUpDown();
            this.bto_pesquisar = new System.Windows.Forms.Button();
            this.bto_AlterarCategoria = new System.Windows.Forms.Button();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.grupo_2 = new System.Windows.Forms.GroupBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.lbl_observacao = new System.Windows.Forms.Label();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.grupo_3 = new System.Windows.Forms.GroupBox();
            this.bto_CadastrarCategoria = new System.Windows.Forms.Button();
            this.bto_limparCategoria = new System.Windows.Forms.Button();
            this.bto_sairCategoria = new System.Windows.Forms.Button();
            this.grupo_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo)).BeginInit();
            this.grupo_2.SuspendLayout();
            this.grupo_3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo_1
            // 
            this.grupo_1.Controls.Add(this.bto_excluirCategoria);
            this.grupo_1.Controls.Add(this.txt_codigo);
            this.grupo_1.Controls.Add(this.bto_pesquisar);
            this.grupo_1.Controls.Add(this.bto_AlterarCategoria);
            this.grupo_1.Controls.Add(this.lbl_codigo);
            this.grupo_1.Location = new System.Drawing.Point(15, 10);
            this.grupo_1.Name = "grupo_1";
            this.grupo_1.Size = new System.Drawing.Size(470, 76);
            this.grupo_1.TabIndex = 0;
            this.grupo_1.TabStop = false;
            // 
            // bto_excluirCategoria
            // 
            this.bto_excluirCategoria.Location = new System.Drawing.Point(299, 35);
            this.bto_excluirCategoria.Name = "bto_excluirCategoria";
            this.bto_excluirCategoria.Size = new System.Drawing.Size(75, 23);
            this.bto_excluirCategoria.TabIndex = 10;
            this.bto_excluirCategoria.Text = "Excluir";
            this.bto_excluirCategoria.UseVisualStyleBackColor = true;
            this.bto_excluirCategoria.Click += new System.EventHandler(this.bto_excluirCategoria_Click_1);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(11, 35);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(120, 23);
            this.txt_codigo.TabIndex = 9;
            this.txt_codigo.ValueChanged += new System.EventHandler(this.txt_codigo_ValueChanged);
            // 
            // bto_pesquisar
            // 
            this.bto_pesquisar.Location = new System.Drawing.Point(137, 35);
            this.bto_pesquisar.Name = "bto_pesquisar";
            this.bto_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.bto_pesquisar.TabIndex = 2;
            this.bto_pesquisar.Text = "Pesquisar";
            this.bto_pesquisar.UseVisualStyleBackColor = true;
            this.bto_pesquisar.Click += new System.EventHandler(this.bto_pesquisar_Click);
            // 
            // bto_AlterarCategoria
            // 
            this.bto_AlterarCategoria.Location = new System.Drawing.Point(218, 35);
            this.bto_AlterarCategoria.Name = "bto_AlterarCategoria";
            this.bto_AlterarCategoria.Size = new System.Drawing.Size(75, 23);
            this.bto_AlterarCategoria.TabIndex = 8;
            this.bto_AlterarCategoria.Text = "Alterar";
            this.bto_AlterarCategoria.UseVisualStyleBackColor = true;
            this.bto_AlterarCategoria.Click += new System.EventHandler(this.bto_AlterarCategoria_Click);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(11, 17);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(46, 15);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código";
            // 
            // grupo_2
            // 
            this.grupo_2.Controls.Add(this.txt_obs);
            this.grupo_2.Controls.Add(this.lbl_observacao);
            this.grupo_2.Controls.Add(this.cbo_status);
            this.grupo_2.Controls.Add(this.lbl_status);
            this.grupo_2.Controls.Add(this.txt_descricao);
            this.grupo_2.Controls.Add(this.lbl_descricao);
            this.grupo_2.Controls.Add(this.txt_nome);
            this.grupo_2.Controls.Add(this.lbl_nome);
            this.grupo_2.Location = new System.Drawing.Point(15, 119);
            this.grupo_2.Name = "grupo_2";
            this.grupo_2.Size = new System.Drawing.Size(470, 267);
            this.grupo_2.TabIndex = 1;
            this.grupo_2.TabStop = false;
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(251, 190);
            this.txt_obs.MaxLength = 255;
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(204, 71);
            this.txt_obs.TabIndex = 7;
            this.txt_obs.TextChanged += new System.EventHandler(this.txt_obs_TextChanged);
            // 
            // lbl_observacao
            // 
            this.lbl_observacao.AutoSize = true;
            this.lbl_observacao.Location = new System.Drawing.Point(304, 172);
            this.lbl_observacao.Name = "lbl_observacao";
            this.lbl_observacao.Size = new System.Drawing.Size(108, 15);
            this.lbl_observacao.TabIndex = 6;
            this.lbl_observacao.Text = "Observações extras";
            this.lbl_observacao.Click += new System.EventHandler(this.lbl_observacao_Click);
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbo_status.Location = new System.Drawing.Point(12, 91);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(121, 23);
            this.cbo_status.TabIndex = 5;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(12, 73);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(39, 15);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Status";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(251, 37);
            this.txt_descricao.MaxLength = 255;
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(204, 130);
            this.txt_descricao.TabIndex = 3;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(327, 19);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(58, 15);
            this.lbl_descricao.TabIndex = 2;
            this.lbl_descricao.Text = "Descrição";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(11, 37);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(201, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 19);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(40, 15);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // grupo_3
            // 
            this.grupo_3.Controls.Add(this.bto_CadastrarCategoria);
            this.grupo_3.Controls.Add(this.bto_limparCategoria);
            this.grupo_3.Controls.Add(this.bto_sairCategoria);
            this.grupo_3.Location = new System.Drawing.Point(16, 392);
            this.grupo_3.Name = "grupo_3";
            this.grupo_3.Size = new System.Drawing.Size(469, 62);
            this.grupo_3.TabIndex = 2;
            this.grupo_3.TabStop = false;
            // 
            // bto_CadastrarCategoria
            // 
            this.bto_CadastrarCategoria.Location = new System.Drawing.Point(388, 21);
            this.bto_CadastrarCategoria.Name = "bto_CadastrarCategoria";
            this.bto_CadastrarCategoria.Size = new System.Drawing.Size(75, 32);
            this.bto_CadastrarCategoria.TabIndex = 9;
            this.bto_CadastrarCategoria.Text = "Cadastrar";
            this.bto_CadastrarCategoria.UseVisualStyleBackColor = true;
            this.bto_CadastrarCategoria.Click += new System.EventHandler(this.bto_CadastrarCategoria_Click);
            // 
            // bto_limparCategoria
            // 
            this.bto_limparCategoria.Location = new System.Drawing.Point(201, 21);
            this.bto_limparCategoria.Name = "bto_limparCategoria";
            this.bto_limparCategoria.Size = new System.Drawing.Size(75, 32);
            this.bto_limparCategoria.TabIndex = 6;
            this.bto_limparCategoria.Text = "Limpar";
            this.bto_limparCategoria.UseVisualStyleBackColor = true;
            this.bto_limparCategoria.Click += new System.EventHandler(this.bto_limparCategoria_Click);
            // 
            // bto_sairCategoria
            // 
            this.bto_sairCategoria.Location = new System.Drawing.Point(6, 21);
            this.bto_sairCategoria.Name = "bto_sairCategoria";
            this.bto_sairCategoria.Size = new System.Drawing.Size(75, 32);
            this.bto_sairCategoria.TabIndex = 5;
            this.bto_sairCategoria.Text = "Sair";
            this.bto_sairCategoria.UseVisualStyleBackColor = true;
            this.bto_sairCategoria.Click += new System.EventHandler(this.bto_sairCategoria_Click);
            // 
            // frm_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(513, 457);
            this.Controls.Add(this.grupo_3);
            this.Controls.Add(this.grupo_2);
            this.Controls.Add(this.grupo_1);
            this.Name = "frm_categoria";
            this.Text = "Gerenciamento de Categoria";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_categoria_FormClosed);
            this.Load += new System.EventHandler(this.frm_categoria_Load);
            this.grupo_1.ResumeLayout(false);
            this.grupo_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo)).EndInit();
            this.grupo_2.ResumeLayout(false);
            this.grupo_2.PerformLayout();
            this.grupo_3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grupo_1;
        private Button bto_pesquisar;
        private Label lbl_codigo;
        private GroupBox grupo_2;
        private ComboBox cbo_status;
        private Label lbl_status;
        private TextBox txt_descricao;
        private Label lbl_descricao;
        private TextBox txt_nome;
        private Label lbl_nome;
        private TextBox txt_obs;
        private Label lbl_observacao;
        private GroupBox grupo_3;
        private Button bto_CadastrarCategoria;
        private Button bto_AlterarCategoria;
        private Button bto_limparCategoria;
        private Button bto_sairCategoria;
        private NumericUpDown txt_codigo;
        private Button bto_excluirCategoria;
    }
}