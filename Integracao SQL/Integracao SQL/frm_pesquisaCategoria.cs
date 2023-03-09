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
    public partial class frm_pesquisaCategoria : Form
    {
        public frm_pesquisaCategoria()
        {
            InitializeComponent();
        }

        private void DataGrid_categoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string conexao = "" +
           "Data Source=localhost;" +
           "Initial catalog=MiniProjeto;" +
           "User ID=sa;" +
           "Password=123456;";

        private void TestarConexao()
        {
            try
            {
                SqlConnection conn = new SqlConnection(conexao);
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                Application.Exit();
            }
        }

        private void ComandoDataGrid()
        {
            string sql = "select id_categoria as 'ID'," +
               "nome_categoria as 'Nome'," +
               "descricao_categoria as 'Descrição'," +
               "obs_categoria as 'Observação'," +
               "status_categoria as 'Status'" +
               "from categoria where nome_categoria like '%" + txt_pesquisaData.Text + "%'";

            SqlConnection conexaoSQL = new SqlConnection(conexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao);
            DataSet ds = new DataSet();
            conexaoSQL.Open();

            try
            {
                adapter.Fill(ds);
                DataGrid_categoria.DataSource = ds.Tables[0];
                _codigoCategoria = DataGrid_categoria.CurrentRow.Cells["ID"].Value.ToString();
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

        public string _codigoCategoria;

        private void DataGrid_categoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigoCategoria = DataGrid_categoria.CurrentRow.Cells["ID"].Value.ToString();
            this.Close();
        }

        private void frm_pesquisaCategoria_Load(object sender, EventArgs e)
        {
            TestarConexao();
            ComandoDataGrid();
        }

        private void txt_pesquisaData_TextChanged(object sender, EventArgs e)
        {
            ComandoDataGrid();
        }
    }
}
