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
    }
}
