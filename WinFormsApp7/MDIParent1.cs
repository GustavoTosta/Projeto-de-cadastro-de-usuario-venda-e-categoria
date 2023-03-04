using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void formulário2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formulário1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro frm = new frmCadastro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }
    }
}