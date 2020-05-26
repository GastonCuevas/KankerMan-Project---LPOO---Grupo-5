using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int USU_ID;

        public int USU_id
        {
            get { return USU_ID; }
            set { USU_ID = value; }
        }
        private string USU_NombreUsuario;

        public string USU_nombreUsuario
        {
            get { return USU_NombreUsuario; }
            set { USU_NombreUsuario = value; }
        }
        private string USU_Contraseña;

        public string USU_contraseña
        {
            get { return USU_Contraseña; }
            set { USU_Contraseña = value; }
        }
        private string USU_ApellidoNombre;

        public string USU_apellidoNombre
        {
            get { return USU_ApellidoNombre; }
            set { USU_ApellidoNombre = value; }
        }
        private string ROL_Codigo;

        public string ROL_codigo
        {
            get { return ROL_Codigo; }
            set { ROL_Codigo = value; }
        }

    }
}
