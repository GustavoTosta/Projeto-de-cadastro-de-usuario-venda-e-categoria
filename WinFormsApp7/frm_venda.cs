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
    public partial class frm_venda : Form
    {
        public frm_venda()
        {
            InitializeComponent();
        }

        private void if_quantidade()
        {

            int quantidade;

            quantidade = int.Parse(txt_Quantidade.Text);

            double valor;

            valor = double.Parse(txt_valor.Text);

            double total;

            total = quantidade * valor;

             if (txt_Quantidade.Text != "0"  )
            {
                txt_total.Text = total.ToString();
            }
        }

        private void comBox_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comBox_Produtos.SelectedIndex == 0)
            {
                txt_valor.Text = "12";
            }

            else if (comBox_Produtos.SelectedIndex == 1)
            {
                txt_valor.Text = "120";
            }

            else if (comBox_Produtos.SelectedIndex == 2)
            {
                txt_valor.Text = "20";
            }

            else if (comBox_Produtos.SelectedIndex == 3)
            {
                txt_valor.Text = "215";
            }

            else if (comBox_Produtos.SelectedIndex == 4)
            {
                txt_valor.Text = "150";
            }

            else if (comBox_Produtos.SelectedIndex == 5)
            {
                txt_valor.Text = "180";
            }

            else if (comBox_Produtos.SelectedIndex == 6)
            {
                txt_valor.Text = "30";
            }

            else if (comBox_Produtos.SelectedIndex == 7)
            {
                txt_valor.Text = "10";
            }

            else if (comBox_Produtos.SelectedIndex == 8)
            {
                txt_valor.Text = "5";
            }

            else if (comBox_Produtos.SelectedIndex == 9)
            {
                txt_valor.Text = "60";
            }

        }

        private void txt_Quantidade_TextChanged(object sender, EventArgs e)
        {
            if (txt_Quantidade.Text == "0")
            {
                MessageBox.Show("Insira uma quantidade válida");
            }
        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void bto_Adicionar_Click(object sender, EventArgs e)
        {
            if_quantidade();
            list_Carrinho.Items.Add("Produto: " + comBox_Produtos.Text + " " + "Quantidade: " + txt_Quantidade.Text + " " + "Total: " + txt_total.Text);
        }

        private void bto_calcular_Click(object sender, EventArgs e)
        {
            if_quantidade();
        }

        private void frm_venda_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Aguarde...");
        }

        private void frm_venda_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void list_Carrinho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bto_Remove_Click(object sender, EventArgs e)
        {
            list_Carrinho.Items.RemoveAt(0);
        }

        private void bto_Finalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("n pronto");
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_totalCarinho_Click(object sender, EventArgs e)
        {

        }
    }
}
