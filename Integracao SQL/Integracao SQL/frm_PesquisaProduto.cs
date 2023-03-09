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
    public partial class frm_PesquisaProduto : Form
    {
        public frm_PesquisaProduto()
        {
            InitializeComponent();
        }

        private string conexao = "" +
      "Data Source=localhost;" +
      "Initial catalog=MiniProjeto;" +
      "User ID=sa;" +
      "Password=123456;";

        public string _codigoProduto;

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
                DataGrid_Produto.DataSource = ds.Tables[0];
                _codigoProduto = DataGrid_Produto.CurrentRow.Cells["ID"].Value.ToString();
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

        private void DataGrid_Produto_DoubleClick(object sender, EventArgs e)
        {
            _codigoProduto = DataGrid_Produto.CurrentRow.Cells["ID"].Value.ToString();
            this.Close();
        }
    }
}
