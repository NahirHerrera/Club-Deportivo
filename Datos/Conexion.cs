using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Club_Deportivo.Datos
{
    internal class Conexion
    {
        // Clase Conexion

        // Atributos para la conexión a la base de datos

        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        // Constructor privado para implementar el patrón Singleton
        // Clase encargada de administrar la conexión con MySQL.
        // Implementa el patrón Singleton para garantizar una única instancia.
        private Conexion()
        {
            this.baseDatos = "club_deportivo_modif";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "gaston123";
        }

        // Método para crear y retornar una conexión a la base de datos
        public MySqlConnection CrearConexion()
        {

            MySqlConnection? cadena = new MySqlConnection();

            try
            {
                // Configurar la cadena de conexión con los parámetros definidos

                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
            }
            catch(Exception ex) {

                // En caso de error, mostrar el mensaje y establecer la cadena a null

                cadena = null;
                throw;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            // Si la instancia no existe, crearla. De lo contrario, retornar la instancia existente

            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
    }
