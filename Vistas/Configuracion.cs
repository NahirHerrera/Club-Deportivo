using Club_Deportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Club_Deportivo.Vistas
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();

            txtPass.UseSystemPasswordChar = true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            string puerto = textBox1.Text.Trim();
            string usuario = textBox2.Text.Trim();
            string password = txtPass.Text;


            if (string.IsNullOrWhiteSpace(puerto) || string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Se debe completos los campos puerto y usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Club_Deportivo.Datos.Conexion.getInstancia().SetCredenciales(puerto, usuario, password);

            try
            {

                // Prueba de conexión a la base de datos
                using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
                {

                    // Abrir la conexión para verificar que funcione correctamente
                    cn.Open();
                    MessageBox.Show("¡Conexión exitosa a la base de datos!");
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores de conexión
                MessageBox.Show("Error al conectar: " + ex.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            txtPass.Text = "";
        }

        // Métodos para ocultar la contraseña
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }
        }
    }
}
