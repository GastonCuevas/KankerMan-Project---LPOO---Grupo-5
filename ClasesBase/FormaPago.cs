using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class FormaPago
    {
        private int FP_ID;

        public int FP_id
        {
            get { return FP_ID; }
            set { FP_ID = value; }
        }
        private string FP_Descripcion;

        public string FP_descripcion
        {
            get { return FP_Descripcion; }
            set { FP_Descripcion = value; }
        }
    }
}
