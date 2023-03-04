namespace WinFormsApp7
{
    partial class frm_login
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.bto_OK = new System.Windows.Forms.Button();
            this.bto_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(12, 9);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(49, 21);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Login";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(12, 33);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(275, 29);
            this.txt_login.TabIndex = 1;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(12, 82);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(53, 21);
            this.lbl_Senha.TabIndex = 2;
            this.lbl_Senha.Text = "Senha";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(12, 106);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(275, 29);
            this.txt_Senha.TabIndex = 3;
            // 
            // bto_OK
            // 
            this.bto_OK.Location = new System.Drawing.Point(212, 171);
            this.bto_OK.Name = "bto_OK";
            this.bto_OK.Size = new System.Drawing.Size(75, 35);
            this.bto_OK.TabIndex = 4;
            this.bto_OK.Text = "OK";
            this.bto_OK.UseVisualStyleBackColor = true;
            this.bto_OK.Click += new System.EventHandler(this.bto_OK_Click);
            // 
            // bto_Sair
            // 
            this.bto_Sair.Location = new System.Drawing.Point(12, 171);
            this.bto_Sair.Name = "bto_Sair";
            this.bto_Sair.Size = new System.Drawing.Size(75, 35);
            this.bto_Sair.TabIndex = 5;
            this.bto_Sair.Text = "Sair";
            this.bto_Sair.UseVisualStyleBackColor = true;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(307, 218);
            this.Controls.Add(this.bto_Sair);
            this.Controls.Add(this.bto_OK);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.lbl_Login);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_login";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Login;
        private TextBox txt_login;
        private Label lbl_Senha;
        private TextBox txt_Senha;
        private Button bto_OK;
        private Button bto_Sair;
    }
}