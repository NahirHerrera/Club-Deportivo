using Club_Deportivo;
using Club_Deportivo.Datos;
using Club_Deportivo.Vistas;
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
    public partial class Cuota : Form
    {
        public Comprobante doc = new Comprobante();
        public Cuota()
        {
            InitializeComponent();
        }
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Home home = new Home("Usuario");
            home.Show();
            this.Hide();
        }

        private void btn_Carnet_Click(object sender, EventArgs e)
        {
            Carnet carnet = new Carnet();
            carnet.Show();
        }

        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            MySqlConnection? cadena = new MySqlConnection();
            try
            {
                string query;
                cadena = Conexion.getInstancia().CrearConexion();
                query = "SELECT s.IdSocio, s.Nombre, s.Apellido, SUM(c.Monto) AS TotalCuota " +
                        "FROM Socios s INNER JOIN Inscripcion i ON s.IdSocio = i.IdSocio " +
                        "WHERE c.Estado = 'Pendiente' AND c.FechaVencimiento < CURDATE() " +
                        "ORDER BY c.FechaVencimiento ASC;";

                MySqlCommand comando = new MySqlCommand(query, cadena);
                comando.CommandType = CommandType.Text;
                cadena.Open();
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    doc.numero_f = Convert.ToInt32(reader.GetString(0));
                    doc.curso_f = reader.GetString(1);
                    doc.alumno_f = reader.GetString(2);
                    doc.monto_f = (float)Convert.ToDouble(reader.GetString(3));
                    doc.fecha_f = (DateTime)Convert.ToDateTime(reader.GetString(4));


                    if (opt.Efvo.Checked == true)
                    {
                        doc.forma_f = "Efectivo";
                        doc.monto_f = (float)(doc.monto_f * 0.90);
                    }

                    else
                    {
                        doc.forma_f = "Tarjeta";
                    }

                    btn_Carnet.Enabled = true;

                }
                else
                {

                    MessageBox.Show("Número de socio inexistente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (cadena.State == ConnectionState.Open)
                { cadena.Close(); }
            }
        }

    }
}
}