using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class TrabajarAtletas
    {
        public static void alta_atleta(string dni, string apellido, string nombre, string nacionalidad, string entrenador, 
            string genero, double altura, double peso, DateTime nacimiento, string direccion, string email)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Atleta " +
                "(Atl_DNI, Atl_Apellido, Atl_Nombre, Atl_Nacionalidad, Atl_Entrenador, Atl_Genero, Atl_Altura, Atl_Peso, Atl_FechaNac, Atl_Direccion, Atl_email) " +
                "VALUES (@dni, @apellido, @nombre, @nacionalidad, @entrenador, @genero, @altura, @peso, @nacimiento, @direccion, @email)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@nacionalidad", nacionalidad);
            cmd.Parameters.AddWithValue("@entrenador", entrenador);
            cmd.Parameters.AddWithValue("@genero", genero);
            cmd.Parameters.AddWithValue("@altura", altura);
            cmd.Parameters.AddWithValue("@peso", peso);
            cmd.Parameters.AddWithValue("@nacimiento", nacimiento);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@email", email);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable list_atletas()
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "SELECT * FROM ATLETA";
            cmd.CommandText = "SELECT Atl_DNI as 'DNI', Atl_Apellido as 'Apellido', Atl_Nombre as 'Nombre', " +
                "Atl_Nacionalidad as 'Nacionalidad', Atl_Genero as 'Género' FROM Atleta";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
