namespace Vistas
{
    partial class frmListaVentas
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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.gbFechas = new System.Windows.Forms.GroupBox();
            this.btnFiltrarFechas = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnFilterMarca = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.btnInvalidar = new System.Windows.Forms.Button();
            this.lblIdVenta = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblSeleccionada = new System.Windows.Forms.Label();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.gbFechas.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(12, 167);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(762, 241);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(92, 25);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(330, 21);
            this.cbClientes.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(28, 28);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Client: ";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(470, 20);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(71, 28);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Client Filter";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Location = new System.Drawing.Point(9, 16);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(201, 20);
            this.dtpFecha1.TabIndex = 4;
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Location = new System.Drawing.Point(216, 16);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha2.TabIndex = 5;
            // 
            // gbFechas
            // 
            this.gbFechas.Controls.Add(this.dtpFecha2);
            this.gbFechas.Controls.Add(this.dtpFecha1);
            this.gbFechas.Location = new System.Drawing.Point(22, 62);
            this.gbFechas.Name = "gbFechas";
            this.gbFechas.Size = new System.Drawing.Size(426, 42);
            this.gbFechas.TabIndex = 6;
            this.gbFechas.TabStop = false;
            this.gbFechas.Text = "Date Range";
            this.gbFechas.UseCompatibleTextRendering = true;
            // 
            // btnFiltrarFechas
            // 
            this.btnFiltrarFechas.Location = new System.Drawing.Point(470, 70);
            this.btnFiltrarFechas.Name = "btnFiltrarFechas";
            this.btnFiltrarFechas.Size = new System.Drawing.Size(71, 28);
            this.btnFiltrarFechas.TabIndex = 7;
            this.btnFiltrarFechas.Text = "Date Filter";
            this.btnFiltrarFechas.UseVisualStyleBackColor = true;
            this.btnFiltrarFechas.Click += new System.EventHandler(this.btnFiltrarFechas_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(28, 129);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(35, 13);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Brand";
            // 
            // btnFilterMarca
            // 
            this.btnFilterMarca.Location = new System.Drawing.Point(470, 121);
            this.btnFilterMarca.Name = "btnFilterMarca";
            this.btnFilterMarca.Size = new System.Drawing.Size(71, 28);
            this.btnFilterMarca.TabIndex = 10;
            this.btnFilterMarca.Text = "Marca Filter";
            this.btnFilterMarca.UseVisualStyleBackColor = true;
            this.btnFilterMarca.Click += new System.EventHandler(this.btnFilterMarca_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(560, 124);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 14;
            this.btnRefrescar.Text = "Refresh Grid";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(92, 126);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(330, 21);
            this.cboMarca.TabIndex = 15;
            // 
            // btnInvalidar
            // 
            this.btnInvalidar.Location = new System.Drawing.Point(130, 15);
            this.btnInvalidar.Name = "btnInvalidar";
            this.btnInvalidar.Size = new System.Drawing.Size(77, 23);
            this.btnInvalidar.TabIndex = 13;
            this.btnInvalidar.Text = "Invalidate";
            this.btnInvalidar.UseVisualStyleBackColor = true;
            this.btnInvalidar.Click += new System.EventHandler(this.btnInvalidar_Click);
            // 
            // lblIdVenta
            // 
            this.lblIdVenta.AutoSize = true;
            this.lblIdVenta.Location = new System.Drawing.Point(3, 36);
            this.lblIdVenta.Name = "lblIdVenta";
            this.lblIdVenta.Size = new System.Drawing.Size(96, 13);
            this.lblIdVenta.TabIndex = 11;
            this.lblIdVenta.Text = "Selected Sale (ID):";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(130, 44);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(77, 23);
            this.btnValidar.TabIndex = 14;
            this.btnValidar.Text = "Validate";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblSeleccionada
            // 
            this.lblSeleccionada.AutoSize = true;
            this.lblSeleccionada.Location = new System.Drawing.Point(105, 36);
            this.lblSeleccionada.Name = "lblSeleccionada";
            this.lblSeleccionada.Size = new System.Drawing.Size(0, 13);
            this.lblSeleccionada.TabIndex = 16;
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.lblSeleccionada);
            this.gbAcciones.Controls.Add(this.btnValidar);
            this.gbAcciones.Controls.Add(this.lblIdVenta);
            this.gbAcciones.Controls.Add(this.btnInvalidar);
            this.gbAcciones.Location = new System.Drawing.Point(567, 26);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(215, 77);
            this.gbAcciones.TabIndex = 17;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Actions";
            // 
            // frmListaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 477);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnFilterMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnFiltrarFechas);
            this.Controls.Add(this.gbFechas);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.dgvVentas);
            this.Name = "frmListaVentas";
            this.Text = "frmListaVentas";
            this.Load += new System.EventHandler(this.frmListaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.gbFechas.ResumeLayout(false);
            this.gbAcciones.ResumeLayout(false);
            this.gbAcciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.GroupBox gbFechas;
        private System.Windows.Forms.Button btnFiltrarFechas;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnFilterMarca;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button btnInvalidar;
        private System.Windows.Forms.Label lblIdVenta;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblSeleccionada;
        private System.Windows.Forms.GroupBox gbAcciones;
    }
}