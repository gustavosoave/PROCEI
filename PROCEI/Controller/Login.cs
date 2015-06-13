using System;
using System.Collections.Generic;
using System.Text;
using PROCEI.Model;

namespace PROCEI.Controller
{
    class Login
    {
        public String Usuario { get; set; }

        private String senha;
        public String Senha { get { return new CriptografiaCesar().encripta(senha); } set { senha = value; } }
         

        private CaptchaItem captcha;
        public CaptchaItem Captcha { get { return captcha ; } set { captcha = new Captcha().sorteio(); } }

        public String TextCaptcha { get; set; }

        public Boolean doLogin() {

            Usuarios usuarioModel = new Usuarios();

            try
            {
                ImportFile arquivoseguro = new ImportFile();
                usuarioModel = arquivoseguro.getUsuarioSenha(Usuario);
            }
            catch
            {
                return false;
            }

            if (Usuario.ToUpper() != usuarioModel.Usuario.ToUpper())
                return false;
            if (Senha != usuarioModel.Senha)
                return false;
            if (TextCaptcha != Captcha.Valor)
                return false;

            return true;
        }

    }
}
