using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;


namespace Vistas
{
    public partial class FrmMain : Form
    {

        string nombre1;

        public FrmMain()
        {
            
            InitializeComponent();
        }

        public FrmMain(string r, string n)
        {
            InitializeComponent();
            string nombre=n;
            string rol=r;
            FrmMain_Load(rol,nombre);
            nombre1 = cargar(nombre);
        }

        private void clientsRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes OFrmClientes = new frmClientes();
            OFrmClientes.Show();
        }

        private void vehicleRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehicleRegistration oFrmVehicleRegistration = new FrmVehicleRegistration();
            oFrmVehicleRegistration.Show();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirms the action?", "close the system", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios oFrmUsuarios = new frmUsuarios();
            oFrmUsuarios.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmMain_Load(string rol,string n)
        {
            string nombreUs=n;
            lblUsuarioLogueado.Text = "User: " + nombreUs + " | Role: Auditor";

            if (rol.Equals("ADM"))
            {
                lblUsuarioLogueado.Text = "User: "+nombreUs+" | Role: Administrador";
                salesToolStripMenuItem.Enabled = false;
                clientsToolStripMenuItem.Enabled = false;
            }
            else if (rol.Equals("VND"))
            {
                lblUsuarioLogueado.Text = "User: " + nombreUs + " | Role: Vendedor";
                vehiclesToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
            }
        }

        private void newSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas oFrmVentas = new frmVentas(nombre1);
            oFrmVentas.Show();
        }

        private string cargar(string nombre) 
        {
            return nombre;
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaVentas oFrmListaVenta = new frmListaVentas();
            oFrmListaVenta.Show();
        }
    }
}
