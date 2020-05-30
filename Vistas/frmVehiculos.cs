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
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            dgvVehiculos.DataSource = TrabajarVehiculo.traerVehiculo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Vehiculo oVehiculo = new Vehiculo();

                oVehiculo.VEH_matricula = txtMatricula.Text;
                oVehiculo.VEH_marca = txtMarca.Text;
                oVehiculo.VEH_modelo = Int32.Parse(txtModelo.Text);
                oVehiculo.VEH_linea = txtLinea.Text;
                oVehiculo.VEH_color = txtColor.Text;
                oVehiculo.VEH_claseVehiculo = txtClaseVehiculo.Text;
                oVehiculo.VEH_gps = cbGPS.Checked;
                oVehiculo.VEH_precio = decimal.Parse(txtPrecio.Text);
                oVehiculo.VEH_puertas = Int32.Parse(txtCantidadPuertas.Text);
                oVehiculo.VEH_tipoVehiculo = txtTipoVehiculo.Text;                

                TrabajarVehiculo.AgregarVehiculo(oVehiculo);

                cargarGrilla();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Vehiculo oVehiculo = new Vehiculo();

                string matricula = (string)dgvVehiculos.CurrentRow.Cells[0].Value;

                oVehiculo.VEH_matricula = matricula;
                oVehiculo.VEH_marca = txtMarca.Text;
                oVehiculo.VEH_modelo = Int32.Parse(txtModelo.Text);
                oVehiculo.VEH_linea = txtLinea.Text;
                oVehiculo.VEH_color = txtColor.Text;
                oVehiculo.VEH_claseVehiculo = txtClaseVehiculo.Text;
                oVehiculo.VEH_gps = cbGPS.Checked;
                oVehiculo.VEH_precio = decimal.Parse(txtPrecio.Text);
                oVehiculo.VEH_puertas = Int32.Parse(txtCantidadPuertas.Text);
                oVehiculo.VEH_tipoVehiculo = txtTipoVehiculo.Text;                

                TrabajarVehiculo.ModificarVehiculo(oVehiculo);

                cargarGrilla();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string matricula = (string)dgvVehiculos.CurrentRow.Cells[0].Value;
                
                TrabajarVehiculo.EliminarVehiculo(matricula);

                cargarGrilla();
            }
        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatricula.Text = (string)dgvVehiculos.CurrentRow.Cells[0].Value;
            txtMarca.Text = (string)dgvVehiculos.CurrentRow.Cells[1].Value;
            txtLinea.Text = (string)dgvVehiculos.CurrentRow.Cells[2].Value;
            txtModelo.Text = Convert.ToString(dgvVehiculos.CurrentRow.Cells[3].Value);
            txtColor.Text = (string)dgvVehiculos.CurrentRow.Cells[4].Value;
            txtCantidadPuertas.Text = Convert.ToString(dgvVehiculos.CurrentRow.Cells[5].Value);
            cbGPS.Checked = (Boolean)dgvVehiculos.CurrentRow.Cells[6].Value;
            txtTipoVehiculo.Text = (string)dgvVehiculos.CurrentRow.Cells[7].Value;
            txtClaseVehiculo.Text = (string)dgvVehiculos.CurrentRow.Cells[8].Value;
            txtPrecio.Text = Convert.ToString(dgvVehiculos.CurrentRow.Cells[9].Value);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (rbtLinea.Checked == true)
            {
                dgvVehiculos.DataSource = TrabajarVehiculo.traerVehiculosLineaSP();
            }
            else 
            {
                dgvVehiculos.DataSource = TrabajarVehiculo.traerVehiculosMarcaSP();
            }
        }
    }
}
