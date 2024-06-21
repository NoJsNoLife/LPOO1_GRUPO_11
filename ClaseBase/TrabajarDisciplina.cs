using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class TrabajarDisciplina
    {
        public static bool existeById(int id)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "ExisteDisciplinaById";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter disciplinaId = new SqlParameter("@disciplinaId", SqlDbType.Int);
            disciplinaId.Value = id;
            cmd.Parameters.Add(disciplinaId);

            SqlParameter existe = new SqlParameter("@existe", SqlDbType.Bit);
            existe.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(existe);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return Convert.ToBoolean(existe.Value);
        }

        public static bool existeByNombre(string nombre)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "ExisteDisciplinaByNombre";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter disciplinaNombre = new SqlParameter("@nombre", SqlDbType.VarChar, 50);
            disciplinaNombre.Value = nombre;
            cmd.Parameters.Add(disciplinaNombre);

            SqlParameter existe = new SqlParameter("@existe", SqlDbType.Bit);
            existe.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(existe);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return Convert.ToBoolean(existe.Value);
        }

        public static bool existeNombreDuplicado(string nombre, int id)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ExisteNombreDuplicado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter disciplinaNombre = new SqlParameter("@nombre", SqlDbType.VarChar, 50);
            disciplinaNombre.Value = nombre;
            cmd.Parameters.Add(disciplinaNombre);

            SqlParameter disciplinaId = new SqlParameter("@id", SqlDbType.Int);
            disciplinaId.Value = id;
            cmd.Parameters.Add(disciplinaId);

            SqlParameter existe = new SqlParameter("@existe", SqlDbType.Bit);
            existe.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(existe);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return Convert.ToBoolean(existe.Value);
        }

        public static void alta_disciplina(string nombre, string descripcion)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "AltaDisciplina";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter disciplinaNombre = new SqlParameter("@nombre", SqlDbType.VarChar, 50);
            disciplinaNombre.Value = nombre;
            cmd.Parameters.Add(disciplinaNombre);

            SqlParameter disciplinaDescripcion = new SqlParameter("@descripcion", SqlDbType.VarChar, 50);
            disciplinaDescripcion.Value = descripcion;
            cmd.Parameters.Add(disciplinaDescripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void baja_disciplina(int id)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "BajaDisciplina";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter disciplinaId = new SqlParameter("@id", SqlDbType.Int);
            disciplinaId.Value = id;
            cmd.Parameters.Add(disciplinaId);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void modificar_disciplina(int id, string nombre, string descripcion)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ModificarDisciplina";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter disciplinaId = new SqlParameter("@id", SqlDbType.Int);
            disciplinaId.Value = id;
            cmd.Parameters.Add(disciplinaId);

            SqlParameter disciplinaNombre = new SqlParameter("@nombre", SqlDbType.VarChar, 50);
            disciplinaNombre.Value = nombre;
            cmd.Parameters.Add(disciplinaNombre);
            
            SqlParameter disciplinaDescripcion = new SqlParameter("@descripcion", SqlDbType.VarChar, 50);
            disciplinaDescripcion.Value = descripcion;
            cmd.Parameters.Add(disciplinaDescripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable listar_disciplinas()
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM ViewDisciplinaFull";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
