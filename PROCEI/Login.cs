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
            MDIPrincipal mdiPrincipal = new MDIPrincipal();
            mdiPrincipal.Show();
            Hide();

            CriptografiaCesar cc = new CriptografiaCesar();
            cc.encripta("Admin");
            cc.decripta(cc.encripta("Admin"));
        }
    }
}
