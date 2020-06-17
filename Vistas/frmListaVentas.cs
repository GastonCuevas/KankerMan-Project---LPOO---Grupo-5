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
    public partial class frmListaVentas : Form
    {
        public frmListaVentas()
        {
            InitializeComponent();
        }

        private void frmListaVentas_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            cargarComboBox();
            cargarData();
        }

        private void cargarGrilla()
        {
            dgvVentas.DataSource = TrabajarVenta.TraerVenta();
        }

        private void cargarComboBox()
        {
            dtpFecha1.Value = DateTime.Today;
            dtpFecha2.Value = DateTime.Today;

            cbClientes.DataSource = TrabajarCliente.traerClientesComboBoxSP();
            cbClientes.DisplayMember = "cli_datos";
            cbClientes.ValueMember = "DNI";
            cbClientes.Text = "Select Client";

            cboMarca.DataSource = TrabajarVehiculo.traerMarcaComboBox();
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.ValueMember = "Descripcion";
            cboMarca.Text = "Select Brand";
        }
        
        private void cargarData()
        {
            int contadorTotal = -1;
            decimal importeTotal = 0;
            int ventasInvalidadas = -1;

            foreach (DataGridViewRow fila in dgvVentas.Rows)
            {
                //Cantidad de Ventas
                contadorTotal = contadorTotal + 1;

                //Importe Total de Ventas
                object obj = fila.Cells["Precio Final"].Value;
                decimal numero = Convert.ToDecimal(obj);
                importeTotal = importeTotal + numero;

                //Cantidad de Ventas Invalidadas
                bool bandera =Convert.ToBoolean(fila.Cells["Estado"].Value);

                if(bandera == false)
                {
                    ventasInvalidadas = ventasInvalidadas + 1;
                }
            }

            lblCantVentas.Text = "Total Sales: " + contadorTotal;
            lblImporteTotal.Text = "Total Amount: " + importeTotal;
            lblInvalidadas.Text = "Invalid Sales: " + ventasInvalidadas;
            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string dni = (string)cbClientes.SelectedValue;
            dgvVentas.DataSource = TrabajarVenta.TraerVentaClienteSP(dni);
            cargarData();
        }

        private void btnFiltrarFechas_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = dtpFecha1.Value;
            DateTime fecha2 = dtpFecha2.Value;

            dgvVentas.DataSource = TrabajarVenta.TraerVentaFechasSP(fecha1,fecha2);
            cargarData();
        }

        private void btnFilterMarca_Click(object sender, EventArgs e)
        {
            string marca = cboMarca.Text;

            dgvVentas.DataSource = TrabajarVenta.TraerVentaMarcaSP(marca);
            cargarData();
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSeleccionada.Text = Convert.ToString(dgvVentas.CurrentRow.Cells[0].Value);
        }

        private void btnInvalidar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Venta oVenta = new Venta();
                
                oVenta.VTA_id = Convert.ToInt32(dgvVentas.CurrentRow.Cells[0].Value);
                oVenta.VTA_estado = false;
                oVenta.USU_id = Convert.ToInt32(dgvVentas.CurrentRow.Cells[9].Value);
                oVenta.VEH_matricula = (string)dgvVentas.CurrentRow.Cells[3].Value;
                oVenta.VTA_fecha = Convert.ToDateTime(dgvVentas.CurrentRow.Cells[10].Value);
                oVenta.FP_id = TrabajarFormaPago.traerId((string)dgvVentas.CurrentRow.Cells[11].Value);
                oVenta.VTA_precioFinal = Convert.ToDecimal(dgvVentas.CurrentRow.Cells[12].Value);

                TrabajarVenta.CambiarVenta(oVenta);

                cargarGrilla();
                cargarData();
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarGrilla();
            //txtMarca.Text = "";
            cbClientes.Text = "Select Client";
            dtpFecha1.Value = DateTime.Today;
            dtpFecha1.Value = DateTime.Today;
            cargarData();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Venta oVenta = new Venta();

                oVenta.VTA_id = Convert.ToInt32(dgvVentas.CurrentRow.Cells[0].Value);
                oVenta.VTA_estado = true;
                oVenta.USU_id = Convert.ToInt32(dgvVentas.CurrentRow.Cells[9].Value);
                oVenta.VEH_matricula = (string)dgvVentas.CurrentRow.Cells[3].Value;
                oVenta.VTA_fecha = Convert.ToDateTime(dgvVentas.CurrentRow.Cells[10].Value);
                oVenta.FP_id = TrabajarFormaPago.traerId((string)dgvVentas.CurrentRow.Cells[11].Value);
                oVenta.VTA_precioFinal = Convert.ToDecimal(dgvVentas.CurrentRow.Cells[12].Value);

                TrabajarVenta.CambiarVenta(oVenta);

                cargarGrilla();
                cargarData();
            }
        }
    }
}
