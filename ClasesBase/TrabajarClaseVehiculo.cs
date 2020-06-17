using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarClaseVehiculo
    {

        /// <summary>
        /// Método que consulta a la tabla ClaseVehiculo y devuelve todos los datos de la misma
        /// </summary>
        /// <returns>Tabla con datos de clase de vehículo</returns>
        public static DataTable ObtenerClase()
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select ";
            cmd.CommandText += " cv_id as 'ID', ";
            cmd.CommandText += " cv_descripcion as 'Descripción'";
            cmd.CommandText += " from ClaseVehiculo as CV";
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
        /// Método que agrega una Clase de Vehículo a la tabla de ClaseVehiculo
        /// </summary>
        /// <param name="oClaseVehiculo"></param>
        public static void AgregarClase(ClaseVehiculo oClaseVehiculo)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Insert con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into ClaseVehiculo(cv_descripcion)
                                values
                                (@d)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@d", oClaseVehiculo.CV_descripcion);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

        }

        /// <summary>
        /// Método que modifica una clase de vehículo de la tabla de ClaseVehiculo según el id
        /// </summary>
        /// <param name="oClaseVehiculo"></param>
        public static void ModificarClase(ClaseVehiculo oClaseVehiculo)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Update con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update ClaseVehiculo 
                                    set 
                                    cv_descripcion=@d
                                    where cv_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@id", oClaseVehiculo.CV_id);
            cmd.Parameters.AddWithValue("@d", oClaseVehiculo.CV_descripcion);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        /// <summary>
        /// Método que elimina una clase de vehículo de la tabla ClaseVehiculo según el id
        /// </summary>
        /// <example>TrabajarClaseVehiculo.EliminarClase(1);</example>
        /// <param name="id"></param>
        public static void EliminarClase(int id)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Delete con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" delete from ClaseVehiculo
                                    where cv_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        /// <summary>
        /// Método que verifica si la clase de Vehículo ya está registrada en la base de datos
        /// </summary>
        /// <param name="descripcion"></param>
        /// <returns>bandera</returns>
        public static bool VerificarClase(string descripcion)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Select con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select cv_descripcion " + "From ClaseVehiculo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            bool bandera = false;

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["cv_descripcion"].Equals(descripcion))
                    {
                        bandera = true;
                    }
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                bandera = false;
            }
            finally
            {
                cnn.Close();
            }

            return bandera;

        }

        /// <summary>
        /// Método que devuelve la descripción de la clase de vehículo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="d"></param>
        /// <returns>descripcion</returns>
        public static string traerDescripcion(string idC)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select @d=cv_descripcion from ClaseVehiculo where cv_id like @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@d", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Output;
            param.Size = 50;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@id", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Size = 50;
            param.Value = idC;
            cmd.Parameters.Add(param);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

            //Creación de la cadena

            string desc = Convert.ToString(cmd.Parameters["@d"].Value);

            //Retornamos la descripción

            return desc;
        }

    }
}
