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
        }
    }
}
