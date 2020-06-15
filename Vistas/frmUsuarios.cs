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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargarGrilla();

            cargarComboRol();

        }

        private void cargarComboRol()
        {
            cboRol.DataSource = TrabajarUsuarios.traerRoles();
            cboRol.DisplayMember = "ROL_Descripcion";
            cboRol.ValueMember = "Rol_Codigo";
            cboRol.Text = "Seleccionar Rol";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "" || txtNombreApellido.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("No puede registar campos vacíos");
            }
            else 
            {
                if (TrabajarUsuarios.VerificarUsuario(txtUsuario.Text) == false)
                {
                    if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Usuario oUsuario = new Usuario();

                        oUsuario.USU_apellidoNombre = txtNombreApellido.Text;
                        oUsuario.USU_contraseña = txtContraseña.Text;
                        oUsuario.USU_nombreUsuario = txtUsuario.Text;
                        oUsuario.ROL_codigo = (string)cboRol.SelectedValue;

                        TrabajarUsuarios.AgregarUsuario(oUsuario);

                        cargarGrilla();
                        limpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Este nombre de usuario ya esta registrado, intente con otro.");
                }
            }
        }

        private void limpiarCampos()
        {
            txtContraseña.Text = "";
            txtNombreApellido.Text = "";
            txtUsuario.Text = "";
            cboRol.Text = "Seleccionar Rol";
        }

        private void cargarGrilla()
        {
            dgvUsuarios.DataSource = TrabajarUsuarios.traerUsuario();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idUsuario = (int)dgvUsuarios.CurrentRow.Cells[0].Value;

                TrabajarUsuarios.EliminarUsuario(idUsuario);

                cargarGrilla();
                limpiarCampos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "" || txtNombreApellido.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("No puede registar campos vacíos");
            }
            else
            {
                if (TrabajarUsuarios.VerificarUsuario(txtUsuario.Text) == false)
                {
                    if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        Usuario oUsuario = new Usuario();

                        int idUsuario = (int)dgvUsuarios.CurrentRow.Cells[0].Value;

                        oUsuario.USU_id = idUsuario;
                        oUsuario.USU_apellidoNombre = txtNombreApellido.Text;
                        oUsuario.USU_contraseña = txtContraseña.Text;
                        oUsuario.USU_nombreUsuario = txtUsuario.Text;
                        oUsuario.ROL_codigo = (string)cboRol.SelectedValue;

                        TrabajarUsuarios.ModificarUsuario(oUsuario);

                        cargarGrilla();
                        limpiarCampos();
                    }
                }
                else 
                {
                    MessageBox.Show("Este nombre de usuario ya esta registrado, intente con otro.");
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = TrabajarUsuarios.traerUsuario(txtFiltro.Text);

            if (dgvUsuarios.DataSource == null)
            {
                MessageBox.Show("No se encontraron coincidencias.");
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                string rol = (string)dgvUsuarios.CurrentRow.Cells[1].Value;

                if(rol=="VND"){
                    cboRol.Text = "Vendedor";
                }
                else if (rol == "ADT")
                {
                    cboRol.Text = "Auditor";
                }
                else {
                    cboRol.Text = "Administrador";
                }
                
                string apellidoNombre = (string)dgvUsuarios.CurrentRow.Cells[2].Value;
                txtNombreApellido.Text = apellidoNombre;
                string usuario = (string)dgvUsuarios.CurrentRow.Cells[3].Value;
                txtUsuario.Text = usuario;
                string contraseña = (string)dgvUsuarios.CurrentRow.Cells[4].Value;
                txtContraseña.Text = contraseña;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarGrilla();
            txtFiltro.Text = "";
        }
   }
}