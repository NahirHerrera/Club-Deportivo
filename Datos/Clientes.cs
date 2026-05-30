using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Club_Deportivo.Datos
{
    public class Clientes
    {
        // Método para registrar un nuevo cliente en la base de datos
        public string RegistrarCliente(string nom, string ape, string tDoc, string doc, bool apto, bool esSocio, int idActividad)
        {

            // Variable para almacenar la respuesta del procedimiento almacenado o el mensaje de error
            string salida = "";
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                // Crear la conexión a la base de datos utilizando la clase Conexion

                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("RegistrarCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros necesarios para el procedimiento almacenado

                comando.Parameters.AddWithValue("Nom", nom);
                comando.Parameters.AddWithValue("Ape", ape);
                comando.Parameters.AddWithValue("tDoc", tDoc);
                comando.Parameters.AddWithValue("Doc", doc);
                comando.Parameters.AddWithValue("Apto", apto);
                comando.Parameters.AddWithValue("EsSocio", esSocio);
                comando.Parameters.AddWithValue("IdActividad", idActividad);

                // Definir un parámetro de salida para capturar la respuesta del procedimiento almacenado

                MySqlParameter ParCodigo= new MySqlParameter();
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
                MessageBox.Show(ex.Message, "ERROR");
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
    }
}
