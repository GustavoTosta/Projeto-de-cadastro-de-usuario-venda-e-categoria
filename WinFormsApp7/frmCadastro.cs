namespace WinFormsApp7
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bto_limpar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_nome.Text = "";
            txt_sexo.SelectedIndex = -1;
            txt_dataDeNascimento.Text = "";
            txt_logradouro.Text = "";
            txt_numero.Text = "";
            txt_complemento.Text = "";
            txt_CEP.Text = "";
            txt_cidade.Text = "";
            txt_UF.SelectedIndex = -1;
            txt_salario.Text = "";
            txt_telefone.Text = "";
            txt_email.Text = "";
            txt_observação.Text = "";
            lbl_resumo.Text = "";
            txt_codigo.Focus();
        }

        private void bto_cadastrar_Click(object sender, EventArgs e)
        {
            lbl_resumo.Text = "Código: " + txt_codigo.Text + "\n" + "Nome: " + txt_nome.Text + "\n" + "Sexo: " + txt_sexo.Text + "\n" + "Data de Nascimento: " + txt_dataDeNascimento.Text + "\n"
            + "Logradouro: " + txt_logradouro.Text + "\n" + "Número: " + txt_numero.Text + "\n" + "Complemento: " + txt_complemento.Text + "\n"
            + "CEP: " + txt_CEP.Text + "\n" + "Cidade " + txt_cidade.Text + "\n" + "UF: " + txt_UF.Text + "\n" + "Salário: " + txt_salario.Text + "\n"
            + "Telefone: " + txt_telefone.Text + "\n" + "Email: " + txt_email.Text + "\n" + "Observação: " + txt_observação.Text;

            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Erro, nenhum código informado");
                return;
            }

            if (txt_nome.Text == "")
            {
                MessageBox.Show("Erro, nenhum nome informado");
                return ;
            }

            if (txt_dataDeNascimento.Text == "")
            {
                MessageBox.Show("Erro, nenhuma data de nascimento informada");
                return;
            }

            if (txt_logradouro.Text == "")
            {
                MessageBox.Show("Erro, nenhum logradouro informado");
                return;
            }

            if (txt_numero.Text == "")
            {
                MessageBox.Show("Erro, nenhum número informado");
                return;
            }

            if (txt_CEP.Text == "")
            {
                MessageBox.Show("Erro, nenhum CEP informado");
                return;
            }

            if (txt_cidade.Text == "")
            {
                MessageBox.Show("Erro, nenhuma cidade informado");
                return;
            }


            if (txt_salario.Text == "")
            {
                MessageBox.Show("Erro, nenhum salário informado");
                return;
            }

            if (txt_telefone.Text == "")
            {
                MessageBox.Show("Erro, nenhum telefone informado");
                return;
            }

            if (txt_email.Text == "")
            {
                MessageBox.Show("Erro, nenhum email informado");
                return;
            }
         
        }

        private void bto_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_CEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}