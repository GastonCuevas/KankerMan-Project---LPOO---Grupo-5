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

            cboClientes.DataSource = TrabajarCliente.traerClienteComboBox();
            cboClientes.DisplayMember = "cli_ayn";
            cboClientes.ValueMember = "cli_dni";
            cboClientes.Text = "Seleccionar Cliente";

            cboVehiculo.DataSource = TrabajarVehiculo.traerVehiculoComboBox();
            cboVehiculo.DisplayMember = "veh_datos";
            cboVehiculo.ValueMember = "veh_matricula";
            cboVehiculo.Text = "Seleccionar Vehiculo";

            cboFormaPago.Items.Add("Cheque");
            cboFormaPago.Items.Add("Efectivo");
            cboFormaPago.Items.Add("Transferencia");
            cboFormaPago.Text = "Seleccionar Forma de Pago";
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Venta oVenta = new Venta();
                Object pago = cboFormaPago.SelectedItem;

                oVenta.CLI_dni = (string)cboClientes.SelectedValue;
                oVenta.USU_id = Int32.Parse(id);
                oVenta.VEH_matricula = (string)cboVehiculo.SelectedValue;
                oVenta.VTA_fecha = dtpFecha.Value;
                oVenta.VTA_formaPago = (string)pago;
                oVenta.VTA_precioFinal = Decimal.Parse(TrabajarVehiculo.verPrecio((string)cboVehiculo.SelectedValue));

                TrabajarVenta.AgregarVenta(oVenta);

                MessageBox.Show("¡VENTA REGISTRADA CON EXITO!");
            }
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            txtPrecio.Text = "$"+TrabajarVehiculo.verPrecio((string)cboVehiculo.SelectedValue);
        }

        private string cargarId(string u)
        {
            string id = TrabajarUsuarios.traerID(u);

            return id;
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
