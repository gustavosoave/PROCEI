using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROCEI.Controller
{
    class Login
    {
        public String usuario { get; set; }
        public String senha { get; set; }

        public Boolean doLogin() {
            if (usuario != "admin")
                return false;
            if (senha != "admin")
                return false;

            return true;
        }

    }
}
