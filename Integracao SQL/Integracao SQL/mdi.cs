using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integracao_SQL
{
    public partial class mdi : Form
    {
        private int childFormNumber = 0;

        public mdi()
        {
            InitializeComponent();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void gerenciamentoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_user usuario = new frm_user();
            this.Hide();
            usuario.Show();
        }

        private void gerenciamentoDeCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categoria categoria = new frm_categoria();
            this.Hide();
            categoria.Show();
        }

        private void gerenciamentoDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produto venda = new frm_produto();
            this.Hide();
            venda.Show();
        }

        private void mdi_Load(object sender, EventArgs e)
        {

        }

        private void mdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pesquisaDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
