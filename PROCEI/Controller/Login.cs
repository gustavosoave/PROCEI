using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROCEI.Controller
{
    class Login
    {
        public String Usuario { get; set; }

        private String senha;
        public String Senha { get { return new CriptografiaCesar().decripta(senha); } set { senha = new CriptografiaCesar().encripta(value); } }

        private CaptchaItem captcha;
        public CaptchaItem Captcha { get { return captcha ; } set { captcha = new Captcha().sorteio(); } }

        public String TextCaptcha { get; set; }

        public Boolean doLogin() {

            if (Usuario != "admin")
                return false;
            if (Senha != "admin")
                return false;
            if (TextCaptcha != Captcha.Valor)
                return false;

            return true;
        }

    }
}
