using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class TrabajarCategoria
    {
        private static string connectionString = DataBaseConfig.DB_CONN; // Asegúrate de reemplazar esto con tu cadena de conexión

        public static void AltaCategoria(string nombre, string descripcion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AltaCategoria", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cat_Nombre", nombre);
                cmd.Parameters.AddWithValue("@Cat_Descripcion", descripcion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void BajaCategoria(int catId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("BajaCategoria", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cat_ID", catId);
                 
                    conn.Open();
                
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Error al eliminar la categoria",e);
                }
                
            }
        }

        public static void EditarCategoria(int catId, string nombre, string descripcion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("EditarCategoria", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cat_ID", catId);
                cmd.Parameters.AddWithValue("@Cat_Nombre", nombre);
                cmd.Parameters.AddWithValue("@Cat_Descripcion", descripcion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable ListarCategorias()
        {
            DataTable dtCategorias = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Preparar el comando SQL para ejecutar la vista
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Categorias", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                // Abrir la conexión y llenar el DataTable con los datos de la vista
                conn.Open();
                da.Fill(dtCategorias);
            }

            return dtCategorias;
        }

        public static DataTable BuscarCategoriaPorID(int catId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("buscarCategoriaPorID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cat_ID", catId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
