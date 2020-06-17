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
    public partial class FrmVehicleRegistration : Form
    {
        public FrmVehicleRegistration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmVehicleRegistration_Load(object sender, EventArgs e)
        {

        }

        private void acceptbutton_Click(object sender, EventArgs e)
        {
            Boolean bVehiculoFound = false;

            Vehiculo oVehiculo = new Vehiculo();

            if(brandtextBox.Text != "" && linetextBox.Text != "" && carNumberPlatetextBox.Text != "" &&
               modeltextBox.Text != "" && colortextBox.Text != "" && doortextBox.Text != "" && vehicletypetextBox.Text != "" &&
               vehicleclasstextBox.Text != "" && pricetextBox.Text != "")
            {
                if(MessageBox.Show("confirms the action?","Save data",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    oVehiculo.VEH_marca = brandtextBox.Text;
                    oVehiculo.VEH_linea = linetextBox.Text;
                    oVehiculo.VEH_matricula = carNumberPlatetextBox.Text;
                    oVehiculo.VEH_modelo = Int32.Parse(modeltextBox.Text);
                    oVehiculo.VEH_color = colortextBox.Text;
                    oVehiculo.VEH_puertas = Int32.Parse(doortextBox.Text);
                    oVehiculo.VEH_gps = GPScheckBox.Checked;
                    oVehiculo.TV_id = Int32.Parse(vehicletypetextBox.Text);
                    oVehiculo.CV_id = Int32.Parse(vehicleclasstextBox.Text);
                    oVehiculo.VEH_precio = Decimal.Parse(pricetextBox.Text);
                    bVehiculoFound = true;
                }
            }
            if (bVehiculoFound)
            {
                MessageBox.Show("Brand: " + oVehiculo.VEH_marca +
                    "\n\nLine: " + oVehiculo.VEH_linea + "\n\nCar Number Plate: " + oVehiculo.VEH_matricula +
                    "\n\nModel: " + oVehiculo.VEH_modelo + "\n\nColor: " + oVehiculo.VEH_color +
                    "\n\nDoors: " + oVehiculo.VEH_puertas + "\n\nGPS: " + oVehiculo.VEH_gps +
                    "\n\nVehicle Type: " + oVehiculo.TV_id + "\n\nVehicle Class: " + oVehiculo.CV_id +
                    "\n\nPrice: " + oVehiculo.VEH_precio, "Data saved successfully!!!");

            }
            else
            {
                MessageBox.Show("Incomplete fields", "Error :(");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linelabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
