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
            dgvVentas.DataSource = TrabajarVenta.TraerVenta();
            cargarComboBox();
        }

        private void cargarComboBox()
        {
            dtpFecha1.Value = DateTime.Today;
            dtpFecha2.Value = DateTime.Today;

            cbClientes.DataSource = TrabajarCliente.traerClientesComboBoxSP();
            cbClientes.DisplayMember = "cli_datos";
            cbClientes.ValueMember = "DNI";
            cbClientes.Text = "Select Client";
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
            string marca = txtMarca.Text;

            dgvVentas.DataSource = TrabajarVenta.TraerVentaMarcaSP(marca);
        }
    }
}
