using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema.DAL;
using System.Data.SqlClient;

namespace Sistema
{
    public partial class frm_ponto : Form
    {
        public frm_ponto()
        {
            InitializeComponent();
            

        }

        public frm_ponto(string usuario)
        {
            InitializeComponent();
            tssUserPonto.Text = usuario;
        }

        private void frm_ponto_Load(object sender, EventArgs e)
        {
            //txt_data.Text = DateTime.Today.ToString("yyy-MM-dd");

            this.pontoBindingSource.DataSource = DataContextFactory.DataContext.Pontos;
            this.usuariosBindingSource.DataSource = DataContextFactory.DataContext.Usuarios;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            //O metodo abaixo adiciona uma nova linha no datagrid para adicionar novos cadastros
            this.pontoBindingSource.AddNew();
            //txt_data.Text = DateTime.Today.ToString("yyy-MM-dd");
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (CB_usuario.Text == tssUserPonto.Text || (tssUserPonto.Text == "adm"))
            {
                //O codigo abaixo, cadastra os dados no banco de dados
                this.pontoBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Ponto registrado com Sucesso!");
            }
            else
            {
                MessageBox.Show("Você não pode lançar pontos para outro usuário!");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (CB_usuario.Text == tssUserPonto.Text || (tssUserPonto.Text == "adm"))
            {
                //O if abaixo, confirma se o usuario quer mesmo excluir
                if (MessageBox.Show("Deseja realmente excluir?", "Excluir ponto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //O codigo abaixo exclui o item selecionado do banco de dados
                    this.pontoBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Ponto Removido!");
                }
            }
            else
            {
                MessageBox.Show("Você não pode excluir o lançamento de outro usuário!");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.pontoBindingSource.CancelEdit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Usuarios)e.Value).Usuario;
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frm_consultaponto(tssUserPonto.Text);
            formulario.Show();
        }
    }
}
