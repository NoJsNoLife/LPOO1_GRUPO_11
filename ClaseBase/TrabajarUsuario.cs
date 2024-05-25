using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace ClaseBase
{
    public class TrabajarUsuario
    {
        public static DataTable list_roles()
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static bool existe_usuario(string usuario)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Usuario WHERE Usu_NombreUsuario = @usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usuario", usuario);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ExisteUsuarioConMismoNombre(string nombreUsuario, int idUsuario)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM Usuario WHERE Usu_NombreUsuario = @nombreUsuario AND Usu_Id != @idUsuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

            cnn.Open();
            int count = (int)cmd.ExecuteScalar();
            cnn.Close();

            return count > 0;
        }
        public static Usuario loginUsuario(String nombreUsuario, String contrasenia)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Usuario WHERE Usu_NombreUsuario = @usuario AND Usu_Contraseña = @contrasenia";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@contrasenia", contrasenia);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                // No se encontró un usuario con ese nombre de usuario y contraseña
                return null;
            }
            else
            {
                // Se encontró un usuario, devolver ese usuario
                DataRow row = dt.Rows[0];
                Usuario usuario = new Usuario();
                usuario.Usu_NombreUsuario = row["Usu_NombreUsuario"].ToString();
                usuario.Usu_Contraseña = row["Usu_Contraseña"].ToString();
                usuario.Usu_ApellidoNombre = row["Usu_ApellidoNombre"].ToString();
                usuario.Rol_Codigo = int.Parse(row["Rol_Codigo"].ToString());
                return usuario;
            }
        }
        public static void alta_usuario(string nombreUsuario, string contrasenia, string apellidoNombre, int rolId)
        {
            list_usuarios();
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Usuario (Usu_NombreUsuario, Usu_Contraseña, Usu_ApellidoNombre, Rol_Codigo) VALUES (@nombreUsuario,@contrasenia,@apellidoNombre,@rolId)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@contrasenia", contrasenia);
            cmd.Parameters.AddWithValue("@apellidoNombre", apellidoNombre);
            cmd.Parameters.AddWithValue("@rolId", rolId);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static void modificar_usuario(int usuarioId, string nombreUsuario, string contrasenia, string nombreYapellido, int nuevoRol)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE Usuario SET Usu_NombreUsuario = @nombreUsuario, Usu_Contraseña = @contrasenia, Usu_ApellidoNombre = @nombreYapellido, Rol_Codigo = @nuevoRol WHERE Usu_ID = @usuarioId";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@contrasenia", contrasenia);
            cmd.Parameters.AddWithValue("@nombreYapellido", nombreYapellido);
            cmd.Parameters.AddWithValue("@nuevoRol", nuevoRol);
            cmd.Parameters.AddWithValue("@usuarioId", usuarioId);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void borrar_usuario(string usuario)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Usuario WHERE Usu_NombreUsuario = @usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usuario", usuario);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static DataTable list_usuarios()
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Usu_Id as 'ID', ";
            cmd.CommandText += " Rol_Descripcion as 'Rol', ";
            cmd.CommandText += " Usu_ApellidoNombre as 'Apellido y Nombre', ";
            cmd.CommandText += " Usu_NombreUsuario as 'Usuario', ";
            cmd.CommandText += " Usu_Contraseña as 'Contrasena', ";
            cmd.CommandText += " U.Rol_Codigo";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.Rol_Codigo=U.Rol_Codigo)";
            cmd.CommandText += " WHERE U.Usu_NombreUsuario IS NOT NULL";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public static DataTable buscar_usuarios(string sPatron)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Rol_Descripcion as 'Rol', ";
            cmd.CommandText += " Usu_ApellidoNombre as 'Apellido y Nombre', ";
            cmd.CommandText += " Usu_NombreUsuario as 'Usuario', Usu_Contraseña as 'Contrasena', ";
            cmd.CommandText += " U.Rol_Codigo";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.Rol_Codigo=U.Rol_Codigo)";

            cmd.CommandText += " WHERE Usu_NombreUsuario LIKE @patron";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@patron", "%" + sPatron + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

