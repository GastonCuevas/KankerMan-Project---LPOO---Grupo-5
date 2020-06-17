using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class TipoVehiculo
    {
        private int TV_ID;

        public int TV_id
        {
            get { return TV_ID; }
            set { TV_ID = value; }
        }
        private string TV_Descripcion;

        public string TV_descripcion
        {
            get { return TV_Descripcion; }
            set { TV_Descripcion = value; }
        }
    }
}
