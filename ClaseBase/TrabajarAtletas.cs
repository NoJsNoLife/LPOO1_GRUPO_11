﻿using Microsoft.Data.SqlClient;
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
        public static bool existe_atleta(string dni)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Atleta WHERE Atl_DNI = @dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

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

        public static void baja_atleta(string dni)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Atleta WHERE Atl_DNI = @dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void editar_atleta(string dni, string apellido, string nombre, string nacionalidad, string entrenador,
            string genero, double altura, double peso, DateTime nacimiento, string direccion, string email)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE Atleta SET " +
                "Atl_Apellido = @apellido, Atl_Nombre = @nombre, Atl_Nacionalidad = @nacionalidad, Atl_Entrenador = @entrenador, " +
                "Atl_Genero = @genero, Atl_Altura = @altura, Atl_Peso = @peso, Atl_FechaNac = @nacimiento, Atl_Direccion = @direccion, Atl_email = @email " +
                "WHERE Atl_DNI = @dni";
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

        public static Atleta buscar_atleta(string dniAtleta)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Atleta WHERE Atl_DNI = @dniAtleta";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dniAtleta", dniAtleta);

            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Atleta atleta = null;
            if (reader.Read())
            {
                atleta = new Atleta();
                atleta.Atl_DNI = reader["Atl_DNI"].ToString();
                atleta.Atl_Nombre = reader["Atl_Nombre"].ToString();
                atleta.Atl_Apellido = reader["Atl_Apellido"].ToString();
                atleta.Atl_Nacionalidad = reader["Atl_Nacionalidad"].ToString();
                atleta.Atl_Entrenador = reader["Atl_Entrenador"].ToString();
                atleta.Atl_Genero = reader["Atl_Genero"].ToString();
                atleta.Atl_Altura = (double)reader["Atl_Altura"];
                atleta.Atl_Peso = (double)reader["Atl_Peso"];
                atleta.Atl_FechaNac = (DateTime)reader["Atl_FechaNac"];
                atleta.Atl_Dirección = reader["Atl_Direccion"].ToString();
                atleta.Atl_email = reader["Atl_email"].ToString();
                    

                
            }

            reader.Close();
            cnn.Close();

            return atleta;
        }

        public static object buscar_atletas(string sPatron)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT Atl_DNI as 'DNI', Atl_Apellido as 'Apellido', Atl_Nombre as 'Nombre', " +
                "Atl_Nacionalidad as 'Nacionalidad', Atl_Genero as 'Género' FROM Atleta";
            cmd.CommandText += " WHERE Atl_DNI LIKE @patron OR Atl_Apellido LIKE @patron OR Atl_Nombre LIKE @patron";

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
