using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuarios
    {
        /// <summary>
        /// Método que consulta a la tabla Usuarios y devuelve todos los datos de la misma
        /// </summary>
        /// <returns>Tabla con datos de usuarios</returns>
        public static DataTable traerUsuario()
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select ";
            cmd.CommandText += " usu_id as 'ID', ";
            cmd.CommandText += " rol_codigo as 'Rol', ";
            cmd.CommandText += " usu_apellidoNombre as 'Apellido y Nombre', ";
            cmd.CommandText += " usu_nombreusuario as 'Usuario', usu_contraseña as 'Contraseña' ";
            cmd.CommandText += " from Usuario as U";
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
        /// Método que consulta a la tabla Usuarios y devuelve todos los datos de la misma según un parámetro
        /// </summary>
        /// <returns>Tabla con datos de usuarios</returns>
        public static DataTable traerUsuario(string u)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select ";
            cmd.CommandText += " usu_id as 'ID', ";
            cmd.CommandText += " rol_codigo as 'Rol', ";
            cmd.CommandText += " usu_apellidoNombre as 'Apellido y Nombre', ";
            cmd.CommandText += " usu_nombreusuario as 'Usuario', usu_contraseña as 'Contraseña' ";
            cmd.CommandText += " from Usuario where usu_nombreusuario like @u";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@u","%" + u + "%");

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
        /// Método que consulta a la tabla Roles y devuelve todos los datos de la misma
        /// </summary>
        /// <returns>Tabla</returns>
        public static DataTable traerRoles()
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Roles";
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
        /// Método que agrega un Usuario a la tabla de Usuario
        /// </summary>
        /// <param name="oUsuario"></param>
        public static void AgregarUsuario(Usuario oUsuario)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Insert con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Usuario(usu_nombreusuario,usu_contraseña,usu_apellidonombre,rol_codigo)
                                values
                                (@u,@p,@ayn,@r)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@u", oUsuario.USU_nombreUsuario);
            cmd.Parameters.AddWithValue("@p", oUsuario.USU_contraseña);
            cmd.Parameters.AddWithValue("@ayn", oUsuario.USU_apellidoNombre);
            cmd.Parameters.AddWithValue("@r", oUsuario.ROL_codigo);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

        }

        /// <summary>
        /// Método que modifica un usuario de la tabla de Usuario según el id
        /// </summary>
        /// <param name="oUsuario"></param>
        public static void ModificarUsuario(Usuario oUsuario)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Update con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Usuario 
                                    set 
                                    usu_nombreusuario=@u,usu_contraseña=@p,usu_apellidonombre=@ayn,rol_codigo=@r
                                    where usu_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@id", oUsuario.USU_id);
            cmd.Parameters.AddWithValue("@u", oUsuario.USU_nombreUsuario);
            cmd.Parameters.AddWithValue("@p", oUsuario.USU_contraseña);
            cmd.Parameters.AddWithValue("@ayn", oUsuario.USU_apellidoNombre);
            cmd.Parameters.AddWithValue("@r", oUsuario.ROL_codigo);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        /// <summary>
        /// Método que elimina un Usuario de la tabla Usuario según el id
        /// </summary>
        /// <example>TrabajarUsuarios.EliminarUsuario(1);</example>
        /// <param name="id"></param>
        public static void EliminarUsuario(int id)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Delete con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" delete from Usuario
                                    where usu_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        /// <summary>
        /// Método que compara los datos ingresados en el login con la base de datos y si encuentra coincidencia devuelve el rol
        /// </summary>
        /// <param name="u"></param>
        /// <param name="p"></param>
        /// <returns>rol</returns>
        public static string ValidarUsuario(string u, string p)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select @rol=rol_codigo from Usuario where (usu_nombreusuario = @u) and (usu_contraseña = @p)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@rol",SqlDbType.VarChar);
            param.Direction = ParameterDirection.Output;
            param.Size = 50;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@u", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Size = 50;
            param.Value = u;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@p", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Size = 50;
            param.Value = p;
            cmd.Parameters.Add(param);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

            //Creación de la cadena

            string rol = Convert.ToString(cmd.Parameters["@rol"].Value);
            
            //Retornamos el rol

            return rol;
        }

        /// <summary>
        /// Método que devuelve Apellido y Nombre del vendedor logueado
        /// </summary>
        /// <param name="u"></param>
        /// <param name="p"></param>
        /// <returns>rol</returns>
        public static string traerVendedor(string u)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select @an=usu_apellidonombre from Usuario where usu_nombreusuario like @u";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@an", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Output;
            param.Size = 50;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@u", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Size = 50;
            param.Value = u;
            cmd.Parameters.Add(param);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

            //Creación de la cadena

            string ApellidoNombre = Convert.ToString(cmd.Parameters["@an"].Value);

            //Retornamos el rol

            return ApellidoNombre;
        }

        /// <summary>
        /// Método que devuelve id del vendedor logueado
        /// </summary>
        /// <param name="u"></param>
        /// <param name="p"></param>
        /// <returns>rol</returns>
        public static string traerID(string u)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select @id=usu_id from Usuario where usu_nombreusuario like @u";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@id", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Output;
            param.Size = 50;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@u", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Size = 50;
            param.Value = u;
            cmd.Parameters.Add(param);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

            //Creación de la cadena

            string id = Convert.ToString(cmd.Parameters["@id"].Value);
             
            //Retornamos el rol

            return id;
        }
    }
}
