namespace Presentacion_UI
{
    partial class frmPreventa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreventa));
            this.comboBoxVehiculos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVehiculoSeleccionado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblClienteSeleccionado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.Preventa = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblForma = new System.Windows.Forms.Label();
            this.comboBoxForma = new System.Windows.Forms.ComboBox();
            this.comboBoxVendedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrearPreventa = new System.Windows.Forms.Button();
            this.lblVendedorSeleccionado = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxVehiculos
            // 
            this.comboBoxVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVehiculos.FormattingEnabled = true;
            this.comboBoxVehiculos.Location = new System.Drawing.Point(15, 21);
            this.comboBoxVehiculos.Name = "comboBoxVehiculos";
            this.comboBoxVehiculos.Size = new System.Drawing.Size(382, 21);
            this.comboBoxVehiculos.TabIndex = 0;
            this.comboBoxVehiculos.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehiculos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblVehiculoSeleccionado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxVehiculos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(25, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehiculos disponible";
            // 
            // lblVehiculoSeleccionado
            // 
            this.lblVehiculoSeleccionado.AutoSize = true;
            this.lblVehiculoSeleccionado.BackColor = System.Drawing.Color.Transparent;
            this.lblVehiculoSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblVehiculoSeleccionado.Location = new System.Drawing.Point(12, 87);
            this.lblVehiculoSeleccionado.Name = "lblVehiculoSeleccionado";
            this.lblVehiculoSeleccionado.Size = new System.Drawing.Size(19, 16);
            this.lblVehiculoSeleccionado.TabIndex = 2;
            this.lblVehiculoSeleccionado.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehiculo seleccionado:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnRegistrar);
            this.groupBox2.Controls.Add(this.lblClienteSeleccionado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxClientes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(25, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 149);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // lblClienteSeleccionado
            // 
            this.lblClienteSeleccionado.AutoSize = true;
            this.lblClienteSeleccionado.BackColor = System.Drawing.Color.Transparent;
            this.lblClienteSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblClienteSeleccionado.Location = new System.Drawing.Point(12, 80);
            this.lblClienteSeleccionado.Name = "lblClienteSeleccionado";
            this.lblClienteSeleccionado.Size = new System.Drawing.Size(19, 16);
            this.lblClienteSeleccionado.TabIndex = 3;
            this.lblClienteSeleccionado.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente seleccionado:";
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(15, 21);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(323, 21);
            this.comboBoxClientes.TabIndex = 0;
            this.comboBoxClientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientes_SelectedIndexChanged);
            // 
            // Preventa
            // 
            this.Preventa.AutoSize = true;
            this.Preventa.BackColor = System.Drawing.Color.Transparent;
            this.Preventa.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preventa.ForeColor = System.Drawing.SystemColors.Control;
            this.Preventa.Location = new System.Drawing.Point(35, 23);
            this.Preventa.Name = "Preventa";
            this.Preventa.Size = new System.Drawing.Size(377, 28);
            this.Preventa.TabIndex = 3;
            this.Preventa.Text = "Asociated System SFCN - Preventa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblForma);
            this.groupBox3.Controls.Add(this.comboBoxForma);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(25, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 102);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Forma de pago";
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.BackColor = System.Drawing.Color.Transparent;
            this.lblForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForma.ForeColor = System.Drawing.Color.White;
            this.lblForma.Location = new System.Drawing.Point(15, 64);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(16, 13);
            this.lblForma.TabIndex = 33;
            this.lblForma.Text = "---";
            // 
            // comboBoxForma
            // 
            this.comboBoxForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxForma.FormattingEnabled = true;
            this.comboBoxForma.Location = new System.Drawing.Point(15, 30);
            this.comboBoxForma.Name = "comboBoxForma";
            this.comboBoxForma.Size = new System.Drawing.Size(166, 21);
            this.comboBoxForma.TabIndex = 33;
            this.comboBoxForma.SelectedIndexChanged += new System.EventHandler(this.comboBoxForma_SelectedIndexChanged);
            // 
            // comboBoxVendedores
            // 
            this.comboBoxVendedores.FormattingEnabled = true;
            this.comboBoxVendedores.Location = new System.Drawing.Point(317, 418);
            this.comboBoxVendedores.Name = "comboBoxVendedores";
            this.comboBoxVendedores.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVendedores.TabIndex = 8;
            this.comboBoxVendedores.SelectedIndexChanged += new System.EventHandler(this.comboBoxVendedores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(246, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vendedor:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(12, 526);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Atras";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(236, 526);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCrearPreventa
            // 
            this.btnCrearPreventa.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCrearPreventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPreventa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCrearPreventa.Location = new System.Drawing.Point(317, 524);
            this.btnCrearPreventa.Name = "btnCrearPreventa";
            this.btnCrearPreventa.Size = new System.Drawing.Size(121, 26);
            this.btnCrearPreventa.TabIndex = 32;
            this.btnCrearPreventa.Text = "Crear";
            this.btnCrearPreventa.UseVisualStyleBackColor = false;
            this.btnCrearPreventa.Click += new System.EventHandler(this.btnCrearPreventa_Click);
            // 
            // lblVendedorSeleccionado
            // 
            this.lblVendedorSeleccionado.AutoSize = true;
            this.lblVendedorSeleccionado.BackColor = System.Drawing.Color.Transparent;
            this.lblVendedorSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblVendedorSeleccionado.Location = new System.Drawing.Point(231, 448);
            this.lblVendedorSeleccionado.Name = "lblVendedorSeleccionado";
            this.lblVendedorSeleccionado.Size = new System.Drawing.Size(16, 13);
            this.lblVendedorSeleccionado.TabIndex = 4;
            this.lblVendedorSeleccionado.Text = "---";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(344, 21);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(63, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmPreventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(458, 566);
            this.Controls.Add(this.lblVendedorSeleccionado);
            this.Controls.Add(this.btnCrearPreventa);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVendedores);
            this.Controls.Add(this.Preventa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPreventa";
            this.Text = "Preventa";
            this.Load += new System.EventHandler(this.frmPreventa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVehiculos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.Label Preventa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxVendedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrearPreventa;
        private System.Windows.Forms.Label lblVehiculoSeleccionado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClienteSeleccionado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVendedorSeleccionado;
        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.ComboBox comboBoxForma;
        private System.Windows.Forms.Button btnRegistrar;
    }
}