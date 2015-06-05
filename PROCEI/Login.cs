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
        PROCEI.Controller.Login loginController = new PROCEI.Controller.Login();
        CaptchaItem ci;

        public fmLogin()
        {
            InitializeComponent();
            mudaCaptcha();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            loginController.Usuario = txtUsuario.Text;
            loginController.Senha = txtSenha.Text;
            loginController.TextCaptcha = txtCaptcha.Text;
            

            if (loginController.doLogin())
            {
                MDIPrincipal mdiPrincipal = new MDIPrincipal();
                mdiPrincipal.Show();
                Hide();
            }
            else 
            {
                MessageBox.Show("Usuario, senha ou imagem incorretos!\nFavor tentar novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
        private void mudaCaptcha(){
            loginController.Captcha = null;
            ci = loginController.Captcha;
            pbCaptcha.Image = ci.Imagem;
        }

        private void btAtualizaCaptcha_Click(object sender, EventArgs e)
        {
            mudaCaptcha();
        }
    }
}
