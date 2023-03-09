using System.Data;
using System.Data.SqlClient;

namespace Integracao_SQL
{
    public partial class frm_user : Form
    {

        public static string Conexao = "" +
            "Data Source=localhost;" +
            "Initial catalog=MiniProjeto;" +
            "User ID=sa;" +
            "Password=123456;";

        private void testeConexao()
        {
          SqlConnection conexao = new SqlConnection(Conexao);
            try
            {
                conexao.Open();
                conexao.Close();
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro: " + excecao.Message);
                Application.Exit();
            }
        }
 

        public frm_user()
        {
            InitializeComponent();
        }

        private void cbo_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bto_limpar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_nome.Text = "";
            txt_login.Text = "";
            txt_senha.Text = "";
            txt_CPF.Text = "";
            cbo_status.SelectedIndex = -1;
            txt_Obs.Text = "";
        }

        private void bto_sair_Click(object sender, EventArgs e)
        {
            mdi mdi = new mdi();
            mdi.Show();
            this.Hide();
        }

        private void frm_user_Load(object sender, EventArgs e)
        {
            testeConexao();
            dataGridUsuario();
        }

        private void bto_Cadastrar_Click(object sender, EventArgs e)
        {

            if (txt_nome.Text == "" || txt_login.Text == "" || txt_senha.Text == "" || txt_CPF.Text == "" || cbo_status.SelectedIndex == -1 )
            {
                MessageBox.Show("Algo não foi preenchido");
            }
            else
            {

                string Cadastro = "Insert into usuario (nome_usuario, login_usuario, senha_usuario, cpf_usuario, obs_usuario, status_usuario)" +
                "values ('" + txt_nome.Text + "'," +
                "'" + txt_login.Text + "'," +
                "'" + txt_senha.Text + "'," +
                "'" + txt_CPF.Text + "'," +
                "'" + txt_Obs.Text + "'," +
                "'" + cbo_status.Text + "')";

                SqlConnection conexao = new SqlConnection(Conexao);
                SqlCommand comando = new SqlCommand(Cadastro, conexao);
                comando.CommandType = CommandType.Text;
                conexao.Open();

                try
                {
                    int i = comando.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Cadastro Realizado com sucesso :)");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }

        }
        private void grupo_1_Enter(object sender, EventArgs e)
        {

        }

        private void bto_excluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Tem certeza que deseja apagar os dados desse usuário?", "Você tem certeza?" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes )
            {
                string sql = "delete from usuario where id_usuario = " + txt_codigo.Text;

                MessageBox.Show("Erro, insira um número válido ao usuário");
              
                SqlConnection conn = new SqlConnection(Conexao);
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.CommandType = CommandType.Text;
               
                try
                {
                    conn.Open();

                    int i = comm.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("ID:" + txt_codigo.Text + " " + "Teve seus dados excluidos com sucesso");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                
                }
            else if(dialogo == DialogResult.No)
            {
                return;
            }
        }

        private void frm_user_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nome_TabIndexChanged(object sender, EventArgs e)
        {
          
        }
        
        private void bto_pesquisar_Click(object sender, EventArgs e)
        {
            
            string sql = "select * from usuario where id_usuario =" + txt_codigo.Text;

            SqlConnection conexaoSQL = new SqlConnection(Conexao);
            SqlCommand comando = new SqlCommand(sql,conexaoSQL);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader;
            conexaoSQL.Open();

            FrmPesquisaUsuario frm = new FrmPesquisaUsuario();
            string conexaoData = frm._codigo;

            if (txt_codigo.Text == "0")
            {
                FrmPesquisaUsuario pesquisa = new FrmPesquisaUsuario();
                pesquisa.ShowDialog();
                txt_codigo.Text = pesquisa._codigo;
                bto_pesquisar.PerformClick();
            }

                try
                {
                    reader = comando.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Pesquisa feita com sucesso, mostrando os resultados...");

                        txt_codigo.Text = reader[0].ToString();
                        txt_nome.Text = reader[1].ToString();
                        txt_login.Text = reader[2].ToString();
                        txt_senha.Text = reader[3].ToString();
                        txt_CPF.Text = reader[4].ToString();
                        txt_Obs.Text = reader[5].ToString();
                        cbo_status.Text = reader[6].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Código do usuário inexistente!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexaoSQL.Close();
                }
            
        }

        private void bto_Alterar_Click(object sender, EventArgs e)
        {

            string sql = "update usuario set " +
                         "nome_usuario = " + "'" + txt_nome.Text + "'," +
                         "login_usuario =" + "'" + txt_login.Text + "'," +
                         "senha_usuario =" + "'" + txt_senha.Text + "'," +
                         "cpf_usuario =" + "'" + txt_CPF.Text + "'," +
                         "obs_usuario =" + "'" + txt_Obs.Text + "'," +
                         "status_usuario =" + "'" + cbo_status.Text + "'" +
                         "where id_usuario =" + txt_codigo.Text;

            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Erro, código é necessário para alteração");
            }
            else
            {

                SqlConnection conn = new SqlConnection(Conexao);
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.CommandType = CommandType.Text;

                try
                {
                    conn.Open();

                    int i = comm.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Dados alterados com sucesso");
                        bto_limpar.PerformClick();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void bto_cadastro2_Click(object sender, EventArgs e)
        {

            if (txt_nome.Text == "" || txt_login.Text == "" || txt_senha.Text == "" || txt_CPF.Text == "" || cbo_status.SelectedIndex == -1)
            {
                MessageBox.Show("Algo não foi preenchido");
            }
            else
            {

                string Cadastro = "Insert into usuario (nome_usuario, login_usuario, senha_usuario, cpf_usuario, obs_usuario, status_usuario)" +
                "values ('" + txt_nome.Text + "'," +
                "'" + txt_login.Text + "'," +
                "'" + txt_senha.Text + "'," +
                "'" + txt_CPF.Text + "'," +
                "'" + txt_Obs.Text + "'," +
                "'" + cbo_status.Text + "')" +
                "select SCOPE_IDENTITY()";

                SqlConnection conexao = new SqlConnection(Conexao);
                SqlCommand comando = new SqlCommand(Cadastro, conexao);
                comando.CommandType = CommandType.Text;
                SqlDataReader leitura;
                conexao.Open();

                try
                {
                    leitura = comando.ExecuteReader();
                    if (leitura.Read())
                    {
                        MessageBox.Show("Cadastro Realizado com sucesso, Código gerado: " + leitura[0].ToString());
                        txt_codigo.Text = leitura[0].ToString();

                        bto_limpar.PerformClick();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void dataGrid_Usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dataGrid_Usuario.CurrentRow.Cells["ID"].Value.ToString();
            dataGridUsuario();
            bto_pesquisar.PerformClick();
        }

        private void dataGridUsuario()
        {
            string sql = "select id_usuario as 'ID'," +
               "nome_usuario as 'Nome'," +
               "login_usuario as 'Login'," +
               "cpf_usuario as 'CPF'," +
               "status_usuario as 'Status'" +
               "from usuario where nome_usuario like '%" + txt_pesquisaData.Text + "%'";

            SqlConnection conexao = new SqlConnection(Conexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao);
            DataSet ds = new DataSet();
            conexao.Open();

            try
            {
                adapter.Fill(ds);
                dataGrid_Usuario.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void txt_pesquisaData_TextChanged(object sender, EventArgs e)
        {
            dataGridUsuario();
        }

        private void txt_codigo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}