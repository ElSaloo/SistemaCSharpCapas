namespace Presentacion_UI
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciaDeTituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibosDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibosDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preventasNoAutorizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preventasAutorizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.preventaToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1287, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localidadToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.vehiculoToolStripMenuItem,
            this.transferenciaDeTituloToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // localidadToolStripMenuItem
            // 
            this.localidadToolStripMenuItem.Name = "localidadToolStripMenuItem";
            this.localidadToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.localidadToolStripMenuItem.Text = "Localidad";
            this.localidadToolStripMenuItem.Click += new System.EventHandler(this.localidadToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // vehiculoToolStripMenuItem
            // 
            this.vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            this.vehiculoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.vehiculoToolStripMenuItem.Text = "Vehiculo";
            this.vehiculoToolStripMenuItem.Click += new System.EventHandler(this.vehiculoToolStripMenuItem_Click);
            // 
            // transferenciaDeTituloToolStripMenuItem
            // 
            this.transferenciaDeTituloToolStripMenuItem.Name = "transferenciaDeTituloToolStripMenuItem";
            this.transferenciaDeTituloToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.transferenciaDeTituloToolStripMenuItem.Text = "Transferencia de titulo";
            this.transferenciaDeTituloToolStripMenuItem.Click += new System.EventHandler(this.transferenciaDeTituloToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recibosDePagoToolStripMenuItem,
            this.recibosDeCompraToolStripMenuItem});
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // recibosDePagoToolStripMenuItem
            // 
            this.recibosDePagoToolStripMenuItem.Name = "recibosDePagoToolStripMenuItem";
            this.recibosDePagoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.recibosDePagoToolStripMenuItem.Text = "Recibos de venta";
            // 
            // recibosDeCompraToolStripMenuItem
            // 
            this.recibosDeCompraToolStripMenuItem.Name = "recibosDeCompraToolStripMenuItem";
            this.recibosDeCompraToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.recibosDeCompraToolStripMenuItem.Text = "Recibos de compra";
            // 
            // preventaToolStripMenuItem
            // 
            this.preventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preventasNoAutorizadasToolStripMenuItem,
            this.preventasAutorizadasToolStripMenuItem});
            this.preventaToolStripMenuItem.Name = "preventaToolStripMenuItem";
            this.preventaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.preventaToolStripMenuItem.Text = "Preventa";
            // 
            // preventasNoAutorizadasToolStripMenuItem
            // 
            this.preventasNoAutorizadasToolStripMenuItem.Name = "preventasNoAutorizadasToolStripMenuItem";
            this.preventasNoAutorizadasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.preventasNoAutorizadasToolStripMenuItem.Text = "Crear Preventa";
            this.preventasNoAutorizadasToolStripMenuItem.Click += new System.EventHandler(this.preventasNoAutorizadasToolStripMenuItem_Click);
            // 
            // preventasAutorizadasToolStripMenuItem
            // 
            this.preventasAutorizadasToolStripMenuItem.Name = "preventasAutorizadasToolStripMenuItem";
            this.preventasAutorizadasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.preventasAutorizadasToolStripMenuItem.Text = "Preventas autorizadas";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesToolStripMenuItem1,
            this.chartToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // informesToolStripMenuItem1
            // 
            this.informesToolStripMenuItem1.Name = "informesToolStripMenuItem1";
            this.informesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.informesToolStripMenuItem1.Text = "Report Viewer";
            this.informesToolStripMenuItem1.Click += new System.EventHandler(this.informesToolStripMenuItem1_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chartToolStripMenuItem.Text = "Chart";
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1287, 803);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociated System SFCN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferenciaDeTituloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibosDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibosDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preventasNoAutorizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preventasAutorizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
    }
}

