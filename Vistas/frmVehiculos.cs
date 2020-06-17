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

            cargarComboBox();
        }

        private void cargarComboBox()
        {
            cboMarca.DataSource = TrabajarVehiculo.traerMarcaComboBox();
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.ValueMember = "Descripcion";
            cboMarca.Text = "Select Brand";

            cboLinea.Items.Add("Corsa");
            cboLinea.Items.Add("Gol");
            cboLinea.Items.Add("Clio");
            cboLinea.Text = "Select Line";

            cboClaseVehiculo.DataSource = TrabajarClaseVehiculo.ObtenerClase();
            cboClaseVehiculo.DisplayMember = "Descripción";
            cboClaseVehiculo.ValueMember = "ID";
            cboClaseVehiculo.Text = "Select Vehicle Class";

            cboColor.Items.Add("Rojo");
            cboColor.Items.Add("Azul");
            cboColor.Items.Add("Verde");
            cboColor.Items.Add("Gris");
            cboColor.Text = "Select Color";

            cboCantPuertas.Items.Add("2");
            cboCantPuertas.Items.Add("3");
            cboCantPuertas.Items.Add("5");
            cboCantPuertas.Text = "Select Doors";

            cboTipoVehiculo.DataSource = TrabajarTipoVehiculo.ObtenerTipo();
            cboTipoVehiculo.DisplayMember = "Descripción";
            cboTipoVehiculo.ValueMember = "ID";
            cboTipoVehiculo.Text = "Select Vehicle Type";

            nudModelo.Minimum = 0;
            nudModelo.Maximum = 1000000;
            nudPrecio.Minimum = 0;
            nudPrecio.Maximum = 10000000;

        }

        private void cargarGrilla()
        {
            dgvVehiculos.DataSource = TrabajarVehiculo.traerVehiculo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboTipoVehiculo.Text == "Select Vehicle Type" || nudModelo.Value == 0 || cboMarca.Text == "Select Brand"
                || cboLinea.Text == "Select Model" || cboColor.Text == "Select Color" || cboTipoVehiculo.Text == "Select Vehicle Type"
                || cboCantPuertas.Text == "Select Doors" || nudPrecio.Value == 0 || txtMatricula.Text == "")
            {
                MessageBox.Show("No puede registar campos vacíos");
            }
            else
            {
                if (TrabajarVehiculo.VerificarVehiculo(txtMatricula.Text) == false)
                {
                    if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Vehiculo oVehiculo = new Vehiculo();

                        oVehiculo.VEH_matricula = txtMatricula.Text;
                        oVehiculo.VEH_marca = cboMarca.Text;
                        oVehiculo.VEH_modelo = Convert.ToInt32(nudModelo.Value);
                        oVehiculo.VEH_linea = cboLinea.Text;
                        oVehiculo.VEH_color = cboColor.Text;
                        oVehiculo.CV_id = (Int32)cboClaseVehiculo.SelectedValue;
                        oVehiculo.VEH_gps = cbGPS.Checked;
                        oVehiculo.VEH_precio = nudPrecio.Value;
                        oVehiculo.VEH_puertas = Convert.ToInt32(cboCantPuertas.Text);
                        oVehiculo.TV_id = (Int32)cboTipoVehiculo.SelectedValue;

                        TrabajarVehiculo.AgregarVehiculo(oVehiculo);

                        cargarGrilla();
                        limpiarGrilla();
                    }
                }
                else 
                {
                    MessageBox.Show("Esta matrícula ya está registrada, intente con otra");
                }
            }
        }

        private void limpiarGrilla()
        {
            txtMatricula.Text = "";
            cboCantPuertas.Text = "Select Doors";
            cbGPS.Checked = false;
            cboClaseVehiculo.Text = "Select Vehicle Class";
            cboColor.Text = "Select Color";
            cboLinea.Text = "Select Line";
            cboMarca.Text = "Select Brand";
            nudModelo.Value = 0;
            cboTipoVehiculo.Text = "Select Vehicle Type";
            nudPrecio.Value = 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cboTipoVehiculo.Text == "Select Vehicle Type" || nudModelo.Value == 0 || cboMarca.Text == "Select Brand"
                || cboLinea.Text == "Select Model" || cboColor.Text == "Select Color" || cboTipoVehiculo.Text == "Select Vehicle Type"
                || cboCantPuertas.Text == "Select Doors" || nudPrecio.Value == 0 || txtMatricula.Text == "")
            {
                MessageBox.Show("No puede registar campos vacíos");
            }
            else
            {
                if (TrabajarVehiculo.VerificarVehiculo(txtMatricula.Text) == true)
                {
                    if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Vehiculo oVehiculo = new Vehiculo();

                        string matricula = (string)dgvVehiculos.CurrentRow.Cells[0].Value;

                        oVehiculo.VEH_matricula = matricula;
                        oVehiculo.VEH_marca = cboMarca.Text;
                        oVehiculo.VEH_modelo = Convert.ToInt32(nudModelo.Value);
                        oVehiculo.VEH_linea = cboLinea.Text;
                        oVehiculo.VEH_color = cboColor.Text;
                        oVehiculo.CV_id = (Int32)cboClaseVehiculo.SelectedValue;
                        oVehiculo.VEH_gps = cbGPS.Checked;
                        oVehiculo.VEH_precio = nudPrecio.Value;
                        oVehiculo.VEH_puertas = Convert.ToInt32(cboCantPuertas.Text);
                        oVehiculo.TV_id = (Int32)cboTipoVehiculo.SelectedValue;

                        TrabajarVehiculo.ModificarVehiculo(oVehiculo);

                        cargarGrilla();
                        limpiarGrilla();
                    }
                }
                else
                {
                    MessageBox.Show("Esta matrícula no está registrada, intente con una válida");
                }
            }   
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("confirms the action?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string matricula = (string)dgvVehiculos.CurrentRow.Cells[0].Value;
                
                TrabajarVehiculo.EliminarVehiculo(matricula);

                cargarGrilla();
                limpiarGrilla();
            }
        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatricula.Text = (string)dgvVehiculos.CurrentRow.Cells[0].Value;
            cboMarca.Text = (string)dgvVehiculos.CurrentRow.Cells[1].Value;
            cboLinea.Text = (string)dgvVehiculos.CurrentRow.Cells[2].Value;
            nudModelo.Value = Convert.ToDecimal(dgvVehiculos.CurrentRow.Cells[3].Value);
            cboColor.Text = (string)dgvVehiculos.CurrentRow.Cells[4].Value;
            cboCantPuertas.Text = Convert.ToString(dgvVehiculos.CurrentRow.Cells[5].Value);
            cbGPS.Checked = (Boolean)dgvVehiculos.CurrentRow.Cells[6].Value;
            cboTipoVehiculo.Text = (string)dgvVehiculos.CurrentRow.Cells[8].Value;
            cboClaseVehiculo.Text = (string)dgvVehiculos.CurrentRow.Cells[9].Value;
            nudPrecio.Value = Convert.ToDecimal(dgvVehiculos.CurrentRow.Cells[7].Value);
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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }
    }
}
