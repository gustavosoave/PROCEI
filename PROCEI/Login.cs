using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PROCEI.Controller;

namespace PROCEI
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            PROCEI.Controller.Login loginController = new PROCEI.Controller.Login();
            loginController.usuario = txtUsuario.Text;
            loginController.senha = txtSenha.Text;

            if (loginController.doLogin())
            {
                MDIPrincipal mdiPrincipal = new MDIPrincipal();
                mdiPrincipal.Show();
                Hide();
            }
            else 
            {
                MessageBox.Show("Usuario ou senha invalidos", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
    }
}
