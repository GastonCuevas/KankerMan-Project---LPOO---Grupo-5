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

            cboMarca.Items.Add("Chevrolet");
            cboMarca.Items.Add("Volkswagen");
            cboMarca.Items.Add("Renault");
            cboMarca.Text = "Select Brand";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string dni = (string)cbClientes.SelectedValue;
            dgvVentas.DataSource = TrabajarVenta.TraerVentaClienteSP(dni);
        }

        private void btnFiltrarFechas_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = dtpFecha1.Value;
            DateTime fecha2 = dtpFecha2.Value;

            dgvVentas.DataSource = TrabajarVenta.TraerVentaFechasSP(fecha1,fecha2);
        }

        private void btnFilterMarca_Click(object sender, EventArgs e)
        {
            string marca = cboMarca.Text;

            dgvVentas.DataSource = TrabajarVenta.TraerVentaMarcaSP(marca);
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
                oVenta.VTA_formaPago = (string)dgvVentas.CurrentRow.Cells[11].Value;
                oVenta.VTA_precioFinal = Convert.ToDecimal(dgvVentas.CurrentRow.Cells[12].Value);

                TrabajarVenta.CambiarVenta(oVenta);

                cargarGrilla();
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarGrilla();
            //txtMarca.Text = "";
            cbClientes.Text = "Select Client";
            dtpFecha1.Value = DateTime.Today;
            dtpFecha1.Value = DateTime.Today;
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
                oVenta.VTA_formaPago = (string)dgvVentas.CurrentRow.Cells[11].Value;
                oVenta.VTA_precioFinal = Convert.ToDecimal(dgvVentas.CurrentRow.Cells[12].Value);

                TrabajarVenta.CambiarVenta(oVenta);

                cargarGrilla();
            }
        }
    }
}
