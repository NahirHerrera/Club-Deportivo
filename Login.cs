using Club_Deportivo.Datos;
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
                using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
                {
                    cn.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos!");
                }
            }
            catch (Exception ex)
            {
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
            DataTable tablaLogin = new DataTable();
            Usuarios dato = new Usuarios();

            tablaLogin = dato.Log_Usu(usuarioBox.Text, contraseniaBox.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }
    }
}
