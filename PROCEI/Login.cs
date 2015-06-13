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
        public Boolean logado = false;
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
                logado = true;
                Close();
            }
            else 
            {
                MessageBox.Show("Usuario, senha ou imagem incorretos!\nFavor tentar novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mudaCaptcha();
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

        private void fmLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
