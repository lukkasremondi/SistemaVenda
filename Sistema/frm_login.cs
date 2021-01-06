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
    public partial class frm_login : Form
    {

        public string usuariologado { get; set; }

        public bool logado = false;

        public frm_login()
        {
            InitializeComponent();
        }

        public void EfetuarLogin()
        {
            var user = DataContextFactory.DataContext.Usuarios.Count(
                x => x.Usuario == txt_usuario.Text && x.Senha == txt_senha.Text);

            if (user > 0)
            {
                this.logado = true;
                var formulario = new frm_menu(txt_usuario.Text);
                this.Dispose();
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválida");
            }

        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            EfetuarLogin();

        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(this, new EventArgs());
            }
        }
    }
}
