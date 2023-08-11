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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Negocio_BLL;
using Entidades_BE;
using Security;

namespace Presentacion_UI
{
    public partial class LoginControlUser : UserControl
    {
        BELogin BElogin;
        BLLLogin BLLlogin;
        public LoginControlUser()
        {
            InitializeComponent();
            BElogin = new BELogin();
            BLLlogin = new BLLLogin();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty) throw new Exception("Debe ingresar Username y Password.");

                BElogin.Username = textBox1.Text;
                BElogin.Password = textBox2.Text;

                string Encriptado = EncriptedSHA.GenerarHashCodeSecurity(BElogin.Password);

                BElogin.Password = Encriptado;

                if (BLLlogin.Log_in(BElogin) == false)
                {
                    frmMenu menu = new frmMenu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    label3.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty) throw new Exception("Debe ingresar Username y Password.");

                BElogin.Username = textBox1.Text;
                BElogin.Password = textBox2.Text;

                string Encriptado = EncriptedSHA.GenerarHashCodeSecurity(BElogin.Password);

                BElogin.Password = Encriptado;

                BLLlogin.Guardar(BElogin);
                DialogResult respuesta;
                respuesta = MessageBox.Show("Usuario y contraseña registrado. Ingrese a su cuenta.", "USUARIO REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginControlUser_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
    }
}
