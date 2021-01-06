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
    public partial class frm_consultaponto : Form
    {
        public frm_consultaponto()
        {
            InitializeComponent();
        }

        public frm_consultaponto(string usuario)
        {
            InitializeComponent();
            tssUserConsulta.Text = usuario;
        }

        private void frm_consultaponto_Load(object sender, EventArgs e)
        {
            this.usuariosBindingSource.DataSource = DataContextFactory.DataContext.Usuarios;
            //this.pontoBindingSource.DataSource = DataContextFactory.DataContext.Pontos;

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.BuscaPonto((int)CB_usuario.SelectedValue);
        }

        public void BuscaPonto(int codigoPonto)
        {
            if (CB_usuario.Text == tssUserConsulta.Text || (tssUserConsulta.Text == "adm"))
            {
                //O codigo abaixo compara o codigo categoria do produto com o codigo ctegoria selecionado no combobox
                this.pontoBindingSource.DataSource = DataContextFactory.DataContext.Pontos.Where(x => x.id_pessoa == codigoPonto);
                
            }
            else
            {
                MessageBox.Show("Você não pode consultar os lançamentos de outros usuários");
            }

        }

        private void pontoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void pontoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
    }
}
