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

namespace Presentacion_UI
{
    public partial class frmLocalidad : Form
    {
        BLLLocalidad BLlocalidad;
        BELocalidad BElocalidad;
        public frmLocalidad()
        {
            InitializeComponent();
            BLlocalidad = new BLLLocalidad();
            BElocalidad = new BELocalidad();
        }
        private void frmLocalidad_Load(object sender, EventArgs e)
        {
            MuestroEnGrilla();
        }
        void MuestroEnGrilla()
        {
            this.dtgvLocalidad.DataSource = null;
            this.dtgvLocalidad.DataSource = BLlocalidad.ListarTodo();
            this.dtgvLocalidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        void Limpiar()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "") throw new Exception("Debe ingresar un nombre de la localidad.");

                BElocalidad.Direccion = this.textBox2.Text;
                BLlocalidad.Guardar(BElocalidad);
                MuestroEnGrilla();
                Limpiar();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvLocalidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BElocalidad = (BELocalidad)this.dtgvLocalidad.CurrentRow.DataBoundItem;
            textBox1.Text = BElocalidad.Codigo.ToString();
            textBox2.Text = BElocalidad.Direccion;
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "") throw new Exception("Debe elegir la localidad a modificar.");

                Asignar();
                BLlocalidad.Guardar(BElocalidad);
                MuestroEnGrilla();
                Limpiar();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Asignar()
        {
            BElocalidad.Codigo = Convert.ToInt32(textBox1.Text);
            BElocalidad.Direccion = textBox2.Text;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "") throw new Exception("Debe elegir la localidad a eliminar.");

                Asignar();

                DialogResult respuesta;
                respuesta = MessageBox.Show("¿Desea eliminar la localidad?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(respuesta == DialogResult.Yes)
                {
                    if(BLlocalidad.Baja(BElocalidad) == false)
                    {
                        MessageBox.Show("Localidad sigue asociado a clientes");
                    }
                    MuestroEnGrilla();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult atras = MessageBox.Show("¿Desea salir?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(atras == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
