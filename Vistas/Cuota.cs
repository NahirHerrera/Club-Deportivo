using Club_Deportivo;
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
    public partial class Cuota : Form
    {
        public DatosComprobante doc;
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
        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            MySqlConnection? cadena = new MySqlConnection();
            try
            {
                string query;
                cadena = Conexion.getInstancia().CrearConexion();
                query = "SELECT s.IdSocio, s.Nombre, s.Apellido, SUM(c.Monto) AS TotalCuota " +
                        "FROM Socios s " +
                        "INNER JOIN Inscripcion i ON s.IdSocio = i.IdSocio " +
                        "INNER JOIN Actividad a ON i.IdActividad = a.IdActividad " +
                        "INNER JOIN Cuota c ON a.IdCuota = c.IdCuota " +
                        "WHERE s.IdSocio = s.IdSocioBuscado " +
                        "ORDER BY s.IdSocio, s.Nombre, s.Apellido ";

                MySqlCommand comando = new MySqlCommand(query, cadena);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@Documento", "32456741");
                cadena.Open();
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    doc = new DatosComprobante();

                    doc.NSocio = reader.GetInt32(0);
                    doc.nombre = reader.GetString(1);
                    doc.apellido = reader.GetString(2);
                    doc.monto = (float)reader.GetDecimal(3);
                    doc.periodo = reader.GetDateTime(4);

                    if (rbEfectivo.Checked)
                    {
                        doc.forma_pago = "Efectivo";
                        doc.monto = (float)(doc.monto * 0.90);
                    }
                    else
                    {
                        doc.forma_pago = "Tarjeta de crédito";
                    }

                    MessageBox.Show("¡El pago se realizo con éxito!", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Carnet.Enabled = true;
                    Comprobante ventanacomprobante = new Comprobante(doc);
                    ventanacomprobante.Show();
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
                {
                    cadena.Close();
                }
            }
        }

        private void Cuota_Load(object sender, EventArgs e)
        {
            btn_Carnet.Enabled = false;
        }
    }
}