using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarTipoVehiculo
    {

        /// <summary>
        /// Método que consulta a la tabla TipoVehiculo y devuelve todos los datos de la misma
        /// </summary>
        /// <returns>Tabla con datos de tipo de vehículo</returns>
        public static DataTable ObtenerTipo()
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select ";
            cmd.CommandText += " tv_id as 'ID', ";
            cmd.CommandText += " tv_descripcion as 'Descripción'";
            cmd.CommandText += " from TipoVehiculo as TV";
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
        /// Método que agrega un Tipo de Vehículo a la tabla de TipoVehiculo
        /// </summary>
        /// <param name="oTipoVehiculo"></param>
        public static void AgregarTipo(TipoVehiculo oTipoVehiculo)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Insert con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into TipoVehiculo(tv_descripcion)
                                values
                                (@d)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@d", oTipoVehiculo.TV_descripcion);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

        }

        /// <summary>
        /// Método que modifica un tipo de vehículo de la tabla de TipoVehiculo según el id
        /// </summary>
        /// <param name="oTipoVehiculo"></param>
        public static void ModificarTipo(TipoVehiculo oTipoVehiculo)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Update con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update TipoVehiculo 
                                    set 
                                    tv_descripcion=@d
                                    where tv_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@id", oTipoVehiculo.TV_id);
            cmd.Parameters.AddWithValue("@d", oTipoVehiculo.TV_descripcion);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        /// <summary>
        /// Método que elimina un tipo de vehículo de la tabla TipoVehiculo según el id
        /// </summary>
        /// <example>TrabajarUsuarios.EliminarTipo(1);</example>
        /// <param name="id"></param>
        public static void EliminarTipo(int id)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Delete con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" delete from TipoVehiculo
                                    where tv_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        /// <summary>
        /// Método que verifica si el Tipo de Vehículo ya está registrado en la base de datos
        /// </summary>
        /// <param name="descripcion"></param>
        /// <returns>bandera</returns>
        public static bool VerificarTipo(string descripcion)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Select con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select tv_descripcion " + "From TipoVehiculo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            bool bandera = false;

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["tv_descripcion"].Equals(descripcion))
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
        /// Método que devuelve la descripción del tipo de vehículo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="d"></param>
        /// <returns>descripcion</returns>
        public static string traerDescripcion(string idT)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select @d=tv_descripcion from TipoVehiculo where tv_id like @id";
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
            param.Value = idT;
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
