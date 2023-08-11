using Entidades_BE;
using Microsoft.VisualBasic;
using Negocio_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Presentacion_UI
{
    public partial class frmVehiculo : Form
    {
        BEVehiculo BEvehiculo;
        BLLVehiculo BLLvehiculo;
        public frmVehiculo()
        {
            InitializeComponent();
            BEvehiculo = new BEVehiculo();
            BLLvehiculo = new BLLVehiculo();
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            MostrarEnGrilla();
            MostrarEnGrillaXML();
            DesactivarFiltro();
        }
        void MostrarEnGrillaXML()
        {
            this.dataGridViewVehiculosXML.DataSource = null;
            this.dataGridViewVehiculosXML.DataSource = LeerXMLlinq();
            this.dataGridViewVehiculosXML.Columns["Estado"].Visible = false;
            this.dataGridViewVehiculosXML.Columns["Codigo"].Visible = false;
        }
        void MostrarEnGrilla()
        {
            this.dtgvVehiculos.DataSource = null;
            this.dtgvVehiculos.DataSource = BLLvehiculo.ListarTodo();
            this.dtgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvVehiculos.Columns["Precio"].HeaderText = "Precio USD $";
        }
        void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtPatente.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtKilometraje.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtEstado.Text = string.Empty;
            comboBoxMarca.SelectedItem = null;
            comboBox1.Text = string.Empty;
        }
        void VerificarDatosDeAutoREGEX()
        {
            if (txtPatente.Text == string.Empty) throw new Exception("Debe ingresar el patente del vehiculo.");
            string PATENTE = txtPatente.Text;
            bool respuestaPat = Regex.IsMatch(PATENTE, "^([A-Z]{3}\\s[0-9]{3}$|[A-Z]{2}\\s[0-9]{3}\\s[A-Z]{2}$)");
            if(respuestaPat == false)
            {
                MessageBox.Show("El patente ingresado NO respeta ninguna de las opciones del formato de patente antiguo o formato nuevo.\n\n(Tenga en cuenta los espacios entre numeros y letras)");
                txtPatente.Text = string.Empty;
            }
            if (comboBoxMarca.SelectedItem == null) throw new Exception("Debe elegir la marca del vehiculo a ingresar.");

            if (txtModelo.Text == string.Empty) throw new Exception("Debe ingresar el modelo del vehiculo.");
            string MODELO = txtModelo.Text;
            bool respuestaMod = Regex.IsMatch(MODELO, "^([a-zA-Z0-9]+$)");
            if (respuestaMod == false)
            {
                MessageBox.Show("El modelo no puede contener caracteres especiales.");
                txtModelo.Text = string.Empty;

            }
            if (comboBox1.SelectedItem == null) throw new Exception("Debe elegir el año del vehiculo a ingresar.");

            if (txtKilometraje.Text == string.Empty) throw new Exception("Debe ingresar el kilometraje del vehiculo.");
            string KILOMETRAJE = txtKilometraje.Text;
            bool respuestaKilo = Regex.IsMatch(KILOMETRAJE, "^([0-9]+$)");
            if (respuestaKilo == false)
            {
                MessageBox.Show("El kilometraje debe ser numerico.");
            }

            if (txtPrecio.Text == string.Empty) throw new Exception("Debe ingresar el precio del vehiculo.");
            string PRECIO = txtPrecio.Text;
            bool respuestaPre = Regex.IsMatch(PRECIO, "^([0-9]+$)");
            if (respuestaPre == false)
            {
                MessageBox.Show("El precio debe ser numerico.");
                txtPrecio.Text = string.Empty;
            }
        }

        private void btnAltaAuto_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarDatosDeAutoREGEX();

                BEvehiculo.Patente = txtPatente.Text;
                BEvehiculo.Marca = comboBoxMarca.SelectedItem.ToString();
                BEvehiculo.Modelo = txtModelo.Text;
                BEvehiculo.Kilometraje = Convert.ToInt32(txtKilometraje.Text);
                BEvehiculo.Año = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                BEvehiculo.Precio = Convert.ToDecimal(txtPrecio.Text);
                BEvehiculo.Estado = BEvehiculo.DeterminarEstadoDeAuto();
                BLLvehiculo.Guardar(BEvehiculo);
                AgregarXMLlinq();
                MostrarEnGrillaXML();
                MostrarEnGrilla();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBajaAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text == "") throw new Exception("Debe elegir el vehiculo a eliminar.");

                Asignar();
                DialogResult respuesta;
                respuesta = MessageBox.Show("¿Desea eliminar el vehiculo?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    BLLvehiculo.Baja(BEvehiculo);
                    MessageBox.Show("El vehiculo se ha eliminado del sistema.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Operacion cancelada.");
                }
                MostrarEnGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Asignar()
        {
            try
            {
                BEvehiculo.Codigo = Convert.ToInt32(txtCodigo.Text);
                BEvehiculo.Patente = txtPatente.Text;
                BEvehiculo.Marca = comboBoxMarca.SelectedItem.ToString();
                BEvehiculo.Modelo = txtModelo.Text;
                BEvehiculo.Kilometraje = Convert.ToInt32(txtKilometraje.Text);
                BEvehiculo.Año = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                BEvehiculo.Precio = Convert.ToDecimal(txtPrecio.Text);
                BEvehiculo.Estado = BEvehiculo.DeterminarEstadoDeAuto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BEvehiculo = (BEVehiculo)this.dtgvVehiculos.CurrentRow.DataBoundItem;
                txtCodigo.Text = BEvehiculo.Codigo.ToString();
                txtPatente.Text = BEvehiculo.Patente;
                comboBoxMarca.SelectedItem = BEvehiculo.Marca;
                txtModelo.Text = BEvehiculo.Modelo;
                txtKilometraje.Text = BEvehiculo.Kilometraje.ToString();
                comboBox1.SelectedItem = BEvehiculo.Año.ToString();
                txtPrecio.Text = BEvehiculo.Precio.ToString();
                txtEstado.Text = BEvehiculo.Estado.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModiAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text == "") throw new Exception("Debe elegir el vehiculo a modificar.");

                VerificarDatosDeAutoREGEX();

                Asignar();
                BLLvehiculo.Guardar(BEvehiculo);
                MostrarEnGrilla();
                MessageBox.Show($"Se ha modificado el vehiculo de codigo: {BEvehiculo.Codigo}.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult atras = MessageBox.Show("¿Desea salir?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (atras == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public List<BEVehiculo> LeerXMLlinq()
        {
            var consulta = from Vehiculo in XElement.Load("VehiculosDisponible.xml").Elements("Vehiculo")
                           select new BEVehiculo
                           {
                               Patente = Convert.ToString(Vehiculo.Attribute("Patente").Value).Trim(),
                               Marca = Convert.ToString(Vehiculo.Element("Marca").Value).Trim(),
                               Modelo = Convert.ToString(Vehiculo.Element("Modelo").Value).Trim(),
                               Año = Convert.ToInt32(Convert.ToString(Vehiculo.Element("Año").Value).Trim()),
                               Kilometraje = Convert.ToInt32(Convert.ToString(Vehiculo.Element("Kilometraje").Value).Trim()),
                               Precio = Convert.ToDecimal(Convert.ToString(Vehiculo.Element("Precio").Value).Trim()),
                           };
            List<BEVehiculo> listavehiculo = consulta.ToList<BEVehiculo>();
            return listavehiculo;
        }
        private void AgregarXMLlinq()
        {
            XDocument xmlDocumento = XDocument.Load("VehiculosDisponible.xml");
            xmlDocumento.Element("Vehiculos").Add(new XElement("Vehiculo",
                                                  new XAttribute("Patente", this.txtPatente.Text.Trim()),
                                                  new XElement("Marca", this.comboBoxMarca.SelectedItem.ToString()),
                                                  new XElement("Modelo", this.txtModelo.Text.Trim()),
                                                  new XElement("Año", this.comboBox1.SelectedItem.ToString()),
                                                  new XElement("Kilometraje", this.txtKilometraje.Text.Trim()),
                                                  new XElement("Precio", this.txtPrecio.Text.Trim())));
            xmlDocumento.Save("VehiculosDisponible.xml");
            LeerXMLlinq();
        }

        private void btnBusquedaFiltro_Click(object sender, EventArgs e)
        {
            this.dataGridViewVehiculosXML.DataSource = null;
            this.dataGridViewVehiculosXML.DataSource = BuscarXML();
        }
        private List<BEVehiculo> BuscarXML()
        {
            if (!Information.IsNumeric(textBox1.Text)) throw new Exception("El precio debe ser numerico.");
            var consulta =
                from Vehiculo in XElement.Load("VehiculosDisponible.xml").Elements("Vehiculo")
                where (string)Vehiculo.Element("Marca") == comboBoxBusquedaMarca.SelectedItem.ToString() || (decimal)Vehiculo.Element("Precio") <= Convert.ToDecimal(textBox1.Text.ToString())
                select new BEVehiculo
                {
                    Patente = Convert.ToString(Vehiculo.Attribute("Patente").Value).Trim(),
                    Marca = Convert.ToString(Vehiculo.Element("Marca").Value).Trim(),
                    Modelo = Convert.ToString(Vehiculo.Element("Modelo").Value).Trim(),
                    Año = Convert.ToInt32(Convert.ToString(Vehiculo.Element("Año").Value).Trim()),
                    Kilometraje = Convert.ToInt32(Convert.ToString(Vehiculo.Element("Kilometraje").Value).Trim()),
                    Precio = Convert.ToDecimal(Convert.ToString(Vehiculo.Element("Precio").Value).Trim()),
                };
            List<BEVehiculo> listavehiculo = consulta.ToList<BEVehiculo>();
            return listavehiculo;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ActivarFiltro();
        }

        private void btnSacarFiltro_Click(object sender, EventArgs e)
        {
            DesactivarFiltro();
        }
        private void DesactivarFiltro()
        {
            this.btnBusquedaFiltro.Visible = false;
            this.btnSacarFiltro.Visible = false;
            this.label10.Visible = false;
            this.comboBoxBusquedaMarca.Visible = false;
            this.textBox1.Visible = false;
            this.label11.Visible = false;
            this.btnFiltro.Visible = true;
            MostrarEnGrillaXML();
        }
        private void ActivarFiltro()
        {
            this.btnBusquedaFiltro.Visible = true;
            this.btnSacarFiltro.Visible = true;
            this.label10.Visible = true;
            this.comboBoxBusquedaMarca.Visible = true;
            this.textBox1.Visible = true;
            this.label11.Visible = true;
            this.btnFiltro.Visible = false;
        }

        private void dataGridViewVehiculosXML_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BEVehiculo vehiculo = new BEVehiculo();
            vehiculo = (BEVehiculo)dataGridViewVehiculosXML.CurrentRow.DataBoundItem;
            txtPatente.Text = vehiculo.Patente.Trim();
            comboBoxMarca.SelectedItem = vehiculo.Marca.Trim();
            txtModelo.Text = vehiculo.Modelo.Trim();
            comboBox1.SelectedItem = vehiculo.Año.ToString().Trim();
            txtKilometraje.Text = vehiculo.Kilometraje.ToString().Trim();
            txtPrecio.Text = vehiculo.Precio.ToString().Trim();
        }

        private void btnModiXML_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewVehiculosXML.SelectedRows.Count > 0)
                {
                    VerificarDatosDeAutoREGEX();
                    ModificarXML(txtPatente.Text);
                    MessageBox.Show($"Se ha modificado el vehiculo de Patente: {txtPatente.Text} SOLAMENTE en el archivo de XML.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarEnGrillaXML();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Debe elegir el vehiculo a modificar de la lista de vehiculos XML.");
                }
            }
            catch (XmlException xmlex)
            {
                MessageBox.Show(xmlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ModificarXML(string patente)
        {
            XDocument documento = XDocument.Load("VehiculosDisponible.xml");
            var consulta = from vehiculo in documento.Descendants("Vehiculo")
                           where vehiculo.Attribute("Patente").Value == patente
                           select vehiculo;
            foreach (XElement modificado in consulta)
            {
                modificado.Element("Marca").Value = comboBoxMarca.SelectedItem.ToString().Trim();
                modificado.Element("Modelo").Value = txtModelo.Text.Trim();
                modificado.Element("Año").Value = comboBox1.SelectedItem.ToString().Trim();
                modificado.Element("Kilometraje").Value = txtKilometraje.Text.Trim();
                modificado.Element("Precio").Value = txtPrecio.Text.Trim();
            }
            documento.Save("VehiculosDisponible.xml");
        }

        private void btnElimXML_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewVehiculosXML.SelectedRows.Count > 0)
                {
                    DialogResult respuesta;
                    respuesta = MessageBox.Show("¿Desea eliminar el vehiculo del archivo XML?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        EliminarXML(txtPatente.Text);
                        MessageBox.Show("El vehiculo se ha eliminado del archivo XML.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Operacion cancelada.");
                    }
                    MostrarEnGrillaXML();
                }
                else
                {
                    MessageBox.Show("Debe elegir el vehiculo a eliminar de la lista de vehiculos XML.");
                }
            }
            catch(XmlException xmlex)
            {
                MessageBox.Show(xmlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EliminarXML(string patente)
        {
            XDocument documento = XDocument.Load("VehiculosDisponible.xml");
            var consulta = from vehiculo in documento.Descendants("Vehiculo")
                           where vehiculo.Attribute("Patente").Value == patente
                           select vehiculo;
            consulta.Remove();
        }
    }
}
