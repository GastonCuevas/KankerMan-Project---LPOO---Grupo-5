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

        /// <summary>
        /// Método que consulta a la tabla Vehiculo y devuelve todos los datos de la misma
        /// </summary>
        /// <returns>Tabla con datos de vehiculos</returns>
        public static DataTable traerVehiculo()
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " select";
            cmd.CommandText += " veh_matricula as 'Matrícula', ";
            cmd.CommandText += " veh_marca as 'Marca', veh_linea as 'Linea', ";
            cmd.CommandText += " veh_modelo as 'Modelo', veh_color as 'Color', ";
            cmd.CommandText += " veh_puertas as 'Puertas', veh_gps as 'GPS', ";
            cmd.CommandText += " veh_tipovehiculo as 'Tipo de Vehículo', veh_clasevehiculo as 'Clase de Vehículo', veh_precio as 'Precio' ";
            cmd.CommandText += " from Vehiculo as V";
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
        /// Método que agrega un Vehículo a la tabla de Vehiculo
        /// </summary>
        /// <param name="oVehiculo"></param>
        public static void AgregarVehiculo(Vehiculo oVehiculo)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Insert con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "agregarVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@matricula", oVehiculo.VEH_matricula);
            cmd.Parameters.AddWithValue("@marca", oVehiculo.VEH_marca);
            cmd.Parameters.AddWithValue("@linea", oVehiculo.VEH_linea);
            cmd.Parameters.AddWithValue("@modelo", oVehiculo.VEH_modelo);
            cmd.Parameters.AddWithValue("@color", oVehiculo.VEH_color);
            cmd.Parameters.AddWithValue("@puertas", oVehiculo.VEH_puertas);
            cmd.Parameters.AddWithValue("@gps", oVehiculo.VEH_gps);
            cmd.Parameters.AddWithValue("@tvehi", oVehiculo.VEH_tipoVehiculo);
            cmd.Parameters.AddWithValue("@cvehi", oVehiculo.VEH_claseVehiculo);
            cmd.Parameters.AddWithValue("@precio", oVehiculo.VEH_precio);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

        }

        /// <summary>
        /// Método que elimina un Vehículo de la tabla Vehícula según la matrícula
        /// </summary>
        /// <example>TrabajarVehiculo.EliminarVehiculo(888-ASD);</example>
        /// <param name="matricula"></param>
        public static void EliminarVehiculo(string matricula)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Delete con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "eliminarVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@matricula", matricula);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        /// <summary>
        /// Método que modifica un vehículo de la tabla de Vehiculo según la matrícula
        /// </summary>
        /// <param name="oCliente"></param>
        public static void ModificarVehiculo(Vehiculo oVehiculo)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Update con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificarVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@matricula", oVehiculo.VEH_matricula);
            cmd.Parameters.AddWithValue("@marca", oVehiculo.VEH_marca);
            cmd.Parameters.AddWithValue("@linea", oVehiculo.VEH_linea);
            cmd.Parameters.AddWithValue("@modelo", oVehiculo.VEH_modelo);
            cmd.Parameters.AddWithValue("@color", oVehiculo.VEH_color);
            cmd.Parameters.AddWithValue("@puertas", oVehiculo.VEH_puertas);
            cmd.Parameters.AddWithValue("@gps", oVehiculo.VEH_gps);
            cmd.Parameters.AddWithValue("@tipov", oVehiculo.VEH_tipoVehiculo);
            cmd.Parameters.AddWithValue("@clasev", oVehiculo.VEH_claseVehiculo);
            cmd.Parameters.AddWithValue("@precio", oVehiculo.VEH_precio);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        /// <summary>
        /// Método que consulta a la tabla Vehiculo y devuelve una lista de vehiculos ordendos por la marca 
        /// mediante un Stored Procedure
        /// </summary>
        /// <returns>Tabla con datos de Vehiculo</returns>
        public static DataTable traerVehiculosMarcaSP()
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "traerVehiculosMarca";
            cmd.CommandType = CommandType.StoredProcedure;
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
        /// Método que consulta a la tabla Vehiculo y devuelve una lista de vehículos ordendos por la linea 
        /// mediante un Stored Procedure
        /// </summary>
        /// <returns>Tabla con datos de Vehiculo</returns>
        public static DataTable traerVehiculosLineaSP()
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "traerVehiculosLinea";
            cmd.CommandType = CommandType.StoredProcedure;
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
    }
}
