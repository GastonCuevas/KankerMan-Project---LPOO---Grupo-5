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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            string u = txtNombreUs.Text;
            string p = txtContraseña.Text;

            string rol = TrabajarUsuarios.ValidarUsuario(u,p);
            FrmMain oFrmMain = new FrmMain(rol,u);

            if (rol == "ADT" || rol == "VND" || rol == "ADM")
            {
                MessageBox.Show("Welcome: " + txtNombreUs.Text, "SYSTEM");

                oFrmMain.Show();
            }
            else
            {
                MessageBox.Show("the data entered is incorrect");
                txtNombreUs.Text = "";
                txtContraseña.Text = "";
            }
        }


        private void buttonAccept_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackColor = System.Drawing.Color.Aqua;
            btnAceptar.ForeColor = System.Drawing.Color.Black;
        }

        private void buttonAccept_MouseHover(object sender, EventArgs e)
        {
            btnAceptar.ForeColor = System.Drawing.Color.Gold;
            btnAceptar.BackColor = System.Drawing.Color.Black;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
