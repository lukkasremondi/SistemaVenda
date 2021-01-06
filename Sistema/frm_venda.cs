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
    public partial class frm_venda : Form
    {
        public frm_venda()
        {
            InitializeComponent();
        }

        private void frm_venda_Load(object sender, EventArgs e)
        {
            //O metodo abaixo atualiza o grid com as informações do banco de dados
            this.pessoasBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Vendas;
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;

            this.vendaBindingSource.AddNew();
        }

        public Venda VendaCorrente
        {
            get
            {
                return (Venda)this.vendaBindingSource.Current;
            }
        }

        public IntensVenda ItemCorrente
        {
            get
            {
                return (IntensVenda)this.intensVendaBindingSource.Current;
            }
        }

        private void btn_novavenda_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.EndEdit();
            //DataContextFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
            btn_novavenda.Enabled = false;

            this.intensVendaBindingSource.DataSource = DataContextFactory.DataContext.IntensVendas.Where (x => x.CodigoProduto == this.VendaCorrente.CodigoVenda);
            NovoItem();
        }

        private void NovoItem()
        {
            this.intensVendaBindingSource.AddNew();
            this.ItemCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ItemCorrente.Quantidade = 1;
        }

        private void btn_novoitem_Click(object sender, EventArgs e)
        {
            this.intensVendaBindingSource.EndEdit();
            DG_vendas.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            NovoItem();


        }

        private void DG_vendas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
