namespace Presentacion_UI
{
    partial class frmVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculo));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.dtgvVehiculos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModiAuto = new System.Windows.Forms.Button();
            this.btnBajaAuto = new System.Windows.Forms.Button();
            this.btnAltaAuto = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridViewVehiculosXML = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSacarFiltro = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBusquedaFiltro = new System.Windows.Forms.Button();
            this.comboBoxBusquedaMarca = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnModiXML = new System.Windows.Forms.Button();
            this.btnElimXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVehiculos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculosXML)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(69, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(68, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(69, 61);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 1;
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Location = new System.Drawing.Point(222, 153);
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(100, 20);
            this.txtKilometraje.TabIndex = 5;
            // 
            // dtgvVehiculos
            // 
            this.dtgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVehiculos.Location = new System.Drawing.Point(33, 220);
            this.dtgvVehiculos.Name = "dtgvVehiculos";
            this.dtgvVehiculos.Size = new System.Drawing.Size(631, 186);
            this.dtgvVehiculos.TabIndex = 6;
            this.dtgvVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVehiculos_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnModiAuto);
            this.groupBox1.Controls.Add(this.btnBajaAuto);
            this.groupBox1.Controls.Add(this.btnAltaAuto);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.comboBoxMarca);
            this.groupBox1.Controls.Add(this.txtKilometraje);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPatente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 193);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Vehiculo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Estado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(380, 117);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 37;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(222, 32);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(128, 20);
            this.txtPrecio.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Precio";
            // 
            // btnModiAuto
            // 
            this.btnModiAuto.Location = new System.Drawing.Point(380, 84);
            this.btnModiAuto.Name = "btnModiAuto";
            this.btnModiAuto.Size = new System.Drawing.Size(75, 23);
            this.btnModiAuto.TabIndex = 32;
            this.btnModiAuto.Text = "Modificar";
            this.btnModiAuto.UseVisualStyleBackColor = true;
            this.btnModiAuto.Click += new System.EventHandler(this.btnModiAuto_Click);
            // 
            // btnBajaAuto
            // 
            this.btnBajaAuto.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnBajaAuto.Location = new System.Drawing.Point(380, 52);
            this.btnBajaAuto.Name = "btnBajaAuto";
            this.btnBajaAuto.Size = new System.Drawing.Size(75, 23);
            this.btnBajaAuto.TabIndex = 31;
            this.btnBajaAuto.Text = "Eliminar";
            this.btnBajaAuto.UseVisualStyleBackColor = false;
            this.btnBajaAuto.Click += new System.EventHandler(this.btnBajaAuto_Click);
            // 
            // btnAltaAuto
            // 
            this.btnAltaAuto.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAltaAuto.Location = new System.Drawing.Point(380, 19);
            this.btnAltaAuto.Name = "btnAltaAuto";
            this.btnAltaAuto.Size = new System.Drawing.Size(75, 23);
            this.btnAltaAuto.TabIndex = 30;
            this.btnAltaAuto.Text = "Insertar";
            this.btnAltaAuto.UseVisualStyleBackColor = false;
            this.btnAltaAuto.Click += new System.EventHandler(this.btnAltaAuto_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2024",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993"});
            this.comboBox1.Location = new System.Drawing.Point(69, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(69, 124);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(185, 20);
            this.txtModelo.TabIndex = 15;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Items.AddRange(new object[] {
            "BMW",
            "Infinity",
            "Kia",
            "Land Rover",
            "Mercedes Benz",
            "Rolls Royce",
            "Subaru",
            "Volkswagen",
            "Alfa Romeo",
            "Cadillac",
            "Ferrari",
            "Isuzu",
            "Lexus",
            "Mini",
            "Peugeot",
            "Seat",
            "Suzuki",
            "Volvo",
            "Aston Martin",
            "Fiat",
            "Iveco",
            "Lotus",
            "Mitsubishi",
            "Audi",
            "Chevrolet",
            "Ford",
            "Jaguar",
            "Lamborghini",
            "Maserati",
            "Porsche",
            "Tesla",
            "Bentley",
            "Citroen",
            "Honda",
            "Jeep",
            "Mazda",
            "Nissan",
            "Renault",
            "Toyota",
            "Hyundai",
            "Dodge"});
            this.comboBoxMarca.Location = new System.Drawing.Point(69, 91);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(147, 21);
            this.comboBoxMarca.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kilometraje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Patente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(413, 165);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(85, 20);
            this.txtEstado.TabIndex = 36;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(33, 624);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "Atras";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridViewVehiculosXML
            // 
            this.dataGridViewVehiculosXML.AllowUserToDeleteRows = false;
            this.dataGridViewVehiculosXML.AllowUserToOrderColumns = true;
            this.dataGridViewVehiculosXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculosXML.Location = new System.Drawing.Point(33, 436);
            this.dataGridViewVehiculosXML.Name = "dataGridViewVehiculosXML";
            this.dataGridViewVehiculosXML.Size = new System.Drawing.Size(631, 182);
            this.dataGridViewVehiculosXML.TabIndex = 42;
            this.dataGridViewVehiculosXML.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVehiculosXML_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Vehiculos en archivo XML";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnFiltro);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnSacarFiltro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnBusquedaFiltro);
            this.groupBox2.Controls.Add(this.comboBoxBusquedaMarca);
            this.groupBox2.Location = new System.Drawing.Point(515, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 193);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda XML";
            // 
            // btnSacarFiltro
            // 
            this.btnSacarFiltro.BackColor = System.Drawing.Color.Wheat;
            this.btnSacarFiltro.Location = new System.Drawing.Point(25, 153);
            this.btnSacarFiltro.Name = "btnSacarFiltro";
            this.btnSacarFiltro.Size = new System.Drawing.Size(102, 23);
            this.btnSacarFiltro.TabIndex = 45;
            this.btnSacarFiltro.Text = "Sacar Filtro";
            this.btnSacarFiltro.UseVisualStyleBackColor = false;
            this.btnSacarFiltro.Click += new System.EventHandler(this.btnSacarFiltro_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.Wheat;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltro.Location = new System.Drawing.Point(47, 84);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(54, 23);
            this.btnFiltro.TabIndex = 44;
            this.btnFiltro.Text = "FILTRO";
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Marca";
            // 
            // btnBusquedaFiltro
            // 
            this.btnBusquedaFiltro.BackColor = System.Drawing.Color.Wheat;
            this.btnBusquedaFiltro.Location = new System.Drawing.Point(25, 124);
            this.btnBusquedaFiltro.Name = "btnBusquedaFiltro";
            this.btnBusquedaFiltro.Size = new System.Drawing.Size(102, 23);
            this.btnBusquedaFiltro.TabIndex = 38;
            this.btnBusquedaFiltro.Text = "Aplicar";
            this.btnBusquedaFiltro.UseVisualStyleBackColor = false;
            this.btnBusquedaFiltro.Click += new System.EventHandler(this.btnBusquedaFiltro_Click);
            // 
            // comboBoxBusquedaMarca
            // 
            this.comboBoxBusquedaMarca.FormattingEnabled = true;
            this.comboBoxBusquedaMarca.Items.AddRange(new object[] {
            "BMW",
            "Infinity",
            "Kia",
            "Land Rover",
            "Mercedes Benz",
            "Rolls Royce",
            "Subaru",
            "Volkswagen",
            "Alfa Romeo",
            "Cadillac",
            "Ferrari",
            "Isuzu",
            "Lexus",
            "Mini",
            "Peugeot",
            "Seat",
            "Suzuki",
            "Volvo",
            "Aston Martin",
            "Fiat",
            "Iveco",
            "Lotus",
            "Mitsubishi",
            "Audi",
            "Chevrolet",
            "Ford",
            "Jaguar",
            "Lamborghini",
            "Maserati",
            "Porsche",
            "Tesla",
            "Bentley",
            "Citroen",
            "Honda",
            "Jeep",
            "Mazda",
            "Nissan",
            "Renault",
            "Toyota",
            "Hyundai",
            "Dodge"});
            this.comboBoxBusquedaMarca.Location = new System.Drawing.Point(15, 45);
            this.comboBoxBusquedaMarca.Name = "comboBoxBusquedaMarca";
            this.comboBoxBusquedaMarca.Size = new System.Drawing.Size(102, 21);
            this.comboBoxBusquedaMarca.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Precio menor a";
            // 
            // btnModiXML
            // 
            this.btnModiXML.Location = new System.Drawing.Point(462, 624);
            this.btnModiXML.Name = "btnModiXML";
            this.btnModiXML.Size = new System.Drawing.Size(92, 23);
            this.btnModiXML.TabIndex = 38;
            this.btnModiXML.Text = "Modificar XML";
            this.btnModiXML.UseVisualStyleBackColor = true;
            this.btnModiXML.Click += new System.EventHandler(this.btnModiXML_Click);
            // 
            // btnElimXML
            // 
            this.btnElimXML.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnElimXML.Location = new System.Drawing.Point(562, 624);
            this.btnElimXML.Name = "btnElimXML";
            this.btnElimXML.Size = new System.Drawing.Size(102, 23);
            this.btnElimXML.TabIndex = 38;
            this.btnElimXML.Text = "Eliminar XML";
            this.btnElimXML.UseVisualStyleBackColor = false;
            this.btnElimXML.Click += new System.EventHandler(this.btnElimXML_Click);
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 659);
            this.Controls.Add(this.btnElimXML);
            this.Controls.Add(this.btnModiXML);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewVehiculosXML);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.dtgvVehiculos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVehiculo";
            this.Text = "Gestion - Vehiculo";
            this.Load += new System.EventHandler(this.frmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVehiculos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculosXML)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.DataGridView dtgvVehiculos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnModiAuto;
        private System.Windows.Forms.Button btnBajaAuto;
        private System.Windows.Forms.Button btnAltaAuto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridViewVehiculosXML;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBusquedaFiltro;
        private System.Windows.Forms.ComboBox comboBoxBusquedaMarca;
        private System.Windows.Forms.Button btnSacarFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnModiXML;
        private System.Windows.Forms.Button btnElimXML;
    }
}