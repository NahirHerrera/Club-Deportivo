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
using Club_Deportivo.Vistas;

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
                query = "SELECT s.IdSocio, s.Nombre, s.Apellido, SUM(c.Monto) AS TotalCuota, MAX(c.FechaPago) AS FechaPago " +
                        "FROM club_deportivo.socios s " +
                        "INNER JOIN club_deportivo.cuota c ON s.IdSocio = c.IdSocio " +
                        "WHERE s.Documento = @Documento " +
                        "GROUP BY s.IdSocio, s.Nombre, s.Apellido ";

                MySqlCommand comando = new MySqlCommand(query, cadena);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@Documento", txt_DNI.Text);
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
                        doc.forma_pago = "Efectivo: 10% off";
                        doc.monto = (float)(doc.monto * 0.90);
                        MessageBox.Show ("¡El pago se realizó con éxito!" + Environment.NewLine +
                        $"Forma de pago: {doc.forma_pago}" + Environment.NewLine +
                        $"Total cobrado: ${doc.monto}", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (rbTarjeta3.Checked)
                    {
                        doc.forma_pago = "Tarj.Crédito: 3 cuotas s/interés)";
                        float valorCuota = doc.monto / 3;
                        MessageBox.Show("¡El pago se realizó con éxito!" + Environment.NewLine +
                        $"Forma de pago: {doc.forma_pago}" + Environment.NewLine +
                        $"Total cobrado: ${doc.monto} (3 cuotas de: ${doc.monto / 3})", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (rbTarjeta6.Checked)
                    {
                        doc.forma_pago = "Tarj.Crédito: 6 cuotas s/interés)";
                        float valorCuota = doc.monto / 6;
                        MessageBox.Show("¡El pago se realizó con éxito!" + Environment.NewLine +
                        $"Forma de pago: {doc.forma_pago}" + Environment.NewLine +
                        $"Total cobrado: ${doc.monto} (6 cuotas de: ${doc.monto / 6})", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

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