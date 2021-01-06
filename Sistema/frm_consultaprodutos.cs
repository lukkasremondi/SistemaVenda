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
    public partial class frm_consultaprodutos : Form
    {
        public frm_consultaprodutos()
        {
            InitializeComponent();
        }

        private void frm_consultaprodutos_Load(object sender, EventArgs e)
        {
            //O codigo abaixo, carrega o banco de dados para preencher o grid ao iniciar o form
            //this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)CB_categoria.SelectedValue);
        }

        public void Pesquisar(int codigoCategoria)
        {
            //O codigo abaixo compara o codigo categoria do produto com o codigo ctegoria selecionado no combobox
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos.Where(x => x.CodigoCategoria == codigoCategoria);

        }
    }
}
