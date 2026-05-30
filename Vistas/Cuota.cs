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
            // VALIDACION DE LA FORMA DE PAGO

            if (!rbEfectivo.Checked &&
                !rbTarjeta3.Checked &&
                !rbTarjeta6.Checked)
            {
                MessageBox.Show(
                    "Seleccione una forma de pago",
                    "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MySqlConnection? cadena = new MySqlConnection();
            try
            {
                string query;
                cadena = Conexion.getInstancia().CrearConexion();
                query = @"SELECT c.idClientes, c.nombre, c.apellido, q.idCuota, q.Monto, q.fechaVencimiento
                        FROM clientes c
                        INNER JOIN cuota q ON c.idClientes = q.idClientes
                        WHERE c.dni = @Documento
                        AND q.Estado = 'Pendiente'";

                MySqlCommand comando = new MySqlCommand(query, cadena);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@Documento", txt_DNI.Text);
                cadena.Open();
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    int idCliente = reader.GetInt32("idClientes");
                    string nombre = reader.GetString("nombre");
                    string apellido = reader.GetString("apellido");

                    int idCuota = reader.GetInt32("idCuota");

                    float monto =
                        Convert.ToSingle(reader.GetDecimal("Monto"));

                    DateTime periodo =
                        reader.GetDateTime("fechaVencimiento");

                    reader.Close();

                    // UPDATE CUOTA

                    string update = @"UPDATE cuota SET Estado='Pagado' WHERE idCuota=@idCuota";
                    MySqlCommand cmdUpdate = new MySqlCommand(update, cadena);
                    cmdUpdate.Parameters.AddWithValue("@idCuota",idCuota);
                    cmdUpdate.ExecuteNonQuery();

                    // UPDATE PAGO
                    Random rnd = new Random();
                    int nroComprobante = rnd.Next(100000, 999999);

                    string insertPago = @"INSERT INTO pagos(idCuota, idClientes, Monto, fechaPago, nroComprobante)
                                        VALUES(@idCuota, @idCliente, @Monto, NOW(), @Comprobante)";

                    MySqlCommand cmdPago = new MySqlCommand(insertPago, cadena);
                    cmdPago.Parameters.AddWithValue("@idCuota", idCuota);
                    cmdPago.Parameters.AddWithValue("@idCliente", idCliente);
                    cmdPago.Parameters.AddWithValue("@Monto", monto);
                    cmdPago.Parameters.AddWithValue("@Comprobante", nroComprobante);
                    cmdPago.ExecuteNonQuery();

                    // DATOS COMPROBANTE

                    doc = new DatosComprobante();
                    doc.NSocio = idCliente;
                    doc.nombre = nombre;
                    doc.apellido = apellido;
                    doc.monto = monto;
                    doc.periodo = periodo;

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
                    MessageBox.Show("No se encontraron cuotas pendientes para ese DNI", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cadena != null && cadena.State == ConnectionState.Open)
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