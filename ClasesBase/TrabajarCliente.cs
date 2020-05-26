using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCliente
    {

        /// <summary>
        /// Método que consulta a la tabla Cliente y devuelve todos los datos de la misma
        /// </summary>
        /// <returns>Tabla con datos de clientes</returns>
        public static DataTable traerCliente()
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " select";
            cmd.CommandText += " cli_dni as 'DNI', ";
            cmd.CommandText += " cli_apellido as 'Apellido', cli_nombre as 'Nombre', ";
            cmd.CommandText += " cli_telefono as 'Teléfono', cli_direccion as 'Dirección' ";
            cmd.CommandText += " from Cliente as C";
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
        /// Método que consulta a la tabla Cliente y devuelve todos los datos de la misma según dos parámetros (dni o apellido)
        /// </summary>
        /// <returns>Tabla con datos de Clientes</returns>
        public static DataTable traerCliente(string dato)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select";
            cmd.CommandText += " cli_dni as 'DNI', ";
            cmd.CommandText += " cli_apellido as 'Apellido', cli_nombre as 'Nombre', ";
            cmd.CommandText += " cli_telefono as 'Teléfono', cli_direccion as 'Dirección' ";
            cmd.CommandText += " from Cliente where (cli_dni like @dato) or (cli_apellido like @dato)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dato",dato);

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
        /// Método que consulta a la tabla Cliente y devuelve los datos para el comboBox de frmVentas
        /// </summary>
        /// <returns>Tabla con datos de Cliente</returns>
        public static DataTable traerClienteComboBox()
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select cli_dni, cli_dni+ ' - ' + cli_apellido + ' - ' + cli_nombre as cli_ayn from Cliente";
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
        /// Método que agrega un Cliente a la tabla de Cliente
        /// </summary>
        /// <param name="oCliente"></param>
        public static void AgregarCliente(Cliente oCliente)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Insert con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Cliente(cli_dni,cli_nombre,cli_apellido,cli_direccion,cli_telefono)
                                values
                                (@dni,@n,@a,@d,@t)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@dni", oCliente.CLI_dni);
            cmd.Parameters.AddWithValue("@n", oCliente.CLI_nombre);
            cmd.Parameters.AddWithValue("@a", oCliente.CLI_apellido);
            cmd.Parameters.AddWithValue("@d", oCliente.CLI_direccion);
            cmd.Parameters.AddWithValue("@t", oCliente.CLI_telefono);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

        }

        /// <summary>
        /// Método que modifica un cliente de la tabla de Cliente según el dni
        /// </summary>
        /// <param name="oCliente"></param>
        public static void ModificarCliente(Cliente oCliente)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Update con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Cliente 
                                    set 
                                    cli_apellido=@a,cli_nombre=@n,cli_direccion=@d,cli_telefono=@t
                                    where cli_dni=@dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@dni", oCliente.CLI_dni);
            cmd.Parameters.AddWithValue("@a", oCliente.CLI_apellido);
            cmd.Parameters.AddWithValue("@n", oCliente.CLI_nombre);
            cmd.Parameters.AddWithValue("@d", oCliente.CLI_direccion);
            cmd.Parameters.AddWithValue("@t", oCliente.CLI_telefono);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        /// <summary>
        /// Método que elimina un Cliente de la tabla Cliente según el dni
        /// </summary>
        /// <example>TrabajarCliente.EliminarCliente(42583210);</example>
        /// <param name="dni"></param>
        public static void EliminarCliente(string dni)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //Configuración de la consulta - Delete con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" delete from Cliente
                                    where cli_dni=@dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@dni", dni);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }
    }
}
