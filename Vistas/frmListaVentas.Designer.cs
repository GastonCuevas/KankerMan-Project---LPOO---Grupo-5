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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnFilterMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.gbFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(12, 167);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(695, 241);
            this.dgvVentas.TabIndex = 0;
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
            this.gbFechas.Text = "Rango de Fechas";
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
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(92, 126);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(330, 20);
            this.txtMarca.TabIndex = 9;
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
            // frmListaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 446);
            this.Controls.Add(this.btnFilterMarca);
            this.Controls.Add(this.txtMarca);
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
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnFilterMarca;
    }
}