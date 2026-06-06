using MySql.Data.MySqlClient;

namespace Club_Deportivo.Datos
{
    internal class Conexion
    {
        private string servidor = "localhost";
        private string? puerto;
        private string? usuario;
        private string? password;
        private string baseDatos = "club_deportivo_modif";

        private static Conexion? instancia = null;

        private Conexion() { }

        public static Conexion getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }

        // Método para recibir los valores desde el formulario
        public void SetCredenciales(string puerto, string usuario, string password)
        {
            this.puerto = puerto;
            this.usuario = usuario;
            this.password = password;
        }

        // Método para crear la conexión con los datos actuales
        public MySqlConnection CrearConexion()
        {
            var cadena = new MySqlConnection
            {
                ConnectionString = $"datasource={servidor};port={puerto};username={usuario};password={password};Database={baseDatos}"
            };
            return cadena;
        }
    }
}
