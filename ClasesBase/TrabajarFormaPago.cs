using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarFormaPago
    {

        /// <summary>
        /// Método que consulta a la tabla FormaPago y devuelve todos los datos de la misma
        /// </summary>
        /// <returns>Tabla con datos de Forma de pago</returns>
        public static DataTable ObtenerFormaPago()
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select ";
            cmd.CommandText += " fp_id as 'ID', ";
            cmd.CommandText += " fp_descripcion as 'Descripción'";
            cmd.CommandText += " from FormaPago as FP";
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
        /// Método que agrega una Forma de pago a la tabla de FormaPago
        /// </summary>
        /// <param name="oFormaPago"></param>
        public static void AgregarFormaPago(FormaPago oFormaPago)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Insert con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into FormaPago(fp_descripcion)
                                values
                                (@d)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@d", oFormaPago.FP_descripcion);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

        }

        /// <summary>
        /// Método que modifica una forma de pago de la tabla de FormaPago según el id
        /// </summary>
        /// <param name="oFormaPago"></param>
        public static void ModificarFormaPago(FormaPago oFormaPago)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Update con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update FormaPago 
                                    set 
                                    fp_descripcion=@d
                                    where fp_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@id", oFormaPago.FP_id);
            cmd.Parameters.AddWithValue("@d", oFormaPago.FP_descripcion);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        /// <summary>
        /// Método que elimina una forma de pago de la tabla FormaPago según el id
        /// </summary>
        /// <example>TrabajarFormaPago.EliminarFormaPago(1);</example>
        /// <param name="id"></param>
        public static void EliminarFormaPago(int id)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Delete con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" delete from FormaPago
                                    where fp_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        /// <summary>
        /// Método que verifica si la forma de pago ya está registrada en la base de datos
        /// </summary>
        /// <param name="descripcion"></param>
        /// <returns>bandera</returns>
        public static bool VerificarFormaPago(string descripcion)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Select con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select fp_descripcion " + "From FormaPago";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            bool bandera = false;

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["fp_descripcion"].Equals(descripcion))
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
        /// Método que devuelve el id de la forma de pago
        /// </summary>
        /// <param name="desc"></param>
        /// <param name="id"></param>
        /// <returns>descripcion</returns>
        public static Int32 traerId(string desc)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select @id=fp_id from FormaPago where fp_descripcion like @desc";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@id", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Output;
            param.Size = 50;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@desc", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Size = 50;
            param.Value = desc;
            cmd.Parameters.Add(param);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

            //Creación de la cadena

            int id = Convert.ToInt32(cmd.Parameters["@id"].Value);

            //Retornamos la descripción

            return id;
        }

    }
}
