using Club_Deportivo.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Club_Deportivo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public Home(string nombre)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Abrir el formulario de inscripción
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_CobrarCuota_Click(object sender, EventArgs e)
        {

            // Abrir el formulario de inscripción
            Cuota cuota = new Cuota();
            cuota.Show();
            this.Hide();
        }

        private void btn_ListadoDeudores_Click(object sender, EventArgs e)
        {

            // Abrir el formulario de inscripción
            Listado listado = new Listado();
            listado.Show();
            this.Hide();
        }
    }
}
