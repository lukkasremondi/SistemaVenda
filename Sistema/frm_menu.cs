using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();

        }

        //TESTE
        public frm_menu(string texto)
        {
            InitializeComponent();
            tssUser.Text = texto;
            if (tssUser.Text == "adm")
            {
                btn_cad_categorias.Visible = true;
            }
        }
        //FIM TESTE

        private void btn_cad_produtos_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void btn_cad_categorias_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_consultaprodutos frm = new frm_consultaprodutos();
            frm.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_venda frm = new frm_venda();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formulario = new frm_ponto(tssUser.Text);
            formulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formulario = new frm_consultaponto(tssUser.Text);
            formulario.Show();
        }
    }
}
