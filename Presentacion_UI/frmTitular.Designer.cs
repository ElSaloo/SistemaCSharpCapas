namespace Presentacion_UI
{
    partial class frmTitular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitular));
            this.Cliente = new System.Windows.Forms.GroupBox();
            this.dtgvClientePreventa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPropioVehiculo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxSeguro = new System.Windows.Forms.CheckBox();
            this.checkBoxCertificadoTra = new System.Windows.Forms.CheckBox();
            this.checkBoxCedula = new System.Windows.Forms.CheckBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.comboBoxVehiculos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvVehiculoPreventa = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientePreventa)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVehiculoPreventa)).BeginInit();
            this.SuspendLayout();
            // 
            // Cliente
            // 
            this.Cliente.Controls.Add(this.dtgvClientePreventa);
            this.Cliente.Location = new System.Drawing.Point(12, 12);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(595, 262);
            this.Cliente.TabIndex = 0;
            this.Cliente.TabStop = false;
            this.Cliente.Text = "Cliente";
            // 
            // dtgvClientePreventa
            // 
            this.dtgvClientePreventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClientePreventa.Location = new System.Drawing.Point(11, 19);
            this.dtgvClientePreventa.Name = "dtgvClientePreventa";
            this.dtgvClientePreventa.Size = new System.Drawing.Size(577, 232);
            this.dtgvClientePreventa.TabIndex = 0;
            this.dtgvClientePreventa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvClientePreventa_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente seleccionado: ";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(158, 281);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(19, 16);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "---";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPropioVehiculo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxSeguro);
            this.groupBox1.Controls.Add(this.checkBoxCertificadoTra);
            this.groupBox1.Controls.Add(this.checkBoxCedula);
            this.groupBox1.Controls.Add(this.lblVehiculo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDesasignar);
            this.groupBox1.Controls.Add(this.btnTransferir);
            this.groupBox1.Controls.Add(this.comboBoxVehiculos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtgvVehiculoPreventa);
            this.groupBox1.Location = new System.Drawing.Point(12, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 251);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehiculos propio";
            // 
            // lblPropioVehiculo
            // 
            this.lblPropioVehiculo.AutoSize = true;
            this.lblPropioVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropioVehiculo.Location = new System.Drawing.Point(365, 223);
            this.lblPropioVehiculo.Name = "lblPropioVehiculo";
            this.lblPropioVehiculo.Size = new System.Drawing.Size(16, 13);
            this.lblPropioVehiculo.TabIndex = 12;
            this.lblPropioVehiculo.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vehiculo propio seleccionado:";
            // 
            // checkBoxSeguro
            // 
            this.checkBoxSeguro.AutoSize = true;
            this.checkBoxSeguro.Location = new System.Drawing.Point(412, 65);
            this.checkBoxSeguro.Name = "checkBoxSeguro";
            this.checkBoxSeguro.Size = new System.Drawing.Size(96, 17);
            this.checkBoxSeguro.TabIndex = 9;
            this.checkBoxSeguro.Text = "Alta de Seguro";
            this.checkBoxSeguro.UseVisualStyleBackColor = true;
            // 
            // checkBoxCertificadoTra
            // 
            this.checkBoxCertificadoTra.AutoSize = true;
            this.checkBoxCertificadoTra.Location = new System.Drawing.Point(412, 19);
            this.checkBoxCertificadoTra.Name = "checkBoxCertificadoTra";
            this.checkBoxCertificadoTra.Size = new System.Drawing.Size(127, 17);
            this.checkBoxCertificadoTra.TabIndex = 8;
            this.checkBoxCertificadoTra.Text = "Transferencia sellado";
            this.checkBoxCertificadoTra.UseVisualStyleBackColor = true;
            // 
            // checkBoxCedula
            // 
            this.checkBoxCedula.AutoSize = true;
            this.checkBoxCedula.Location = new System.Drawing.Point(412, 42);
            this.checkBoxCedula.Name = "checkBoxCedula";
            this.checkBoxCedula.Size = new System.Drawing.Size(90, 17);
            this.checkBoxCedula.TabIndex = 7;
            this.checkBoxCedula.Text = "Cedula Verde";
            this.checkBoxCedula.UseVisualStyleBackColor = true;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(162, 185);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(19, 16);
            this.lblVehiculo.TabIndex = 3;
            this.lblVehiculo.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vehiculo seleccionado: ";
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.Location = new System.Drawing.Point(113, 218);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(91, 23);
            this.btnDesasignar.TabIndex = 6;
            this.btnDesasignar.Text = "Desasignar";
            this.btnDesasignar.UseVisualStyleBackColor = true;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(16, 218);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(91, 23);
            this.btnTransferir.TabIndex = 5;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // comboBoxVehiculos
            // 
            this.comboBoxVehiculos.FormattingEnabled = true;
            this.comboBoxVehiculos.Location = new System.Drawing.Point(70, 161);
            this.comboBoxVehiculos.Name = "comboBoxVehiculos";
            this.comboBoxVehiculos.Size = new System.Drawing.Size(319, 21);
            this.comboBoxVehiculos.TabIndex = 4;
            this.comboBoxVehiculos.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehiculos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehiculo ";
            // 
            // dtgvVehiculoPreventa
            // 
            this.dtgvVehiculoPreventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVehiculoPreventa.Location = new System.Drawing.Point(12, 19);
            this.dtgvVehiculoPreventa.Name = "dtgvVehiculoPreventa";
            this.dtgvVehiculoPreventa.Size = new System.Drawing.Size(377, 132);
            this.dtgvVehiculoPreventa.TabIndex = 0;
            this.dtgvVehiculoPreventa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVehiculoPreventa_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(508, 568);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Atras";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmTitular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 594);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTitular";
            this.Text = "Gestion - Transferencia";
            this.Load += new System.EventHandler(this.frmTitular_Load);
            this.Cliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientePreventa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVehiculoPreventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Cliente;
        private System.Windows.Forms.DataGridView dtgvClientePreventa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvVehiculoPreventa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.ComboBox comboBoxVehiculos;
        private System.Windows.Forms.CheckBox checkBoxSeguro;
        private System.Windows.Forms.CheckBox checkBoxCertificadoTra;
        private System.Windows.Forms.CheckBox checkBoxCedula;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPropioVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
    }
}