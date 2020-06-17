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
    public partial class frmVentas : Form
    {

        string id;

        public frmVentas()
        {
            InitializeComponent();
        }

        public frmVentas(string u)
        {
            InitializeComponent();
            id = cargarId(u);
            frmVentas_Load(u);
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            
        }

        private void frmVentas_Load(string u)
        {
            cargarComboRol(u);
            
        }

        /// <summary>
        /// Carga los combos rol con sus respectivos items y actualiza la fecha
        /// </summary>
        private void cargarComboRol(string u)
        {
            string nombreVendedor = TrabajarUsuarios.traerVendedor(u);

            lblVendedor.Text = "Vendedor: " + nombreVendedor;

            //Configurar Fecha actual
            dtpFecha.Value = DateTime.Today;

            nudPrecio.Minimum = 0;
            nudPrecio.Maximum = 10000000;

            cboClientes.DataSource = TrabajarCliente.traerClienteComboBox();
            cboClientes.DisplayMember = "cli_ayn";
            cboClientes.ValueMember = "cli_dni";
            cboClientes.Text = "Select Client";

            cboVehiculo.DataSource = TrabajarVehiculo.traerVehiculoComboBox();
            cboVehiculo.DisplayMember = "veh_datos";
            cboVehiculo.ValueMember = "veh_matricula";
            cboVehiculo.Text = "Select Vehicle";

            cboFormaPago.DataSource = TrabajarFormaPago.ObtenerFormaPago();
            cboFormaPago.DisplayMember = "Descripción";
            cboFormaPago.ValueMember = "ID";
            cboFormaPago.Text = "Select Vehicle Type";
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (cboClientes.Text == "Select Client" || nudPrecio.Value == 0 || cboFormaPago.Text == "Select Way To Pay"
                || cboVehiculo.Text == "Select Vehicle")
            {
                MessageBox.Show("No puede registar campos vacíos");
            }
            else
            {
                if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Venta oVenta = new Venta();

                    oVenta.CLI_dni = (string)cboClientes.SelectedValue;
                    oVenta.USU_id = Int32.Parse(id);
                    oVenta.VEH_matricula = (string)cboVehiculo.SelectedValue;
                    oVenta.VTA_fecha = dtpFecha.Value;
                    oVenta.FP_id = (Int32)cboFormaPago.SelectedValue;
                    oVenta.VTA_precioFinal = Decimal.Parse(TrabajarVehiculo.verPrecio((string)cboVehiculo.SelectedValue));
                    oVenta.VTA_estado = true;

                    TrabajarVenta.AgregarVenta(oVenta);

                    MessageBox.Show("¡VENTA REGISTRADA CON EXITO!");
                    limpiarCampos();
                }
            }
        }

        private void limpiarCampos()
        {
            dtpFecha.Value = DateTime.Today;
            cboClientes.Text = "Select Client";
            cboVehiculo.Text = "Select Vehicle";
            cboFormaPago.Text = "Select Way To Pay";
            nudPrecio.Value = 0;
        }

        private string cargarId(string u)
        {
            string id = TrabajarUsuarios.traerID(u);

            return id;
        }

        private void cboVehiculo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nudPrecio.Value = Decimal.Parse(TrabajarVehiculo.verPrecio((string)cboVehiculo.SelectedValue));
        }
    }
}
