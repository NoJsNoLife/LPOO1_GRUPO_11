using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class TrabajarEvento
    {
        public static void insertar(int id_atleta, int id_com, string estado, string fechaInicio, string fechaFin)
        {
            String conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "INSERT INTO Evento (Com_ID, Atl_ID, Eve_Estado, Eve_HoraInicio, Eve_HoraFin) VALUES (@com_id, @atl_id, @estado, @horaInicio, @horaFin)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@com_id", id_com);
            cmd.Parameters.AddWithValue("@atl_id", id_atleta);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@horaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@horaFin", fechaFin);
            
            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();


        }

        public static bool existe_duplicado(int id_atleta, int id_com)
        {
            String conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT COUNT(*) FROM Evento WHERE Atl_ID = @atl_id AND Com_ID = @com_id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@com_id", id_com);
            cmd.Parameters.AddWithValue("@atl_id", id_atleta);

            cnn.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            cnn.Close();

            return count > 0;
        }

        public static Evento buscarEventoByIdAtleta(int id_atleta, int id_com)
        {
            String conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT * FROM Evento WHERE Atl_ID = @atl_id AND Com_ID = @com_id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@com_id", id_com);
            cmd.Parameters.AddWithValue("@atl_id", id_atleta);

            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            Evento evento = null;

            if (reader.Read())
            {
                evento = new Evento();
                evento.Eve_ID = reader.GetInt32(reader.GetOrdinal("Eve_ID"));
                evento.Com_ID = reader.GetInt32(reader.GetOrdinal("Com_ID"));
                evento.Atl_ID = reader.GetInt32(reader.GetOrdinal("Atl_ID"));
                evento.Eve_Estado = reader.GetString(reader.GetOrdinal("Eve_Estado"));
                evento.Eve_HoraInicio = reader.GetDateTime(reader.GetOrdinal("Eve_HoraInicio"));
                evento.Eve_HoraFin = reader.GetDateTime(reader.GetOrdinal("Eve_HoraFin"));
            }

            cnn.Close();

            return evento;
        }


        public static DataTable listarEventos() { 
           String conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT * FROM Evento";
            cmd.CommandType = CommandType.Text;

            cnn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            cnn.Close();

            return dataTable;
        }

        public static Evento buscarEventoPorAtletaDniYCompetencia(string dni, int id_com)
        {
            Atleta atleta = TrabajarAtletas.buscar_atleta(dni);
            if (atleta == null)
            {
                return null;
            }

            String conexion = DataBaseConfig.DB_CONN;
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Evento WHERE Atl_ID = @atl_id AND Com_ID = @com_id", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@com_id", id_com);
                    cmd.Parameters.AddWithValue("@atl_id", atleta.Atl_ID);

                    cnn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Evento evento = new Evento();
                            evento.Eve_ID = reader.GetInt32(reader.GetOrdinal("Eve_ID"));
                            evento.Com_ID = reader.GetInt32(reader.GetOrdinal("Com_ID"));
                            evento.Atl_ID = reader.GetInt32(reader.GetOrdinal("Atl_ID"));
                            evento.Eve_Estado = reader.GetString(reader.GetOrdinal("Eve_Estado"));
                            evento.Eve_HoraInicio = reader.GetDateTime(reader.GetOrdinal("Eve_HoraInicio"));
                            evento.Eve_HoraFin = reader.GetDateTime(reader.GetOrdinal("Eve_HoraFin"));
                            return evento;
                        }
                    }
                }
            }
            return null;
        }

        public static void baja_evento(int id_evento)
        {
            String conexion = DataBaseConfig.DB_CONN;
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Evento SET Eve_Estado = 'Anulado' WHERE Eve_ID = @eve_id", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@eve_id", id_evento);

                    cnn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable buscarAtletasPorCompetencia(int idCompetencia)
        {
            DataTable dataTable = new DataTable();
            String conexion = DataBaseConfig.DB_CONN;
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                // Consulta modificada para incluir la verificación del estado "Acreditado"
                string consulta = @"
                    SELECT a.* 
                    FROM Atleta a
                    INNER JOIN Evento e ON a.Atl_ID = e.Atl_ID
                    WHERE e.Com_ID = @com_id AND e.Atl_ID IS NOT NULL AND e.Eve_Estado = 'Acreditado'";

                using (SqlCommand cmd = new SqlCommand(consulta, cnn))
                {
                    cmd.Parameters.AddWithValue("@com_id", idCompetencia); // Usar idCompetencia para filtrar

                    cnn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public static void ActualizarTiemposEvento(int idAtleta, int idCompetencia, DateTime horaInicio, DateTime horaFin)
        {
            String conexion = DataBaseConfig.DB_CONN;
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                // Consulta SQL para actualizar los tiempos de inicio y fin
                string consulta = @"
                    UPDATE Evento
                    SET Eve_HoraInicio = @horaInicio, Eve_HoraFin = @horaFin
                    WHERE Atl_ID = @atlId AND Com_ID = @comId";

                using (SqlCommand cmd = new SqlCommand(consulta, cnn))
                {
                    // Asignar los valores a los parámetros
                    cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFin", horaFin);
                    cmd.Parameters.AddWithValue("@atlId", idAtleta);
                    cmd.Parameters.AddWithValue("@comId", idCompetencia);

                    cnn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    // Opcional: Puedes usar filasAfectadas para verificar si la actualización fue exitosa
                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("Tiempos actualizados correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el evento especificado.");
                    }
                }
            }
        }







    }
}
