namespace Integracao_SQL
{
    partial class frm_login
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
            this.bto_OK = new System.Windows.Forms.Button();
            this.bto_sair = new System.Windows.Forms.Button();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bto_OK
            // 
            this.bto_OK.Location = new System.Drawing.Point(151, 123);
            this.bto_OK.Name = "bto_OK";
            this.bto_OK.Size = new System.Drawing.Size(75, 31);
            this.bto_OK.TabIndex = 2;
            this.bto_OK.Text = "OK";
            this.bto_OK.UseVisualStyleBackColor = true;
            this.bto_OK.Click += new System.EventHandler(this.bto_OK_Click);
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(12, 123);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(75, 31);
            this.bto_sair.TabIndex = 3;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            this.bto_sair.Click += new System.EventHandler(this.bto_sair_Click);
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(12, 30);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(214, 23);
            this.txt_login.TabIndex = 0;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(12, 12);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(37, 15);
            this.lbl_login.TabIndex = 3;
            this.lbl_login.Text = "Login";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(12, 60);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(39, 15);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "Senha";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(12, 78);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(214, 23);
            this.txt_senha.TabIndex = 1;
            // 
            // frm_login
            // 
            this.AcceptButton = this.bto_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.bto_sair;
            this.ClientSize = new System.Drawing.Size(258, 168);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.bto_sair);
            this.Controls.Add(this.bto_OK);
            this.Name = "frm_login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bto_OK;
        private Button bto_sair;
        private TextBox txt_login;
        private Label lbl_login;
        private Label lbl_senha;
        private TextBox txt_senha;
    }
}