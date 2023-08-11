using Entidades_BE;
using Negocio_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion_UI
{
    public partial class frmInformeChart : Form
    {
        BLLInformes BLLinformes;
        DataSet dataset = new DataSet();
        public frmInformeChart()
        {
            InitializeComponent();
            BLLinformes = new BLLInformes();
        }
        void CargoGrafico()
        {
            string[] xEmpresa = { " Total Vendido", " Total Adquirido" };
            int[] xCantidad = { BLLinformes.TotalVendido(), BLLinformes.TotalAdquirido() };
            chart1.Series[0].Points.DataBindXY(xEmpresa, xCantidad);
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

        private void frmInformeChart_Load(object sender, EventArgs e)
        {
            CargoGrafico();
            CargoLista();
            CargoLista2();
            CargoLista3();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult atras = MessageBox.Show("¿Desea salir?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (atras == DialogResult.Yes)
            {
                this.Close();
            }
        }
        void CargoLista()
        {
            Dictionary<string, decimal> listadatos = new Dictionary<string, decimal>();

            foreach (BEVehiculo vehiculo in BLLinformes.ListarTodosVendido())
            {
                BEVehiculo vehi = new BEVehiculo();
                vehi = vehiculo;
                listadatos.Add(vehi.Patente, vehi.Precio);
            }
            chart2.Titles.Clear();
            chart2.ChartAreas.Clear();
            chart2.Series.Clear();

            Title titulo = new Title("TOP 5 VEHICULO (Precio)");
            chart2.Titles.Add(titulo);

            ChartArea area = new ChartArea();
            chart2.ChartAreas.Add(area);

            Series serie = new Series("Precio USD $");
            serie.ChartType = SeriesChartType.Bar;
            serie.Points.DataBindXY(listadatos.Keys, listadatos.Values);

            chart2.Series.Add(serie);
        }
        void CargoLista2()
        {
            Dictionary<string, decimal> listadatos = new Dictionary<string, decimal>();

            foreach (BEVehiculo vehiculo in BLLinformes.ListarPorMarcaVendido("Volkswagen"))
            {
                BEVehiculo vehi = new BEVehiculo();
                vehi = vehiculo;
                listadatos.Add(vehi.Modelo, vehi.Precio);
            }
            chart3.Titles.Clear();
            chart3.ChartAreas.Clear();
            chart3.Series.Clear();

            Title titulo = new Title("VOLKSWAGEN VALOR");
            chart3.Titles.Add(titulo);

            ChartArea area = new ChartArea();
            chart3.ChartAreas.Add(area);
            chart3.ChartAreas[0].Area3DStyle.Enable3D = true;

            Series serie = new Series("Precio USD $");
            serie.ChartType = SeriesChartType.StackedColumn;
            serie.Points.DataBindXY(listadatos.Keys, listadatos.Values);
            serie.Font = new Font("Arial", 10, FontStyle.Bold);

            chart3.Series.Add(serie);
        }
        void CargoLista3()
        {
            Dictionary<string, decimal> listadatos = new Dictionary<string, decimal>();

            foreach (BEVehiculo vehiculo in BLLinformes.ListarDisponible())
            {
                BEVehiculo vehi = new BEVehiculo();
                vehi = vehiculo;
                listadatos.Add(vehi.Modelo, vehi.Kilometraje);
            }
            chart4.Titles.Clear();
            chart4.ChartAreas.Clear();
            chart4.Series.Clear();

            Title titulo = new Title("VEHICULOS VENDIDOS");
            chart4.Titles.Add(titulo);

            ChartArea area = new ChartArea();
            chart4.ChartAreas.Add(area);
            chart4.ChartAreas[0].Area3DStyle.Enable3D = true;

            Series serie = new Series("Kilometraje");
            serie.ChartType = SeriesChartType.Radar;
            serie.Points.DataBindXY(listadatos.Keys, listadatos.Values);
            serie.Font = new Font("Arial", 10, FontStyle.Bold);

            chart4.Series.Add(serie);
        }
    }
}
