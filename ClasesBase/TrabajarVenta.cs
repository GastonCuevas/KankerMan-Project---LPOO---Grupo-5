using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarVenta
    {

        /// <summary>
        /// Método que agrega una Venta a la tabla de Venta
        /// </summary>
        /// <param name="oVenta"></param>
        public static void AgregarVenta(Venta oVenta)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Insert con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Venta(cli_dni,veh_matricula,usu_id,vta_fecha,vta_formapago,vta_preciofinal)
                                values
                                (@dni,@m,@id,@f,@p,@pf)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@dni", oVenta.CLI_dni);
            cmd.Parameters.AddWithValue("@m", oVenta.VEH_matricula);
            cmd.Parameters.AddWithValue("@id", oVenta.USU_id);
            cmd.Parameters.AddWithValue("@f", oVenta.VTA_fecha);
            cmd.Parameters.AddWithValue("@p", oVenta.VTA_formaPago);
            cmd.Parameters.AddWithValue("@pf", oVenta.VTA_precioFinal);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

        }

        public static DataTable TraerVenta()
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "traerVistaVenta";
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
        /// Método que consulta a la vista ventasCliente y devuelve una lista de ventas filtrada por cliente
        /// mediante un Stored Procedure
        /// </summary>
        /// <returns>Vista con datos de Venta</returns>
        public static DataTable TraerVentaClienteSP(string dni)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "traerVentaCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

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
        /// Método que consulta a la vista ventasFecha y devuelve una lista de ventas filtrada por un rango de fecha
        /// mediante un Stored Procedure
        /// </summary>
        /// <returns>Vista con datos de Venta</returns>
        public static DataTable TraerVentaFechasSP(DateTime fecha1, DateTime fecha2)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "traerVentaFechas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha1", fecha1);
            cmd.Parameters.AddWithValue("@fecha2", fecha2);

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
        /// Método que consulta a la vista ventasFecha y devuelve una lista de ventas filtrada por la marca del vehículo
        /// mediante un Stored Procedure
        /// </summary>
        /// <returns>Vista con datos de Venta</returns>
        public static DataTable TraerVentaMarcaSP(string marca)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "traerVistaMarca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@marca", marca);

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
