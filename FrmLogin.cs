using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geek
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;
            if (usuario == "admin" && senha == "admin")
            {
                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretas! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtSenha.Text = "";
                this.txtUsuario.Focus();
            }
        }
    }
}
