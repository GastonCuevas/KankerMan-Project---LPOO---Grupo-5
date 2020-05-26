namespace Vistas
{
    partial class FrmMain
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
            this.opcionsmenuStrip = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closebutton = new System.Windows.Forms.Button();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.opcionsmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // opcionsmenuStrip
            // 
            this.opcionsmenuStrip.BackColor = System.Drawing.Color.Aqua;
            this.opcionsmenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.opcionsmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.vehiclesToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.opcionsmenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.opcionsmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.opcionsmenuStrip.Name = "opcionsmenuStrip";
            this.opcionsmenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.opcionsmenuStrip.Size = new System.Drawing.Size(96, 238);
            this.opcionsmenuStrip.TabIndex = 0;
            this.opcionsmenuStrip.Text = "OpcionsmenuStrip";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 22, 0, 0);
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsRegistrationToolStripMenuItem});
            this.clientsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 22, 0, 0);
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 19);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // clientsRegistrationToolStripMenuItem
            // 
            this.clientsRegistrationToolStripMenuItem.Name = "clientsRegistrationToolStripMenuItem";
            this.clientsRegistrationToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.clientsRegistrationToolStripMenuItem.Text = "Clients Management";
            this.clientsRegistrationToolStripMenuItem.Click += new System.EventHandler(this.clientsRegistrationToolStripMenuItem_Click);
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleRegistrationToolStripMenuItem});
            this.vehiclesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 22, 0, 0);
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(62, 19);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            // 
            // vehicleRegistrationToolStripMenuItem
            // 
            this.vehicleRegistrationToolStripMenuItem.Name = "vehicleRegistrationToolStripMenuItem";
            this.vehicleRegistrationToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.vehicleRegistrationToolStripMenuItem.Text = "Vehicle Management";
            this.vehicleRegistrationToolStripMenuItem.Click += new System.EventHandler(this.vehicleRegistrationToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSaleToolStripMenuItem,
            this.viewSalesToolStripMenuItem});
            this.salesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 22, 0, 0);
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 19);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // newSaleToolStripMenuItem
            // 
            this.newSaleToolStripMenuItem.Name = "newSaleToolStripMenuItem";
            this.newSaleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newSaleToolStripMenuItem.Text = "New Sale";
            this.newSaleToolStripMenuItem.Click += new System.EventHandler(this.newSaleToolStripMenuItem_Click);
            // 
            // viewSalesToolStripMenuItem
            // 
            this.viewSalesToolStripMenuItem.Name = "viewSalesToolStripMenuItem";
            this.viewSalesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewSalesToolStripMenuItem.Text = "View Sales";
            this.viewSalesToolStripMenuItem.Click += new System.EventHandler(this.viewSalesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 19);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            this.gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            this.gestionarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.gestionarUsuariosToolStripMenuItem.Text = "User Management";
            this.gestionarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionarUsuariosToolStripMenuItem_Click);
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.Aqua;
            this.closebutton.Location = new System.Drawing.Point(153, 135);
            this.closebutton.Margin = new System.Windows.Forms.Padding(2);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(81, 25);
            this.closebutton.TabIndex = 1;
            this.closebutton.Text = "Close System";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.AutoSize = true;
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(214, 18);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioLogueado.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 238);
            this.Controls.Add(this.lblUsuarioLogueado);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.opcionsmenuStrip);
            this.MainMenuStrip = this.opcionsmenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "PrincipalMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.opcionsmenuStrip.ResumeLayout(false);
            this.opcionsmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip opcionsmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleRegistrationToolStripMenuItem;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarUsuariosToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuarioLogueado;
        private System.Windows.Forms.ToolStripMenuItem newSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;
    }
}