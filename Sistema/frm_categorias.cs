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
    public partial class frm_categorias : Form
    {
        public frm_categorias()
        {
            InitializeComponent();
        }

        private void frm_categorias_Load(object sender, EventArgs e)
        {
            //O metodo abaixo atualiza o grid com as informações do banco de dados
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        //O metodo abaixo valida se o textbox esta preenchido ou nao
        private bool valida()
        {
            if (txt_categoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("A Categoria é obrigatória!");
                txt_categoria.Focus();
                return false;
            }
            return true;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            //O metodo abaixo adiciona uma nova linha no datagrid para adicionar novos cadastros
            this.categoriaBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //O if abaixo, chama o metodo valida() para validar se o campo esta preenchido
            if (this.valida())
            {
                //O codigo abaixo, cadastra os dados no banco de dados
                this.categoriaBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria Inserida com Sucesso!");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            //O if abaixo, confirma se o usuario quer mesmo excluir
            if (MessageBox.Show("Deseja realmente excluir?", "Excluir categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //O if abaixo chama o metodo para validar se a categoria possui produtos vinculados
                if (this.CategoriaPossuiProduto(this.categoriaAtual))
                    MessageBox.Show("Existem produtos vinculados nesta categoria!");
                else
                {
                    //O codigo abaixo exclui o item selecionado do banco de dados
                    this.categoriaBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria Removida!");
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
        }

        public Categoria categoriaAtual
        {
            get
            {
                return (Categoria)this.categoriaBindingSource.Current;
            }
        }

        //O metodo abaixo verifica se existem produtos na categoria
        private bool CategoriaPossuiProduto(Categoria categoria){

            var produtos = DataContextFactory.DataContext.Produtos.Where(x => x.CodigoCategoria == categoria.Codigo);
            if (produtos.Count() > 0)
                return true;
            else
                return false;
        }

    }
}
