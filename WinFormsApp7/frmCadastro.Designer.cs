namespace WinFormsApp7
{
    partial class frmCadastro
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
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_DataNascimento = new System.Windows.Forms.Label();
            this.lbl_logradouro = new System.Windows.Forms.Label();
            this.txt_logradouro = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_complemento = new System.Windows.Forms.Label();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lbl_UF = new System.Windows.Forms.Label();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_observação = new System.Windows.Forms.Label();
            this.lbl_resumo = new System.Windows.Forms.Label();
            this.txt_observação = new System.Windows.Forms.TextBox();
            this.bto_cadastrar = new System.Windows.Forms.Button();
            this.bto_limpar = new System.Windows.Forms.Button();
            this.bto_sair = new System.Windows.Forms.Button();
            this.txt_sexo = new System.Windows.Forms.ComboBox();
            this.txt_UF = new System.Windows.Forms.ComboBox();
            this.txt_dataDeNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_CEP = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(42, 18);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(46, 15);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(94, 15);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 23);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(7, 52);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(40, 15);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(7, 70);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(259, 23);
            this.txt_nome.TabIndex = 2;
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(314, 52);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(32, 15);
            this.lbl_sexo.TabIndex = 4;
            this.lbl_sexo.Text = "Sexo";
            // 
            // lbl_DataNascimento
            // 
            this.lbl_DataNascimento.AutoSize = true;
            this.lbl_DataNascimento.Location = new System.Drawing.Point(479, 52);
            this.lbl_DataNascimento.Name = "lbl_DataNascimento";
            this.lbl_DataNascimento.Size = new System.Drawing.Size(114, 15);
            this.lbl_DataNascimento.TabIndex = 6;
            this.lbl_DataNascimento.Text = "Data de Nascimento";
            // 
            // lbl_logradouro
            // 
            this.lbl_logradouro.AutoSize = true;
            this.lbl_logradouro.Location = new System.Drawing.Point(7, 117);
            this.lbl_logradouro.Name = "lbl_logradouro";
            this.lbl_logradouro.Size = new System.Drawing.Size(69, 15);
            this.lbl_logradouro.TabIndex = 8;
            this.lbl_logradouro.Text = "Logradouro";
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.Location = new System.Drawing.Point(9, 135);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(257, 23);
            this.txt_logradouro.TabIndex = 5;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(314, 117);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(51, 15);
            this.lbl_numero.TabIndex = 10;
            this.lbl_numero.Text = "Número";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(314, 135);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(90, 23);
            this.txt_numero.TabIndex = 6;
            this.txt_numero.TextChanged += new System.EventHandler(this.txt_numero_TextChanged);
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Location = new System.Drawing.Point(479, 117);
            this.lbl_complemento.Name = "lbl_complemento";
            this.lbl_complemento.Size = new System.Drawing.Size(84, 15);
            this.lbl_complemento.TabIndex = 12;
            this.lbl_complemento.Text = "Complemento";
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(479, 135);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(181, 23);
            this.txt_complemento.TabIndex = 7;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(9, 180);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(28, 15);
            this.lbl_cep.TabIndex = 14;
            this.lbl_cep.Text = "CEP";
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Location = new System.Drawing.Point(265, 180);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(44, 15);
            this.lbl_Cidade.TabIndex = 16;
            this.lbl_Cidade.Text = "Cidade";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(265, 198);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(190, 23);
            this.txt_cidade.TabIndex = 9;
            // 
            // lbl_UF
            // 
            this.lbl_UF.AutoSize = true;
            this.lbl_UF.Location = new System.Drawing.Point(516, 180);
            this.lbl_UF.Name = "lbl_UF";
            this.lbl_UF.Size = new System.Drawing.Size(21, 15);
            this.lbl_UF.TabIndex = 18;
            this.lbl_UF.Text = "UF";
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Location = new System.Drawing.Point(9, 241);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(42, 15);
            this.lbl_salario.TabIndex = 20;
            this.lbl_salario.Text = "Salário";
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(9, 259);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(180, 23);
            this.txt_salario.TabIndex = 11;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(227, 241);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(51, 15);
            this.lbl_telefone.TabIndex = 22;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(499, 241);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(36, 15);
            this.lbl_Email.TabIndex = 24;
            this.lbl_Email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(499, 259);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(178, 23);
            this.txt_email.TabIndex = 13;
            // 
            // lbl_observação
            // 
            this.lbl_observação.AutoSize = true;
            this.lbl_observação.Location = new System.Drawing.Point(9, 298);
            this.lbl_observação.Name = "lbl_observação";
            this.lbl_observação.Size = new System.Drawing.Size(69, 15);
            this.lbl_observação.TabIndex = 26;
            this.lbl_observação.Text = "Observação";
            this.lbl_observação.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_resumo
            // 
            this.lbl_resumo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_resumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_resumo.Location = new System.Drawing.Point(732, 18);
            this.lbl_resumo.Name = "lbl_resumo";
            this.lbl_resumo.Size = new System.Drawing.Size(261, 401);
            this.lbl_resumo.TabIndex = 27;
            this.lbl_resumo.Text = "Resumo";
            this.lbl_resumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_observação
            // 
            this.txt_observação.Location = new System.Drawing.Point(7, 316);
            this.txt_observação.Multiline = true;
            this.txt_observação.Name = "txt_observação";
            this.txt_observação.Size = new System.Drawing.Size(696, 85);
            this.txt_observação.TabIndex = 14;
            // 
            // bto_cadastrar
            // 
            this.bto_cadastrar.Location = new System.Drawing.Point(628, 415);
            this.bto_cadastrar.Name = "bto_cadastrar";
            this.bto_cadastrar.Size = new System.Drawing.Size(75, 32);
            this.bto_cadastrar.TabIndex = 17;
            this.bto_cadastrar.Text = "Cadastrar";
            this.bto_cadastrar.UseVisualStyleBackColor = true;
            this.bto_cadastrar.Click += new System.EventHandler(this.bto_cadastrar_Click);
            // 
            // bto_limpar
            // 
            this.bto_limpar.Location = new System.Drawing.Point(314, 415);
            this.bto_limpar.Name = "bto_limpar";
            this.bto_limpar.Size = new System.Drawing.Size(75, 32);
            this.bto_limpar.TabIndex = 16;
            this.bto_limpar.Text = "Limpar";
            this.bto_limpar.UseVisualStyleBackColor = true;
            this.bto_limpar.Click += new System.EventHandler(this.bto_limpar_Click);
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(13, 415);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(75, 32);
            this.bto_sair.TabIndex = 15;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            this.bto_sair.Click += new System.EventHandler(this.bto_sair_Click);
            // 
            // txt_sexo
            // 
            this.txt_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_sexo.FormattingEnabled = true;
            this.txt_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.txt_sexo.Location = new System.Drawing.Point(314, 70);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(121, 23);
            this.txt_sexo.TabIndex = 3;
            // 
            // txt_UF
            // 
            this.txt_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_UF.FormattingEnabled = true;
            this.txt_UF.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.txt_UF.Location = new System.Drawing.Point(516, 198);
            this.txt_UF.Name = "txt_UF";
            this.txt_UF.Size = new System.Drawing.Size(121, 23);
            this.txt_UF.TabIndex = 10;
            // 
            // txt_dataDeNascimento
            // 
            this.txt_dataDeNascimento.Location = new System.Drawing.Point(479, 70);
            this.txt_dataDeNascimento.Mask = "00/00/0000";
            this.txt_dataDeNascimento.Name = "txt_dataDeNascimento";
            this.txt_dataDeNascimento.Size = new System.Drawing.Size(137, 23);
            this.txt_dataDeNascimento.TabIndex = 4;
            this.txt_dataDeNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(227, 259);
            this.txt_telefone.Mask = "(00) 0000000-00";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(234, 23);
            this.txt_telefone.TabIndex = 12;
            // 
            // txt_CEP
            // 
            this.txt_CEP.Location = new System.Drawing.Point(9, 198);
            this.txt_CEP.Mask = "00000-000";
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(214, 23);
            this.txt_CEP.TabIndex = 8;
            // 
            // frmCadastro
            // 
            this.AcceptButton = this.bto_cadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bto_sair;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.txt_CEP);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_dataDeNascimento);
            this.Controls.Add(this.txt_UF);
            this.Controls.Add(this.txt_sexo);
            this.Controls.Add(this.bto_sair);
            this.Controls.Add(this.bto_limpar);
            this.Controls.Add(this.bto_cadastrar);
            this.Controls.Add(this.txt_observação);
            this.Controls.Add(this.lbl_resumo);
            this.Controls.Add(this.lbl_observação);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.lbl_UF);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lbl_Cidade);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.txt_complemento);
            this.Controls.Add(this.lbl_complemento);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txt_logradouro);
            this.Controls.Add(this.lbl_logradouro);
            this.Controls.Add(this.lbl_DataNascimento);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_codigo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frmCadastro";
            this.ShowIcon = false;
            this.Text = "Formulário";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_codigo;
        private TextBox txt_codigo;
        private Label lbl_nome;
        private TextBox txt_nome;
        private Label lbl_sexo;
        private Label lbl_DataNascimento;
        private Label lbl_logradouro;
        private TextBox txt_logradouro;
        private Label lbl_numero;
        private TextBox txt_numero;
        private Label lbl_complemento;
        private TextBox txt_complemento;
        private Label lbl_cep;
        private Label lbl_Cidade;
        private TextBox txt_cidade;
        private Label lbl_UF;
        private Label lbl_salario;
        private TextBox txt_salario;
        private Label lbl_telefone;
        private Label lbl_Email;
        private TextBox txt_email;
        private Label lbl_observação;
        private Label lbl_resumo;
        private TextBox txt_observação;
        private Button bto_cadastrar;
        private Button bto_limpar;
        private Button bto_sair;
        private ComboBox txt_sexo;
        private ComboBox txt_UF;
        private MaskedTextBox txt_dataDeNascimento;
        private MaskedTextBox txt_telefone;
        private MaskedTextBox txt_CEP;
    }
}