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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cliente oCliente = new Cliente();

                oCliente.CLI_apellido = txtApellido.Text;
                oCliente.CLI_direccion = txtDireccion.Text;
                oCliente.CLI_dni = txtDNI.Text;
                oCliente.CLI_nombre = txtNombre.Text;
                oCliente.CLI_telefono = txtTelefono.Text;

                TrabajarCliente.AgregarCliente(oCliente);

                cargarGrilla();
            }
        }

        private void cargarGrilla() 
        {
            dgvClientes.DataSource = TrabajarCliente.traerCliente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                string dniCliente = (string)dgvClientes.CurrentRow.Cells[0].Value;

                TrabajarCliente.EliminarCliente(dniCliente);

                cargarGrilla();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cliente oCliente = new Cliente();

                string dniCliente = (string)dgvClientes.CurrentRow.Cells[0].Value;

                oCliente.CLI_apellido = txtApellido.Text;
                oCliente.CLI_direccion = txtDireccion.Text;
                oCliente.CLI_nombre = txtNombre.Text;
                oCliente.CLI_telefono = txtTelefono.Text;
                oCliente.CLI_dni = dniCliente;

                TrabajarCliente.ModificarCliente(oCliente);

                cargarGrilla();
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = TrabajarCliente.traerCliente(txtFiltro.Text);
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string  dni = (string)dgvClientes.CurrentRow.Cells[0].Value;
            txtDNI.Text = dni;
            string apellido = (string)dgvClientes.CurrentRow.Cells[1].Value;
            txtApellido.Text = apellido;
            string nombre = (string)dgvClientes.CurrentRow.Cells[2].Value;
            txtNombre.Text = nombre;
            string telefono = (string)dgvClientes.CurrentRow.Cells[3].Value;
            txtTelefono.Text = telefono;
            string direccion = (string)dgvClientes.CurrentRow.Cells[4].Value;
            txtDireccion.Text = direccion;
        }


    }
}
