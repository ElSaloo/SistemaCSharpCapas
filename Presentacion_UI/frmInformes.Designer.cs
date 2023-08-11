namespace Presentacion_UI
{
    partial class frmInformes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformes));
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tP1integradorDataSet = new Presentacion_UI.TP1integradorDataSet();
            this.btnTotalVehiculosAdquirido = new System.Windows.Forms.Button();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.dtgvVehiculosPorMarca = new System.Windows.Forms.DataGridView();
            this.btnTotalMarca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVendidoPorMarca = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTotalVenta = new System.Windows.Forms.TextBox();
            this.btnTotalVenta = new System.Windows.Forms.Button();
            this.txtMostExpensive = new System.Windows.Forms.TextBox();
            this.btnMostExpensive = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtTotalDisponible = new System.Windows.Forms.TextBox();
            this.btnTotalDisponible = new System.Windows.Forms.Button();
            this.txtTotalRecaudado = new System.Windows.Forms.TextBox();
            this.btnTotalEmpresa = new System.Windows.Forms.Button();
            this.btnVerTodosVendido = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vehiculoTableAdapter = new Presentacion_UI.TP1integradorDataSetTableAdapters.VehiculoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP1integradorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVehiculosPorMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataMember = "Vehiculo";
            this.vehiculoBindingSource.DataSource = this.tP1integradorDataSet;
            // 
            // tP1integradorDataSet
            // 
            this.tP1integradorDataSet.DataSetName = "TP1integradorDataSet";
            this.tP1integradorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTotalVehiculosAdquirido
            // 
            this.btnTotalVehiculosAdquirido.Location = new System.Drawing.Point(115, 12);
            this.btnTotalVehiculosAdquirido.Name = "btnTotalVehiculosAdquirido";
            this.btnTotalVehiculosAdquirido.Size = new System.Drawing.Size(140, 23);
            this.btnTotalVehiculosAdquirido.TabIndex = 0;
            this.btnTotalVehiculosAdquirido.Text = "Total vehiculos adquirido";
            this.btnTotalVehiculosAdquirido.UseVisualStyleBackColor = true;
            this.btnTotalVehiculosAdquirido.Click += new System.EventHandler(this.btnTotalVehiculosAdquirido_Click);
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Location = new System.Drawing.Point(15, 12);
            this.txtTotalCompra.Multiline = true;
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(85, 21);
            this.txtTotalCompra.TabIndex = 1;
            // 
            // dtgvVehiculosPorMarca
            // 
            this.dtgvVehiculosPorMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVehiculosPorMarca.Location = new System.Drawing.Point(12, 193);
            this.dtgvVehiculosPorMarca.Name = "dtgvVehiculosPorMarca";
            this.dtgvVehiculosPorMarca.Size = new System.Drawing.Size(625, 29);
            this.dtgvVehiculosPorMarca.TabIndex = 7;
            // 
            // btnTotalMarca
            // 
            this.btnTotalMarca.Location = new System.Drawing.Point(166, 91);
            this.btnTotalMarca.Name = "btnTotalMarca";
            this.btnTotalMarca.Size = new System.Drawing.Size(74, 23);
            this.btnTotalMarca.TabIndex = 8;
            this.btnTotalMarca.Text = "Ver";
            this.btnTotalMarca.UseVisualStyleBackColor = true;
            this.btnTotalMarca.Click += new System.EventHandler(this.btnTotalMarca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Vehiculos disponible en venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad de:";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            "Peogeot",
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
            this.comboBox1.Location = new System.Drawing.Point(82, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(236, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "vendido";
            // 
            // btnVendidoPorMarca
            // 
            this.btnVendidoPorMarca.Enabled = false;
            this.btnVendidoPorMarca.Location = new System.Drawing.Point(287, 253);
            this.btnVendidoPorMarca.Name = "btnVendidoPorMarca";
            this.btnVendidoPorMarca.Size = new System.Drawing.Size(74, 23);
            this.btnVendidoPorMarca.TabIndex = 20;
            this.btnVendidoPorMarca.Text = "Ver";
            this.btnVendidoPorMarca.UseVisualStyleBackColor = true;
            this.btnVendidoPorMarca.Click += new System.EventHandler(this.btnVendidoPorMarca_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 97);
            this.dataGridView1.TabIndex = 21;
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.Location = new System.Drawing.Point(15, 39);
            this.txtTotalVenta.Multiline = true;
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.Size = new System.Drawing.Size(85, 21);
            this.txtTotalVenta.TabIndex = 22;
            // 
            // btnTotalVenta
            // 
            this.btnTotalVenta.Location = new System.Drawing.Point(115, 41);
            this.btnTotalVenta.Name = "btnTotalVenta";
            this.btnTotalVenta.Size = new System.Drawing.Size(140, 23);
            this.btnTotalVenta.TabIndex = 23;
            this.btnTotalVenta.Text = "Total vehiculos vendido";
            this.btnTotalVenta.UseVisualStyleBackColor = true;
            this.btnTotalVenta.Click += new System.EventHandler(this.btnTotalVenta_Click);
            // 
            // txtMostExpensive
            // 
            this.txtMostExpensive.Location = new System.Drawing.Point(309, 39);
            this.txtMostExpensive.Multiline = true;
            this.txtMostExpensive.Name = "txtMostExpensive";
            this.txtMostExpensive.Size = new System.Drawing.Size(121, 21);
            this.txtMostExpensive.TabIndex = 24;
            // 
            // btnMostExpensive
            // 
            this.btnMostExpensive.Location = new System.Drawing.Point(436, 37);
            this.btnMostExpensive.Name = "btnMostExpensive";
            this.btnMostExpensive.Size = new System.Drawing.Size(124, 23);
            this.btnMostExpensive.TabIndex = 25;
            this.btnMostExpensive.Text = "Vehiculo mayor valor";
            this.btnMostExpensive.UseVisualStyleBackColor = true;
            this.btnMostExpensive.Click += new System.EventHandler(this.btnMostExpensive_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(561, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Atras";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtTotalDisponible
            // 
            this.txtTotalDisponible.Location = new System.Drawing.Point(309, 12);
            this.txtTotalDisponible.Multiline = true;
            this.txtTotalDisponible.Name = "txtTotalDisponible";
            this.txtTotalDisponible.Size = new System.Drawing.Size(85, 21);
            this.txtTotalDisponible.TabIndex = 27;
            // 
            // btnTotalDisponible
            // 
            this.btnTotalDisponible.Location = new System.Drawing.Point(400, 10);
            this.btnTotalDisponible.Name = "btnTotalDisponible";
            this.btnTotalDisponible.Size = new System.Drawing.Size(140, 23);
            this.btnTotalDisponible.TabIndex = 28;
            this.btnTotalDisponible.Text = "Total vehiculos disponible";
            this.btnTotalDisponible.UseVisualStyleBackColor = true;
            this.btnTotalDisponible.Click += new System.EventHandler(this.btnTotalDisponible_Click);
            // 
            // txtTotalRecaudado
            // 
            this.txtTotalRecaudado.Location = new System.Drawing.Point(12, 406);
            this.txtTotalRecaudado.Multiline = true;
            this.txtTotalRecaudado.Name = "txtTotalRecaudado";
            this.txtTotalRecaudado.Size = new System.Drawing.Size(144, 21);
            this.txtTotalRecaudado.TabIndex = 29;
            // 
            // btnTotalEmpresa
            // 
            this.btnTotalEmpresa.Location = new System.Drawing.Point(173, 406);
            this.btnTotalEmpresa.Name = "btnTotalEmpresa";
            this.btnTotalEmpresa.Size = new System.Drawing.Size(140, 23);
            this.btnTotalEmpresa.TabIndex = 30;
            this.btnTotalEmpresa.Text = "Valor Total de empresa";
            this.btnTotalEmpresa.UseVisualStyleBackColor = true;
            this.btnTotalEmpresa.Click += new System.EventHandler(this.btnTotalRecaudado_Click);
            // 
            // btnVerTodosVendido
            // 
            this.btnVerTodosVendido.Location = new System.Drawing.Point(529, 253);
            this.btnVerTodosVendido.Name = "btnVerTodosVendido";
            this.btnVerTodosVendido.Size = new System.Drawing.Size(107, 23);
            this.btnVerTodosVendido.TabIndex = 31;
            this.btnVerTodosVendido.Text = "Ver todos vendido";
            this.btnVerTodosVendido.UseVisualStyleBackColor = true;
            this.btnVerTodosVendido.Click += new System.EventHandler(this.btnVerTodosVendido_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vehiculoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion_UI.Informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(894, 595);
            this.reportViewer1.TabIndex = 32;
            // 
            // vehiculoTableAdapter
            // 
            this.vehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 595);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnVerTodosVendido);
            this.Controls.Add(this.btnTotalEmpresa);
            this.Controls.Add(this.txtTotalRecaudado);
            this.Controls.Add(this.btnTotalDisponible);
            this.Controls.Add(this.txtTotalDisponible);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostExpensive);
            this.Controls.Add(this.txtMostExpensive);
            this.Controls.Add(this.btnTotalVenta);
            this.Controls.Add(this.txtTotalVenta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVendidoPorMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTotalMarca);
            this.Controls.Add(this.dtgvVehiculosPorMarca);
            this.Controls.Add(this.txtTotalCompra);
            this.Controls.Add(this.btnTotalVehiculosAdquirido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInformes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.frmInformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP1integradorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVehiculosPorMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTotalVehiculosAdquirido;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.DataGridView dtgvVehiculosPorMarca;
        private System.Windows.Forms.Button btnTotalMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVendidoPorMarca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTotalVenta;
        private System.Windows.Forms.Button btnTotalVenta;
        private System.Windows.Forms.TextBox txtMostExpensive;
        private System.Windows.Forms.Button btnMostExpensive;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtTotalDisponible;
        private System.Windows.Forms.Button btnTotalDisponible;
        private System.Windows.Forms.TextBox txtTotalRecaudado;
        private System.Windows.Forms.Button btnTotalEmpresa;
        private System.Windows.Forms.Button btnVerTodosVendido;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TP1integradorDataSet tP1integradorDataSet;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private TP1integradorDataSetTableAdapters.VehiculoTableAdapter vehiculoTableAdapter;
    }
}