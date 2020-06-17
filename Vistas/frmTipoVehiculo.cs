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
    public partial class frmTipoVehiculo : Form
    {
        public frmTipoVehiculo()
        {
            InitializeComponent();
        }

        private void frmTipoVehiculo_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            dgvTipoVehiculo.DataSource = TrabajarTipoVehiculo.ObtenerTipo();
        }

        private void dgvTipoVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string descripcion = (string)dgvTipoVehiculo.CurrentRow.Cells[1].Value;
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
                if (TrabajarTipoVehiculo.VerificarTipo(txtDescripcion.Text) == false)
                {
                    if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        TipoVehiculo oTipoVehiculo = new TipoVehiculo(); 

                        oTipoVehiculo.TV_descripcion = txtDescripcion.Text;

                        TrabajarTipoVehiculo.AgregarTipo(oTipoVehiculo);

                        cargarGrilla();
                        limpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Este tipo de vehículo ya esta registrado, intente con otro.");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idTipoVehiculo = (int)dgvTipoVehiculo.CurrentRow.Cells[0].Value;

                TrabajarTipoVehiculo.EliminarTipo(idTipoVehiculo);

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
                if (TrabajarTipoVehiculo.VerificarTipo(txtDescripcion.Text) == false)
                {
                    if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        TipoVehiculo oTipoVehiculo = new TipoVehiculo();

                        oTipoVehiculo.TV_descripcion = txtDescripcion.Text;

                        int idTipoVehiculo = (int)dgvTipoVehiculo.CurrentRow.Cells[0].Value;

                        oTipoVehiculo.TV_id = idTipoVehiculo;

                        TrabajarTipoVehiculo.ModificarTipo(oTipoVehiculo);

                        cargarGrilla();
                        limpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Este tipo de vehículo ya esta registrado, intente con otro.");
                }
            }
        }

        private void limpiarCampos()
        {
            txtDescripcion.Text = "";
        }
    }
}
