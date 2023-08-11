using Entidades_BE;
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
using System.Xml;
using System.Xml.Linq;

namespace Presentacion_UI
{
    public partial class frmPreventa : Form
    {
        BLLCliente bllcliente;
        BLLClienteNormal bllclientenormal;
        BLLClientePremium bllclientepremium;
        BLLVehiculo bllvehiculo;
        BLLVendedor bllvendedor;
        BLLFormaDePago bllformadepago;
        BECliente BEcliente;
        BEVehiculo BEvehiculo;
        BEVendedor BEvendedor;
        BEPreventa preventa;
        BEFormaDePago formadepago;
        BLLInformes bllinformes;
        public frmPreventa()
        {
            InitializeComponent();
            bllcliente = new BLLClienteNormal();
            bllvehiculo = new BLLVehiculo();
            bllvendedor = new BLLVendedor();
            bllclientenormal = new BLLClienteNormal();
            bllclientepremium= new BLLClientePremium();
            BEvendedor = new BEVendedor();
            BEvehiculo = new BEVehiculo();
            formadepago = new BEFormaDePago();
            bllformadepago = new BLLFormaDePago();
            bllinformes = new BLLInformes();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult atras = MessageBox.Show("¿Desea salir?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (atras == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        void Limpiar()
        {
            try
            {
                comboBoxVehiculos.SelectedItem = null;
                comboBoxClientes.SelectedItem = null;
                comboBoxVendedores.SelectedItem = null;
                comboBoxForma.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmPreventa_Load(object sender, EventArgs e)
        {
            CargarComboVehiculos();
            CargarComboCliente();
            CargarComboVendedores();
            CargarComboFormas();
        }
        
        void CargarComboVehiculos()
        {
            comboBoxVehiculos.DataSource = null;
            comboBoxVehiculos.DataSource = bllinformes.ListarDisponible();
            comboBoxVehiculos.Refresh();
            comboBoxVehiculos.SelectedItem = null;
        }
        void CargarComboCliente()
        {
            comboBoxClientes.DataSource = null;
            comboBoxClientes.DataSource = bllcliente.ListarTodo();
            comboBoxClientes.Refresh();
            comboBoxClientes.SelectedItem = null;
        }
        void CargarComboVendedores()
        {
            comboBoxVendedores.DataSource = null;
            comboBoxVendedores.DataSource = bllvendedor.ListarTodo();
            comboBoxVendedores.Refresh();
            comboBoxVendedores.SelectedItem = null;
        }
        void CargarComboFormas()
        {
            comboBoxForma.DataSource = null;
            comboBoxForma.DataSource = bllformadepago.ListarTodo();
            comboBoxForma.Refresh();
            comboBoxForma.SelectedItem = null;
        }
        private void comboBoxVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVehiculos.SelectedItem != null)
            {
                BEvehiculo = (BEVehiculo)comboBoxVehiculos.SelectedItem;

                lblVehiculoSeleccionado.Text = $"Codigo: {BEvehiculo.Codigo}\n" +
                                               $"{BEvehiculo.Patente}\n" +
                                               $"{BEvehiculo.Marca} {BEvehiculo.Modelo} {BEvehiculo.Año}\n" +
                                               $"Kilometraje: {BEvehiculo.Kilometraje}\n" +
                                               $"PRECIO: USD$ {BEvehiculo.Precio}";
            }
            else
            {
                lblVehiculoSeleccionado.Text = "---";
            }
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedItem != null)
            {
                BEcliente = (BECliente)comboBoxClientes.SelectedItem;

                lblClienteSeleccionado.Text = $"Legajo: {BEcliente.Legajo}\n" +
                                              $"DNI: {BEcliente.DNI} | Nombre: {BEcliente.Nombre}, Apellido: {BEcliente.Apellido}\n" +
                                              $"Localidad: {BEcliente.Direccion.Direccion}, Telefono: {BEcliente.Telefono}";
            }
            else
            {
                lblClienteSeleccionado.Text = "---";
            }            
        }

        private void comboBoxVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVendedores.SelectedItem != null)
            {
                BEvendedor = (BEVendedor)comboBoxVendedores.SelectedItem;

                lblVendedorSeleccionado.Text = $"Codigo: {BEvendedor.Codigo}, DNI: {BEvendedor.DNI}\n" +
                                               $"Nombre: {BEvendedor.Nombre}, Apellido: {BEvendedor.Apellido}";
            }
            else
            {
                lblVendedorSeleccionado.Text = "---";
            }
        }

        private void btnCrearPreventa_Click(object sender, EventArgs e)
        {
            if (lblVehiculoSeleccionado.Text != "---")
            {
                if(lblClienteSeleccionado.Text != "---")
                {
                    if(lblVendedorSeleccionado.Text != "---")
                    {
                        if(lblForma.Text != "---")
                        {
                            BEvehiculo = (BEVehiculo)comboBoxVehiculos.SelectedItem;
                            BEcliente = (BECliente)comboBoxClientes.SelectedItem;
                            BEvendedor = (BEVendedor)comboBoxVendedores.SelectedItem;
                            formadepago = (BEFormaDePago)comboBoxForma.SelectedItem;

                            DateTime fechacreacion = DateTime.Now;

                            bool autorizacion = false;

                            if(BEcliente is BEClienteNormal)
                            {
                                decimal descuento = bllclientenormal.PrecioAPagar(BEvehiculo) - BEvehiculo.Precio;
                                decimal comisionvendedor = BEvehiculo.Precio * 0.10m;

                                decimal montototal = BEvehiculo.Precio - descuento + comisionvendedor;

                                DialogResult pago = MessageBox.Show($"Total a cobrar:\n\nValor de vehiculo: $ {BEvehiculo.Precio}\nDescuento: -$ {descuento}\nComision: +$ {comisionvendedor}\nMonto: $ {bllclientenormal.PrecioAPagar(BEvehiculo)}\n\n----------------\n\nTotal a cobrar: $ {montototal}", "PAGO", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                                if (pago == DialogResult.OK)
                                {
                                    preventa = new BEPreventa(BEvendedor, BEcliente, BEvehiculo, fechacreacion, formadepago, montototal, autorizacion);

                                    bllvendedor.CrearPreventa(preventa);
                                    bllvehiculo.TransferirClienteVehiculo(BEcliente, BEvehiculo);
                                }
                                MessageBox.Show($"Vehiculo {BEvehiculo.Patente} Asociado al cliente {BEcliente.DNI} Exitosamente!");
                            }
                            else
                            {
                                decimal descuento = bllclientepremium.PrecioAPagar(BEvehiculo) - BEvehiculo.Precio;
                                decimal comisionvendedor = BEvehiculo.Precio * 0.10m;

                                decimal montototal = BEvehiculo.Precio - descuento + comisionvendedor;

                                DialogResult pago = MessageBox.Show($"Total a cobrar:\n\nValor de vehiculo: $ {BEvehiculo.Precio}\nDescuento: -$ {descuento}\nComision: +$ {comisionvendedor}\nMonto: $ {bllclientepremium.PrecioAPagar(BEvehiculo)}\n\n----------------\n\nTotal a cobrar: $ {montototal}", "PAGO", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                                if (pago == DialogResult.OK)
                                {
                                    preventa = new BEPreventa(BEvendedor, BEcliente, BEvehiculo, fechacreacion, formadepago, montototal, autorizacion);

                                    bllvendedor.CrearPreventa(preventa);
                                    bllvehiculo.TransferirClienteVehiculo(BEcliente, BEvehiculo);
                                }
                                MessageBox.Show($"Vehiculo {BEvehiculo.Patente} Asociado al cliente {BEcliente.DNI} Exitosamente!");
                            }
                        }
                        else
                        {
                            throw new Exception("Debe seleccionar la forma de pago.");
                        }
                    }
                    else
                    {
                        throw new Exception("Debe seleccionarse como vendedor de la venta.");
                    }
                }
                else
                {
                    throw new Exception("Debe seleccionar un cliente.");
                }
            }
            else
            {
                throw new Exception("Debe seleccionar un vehiculo.");
            }
            
        }

        private void comboBoxForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxForma.SelectedItem != null)
            {
                formadepago = (BEFormaDePago)comboBoxForma.SelectedItem;

                lblForma.Text = $"Codigo: {BEvendedor.Codigo}, DNI: {BEvendedor.DNI}\n" +
                                               $"Nombre: {BEvendedor.Nombre}, Apellido: {BEvendedor.Apellido}";
            }
            else
            {
                lblForma.Text = "---";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmCliente formCliente = new frmCliente();
            formCliente.Show();
        }
    }
}
