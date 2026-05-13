using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Club_Deportivo.Datos
{
    internal class Usuarios
    {
        // Método que retorna una tabla con la información del login
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);

                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Log_Usu: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
