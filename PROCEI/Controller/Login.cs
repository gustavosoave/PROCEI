using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROCEI.Controller
{
    class Login
    {
        public String usuario { get; set; }
        public String senha { get { return senha; } set { new CriptografiaCesar().encripta(value); } }

        public Boolean doLogin() {

            if (usuario != "admin")
                return false;
            if (senha != new CriptografiaCesar().encripta("admin"))
                return false;

            return true;
        }

    }
}
