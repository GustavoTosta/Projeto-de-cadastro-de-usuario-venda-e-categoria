using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integracao_SQL
{
    public partial class FrmPesquisaUsuario : Form
    {

        private string conexao = "" +
               "Data Source=localhost;" +
               "Initial catalog=MiniProjeto;" +
               "User ID=sa;" +
               "Password=123456;";

        private void testeConexao()
        {
            SqlConnection conexaoSQL = new SqlConnection(conexao);
            try
            {
                conexaoSQL.Open();
                conexaoSQL.Close();
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro: " + excecao.Message);
                Application.Exit();
            }
        }

        private void ComandoDataGrid()
        {
            string sql = "select id_usuario as 'ID'," +
               "nome_usuario as 'Nome'," +
               "login_usuario as 'Login'," +
               "cpf_usuario as 'CPF'," +
               "status_usuario as 'Status'" +
               "from usuario where nome_usuario like '%" + txt_pesquisaData.Text + "%'";

            SqlConnection conexaoSQL = new SqlConnection(conexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao);
            DataSet ds = new DataSet();
            conexaoSQL.Open();

            try
            {
                adapter.Fill(ds);
                DataGrid_usuario.DataSource = ds.Tables[0];
                _codigo = DataGrid_usuario.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexaoSQL.Close();
            }
        }

        public FrmPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void DataGrid_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            testeConexao();
            ComandoDataGrid();
        }

        public string _codigo;

        private void txt_pesquisaData_TextChanged(object sender, EventArgs e)
        {
            ComandoDataGrid();
        }

        private void DataGrid_usuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGrid_usuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigo = DataGrid_usuario.CurrentRow.Cells["ID"].Value.ToString();
            this.Close();
        }
    }
}
