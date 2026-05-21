using Club_Deportivo.Datos;
using Club_Deportivo.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace Club_Deportivo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                // Prueba de conexión a la base de datos
                using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
                {

                    // Abrir la conexión para verificar que funcione correctamente
                    cn.Open();
                    MessageBox.Show("¡Conexión exitosa a la base de datos!");
                }
            }
            catch (Exception ex)
            {

                // Manejo de errores de conexión
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void usuarioInput(object sender, EventArgs e)
        {

        }

        private void contraseniaInput(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Validar que los campos no estén vacíos
            Usuarios user = new Usuarios();
            E_Usuario usuario = user.Log_Usu(usuarioBox.Text, contraseniaBox.Text);


            // Verificar si el usuario es válido
            if (usuario != null)
            {

                // Mostrar mensaje de éxito
                MessageBox.Show("Ingreso exitoso: " + usuario.Usuario,
                                "MENSAJES DEL SISTEMA",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Abrir el formulario principal (Home) y ocultar el formulario de login
                Home home = new Home(usuarioBox.Text);
                home.Show();
                this.Hide();
            }
            else
            {

                // Mostrar mensaje de error
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }



    }
}