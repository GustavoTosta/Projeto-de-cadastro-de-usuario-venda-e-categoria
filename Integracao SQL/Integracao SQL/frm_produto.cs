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

    public partial class frm_produto : Form
    {
        public frm_produto()
        {
            InitializeComponent();
        }

        string Conexao = "" +
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


        private void bto_limparCategoria_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            txt_quantidade.Text = "";
            txt_peso.Text = "";
            txt_UnidadeMedida.Text = "";
            cbo_nomeCategoria.SelectedIndex = -1;
            cbo_IDCategoria.SelectedIndex = -1;
            txt_datahora.Text = "";
            txt_valorcusto.Text = "";
            txt_valorVenda.Text = "";
            cbo_status.SelectedIndex = -1;
            txt_obs.Text = "";
        }

        private void frm_produto_Load(object sender, EventArgs e)
        {
            testeConexao();
            CarregarCategoria();
        }

        private void CarregarCategoria()
        {
            string sqlCategoria = "select id_categoria, nome_categoria from categoria";

            SqlConnection conn = new SqlConnection(Conexao);
            SqlCommand cmd = new SqlCommand(sqlCategoria, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            DataTable table = new DataTable();

            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                table.Load(leitura);
                cbo_IDCategoria.DisplayMember = "id_categoria";
                cbo_IDCategoria.DataSource = table;

                cbo_nomeCategoria.DisplayMember = "nome_categoria";
                cbo_nomeCategoria.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void frm_produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bto_sairCategoria_Click(object sender, EventArgs e)
        {
            mdi mdi = new mdi();
            mdi.Show();
            this.Hide();
        }

        private void txt_UnidadeMedida_TextChanged(object sender, EventArgs e)
        {

        }

        private void grupo_2_Enter(object sender, EventArgs e)
        {

            
            

        }

        private void bto_CadastrarCategoria_Click(object sender, EventArgs e)
        {
            string Cadastro = "Insert into produto (id_categoria_produto, nome_produto, qtde_produto, peso_produto, unidade_produto, cadastro_produto , valorcusto_produto, valorvenda_produto, obs_produto, status_produto)" +
          "values ('" + cbo_IDCategoria.Text + "'," +
          "'" + txt_nome.Text + "'," +
          "'" + txt_quantidade.Text + "'," +
          "'" + txt_peso.Text + "'," +
          "'" + txt_UnidadeMedida.Text + "'," +
          "'" + txt_datahora.Text + "'," +
          "'" + txt_valorcusto.Text + "'," +
          "'" + txt_valorVenda.Text + "'," +
          "'" + txt_obs.Text + "'," +
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

        private void txt_valorcusto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Tem certeza que deseja apagar os dados desse produto?", "Você tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                string sql = "delete from produto where id_produto = " + txt_codigo.Text;

                MessageBox.Show("Erro, insira um número válido ao produto");

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
            else if (dialogo == DialogResult.No)
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string sql = "update produto set " +
                         "nome_produto = " + "'" + txt_nome.Text + "'," +
                         "qtde_produto =" + "'" + txt_quantidade.Text + "'," +
                         "peso_produto =" + "'" + txt_peso.Text + "'," +
                         "unidadeMedida =" + "'" + txt_UnidadeMedida.Text + "'," +
                         "obs_usuario =" + "'" + txt_valorcusto.Text + "'," +
                         "obs_usuario =" + "'" + txt_valorVenda.Text + "'," +
                         "status_usuario =" + "'" + cbo_status.Text + "'" +
                         "status_usuario =" + "'" + txt_obs.Text + "'" +
                         "where id_produto =" + txt_codigo.Text;

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
                        bto_limparCategoria.PerformClick();
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

        private void bto_codigo_Click(object sender, EventArgs e)
        {
            string sql = "select * from produto where id_produto =" + txt_codigo.Text;

            SqlConnection conexaoSQL = new SqlConnection(Conexao);
            SqlCommand comando = new SqlCommand(sql, conexaoSQL);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader;
            conexaoSQL.Open();

            if (txt_codigo.Text == "0")
            {
                frm_pesquisaCategoria pesquisaCategoria = new frm_pesquisaCategoria();
                pesquisaCategoria.ShowDialog();
                txt_codigo.Text = pesquisaCategoria._codigoCategoria;
                bto_codigo.PerformClick();
            }

            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Erro, código é necessário para pesquisa");

            }
            else
            {

                try
                {
                    reader = comando.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Pesquisa feita com sucesso, mostrando os resultados...");

                        txt_codigo.Text = reader[0].ToString();
                        cbo_IDCategoria.Text = reader[1].ToString();
                        txt_nome.Text = reader[2].ToString();
                        txt_quantidade.Text = reader[3].ToString();
                        txt_peso.Text = reader[4].ToString();
                        txt_UnidadeMedida.Text = reader[5].ToString();
                        txt_datahora.Text = reader[6].ToString();
                        txt_valorcusto.Text = reader[7].ToString();
                        txt_valorVenda.Text = reader[8].ToString();
                        txt_obs.Text = reader[9].ToString();
                        cbo_status.Text = reader[10].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Código do produto inexistente!");
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

                //AQUI PESQUISA CATEGORIA POR NOME

                /*string codigoCategoria = "select * from categoria where id_categoria =" + txt_codigoCategoria.Text;

                SqlConnection conexaoSQL2 = new SqlConnection(Conexao);
                SqlCommand comandoSQL = new SqlCommand(codigoCategoria, conexaoSQL2);
                comando.CommandType = CommandType.Text;
                SqlDataReader reader2;
                conexaoSQL.Open();

                try
                {
                    reader2 = comando.ExecuteReader();
                    if (reader2.Read())
                    {
                        txt_nomeCategoria.Text = reader2[2].ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexaoSQL2.Close();
                }
                */
            }

        }

        private void txt_codigoCategoria_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_nomeCategoria.Text = "";
            string codigoCategoria = "select * from categoria where id_categoria =" + cbo_IDCategoria.Text;

            SqlConnection conexaoSQL2 = new SqlConnection(Conexao);
            SqlCommand comandoSQL = new SqlCommand(codigoCategoria, conexaoSQL2);
            comandoSQL.CommandType = CommandType.Text;
            SqlDataReader reader2;
            conexaoSQL2.Open();

            try
            {
                reader2 = comandoSQL.ExecuteReader();
                if (reader2.Read())
                {
                    cbo_nomeCategoria.Text = reader2[1].ToString();
                }
                else
                {
                    MessageBox.Show("Código de categoria não encontrado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexaoSQL2.Close();
            }
        }

        private void txt_codigo_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}   

