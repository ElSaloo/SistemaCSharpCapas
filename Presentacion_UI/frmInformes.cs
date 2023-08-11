using Entidades_BE;
using Negocio_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class frmInformes : Form
    {
        BLLInformes BLLinformes;
        public frmInformes()
        {
            InitializeComponent();
            BLLinformes = new BLLInformes();
        }

        private void frmInformes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tP1integradorDataSet.Vehiculo' table. You can move, or remove it, as needed.
            this.vehiculoTableAdapter.Fill(this.tP1integradorDataSet.Vehiculo);
            this.reportViewer1.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult atras = MessageBox.Show("¿Desea salir?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (atras == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTotalVehiculosAdquirido_Click(object sender, EventArgs e)
        {
            txtTotalCompra.Text = Convert.ToInt32(BLLinformes.TotalAdquirido()).ToString();
        }

        private void btnTotalVenta_Click(object sender, EventArgs e)
        {
            txtTotalVenta.Text = Convert.ToInt32(BLLinformes.TotalVendido()).ToString();
        }

        private void btnTotalDisponible_Click(object sender, EventArgs e)
        {
            txtTotalDisponible.Text = (Convert.ToInt32(BLLinformes.TotalAdquirido()) - Convert.ToInt32(BLLinformes.TotalVendido())).ToString();
        }

        private void btnMostExpensive_Click(object sender, EventArgs e)
        {
            txtMostExpensive.Text = "USD $ " + (Convert.ToDecimal(BLLinformes.PrecioMasAlto())).ToString();
        }

        private void btnTotalMarca_Click(object sender, EventArgs e)
        {
            MuestroEnGrillaAutosDisponible();
        }
        void MuestroEnGrillaAutosDisponible()
        {
            this.dtgvVehiculosPorMarca.DataSource = null;
            this.dtgvVehiculosPorMarca.DataSource = BLLinformes.ListarDisponible();
            this.dtgvVehiculosPorMarca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvVehiculosPorMarca.Columns["Precio"].HeaderText = "Precio USD $";
        }

        private void btnTotalRecaudado_Click(object sender, EventArgs e)
        {
            txtTotalRecaudado.Text = "USD $ " + (Convert.ToDecimal(BLLinformes.ValorEmpresaTotal())).ToString();
        }

        private void btnVendidoPorMarca_Click(object sender, EventArgs e)
        {
            MuestroEnGrillaDeAutosVendido();
        }

        void MuestroEnGrillaDeAutosVendido()
        {
            string marca = comboBox1.Text;
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = BLLinformes.ListarPorMarcaVendido(marca);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.Columns["Precio"].HeaderText = "Precio USD $";
        }

        private void btnVerTodosVendido_Click(object sender, EventArgs e)
        {
            MuestroEnGrillaDeTodosAutosVendido();
        }

        void MuestroEnGrillaDeTodosAutosVendido()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = BLLinformes.ListarTodosVendido();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.Columns["Precio"].HeaderText = "Precio USD $";
        }

    }
}
