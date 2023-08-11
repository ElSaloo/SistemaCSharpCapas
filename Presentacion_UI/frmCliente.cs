using Negocio_BLL;
using Entidades_BE;
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
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Presentacion_UI
{
    public partial class frmCliente : Form
    {
        BLLLocalidad BLlocalidad;
        BELocalidad BElocalidad;
        BECliente BEcliente;
        BLLClienteNormal BLLclientenormal;
        BEClienteNormal BEclientenormal;
        BEClientePremium BEclientepremium;
        public frmCliente()
        {
            InitializeComponent();
            BLlocalidad = new BLLLocalidad();
            BElocalidad = new BELocalidad();
            BLLclientenormal = new BLLClienteNormal();
            BEclientenormal = new BEClienteNormal();
            BEclientepremium = new BEClientePremium();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarComboLocalidad();
            comboBoxLocalidad.SelectedItem = null;
            dateTimePickerFechNac.Value = DateTime.Now;
            MostrarEnGrilla();
            textBoxPremium.Visible= false;
        }
        void CargarComboLocalidad()
        {
            comboBoxLocalidad.DataSource = null;
            comboBoxLocalidad.DataSource = BLlocalidad.ListarTodo();
            comboBoxLocalidad.ValueMember = "Codigo";
            comboBoxLocalidad.DisplayMember = "Direccion";
            comboBoxLocalidad.Refresh();
        }
        void MostrarEnGrilla()
        {
            this.dtgvCliente.DataSource = null;
            this.dtgvCliente.DataSource = BLLclientenormal.ListarTodo();
            this.dtgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvCliente.Columns["Direccion"].HeaderText = "Localidad";
            this.dtgvCliente.Columns["Legajo"].DefaultCellStyle.BackColor = Color.LightGray;
        }

        void Asignar()
        {
            try
            {
                int cliente = Convert.ToInt32(textBoxPremium.Text);
                if(cliente == 0)
                {
                    BEclientenormal.Legajo = Convert.ToInt32(txtLegajo.Text);
                    BEclientenormal.Nombre = txtNombre.Text;
                    BEclientenormal.Apellido = txtApellido.Text;
                    BEclientenormal.DNI = Convert.ToInt32(txtDNI.Text);
                    BEclientenormal.Telefono = Convert.ToInt32(txtTelefono.Text);
                    BEclientenormal.FechaNacimiento = this.dateTimePickerFechNac.Value;
                    BEclientenormal.Edad = BEclientenormal.CalcularEdad();
                    BEclientenormal.Direccion = (BELocalidad)this.comboBoxLocalidad.SelectedItem;
                }
                else
                {
                    BEclientepremium.Legajo = Convert.ToInt32(txtLegajo.Text);
                    BEclientepremium.Nombre = txtNombre.Text;
                    BEclientepremium.Apellido = txtApellido.Text;
                    BEclientepremium.DNI = Convert.ToInt32(txtDNI.Text);
                    BEclientepremium.Telefono = Convert.ToInt32(txtTelefono.Text);
                    BEclientepremium.FechaNacimiento = this.dateTimePickerFechNac.Value;
                    BEclientepremium.Edad = BEclientepremium.CalcularEdad();
                    BEclientepremium.Direccion = (BELocalidad)this.comboBoxLocalidad.SelectedItem;
                    BEclientepremium.Premium = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Limpiar()
        {
            try
            {
                txtLegajo.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtDNI.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtEdad.Text = string.Empty;
                comboBoxLocalidad.SelectedItem = null;
                dateTimePickerFechNac.Value = DateTime.Now;
                textBoxPremium.Text = string.Empty;
                radioButtonPremium.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnModiCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLegajo.Text == string.Empty) throw new Exception("Debe elegir el cliente a modificar");
                Asignar();
                if (textBoxPremium.Text == "1")
                {
                    BLLclientenormal.Guardar(BEclientepremium);
                }
                else
                {
                    BLLclientenormal.Guardar(BEclientenormal);
                }
                MostrarEnGrilla();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonPremium.Checked)
                {
                    BEclientepremium = new BEClientePremium();
                    BEclientepremium.Premium = true;
                    VerificoDatosREGEX();
                    BEclientepremium.Nombre = txtNombre.Text;
                    BEclientepremium.Apellido = txtApellido.Text;
                    BEclientepremium.DNI = Convert.ToInt32(txtDNI.Text);
                    BEclientepremium.Telefono = Convert.ToInt32(txtTelefono.Text);
                    BEclientepremium.FechaNacimiento = this.dateTimePickerFechNac.Value;
                    BEclientepremium.Edad = BEclientepremium.CalcularEdad();
                    BEclientepremium.Direccion = (BELocalidad)this.comboBoxLocalidad.SelectedItem;
                    BLLclientenormal.Guardar(BEclientepremium);
                }
                else
                {
                    BEcliente = new BEClienteNormal();
                    VerificoDatosREGEX();
                    BEclientenormal.Nombre = txtNombre.Text;
                    BEclientenormal.Apellido = txtApellido.Text;
                    BEclientenormal.DNI = Convert.ToInt32(txtDNI.Text);
                    BEclientenormal.Telefono = Convert.ToInt32(txtTelefono.Text);
                    BEclientenormal.FechaNacimiento = this.dateTimePickerFechNac.Value;
                    BEclientenormal.Edad = BEclientenormal.CalcularEdad();
                    BEclientenormal.Direccion = (BELocalidad)this.comboBoxLocalidad.SelectedItem;
                    BLLclientenormal.Guardar(BEclientenormal);
                }
                MostrarEnGrilla();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void VerificoDatosREGEX()
        {
            if (txtNombre.Text == string.Empty) throw new Exception("Debe ingresar el nombre del cliente.");
            string NOMBRE = txtNombre.Text;
            bool respuestaNombre = Regex.IsMatch(NOMBRE, "^([a-zA-Z]+$)");
            if (respuestaNombre == false)
            {
                MessageBox.Show("El nombre debe ser alfabetico.");
                txtNombre.Text = string.Empty;
            }

            if (txtApellido.Text == string.Empty) throw new Exception("Debe ingresar el apellido del cliente.");
            string APELLIDO = txtApellido.Text;
            bool respuestaApellido = Regex.IsMatch(APELLIDO, "^([a-zA-Z]+$)");
            if (respuestaApellido == false)
            {
                MessageBox.Show("El apellido debe ser alfabetico.");
                txtApellido.Text = string.Empty;
            }

            if (txtDNI.Text == string.Empty) throw new Exception("Debe ingresar el DNI del cliente.");
            string DNI = txtDNI.Text;
            bool respuestaDNI = Regex.IsMatch(DNI, "^([0-9]{8})");
            if (respuestaDNI == false)
            {
                MessageBox.Show("El DNI debe ser de 8 digitos sin espacios o puntos.");
            }

            if (DateTime.Now.Year - dateTimePickerFechNac.Value.Year < 16) throw new Exception("El cliente debe cumplir los 16 años antes de poder ser registrado en el sistema.");

            if (txtTelefono.Text == string.Empty) throw new Exception("Debe ingresar el telefono del cliente.");
            string TELEFONO = txtTelefono.Text;
            bool respuestaTele = Regex.IsMatch(TELEFONO, "^([0-9]{10})");
            if (respuestaTele == false)
            {
                MessageBox.Show("El numero de telefono son los 2 digitos de su area + los 8 digitos.");
                txtTelefono.Text = string.Empty;
            }

            if (comboBoxLocalidad.SelectedItem == null) throw new Exception("Debe ingresar la localidad del cliente.");
        }
        private void dtgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
            try
            {
                radioButtonPremium.Checked = false;
                radioButtonPremium.Enabled = false;

                BEcliente = (BECliente)this.dtgvCliente.CurrentRow.DataBoundItem;
                txtLegajo.Text = BEcliente.Legajo.ToString();
                txtNombre.Text = BEcliente.Nombre;
                txtApellido.Text = BEcliente.Apellido;
                txtDNI.Text = BEcliente.DNI.ToString();
                txtTelefono.Text = BEcliente.Telefono.ToString();
                comboBoxLocalidad.Text = BEcliente.Direccion.Direccion;
                this.dateTimePickerFechNac.Value = BEcliente.FechaNacimiento;
                txtEdad.Text = BEcliente.CalcularEdad().ToString();
                if(BEcliente is BEClientePremium)
                {
                    textBoxPremium.Text = "true";
                }
                else
                {
                    textBoxPremium.Text = "false";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLegajo.Text == string.Empty) throw new Exception("Debe elegir el cliente a eliminar");
                Asignar();
                DialogResult respuesta;
                respuesta = MessageBox.Show("¿Desea eliminar el cliente?, algun vehiculo asociado a este cliente aparecera libre sin dueño en el registro de vehiculos", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    BLLclientenormal.Baja(BEcliente);
                    MostrarEnGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            radioButtonPremium.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult atras = MessageBox.Show("¿Desea salir?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (atras == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
