using Entidades_BE;
using Negocio_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Security;

namespace Presentacion_UI
{
    public partial class frmLogin : Form
    {
        BELogin BElogin;
        BLLLogin BLLlogin;
        public frmLogin()
        {
            InitializeComponent();
            BElogin = new BELogin();
            BLLlogin = new BLLLogin();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
