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

namespace Sistema
{
    public partial class frm_produtos : Form
    {
        public frm_produtos()
        {
            InitializeComponent();
        }

        private void frm_produtos_Load(object sender, EventArgs e)
        {
            //O codigo abaixo, carrega o banco de dados para preencher o grid ao iniciar o form
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private bool valida()
        {
            if (txt_descricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O produto é obrigatório!");
                txt_descricao.Focus();
                return false;
            }
            return true;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            //O metodo abaixo adiciona uma nova linha no datagrid para adicionar novos cadastros
            this.produtoBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //O if abaixo, chama o metodo valida() para validar se o campo esta preenchido
            if (this.valida())
            {
                //O codigo abaixo, cadastra os dados no banco de dados
                this.produtoBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Produto cadastrado com Sucesso!");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            //O if abaixo, confirma se o usuario quer mesmo excluir
            if (MessageBox.Show("Deseja realmente excluir?", "Excluir produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    //O codigo abaixo exclui o item selecionado do banco de dados
                    this.produtoBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Produto Removido!");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((Categoria)e.Value).Descricao;
        }
    }
}
