using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Integracao_SQL
{
    public partial class frm_login : Form
    {

        string conexao = frm_user.Conexao;

        private void TestarConexao()
        {
            SqlConnection sqlConnection = new SqlConnection(conexao);
            try
            {
                sqlConnection.Open();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
            public frm_login()
        {
            InitializeComponent();
        }

        private void bto_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bto_OK_Click(object sender, EventArgs e)
        {
            string sql = "select * from usuario where " +
                "login_usuario = '" + txt_login.Text + "' and " +
                "senha_usuario = '" + txt_senha.Text + "'";

           SqlConnection conexaoSQL = new SqlConnection(conexao);
           SqlCommand cmd = new SqlCommand(sql, conexaoSQL);
           cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conexaoSQL.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    MessageBox.Show("Login feito com sucesso");
                    mdi mdi = new mdi();
                    mdi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorreto");
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

        private void frm_login_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }
    }
}
