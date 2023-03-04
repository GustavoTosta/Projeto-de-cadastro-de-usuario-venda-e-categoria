namespace WinFormsApp7
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void bto_OK_Click(object sender, EventArgs e)
        {
            string login = txt_login.Text;
            string senha = txt_Senha.Text;

            if ((login == "adm" || senha == "adm") == false)
            {
                MessageBox.Show("Login ou senha inválida");
                txt_login.Text = "";
                txt_Senha.Text = "";
                Focus();
                return;
            }

            else if (login == "adm" || senha == "adm")
            {
                MDIParent1 mdi = new MDIParent1();

                frmCadastro frmCadastro = new frmCadastro();
                MessageBox.Show("Bem vindo");
                mdi.Show();
                this.Hide();
            }

        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}