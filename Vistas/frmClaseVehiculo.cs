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
    public partial class frmClaseVehiculo : Form
    {
        public frmClaseVehiculo()
        {
            InitializeComponent();
        }

        private void frmClaseVehiculo_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            dgvClaseVehiculo.DataSource = TrabajarClaseVehiculo.ObtenerClase();
        }

        private void dgvClaseVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string descripcion = (string)dgvClaseVehiculo.CurrentRow.Cells[1].Value;
            txtDescripcion.Text = descripcion;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("No puede registar campos vacíos");
            }
            else
            {
                if (TrabajarClaseVehiculo.VerificarClase(txtDescripcion.Text) == false)
                {
                    if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClaseVehiculo oClaseVehiculo = new ClaseVehiculo();

                        oClaseVehiculo.CV_descripcion = txtDescripcion.Text;

                        TrabajarClaseVehiculo.AgregarClase(oClaseVehiculo);

                        cargarGrilla();
                        limpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Esta clase de vehículo ya esta registrada, intente con otra.");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idClaseVehiculo = (int)dgvClaseVehiculo.CurrentRow.Cells[0].Value;

                TrabajarClaseVehiculo.EliminarClase(idClaseVehiculo);

                cargarGrilla();
                limpiarCampos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("No puede registar campos vacíos");
            }
            else
            {
                if (TrabajarClaseVehiculo.VerificarClase(txtDescripcion.Text) == false)
                {
                    if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        ClaseVehiculo oClaseVehiculo = new ClaseVehiculo();

                        oClaseVehiculo.CV_descripcion = txtDescripcion.Text;

                        int idClaseVehiculo = (int)dgvClaseVehiculo.CurrentRow.Cells[0].Value;

                        oClaseVehiculo.CV_id = idClaseVehiculo;

                        TrabajarClaseVehiculo.ModificarClase(oClaseVehiculo);

                        cargarGrilla();
                        limpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Esta clase de vehículo ya esta registrada, intente con otra.");
                }
            }
        }

        private void limpiarCampos()
        {
            txtDescripcion.Text = "";
        }
    }
}
