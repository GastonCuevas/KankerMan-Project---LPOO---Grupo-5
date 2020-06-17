using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Venta
    {
        private int VTA_ID;

        public int VTA_id
        {
            get { return VTA_ID; }
            set { VTA_ID = value; }
        }
        private string CLI_DNI;

        public string CLI_dni
        {
            get { return CLI_DNI; }
            set { CLI_DNI = value; }
        }
        private string VEH_Matricula;

        public string VEH_matricula
        {
            get { return VEH_Matricula; }
            set { VEH_Matricula = value; }
        }
        private int USU_ID;

        public int USU_id
        {
            get { return USU_ID; }
            set { USU_ID = value; }
        }
        private DateTime VTA_Fecha;

        public DateTime VTA_fecha
        {
            get { return VTA_Fecha; }
            set { VTA_Fecha = value; }
        }
        private int FP_ID;

        public int FP_id
        {
            get { return FP_ID; }
            set { FP_ID = value; }
        }
        private decimal VTA_PrecioFinal;

        public decimal VTA_precioFinal
        {
            get { return VTA_PrecioFinal; }
            set { VTA_PrecioFinal = value; }
        }

        private bool VTA_Estado;

        public bool VTA_estado
        {
            get { return VTA_Estado; }
            set { VTA_Estado = value; }
        }
    }
}
