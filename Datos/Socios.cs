using Club_Deportivo.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace Club_Deportivo.Datos
{
    internal class Socios
    {
        // Método para registrar un nuevo socio en la base de datos
        public string Nuevo_Socio(E_Socio socio)
        {

            // Variable para almacenar la respuesta del procedimiento almacenado o el mensaje de error
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();

            
            try
            {
                // Crear la conexión a la base de datos utilizando la clase Conexion

                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("RegistroSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros necesarios para el procedimiento almacenado

                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = socio.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = socio.Apellido;
                comando.Parameters.Add("TDoc", MySqlDbType.VarChar).Value = socio.TipoDoc;
                comando.Parameters.Add("Doc", MySqlDbType.VarChar).Value = socio.Documento;

                // Definir un parámetro de salida para capturar la respuesta del procedimiento almacenado

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);

                // Abrir la conexión, ejecutar el comando y capturar la respuesta del procedimiento almacenado
                sqlCon.Open();
                comando.ExecuteNonQuery();

                // Convertir la respuesta del procedimiento almacenado a string y asignarla a la variable de salida

                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                // En caso de una excepción, asignar el mensaje de error a la variable de salida
                salida = ex.Message;
            }
            finally
            {

                // Asegurarse de cerrar la conexión a la base de datos si está abierta
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return salida;
        }
        public string ObtenerEstadoCuota(int idSocio)
        {
            string estado = "";

            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                string query = @"SELECT Estado FROM cuota WHERE IdSocio=@IdSocio";

                MySqlCommand cmd = new MySqlCommand(query, sqlCon);

                cmd.Parameters.AddWithValue( "@IdSocio", idSocio);

                sqlCon.Open();

                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    estado = resultado.ToString();
                }
            }

            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return estado;
        }
    }
}
