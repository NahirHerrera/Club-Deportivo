using Club_Deportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Club_Deportivo
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }
        private void Listado_Load(object sender, EventArgs e)
        {
            CargaGrilla();
        }
        public void CargaGrilla()
        {

            MySqlConnection? cadena = new MySqlConnection();
            try
            {
                string query;
                cadena = Conexion.getInstancia().CrearConexion();
                query = "SELECT s.Nombre, s.Apellido, s.Documento, c.Monto, c.FechaVencimiento " +
                        "FROM Cuota c INNER JOIN Socios s ON s.IdSocio = c.IdSocio " +
                        "WHERE c.Estado = 'Pendiente' AND c.FechaVencimiento < CURDATE() " +
                        "ORDER BY c.FechaVencimiento ASC;";

                MySqlCommand comando = new MySqlCommand(query, cadena);
                comando.CommandType = CommandType.Text;
                cadena.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvCuota.Rows.Add();
                        dtgvCuota.Rows[renglon].Cells[0].Value = reader.GetString(0);
                        dtgvCuota.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dtgvCuota.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        dtgvCuota.Rows[renglon].Cells[3].Value = reader.GetDecimal(3);
                        dtgvCuota.Rows[renglon].Cells[4].Value = reader.GetDateTime(4);
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para la carga de la grilla");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cadena.State == ConnectionState.Open)
                { cadena.Close(); }
                ;
            }
        }
        private void btnVolverListado_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
