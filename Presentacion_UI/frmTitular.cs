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

namespace Presentacion_UI
{
    public partial class frmTitular : Form
    {
        BECliente BEcliente;
        BLLVehiculo BLLvehiculo;
        BEVehiculo BEvehiculo;
        BLLClienteNormal BLLclientenormal;
        BLLClientePremium BLLclientepremium;
        public frmTitular()
        {
            InitializeComponent();
            BEcliente = null;
            BLLvehiculo = new BLLVehiculo();
            BEvehiculo = new BEVehiculo();
            BLLclientenormal = new BLLClienteNormal();
            BLLclientepremium = new BLLClientePremium();
        }

        private void frmTitular_Load(object sender, EventArgs e)
        {
            MostrarEnGrilla();
            CargarComboVehiculos();
        }

        void MostrarEnGrilla()
        {
            this.dtgvClientePreventa.DataSource = null;
            this.dtgvClientePreventa.DataSource = BLLclientenormal.ListarTodo();
            this.dtgvClientePreventa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvClientePreventa.Columns["Direccion"].Visible= false;
        }
        void CargarComboVehiculos()
        {
            comboBoxVehiculos.DataSource = null;
            comboBoxVehiculos.DataSource = BLLvehiculo.ListarTodo();
            comboBoxVehiculos.Refresh();
            comboBoxVehiculos.SelectedItem = null;
        }

        void MostrarEnGrilla2()
        {
            try
            {
                dtgvVehiculoPreventa.DataSource = null;
                dtgvVehiculoPreventa.DataSource = BEcliente.vehiculosPropios;
                this.dtgvVehiculoPreventa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                if (dtgvVehiculoPreventa.Rows.Count > 0)
                {
                    dtgvVehiculoPreventa.DataSource = null;
                    dtgvVehiculoPreventa.DataSource = BEcliente.vehiculosPropios;
                    this.dtgvVehiculoPreventa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    this.dtgvVehiculoPreventa.Columns["Precio"].Visible = false;
                    this.dtgvVehiculoPreventa.Columns["Estado"].Visible = false;
                    this.dtgvVehiculoPreventa.Columns["Kilometraje"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void RefrescaCheckBoxyCombo()
        {
            checkBoxSeguro.Checked = false;
            checkBoxCertificadoTra.Checked = false;
            checkBoxCedula.Checked = false;

            comboBoxVehiculos.SelectedItem = null;
        }
        private void dtgvClientePreventa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblPropioVehiculo.Text = "---";

            BEcliente = (BECliente)dtgvClientePreventa.CurrentRow.DataBoundItem;

            lblCliente.Text = $"{BEcliente.DNI} | {BEcliente.Nombre} {BEcliente.Apellido}";

            MostrarEnGrilla2();

        }

        private void comboBoxVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxVehiculos.SelectedItem != null)
            {
                BEvehiculo = (BEVehiculo)comboBoxVehiculos.SelectedItem;

                lblVehiculo.Text = $"{BEvehiculo.Patente} {BEvehiculo.Marca} {BEvehiculo.Modelo} {BEvehiculo.Año}";
            }
            else
            {
                lblVehiculo.Text = "---";
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if(lblCliente.Text != "---")
            {
                if (checkBoxCedula.Checked && checkBoxCertificadoTra.Checked && checkBoxSeguro.Checked)
                {
                    try
                    {
                        BEcliente = (BECliente)dtgvClientePreventa.CurrentRow.DataBoundItem;
                        BEvehiculo = (BEVehiculo)comboBoxVehiculos.SelectedItem;

                        if (BEcliente is BEClientePremium)
                        {
                            decimal extra = BLLclientepremium.PrecioAPagar(BEvehiculo) - BEvehiculo.Precio;

                            DialogResult pago = MessageBox.Show($"Total a cobrar:\n\nValor de vehiculo: $ {BEvehiculo.Precio}\nDescuento: {extra}\n\nTotal: {BLLclientepremium.PrecioAPagar(BEvehiculo)}", "PAGO", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                            if (pago == DialogResult.OK)
                            {
                                if (BLLvehiculo.TransferirClienteVehiculo(BEcliente, BEvehiculo) == false)
                                {
                                    MessageBox.Show("El vehiculo ya se encuentra asociado.");
                                }
                                else
                                {
                                    BLLvehiculo.TransferirClienteVehiculo(BEcliente, BEvehiculo);
                                    MostrarEnGrilla();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sin el pago realizado, el vehiculo NO se podra transferir.");
                            }
                            MostrarEnGrilla2();
                            RefrescaCheckBoxyCombo();
                            comboBoxVehiculos.SelectedItem = null;                            
                        }
                        else
                        {
                            decimal extra = BLLclientenormal.PrecioAPagar(BEvehiculo) - BEvehiculo.Precio;

                            DialogResult pago = MessageBox.Show($"Total a cobrar:\n\nValor de vehiculo: $ {BEvehiculo.Precio}\nImpuesto: {extra}\n\nTotal: {BLLclientenormal.PrecioAPagar(BEvehiculo)}", "PAGO", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                            if (pago == DialogResult.OK)
                            {
                                if (BLLvehiculo.TransferirClienteVehiculo(BEcliente, BEvehiculo) == false)
                                {
                                    MessageBox.Show("El vehiculo ya se encuentra asociado.");
                                }
                                else
                                {
                                    BLLvehiculo.TransferirClienteVehiculo(BEcliente, BEvehiculo);
                                    MostrarEnGrilla();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sin el pago realizado, el vehiculo NO se podra transferir.");
                            }
                            MostrarEnGrilla2();
                            RefrescaCheckBoxyCombo();
                            comboBoxVehiculos.SelectedItem = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("El cliente no cumple con las precondiciones para la asignacion.\n\n" +
                    "Verifique:\n" +
                    "- Recibo de pago\n" +
                    "- Alta de seguro\n" +
                    "- Certificacion de transferencia (sellado por escribania)\n" +
                    "- Cedula verde\n");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el cliente.");
            }
        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblCliente.Text != null)
                {
                    BLLvehiculo.DesasignarClienteVehiculo(BEcliente, BEvehiculo);
                    MostrarEnGrilla();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el cliente y su vehiculo a desasociar.");
                }
                MostrarEnGrilla2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MostrarEnGrilla2();
        }

        private void dtgvVehiculoPreventa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (BEcliente.vehiculosPropios.Count> 0)
                {
                    BEvehiculo = (BEVehiculo)dtgvVehiculoPreventa.CurrentRow.DataBoundItem;
                    lblPropioVehiculo.Text = $"{BEvehiculo.Patente} | {BEvehiculo.Marca} {BEvehiculo.Modelo} {BEvehiculo.Año}";
                }
                else
                {
                    lblPropioVehiculo.Text = "---";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult atras = MessageBox.Show("¿Desea salir?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (atras == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
