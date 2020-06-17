using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class ClaseVehiculo
    {
        private int CV_ID;

        public int CV_id
        {
            get { return CV_ID; }
            set { CV_ID = value; }
        }
        private string CV_Descripcion;

        public string CV_descripcion
        {
            get { return CV_Descripcion; }
            set { CV_Descripcion = value; }
        }
    }
}
