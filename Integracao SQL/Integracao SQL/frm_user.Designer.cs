namespace Integracao_SQL
{
    partial class frm_user
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grupo_1 = new System.Windows.Forms.GroupBox();
            this.txt_codigo = new System.Windows.Forms.NumericUpDown();
            this.bto_Alterar = new System.Windows.Forms.Button();
            this.bto_pesquisar = new System.Windows.Forms.Button();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.grupo_2 = new System.Windows.Forms.GroupBox();
            this.txt_Obs = new System.Windows.Forms.TextBox();
            this.lbl_obs = new System.Windows.Forms.Label();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.grupo_3 = new System.Windows.Forms.GroupBox();
            this.bto_cadastro2 = new System.Windows.Forms.Button();
            this.bto_Cadastrar = new System.Windows.Forms.Button();
            this.bto_limpar = new System.Windows.Forms.Button();
            this.bto_sair = new System.Windows.Forms.Button();
            this.grupo3 = new System.Windows.Forms.GroupBox();
            this.dataGrid_Usuario = new System.Windows.Forms.DataGridView();
            this.txt_pesquisaData = new System.Windows.Forms.TextBox();
            this.grupo_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo)).BeginInit();
            this.grupo_2.SuspendLayout();
            this.grupo_3.SuspendLayout();
            this.grupo3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // grupo_1
            // 
            this.grupo_1.Controls.Add(this.txt_codigo);
            this.grupo_1.Controls.Add(this.bto_Alterar);
            this.grupo_1.Controls.Add(this.bto_pesquisar);
            this.grupo_1.Controls.Add(this.lbl_codigo);
            this.grupo_1.Location = new System.Drawing.Point(12, 12);
            this.grupo_1.Name = "grupo_1";
            this.grupo_1.Size = new System.Drawing.Size(380, 78);
            this.grupo_1.TabIndex = 0;
            this.grupo_1.TabStop = false;
            this.grupo_1.Enter += new System.EventHandler(this.grupo_1_Enter);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(15, 39);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(120, 23);
            this.txt_codigo.TabIndex = 6;
            // 
            // bto_Alterar
            // 
            this.bto_Alterar.Location = new System.Drawing.Point(226, 40);
            this.bto_Alterar.Name = "bto_Alterar";
            this.bto_Alterar.Size = new System.Drawing.Size(75, 23);
            this.bto_Alterar.TabIndex = 3;
            this.bto_Alterar.Text = "Alterar";
            this.bto_Alterar.UseVisualStyleBackColor = true;
            this.bto_Alterar.Click += new System.EventHandler(this.bto_Alterar_Click);
            // 
            // bto_pesquisar
            // 
            this.bto_pesquisar.Location = new System.Drawing.Point(153, 40);
            this.bto_pesquisar.Name = "bto_pesquisar";
            this.bto_pesquisar.Size = new System.Drawing.Size(67, 23);
            this.bto_pesquisar.TabIndex = 2;
            this.bto_pesquisar.Text = "Pesquisar";
            this.bto_pesquisar.UseVisualStyleBackColor = true;
            this.bto_pesquisar.Click += new System.EventHandler(this.bto_pesquisar_Click);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(15, 22);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(46, 15);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código";
            // 
            // grupo_2
            // 
            this.grupo_2.Controls.Add(this.txt_Obs);
            this.grupo_2.Controls.Add(this.lbl_obs);
            this.grupo_2.Controls.Add(this.cbo_status);
            this.grupo_2.Controls.Add(this.lbl_status);
            this.grupo_2.Controls.Add(this.txt_CPF);
            this.grupo_2.Controls.Add(this.lbl_CPF);
            this.grupo_2.Controls.Add(this.txt_senha);
            this.grupo_2.Controls.Add(this.lbl_senha);
            this.grupo_2.Controls.Add(this.txt_login);
            this.grupo_2.Controls.Add(this.lbl_login);
            this.grupo_2.Controls.Add(this.txt_nome);
            this.grupo_2.Controls.Add(this.lbl_nome);
            this.grupo_2.Location = new System.Drawing.Point(12, 113);
            this.grupo_2.Name = "grupo_2";
            this.grupo_2.Size = new System.Drawing.Size(513, 286);
            this.grupo_2.TabIndex = 0;
            this.grupo_2.TabStop = false;
            // 
            // txt_Obs
            // 
            this.txt_Obs.Location = new System.Drawing.Point(18, 162);
            this.txt_Obs.MaxLength = 255;
            this.txt_Obs.Multiline = true;
            this.txt_Obs.Name = "txt_Obs";
            this.txt_Obs.Size = new System.Drawing.Size(465, 111);
            this.txt_Obs.TabIndex = 10;
            // 
            // lbl_obs
            // 
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Location = new System.Drawing.Point(18, 144);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(28, 15);
            this.lbl_obs.TabIndex = 9;
            this.lbl_obs.Text = "Obs";
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbo_status.Location = new System.Drawing.Point(362, 100);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(121, 23);
            this.cbo_status.TabIndex = 8;
            this.cbo_status.SelectedIndexChanged += new System.EventHandler(this.cbo_status_SelectedIndexChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(362, 82);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(39, 15);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "Status";
            // 
            // txt_CPF
            // 
            this.txt_CPF.Location = new System.Drawing.Point(256, 100);
            this.txt_CPF.Mask = "000,000,000-00";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(100, 23);
            this.txt_CPF.TabIndex = 6;
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Location = new System.Drawing.Point(256, 82);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(28, 15);
            this.lbl_CPF.TabIndex = 5;
            this.lbl_CPF.Text = "CPF";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(150, 100);
            this.txt_senha.MaxLength = 30;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(100, 23);
            this.txt_senha.TabIndex = 3;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(150, 82);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(39, 15);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "Senha";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(18, 100);
            this.txt_login.MaxLength = 30;
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(126, 23);
            this.txt_login.TabIndex = 2;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(18, 82);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(37, 15);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "Login";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(18, 46);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(464, 23);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.TabIndexChanged += new System.EventHandler(this.txt_nome_TabIndexChanged);
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(15, 28);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(40, 15);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // grupo_3
            // 
            this.grupo_3.Controls.Add(this.bto_cadastro2);
            this.grupo_3.Controls.Add(this.bto_Cadastrar);
            this.grupo_3.Controls.Add(this.bto_sair);
            this.grupo_3.Location = new System.Drawing.Point(12, 405);
            this.grupo_3.Name = "grupo_3";
            this.grupo_3.Size = new System.Drawing.Size(904, 61);
            this.grupo_3.TabIndex = 1;
            this.grupo_3.TabStop = false;
            // 
            // bto_cadastro2
            // 
            this.bto_cadastro2.Location = new System.Drawing.Point(408, 13);
            this.bto_cadastro2.Name = "bto_cadastro2";
            this.bto_cadastro2.Size = new System.Drawing.Size(75, 41);
            this.bto_cadastro2.TabIndex = 5;
            this.bto_cadastro2.Text = "Cadastrar 2.0";
            this.bto_cadastro2.UseVisualStyleBackColor = true;
            this.bto_cadastro2.Click += new System.EventHandler(this.bto_cadastro2_Click);
            // 
            // bto_Cadastrar
            // 
            this.bto_Cadastrar.Location = new System.Drawing.Point(823, 22);
            this.bto_Cadastrar.Name = "bto_Cadastrar";
            this.bto_Cadastrar.Size = new System.Drawing.Size(75, 32);
            this.bto_Cadastrar.TabIndex = 4;
            this.bto_Cadastrar.Text = "Cadastrar";
            this.bto_Cadastrar.UseVisualStyleBackColor = true;
            this.bto_Cadastrar.Click += new System.EventHandler(this.bto_Cadastrar_Click);
            // 
            // bto_limpar
            // 
            this.bto_limpar.Location = new System.Drawing.Point(420, 465);
            this.bto_limpar.Name = "bto_limpar";
            this.bto_limpar.Size = new System.Drawing.Size(75, 32);
            this.bto_limpar.TabIndex = 1;
            this.bto_limpar.Text = "Limpar";
            this.bto_limpar.UseVisualStyleBackColor = true;
            this.bto_limpar.Click += new System.EventHandler(this.bto_limpar_Click);
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(6, 22);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(75, 32);
            this.bto_sair.TabIndex = 0;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            this.bto_sair.Click += new System.EventHandler(this.bto_sair_Click);
            // 
            // grupo3
            // 
            this.grupo3.Controls.Add(this.dataGrid_Usuario);
            this.grupo3.Controls.Add(this.txt_pesquisaData);
            this.grupo3.Location = new System.Drawing.Point(531, 12);
            this.grupo3.Name = "grupo3";
            this.grupo3.Size = new System.Drawing.Size(385, 387);
            this.grupo3.TabIndex = 2;
            this.grupo3.TabStop = false;
            // 
            // dataGrid_Usuario
            // 
            this.dataGrid_Usuario.AllowUserToAddRows = false;
            this.dataGrid_Usuario.AllowUserToDeleteRows = false;
            this.dataGrid_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Usuario.Location = new System.Drawing.Point(6, 45);
            this.dataGrid_Usuario.Name = "dataGrid_Usuario";
            this.dataGrid_Usuario.ReadOnly = true;
            this.dataGrid_Usuario.RowTemplate.Height = 25;
            this.dataGrid_Usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Usuario.Size = new System.Drawing.Size(373, 329);
            this.dataGrid_Usuario.TabIndex = 1;
            this.dataGrid_Usuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Usuario_CellContentClick);
            // 
            // txt_pesquisaData
            // 
            this.txt_pesquisaData.Location = new System.Drawing.Point(6, 16);
            this.txt_pesquisaData.Name = "txt_pesquisaData";
            this.txt_pesquisaData.PlaceholderText = "Pesquisa";
            this.txt_pesquisaData.Size = new System.Drawing.Size(373, 23);
            this.txt_pesquisaData.TabIndex = 0;
            this.txt_pesquisaData.TextChanged += new System.EventHandler(this.txt_pesquisaData_TextChanged);
            // 
            // frm_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(928, 498);
            this.Controls.Add(this.grupo3);
            this.Controls.Add(this.grupo_3);
            this.Controls.Add(this.bto_limpar);
            this.Controls.Add(this.grupo_2);
            this.Controls.Add(this.grupo_1);
            this.Name = "frm_user";
            this.Text = "Tela de Gerenciamento de Usuários";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_user_FormClosed);
            this.Load += new System.EventHandler(this.frm_user_Load);
            this.grupo_1.ResumeLayout(false);
            this.grupo_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo)).EndInit();
            this.grupo_2.ResumeLayout(false);
            this.grupo_2.PerformLayout();
            this.grupo_3.ResumeLayout(false);
            this.grupo3.ResumeLayout(false);
            this.grupo3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grupo_1;
        private Button bto_pesquisar;
        private Label lbl_codigo;
        private GroupBox grupo_2;
        private MaskedTextBox txt_CPF;
        private Label lbl_CPF;
        private TextBox txt_senha;
        private Label lbl_senha;
        private TextBox txt_login;
        private Label lbl_login;
        private TextBox txt_nome;
        private Label lbl_nome;
        private TextBox txt_Obs;
        private Label lbl_obs;
        private ComboBox cbo_status;
        private Label lbl_status;
        private GroupBox grupo_3;
        private Button bto_Cadastrar;
        private Button bto_Alterar;
        private Button bto_limpar;
        private Button bto_sair;
        private Button bto_cadastro2;
        private GroupBox grupo3;
        private DataGridView dataGrid_Usuario;
        private TextBox txt_pesquisaData;
        private NumericUpDown txt_codigo;
    }
}