namespace Vistas
{
    partial class frmVehiculos
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
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblPuertas = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblClaseVehiculo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblGPS = new System.Windows.Forms.Label();
            this.cbGPS = new System.Windows.Forms.CheckBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.rbtMarca = new System.Windows.Forms.RadioButton();
            this.rbtLinea = new System.Windows.Forms.RadioButton();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboLinea = new System.Windows.Forms.ComboBox();
            this.cboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.cboClaseVehiculo = new System.Windows.Forms.ComboBox();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudModelo = new System.Windows.Forms.NumericUpDown();
            this.cboCantPuertas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.gbOrdenar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(300, 71);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Size = new System.Drawing.Size(632, 280);
            this.dgvVehiculos.TabIndex = 0;
            this.dgvVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 327);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(64, 24);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Add";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(103, 327);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(64, 24);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modify";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(191, 327);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 24);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Delete";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(12, 15);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(56, 13);
            this.lblMatricula.TabIndex = 4;
            this.lblMatricula.Text = "Enrollment";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 46);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(35, 13);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Brand";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(12, 77);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(36, 13);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Model";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(12, 108);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(27, 13);
            this.lblLinea.TabIndex = 7;
            this.lblLinea.Text = "Line";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(12, 139);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(69, 13);
            this.lblTipoVehiculo.TabIndex = 8;
            this.lblTipoVehiculo.Text = "Vehicle Type";
            // 
            // lblPuertas
            // 
            this.lblPuertas.AutoSize = true;
            this.lblPuertas.Location = new System.Drawing.Point(12, 170);
            this.lblPuertas.Name = "lblPuertas";
            this.lblPuertas.Size = new System.Drawing.Size(35, 13);
            this.lblPuertas.TabIndex = 9;
            this.lblPuertas.Text = "Doors";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 201);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color";
            // 
            // lblClaseVehiculo
            // 
            this.lblClaseVehiculo.AutoSize = true;
            this.lblClaseVehiculo.Location = new System.Drawing.Point(12, 232);
            this.lblClaseVehiculo.Name = "lblClaseVehiculo";
            this.lblClaseVehiculo.Size = new System.Drawing.Size(70, 13);
            this.lblClaseVehiculo.TabIndex = 11;
            this.lblClaseVehiculo.Text = "Vehicle Class";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 262);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(31, 13);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Price";
            // 
            // lblGPS
            // 
            this.lblGPS.AutoSize = true;
            this.lblGPS.Location = new System.Drawing.Point(12, 295);
            this.lblGPS.Name = "lblGPS";
            this.lblGPS.Size = new System.Drawing.Size(29, 13);
            this.lblGPS.TabIndex = 13;
            this.lblGPS.Text = "GPS";
            // 
            // cbGPS
            // 
            this.cbGPS.AutoSize = true;
            this.cbGPS.Location = new System.Drawing.Point(103, 294);
            this.cbGPS.Name = "cbGPS";
            this.cbGPS.Size = new System.Drawing.Size(15, 14);
            this.cbGPS.TabIndex = 14;
            this.cbGPS.UseVisualStyleBackColor = true;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(103, 12);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(169, 20);
            this.txtMatricula.TabIndex = 15;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(631, 31);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(64, 23);
            this.btnOrdenar.TabIndex = 24;
            this.btnOrdenar.Text = "Sort";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // rbtMarca
            // 
            this.rbtMarca.AutoSize = true;
            this.rbtMarca.Checked = true;
            this.rbtMarca.Location = new System.Drawing.Point(55, 19);
            this.rbtMarca.Name = "rbtMarca";
            this.rbtMarca.Size = new System.Drawing.Size(53, 17);
            this.rbtMarca.TabIndex = 25;
            this.rbtMarca.TabStop = true;
            this.rbtMarca.Text = "Brand";
            this.rbtMarca.UseVisualStyleBackColor = true;
            // 
            // rbtLinea
            // 
            this.rbtLinea.AutoSize = true;
            this.rbtLinea.Location = new System.Drawing.Point(144, 19);
            this.rbtLinea.Name = "rbtLinea";
            this.rbtLinea.Size = new System.Drawing.Size(45, 17);
            this.rbtLinea.TabIndex = 26;
            this.rbtLinea.TabStop = true;
            this.rbtLinea.Text = "Line";
            this.rbtLinea.UseVisualStyleBackColor = true;
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.rbtLinea);
            this.gbOrdenar.Controls.Add(this.rbtMarca);
            this.gbOrdenar.Location = new System.Drawing.Point(345, 16);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Size = new System.Drawing.Size(268, 49);
            this.gbOrdenar.TabIndex = 27;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Sort By:";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(707, 32);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 28;
            this.btnRefrescar.Text = "Refresh Grid";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(103, 43);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(169, 21);
            this.cboMarca.TabIndex = 29;
            // 
            // cboLinea
            // 
            this.cboLinea.FormattingEnabled = true;
            this.cboLinea.Location = new System.Drawing.Point(103, 105);
            this.cboLinea.Name = "cboLinea";
            this.cboLinea.Size = new System.Drawing.Size(169, 21);
            this.cboLinea.TabIndex = 31;
            // 
            // cboTipoVehiculo
            // 
            this.cboTipoVehiculo.FormattingEnabled = true;
            this.cboTipoVehiculo.Location = new System.Drawing.Point(103, 136);
            this.cboTipoVehiculo.Name = "cboTipoVehiculo";
            this.cboTipoVehiculo.Size = new System.Drawing.Size(169, 21);
            this.cboTipoVehiculo.TabIndex = 32;
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(103, 198);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(169, 21);
            this.cboColor.TabIndex = 34;
            // 
            // cboClaseVehiculo
            // 
            this.cboClaseVehiculo.FormattingEnabled = true;
            this.cboClaseVehiculo.Location = new System.Drawing.Point(103, 229);
            this.cboClaseVehiculo.Name = "cboClaseVehiculo";
            this.cboClaseVehiculo.Size = new System.Drawing.Size(169, 21);
            this.cboClaseVehiculo.TabIndex = 35;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(103, 260);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(169, 20);
            this.nudPrecio.TabIndex = 36;
            // 
            // nudModelo
            // 
            this.nudModelo.Location = new System.Drawing.Point(103, 75);
            this.nudModelo.Name = "nudModelo";
            this.nudModelo.Size = new System.Drawing.Size(169, 20);
            this.nudModelo.TabIndex = 37;
            // 
            // cboCantPuertas
            // 
            this.cboCantPuertas.FormattingEnabled = true;
            this.cboCantPuertas.Location = new System.Drawing.Point(103, 167);
            this.cboCantPuertas.Name = "cboCantPuertas";
            this.cboCantPuertas.Size = new System.Drawing.Size(169, 21);
            this.cboCantPuertas.TabIndex = 33;
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 380);
            this.Controls.Add(this.nudModelo);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.cboClaseVehiculo);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.cboCantPuertas);
            this.Controls.Add(this.cboTipoVehiculo);
            this.Controls.Add(this.cboLinea);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.gbOrdenar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.cbGPS);
            this.Controls.Add(this.lblGPS);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblClaseVehiculo);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPuertas);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvVehiculos);
            this.Name = "frmVehiculos";
            this.Text = "frmVehiculos";
            this.Load += new System.EventHandler(this.frmVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblPuertas;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblClaseVehiculo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblGPS;
        private System.Windows.Forms.CheckBox cbGPS;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RadioButton rbtMarca;
        private System.Windows.Forms.RadioButton rbtLinea;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboLinea;
        private System.Windows.Forms.ComboBox cboTipoVehiculo;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.ComboBox cboClaseVehiculo;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.NumericUpDown nudModelo;
        private System.Windows.Forms.ComboBox cboCantPuertas;
    }
}