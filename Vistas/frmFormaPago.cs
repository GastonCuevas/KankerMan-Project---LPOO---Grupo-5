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
    public partial class frmFormaPago : Form
    {
        public frmFormaPago()
        {
            InitializeComponent();
        }

        private void frmFormaPago_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            dgvFormaPago.DataSource = TrabajarFormaPago.ObtenerFormaPago();
        }

        private void dgvFormaPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string descripcion = (string)dgvFormaPago.CurrentRow.Cells[1].Value;
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
                if (TrabajarFormaPago.VerificarFormaPago(txtDescripcion.Text) == false)
                {
                    if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FormaPago oFormaPago = new FormaPago();

                        oFormaPago.FP_descripcion = txtDescripcion.Text;

                        TrabajarFormaPago.AgregarFormaPago(oFormaPago);

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
                int idFormaPago = (int)dgvFormaPago.CurrentRow.Cells[0].Value;

                TrabajarFormaPago.EliminarFormaPago(idFormaPago);

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
                if (TrabajarFormaPago.VerificarFormaPago(txtDescripcion.Text) == false)
                {
                    if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        FormaPago oFormaPago = new FormaPago();

                        oFormaPago.FP_descripcion = txtDescripcion.Text;

                        int idFormaPago = (int)dgvFormaPago.CurrentRow.Cells[0].Value;

                        oFormaPago.FP_id = idFormaPago;

                        TrabajarFormaPago.ModificarFormaPago(oFormaPago);

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
