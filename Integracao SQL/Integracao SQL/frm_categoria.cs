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
    public partial class frm_categoria : Form
    {

        string stringconexao = "" +
            "Data source=localhost;" +
            "Initial catalog=MiniProjeto;" +
            "User ID=sa;" +
            "Password=123456;";

        private void TestarConexao()
        {
            SqlConnection sqlConnection = new SqlConnection(stringconexao);
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

        public frm_categoria()
        {
            InitializeComponent();
        }

        private void frm_categoria_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void lbl_observacao_Click(object sender, EventArgs e)
        {

        }

        private void txt_obs_TextChanged(object sender, EventArgs e)
        {

        }

        private void bto_limparCategoria_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            cbo_status.SelectedIndex = -1;
            txt_descricao.Text = "";
            txt_obs.Text = "";
        }

        private void bto_sairCategoria_Click(object sender, EventArgs e)
        {
            mdi mdi = new mdi();
            mdi.Show();
            this.Hide();
        }

        private void bto_CadastrarCategoria_Click(object sender, EventArgs e)
        {
            string Cadastro = "Insert into categoria (nome_categoria, descricao_categoria, obs_categoria, status_categoria)" +
            "values ('" + txt_nome.Text + "'," +
            "'" + txt_descricao.Text + "'," +
            "'" + txt_obs.Text + "'," +
            "'" + cbo_status.Text + "')" + "Select SCOPE_IDENTITY()";

            if (txt_nome.Text == "" || txt_descricao.Text == "" || cbo_status.SelectedIndex == -1)
            {
                MessageBox.Show("Algo não foi preenchido");
            }
            else
            {

                SqlConnection conexao = new SqlConnection(stringconexao);
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

                        bto_limparCategoria.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("deu ruim");
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

        private void frm_categoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bto_pesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from categoria where id_categoria =" + txt_codigo.Text;

            SqlConnection conexaoSQL = new SqlConnection(stringconexao);
            SqlCommand comando = new SqlCommand(sql, conexaoSQL);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader;
            conexaoSQL.Open();

            //Data Grid AQUI
            if (txt_codigo.Text == "0")
            {
                frm_pesquisaCategoria pesquisaCategoria = new frm_pesquisaCategoria();
                pesquisaCategoria.ShowDialog();
                txt_codigo.Text = pesquisaCategoria._codigoCategoria;
                bto_pesquisar.PerformClick();
                
            }
            // Fim do Data Grid AQUI

            else if (txt_codigo.Text == "")
            {
                MessageBox.Show("Insira um número válido");
                txt_codigo.Text = "0";
                return;
            }

            try
            {
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Pesquisa feita com sucesso, mostrando os resultados...");

                    txt_codigo.Text = reader[0].ToString();
                    txt_nome.Text = reader[1].ToString();
                    txt_descricao.Text = reader[2].ToString();
                    txt_obs.Text = reader[3].ToString();
                    cbo_status.Text = reader[4].ToString();
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

        private void bto_AlterarCategoria_Click(object sender, EventArgs e)
        {
            string sql = "update categoria set " +
                       "nome_categoria = " + "'" + txt_nome.Text + "'," +
                       "descricao_categoria =" + "'" + txt_descricao.Text + "'," +
                       "obs_categoria =" + "'" + txt_obs.Text + "'," +
                       "status_categoria =" + "'" + cbo_status.Text + "'" +
                       "where id_categoria =" + txt_codigo.Text;

            SqlConnection conn = new SqlConnection(stringconexao);
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = CommandType.Text;

            if (txt_codigo.Text == "0")
            {
                MessageBox.Show("0 é um número inválido");
                txt_codigo.Text = "1";
                return;
            }
            else if (txt_codigo.Text == "")
            {
                MessageBox.Show("Insira um número válido");
                txt_codigo.Text = "0";
                return;
            }

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

        private void bto_excluirCategoria_Click(object sender, EventArgs e)
        {
            string sql = "delete from categoria where id_categoria = " + txt_codigo.Text;

            if (txt_codigo.Text == "0")
            {
                    MessageBox.Show("0 é um número inválido");
                    txt_codigo.Text = "1";
                    return;
            }
            else if (txt_codigo.Text == "")
            {
                MessageBox.Show("Insira um número válido");
                txt_codigo.Text = "0";
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection(stringconexao);
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
        }

        private void bto_excluirCategoria_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Tem certeza que deseja apagar os dados dessa categoria?", "Você tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                string sql = "delete from categoria where id_categoria = " + txt_codigo.Text;

                MessageBox.Show("Erro, insira um número válido a categoria");

                SqlConnection conn = new SqlConnection(stringconexao);
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.CommandType = CommandType.Text;

                try
                {
                    conn.Open();

                    int i = comm.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("ID: " + txt_codigo.Text + " " + "Teve seus dados excluidos com sucesso");
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

        private void txt_codigo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
