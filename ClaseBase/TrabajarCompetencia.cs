using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class TrabajarCompetencia
    {
        private static string connectionString = DataBaseConfig.DB_CONN;

        public static DataTable listarCompetencias()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM vw_CompetenciaConCategoriaYDisciplina", connection);
                command.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public static void InsertarCompetencia(string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, string estado, string organizador, string ubicacion, string sponsors, int catId, int disId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("AltaCompetencia", connection); // Asegúrate de usar el nombre correcto del procedimiento almacenado
                command.CommandType = CommandType.StoredProcedure;

                // Agregando todos los parámetros necesarios para el procedimiento almacenado
                command.Parameters.AddWithValue("@Com_Nombre", nombre);
                command.Parameters.AddWithValue("@Com_Descripcion", descripcion);
                command.Parameters.AddWithValue("@Com_FechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@Com_FechaFin", fechaFin);
                command.Parameters.AddWithValue("@Com_Estado", estado);
                command.Parameters.AddWithValue("@Com_Organizador", organizador);
                command.Parameters.AddWithValue("@Com_Ubicacion", ubicacion);
                command.Parameters.AddWithValue("@Com_Sponsors", sponsors);
                command.Parameters.AddWithValue("@Cat_ID", catId);
                command.Parameters.AddWithValue("@Dis_ID", disId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public static void ActualizarCompetencia(int id, string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, string estado, string organizador, string ubicacion, string sponsors, int catId, int disId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EditarCompetencia", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregando todos los parámetros necesarios para el procedimiento almacenado
                    command.Parameters.AddWithValue("@Com_ID", id);
                    command.Parameters.AddWithValue("@Com_Nombre", nombre);
                    command.Parameters.AddWithValue("@Com_Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Com_FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@Com_FechaFin", fechaFin);
                    command.Parameters.AddWithValue("@Com_Estado", estado);
                    command.Parameters.AddWithValue("@Com_Organizador", organizador);
                    command.Parameters.AddWithValue("@Com_Ubicacion", ubicacion);
                    command.Parameters.AddWithValue("@Com_Sponsors", sponsors);
                    command.Parameters.AddWithValue("@Cat_ID", catId);
                    command.Parameters.AddWithValue("@Dis_ID", disId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Considera registrar el error en un archivo de log o mostrar un mensaje al usuario
                throw ex;
            }
        }


        public static void EliminarCompetencia(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("BajaCompetencia", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Com_ID", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static Competencia buscarCompetenciaPorId(int id)
        {
            Competencia competencia = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("BuscarCompetenciaPorId", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Com_ID", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        competencia = new Competencia
                        {
                            
                            Com_ID = reader.GetInt32(reader.GetOrdinal("Com_ID")),
                            Com_Nombre = reader.GetString(reader.GetOrdinal("Com_Nombre")),
                            Com_Descripcion = reader.GetString(reader.GetOrdinal("Com_Descripcion")),
                            Com_FechaInicio = reader.GetDateTime(reader.GetOrdinal("Com_FechaInicio")),
                            Com_FechaFin = reader.GetDateTime(reader.GetOrdinal("Com_FechaFin")),
                            Com_Estado = reader.GetString(reader.GetOrdinal("Com_Estado")),
                            Com_Organizador = reader.GetString(reader.GetOrdinal("Com_Organizador")),
                            Com_Ubicacion = reader.GetString(reader.GetOrdinal("Com_Ubicacion")),
                            Com_Sponsors = reader.GetString(reader.GetOrdinal("Com_Sponsors")),
                            Cat_ID = reader.GetInt32(reader.GetOrdinal("Cat_ID")),
                            Dis_ID = reader.GetInt32(reader.GetOrdinal("Dis_ID"))
                        };
                    }
                }
            }

            return competencia;
        }


    }


}
