using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidad formLocalidad = new frmLocalidad();
            formLocalidad.MdiParent = this;
            formLocalidad.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente formCliente = new frmCliente();
            formCliente.MdiParent = this;
            formCliente.Show();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiculo formVehiculo = new frmVehiculo();
            formVehiculo.MdiParent = this;
            formVehiculo.Show();
        }

        private void transferenciaDeTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTitular formTitular = new frmTitular();
            formTitular.MdiParent = this;
            formTitular.Show();
        }

        private void informesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInformes formInformes = new frmInformes();
            formInformes.MdiParent = this;
            formInformes.Show();
        }

        private void preventasNoAutorizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreventa formPreventa = new frmPreventa();
            formPreventa.MdiParent = this;
            formPreventa.Show();
        }

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformeChart formInformesChart = new frmInformeChart();
            formInformesChart.MdiParent = this;
            formInformesChart.Show();
        }
    }
}
