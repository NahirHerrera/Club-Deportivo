using Club_Deportivo.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace Club_Deportivo.Datos
{
    public class Usuarios
    {
        public E_Usuario Log_Usu(string usu, string pass)
        {
            // Establecer la conexión a la base de datos utilizando la clase Conexion
            using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
            {

                // Abrir la conexión
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("IngresoLogin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Usu", usu);
                cmd.Parameters.AddWithValue("Pass", pass);

                // Ejecutar el comando y obtener el resultado

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    // Verificar si se obtuvo un resultado y mapearlo a un objeto E_Usuario
                    if (dr.Read())
                    {

                        // Crear y retornar un nuevo objeto E_Usuario con los datos obtenidos
                        return new E_Usuario
                        {
                            idUsuario = dr.GetInt32("IdUsuario"),
                            Usuario = dr.GetString("Usuario"),
                            Password = dr.GetString("Password")
                        };
                    }
                }
            }
            // Si no se encontró un usuario válido, retornar null
            return null;
        }
    }
}
