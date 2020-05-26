using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarVehiculo
    {

        /// <summary>
        /// Método que consulta a la tabla Vehículo y devuelve los datos para el comboBox de frmVentas
        /// </summary>
        /// <returns>Tabla con datos de Vehículo</returns>
        public static DataTable traerVehiculoComboBox()
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select veh_matricula, veh_matricula +' - '+ veh_marca + ' - ' + veh_linea as veh_datos from Vehiculo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Creación de la tabla

            DataTable dt = new DataTable();

            //Cración del adaptador

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            //Llenamos la tabla con los datos que necesitamos
            da.Fill(dt);

            //Retornamos la tabla cargada
            return dt;
        }

        /// <summary>
        /// Devuelve el precio del vehiculo segun un parametro 
        /// </summary>
        /// <param name="p">matricula</param>
        /// <returns>precio $$$</returns>
        public static string verPrecio(string p)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select @precio=veh_precio from Vehiculo where veh_matricula like @m";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@precio", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Output;
            param.Size = 50;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@m", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Size = 50;
            param.Value = p;
            cmd.Parameters.Add(param);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

            //Creación de la cadena

            string precio = Convert.ToString(cmd.Parameters["@precio"].Value);

            //Retornamos el rol

            return precio;
        }
    }
}
