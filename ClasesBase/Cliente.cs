using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string CLI_DNI;

        public string CLI_dni
        {
            get { return CLI_DNI; }
            set { CLI_DNI = value; }
        }
        private string CLI_Nombre;

        public string CLI_nombre
        {
            get { return CLI_Nombre; }
            set { CLI_Nombre = value; }
        }
        private string CLI_Apellido;

        public string CLI_apellido
        {
            get { return CLI_Apellido; }
            set { CLI_Apellido = value; }
        }
        private string CLI_Direccion;

        public string CLI_direccion
        {
            get { return CLI_Direccion; }
            set { CLI_Direccion = value; }
        }
        private string CLI_Telefono;

        public string CLI_telefono
        {
            get { return CLI_Telefono; }
            set { CLI_Telefono = value; }
        }
    }
}
