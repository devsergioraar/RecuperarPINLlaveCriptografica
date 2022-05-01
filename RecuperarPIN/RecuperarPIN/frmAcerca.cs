using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuperarClave
{
    public partial class frmAcerca : Form
    {
        public frmAcerca()
        {
            InitializeComponent();
        }

        private void btnGoGithub_Click( object sender, EventArgs e )
        {
            System.Diagnostics.Process.Start("http://github.com/sergioraar");
        }
    }
}
