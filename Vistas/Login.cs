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
        private void contraseniaBox_Enter(object sender, EventArgs e)
        {
            if (contraseniaBox.Text == "CONTRASEÑA")
            {
                contraseniaBox.Text = "";
                contraseniaBox.UseSystemPasswordChar = true;
            }
        }
        private void contraseniaBox_Leave(object sender, EventArgs e)
        {
            if (contraseniaBox.Text == "")
            {
                contraseniaBox.Text = "CONTRASEÑA";
                contraseniaBox.UseSystemPasswordChar = false;
            }
        }
    }

}