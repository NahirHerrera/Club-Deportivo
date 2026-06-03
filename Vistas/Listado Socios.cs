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
    // Formulario para mostrar el listado de socios
    public partial class ListadoSocios : Form
    {
        public ListadoSocios()
        {
            InitializeComponent();
            this.Load += ListadoSocios_Load;
        }

        // Configura las columnas del DataGridView para mostrar los datos de los socios
        private void ConfigurarGrilla()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.AutoGenerateColumns = false;

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "idCliente", HeaderText = "ID Cliente", DataPropertyName = "idCliente" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Apellido", HeaderText = "Apellido", DataPropertyName = "Apellido" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Documento", HeaderText = "Documento", DataPropertyName = "Documento" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Actividad", HeaderText = "Actividad", DataPropertyName = "Actividad" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaInscripcion", HeaderText = "Fecha Inscripción", DataPropertyName = "FechaInscripcion" });
        }


        private void ListadoSocios_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            CargaGrilla(null);
        }

        // Carga los datos de los socios en el DataGridView, filtrando por DNI si se proporciona
        public void CargaGrilla(string dni = null)
        {
            try
            {
                // Se utiliza un bloque using para asegurar que la conexión y el comando se cierren correctamente
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                using (MySqlCommand cmd = new MySqlCommand("ObtenerSocios", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_dni", (object)dni ?? DBNull.Value);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        foreach (DataColumn col in dt.Columns)
                        {
                            Console.WriteLine(col.ColumnName);
                        }
                        dataGridView2.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Evento del botón para filtrar el listado de socios por DNI
        private void button1_Click(object sender, EventArgs e)
        {
            string dni = string.IsNullOrWhiteSpace(textBox1.Text) ? null : textBox1.Text.Trim();
            CargaGrilla(dni);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
