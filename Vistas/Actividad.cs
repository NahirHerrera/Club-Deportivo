using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Club_Deportivo.Datos;

namespace Club_Deportivo.Vistas
{
    public partial class Actividad : Form
    {
        private int idClienteActual;
        private bool esSocioActual;
        public Actividad()
        {
            InitializeComponent();
        }

        private void Actividad_Load(object sender, EventArgs e)
        {
            dgvActividades.Visible = false;
            btn_Inscribir.Enabled = false;
        }

        private void CargarActividades()
        {
            MySqlConnection cadena = null;

            try
            {
                cadena = Conexion.getInstancia().CrearConexion();
                string query = "SELECT idActividades, nombreActividad, costo_pase_diario FROM actividades";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, cadena);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                dgvActividades.DataSource = tabla;

                if (!dgvActividades.Columns.Contains("Seleccionar"))
                {
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

                    chk.Name = "Seleccionar";
                    chk.HeaderText = "Seleccionar";

                    dgvActividades.Columns.Insert(0, chk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cadena != null && cadena.State == ConnectionState.Open)
                {
                    cadena.Close();
                }
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            MySqlConnection cadena = null;

            try
            {
                cadena = Conexion.getInstancia().CrearConexion();
                string query = @"SELECT idClientes, nombre, apellido FROM clientes WHERE dni = @dni";
                MySqlCommand comando = new MySqlCommand(query, cadena);
                comando.Parameters.AddWithValue("@dni", txt_DNI.Text);
                cadena.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    int idCliente = Convert.ToInt32(reader["idClientes"]);
                    idClienteActual = idCliente;

                    MessageBox.Show("Cliente encontrado: " +
                        reader["nombre"].ToString() + " " +
                        reader["apellido"].ToString());

                    reader.Close();

                    string querySocio = @"SELECT * FROM socios WHERE idClientes = @idCliente";

                    MySqlCommand cmdSocio = new MySqlCommand(querySocio, cadena);

                    cmdSocio.Parameters.AddWithValue("@idCliente", idCliente);

                    MySqlDataReader readerSocio = cmdSocio.ExecuteReader();

                    if (readerSocio.Read())
                    {
                        esSocioActual = true;
                        MessageBox.Show("ES SOCIO");
                    }
                    else
                    {
                        esSocioActual = false;
                        MessageBox.Show("ES NO SOCIO");
                    }

                    readerSocio.Close();

                    if (esSocioActual)
                    {
                        string queryCuota = @"SELECT Estado FROM cuota WHERE idClientes = @idCliente ORDER BY idCuota DESC LIMIT 1";

                        MySqlCommand cmdCuota = new MySqlCommand(queryCuota, cadena);

                        cmdCuota.Parameters.AddWithValue("@idCliente", idClienteActual);

                        object estado = cmdCuota.ExecuteScalar();

                        if (estado != null && estado.ToString() == "Pagado")
                        {
                            MessageBox.Show("Socio con cuota al día");

                            dgvActividades.Visible = true;
                            btn_Inscribir.Enabled = true;

                            CargarActividades();
                        }
                        else
                        {
                            MessageBox.Show("El socio posee cuotas pendientes");

                            dgvActividades.Visible = false;
                            btn_Inscribir.Enabled = false;
                        }
                    }
                    else
                    {
                        dgvActividades.Visible = true;
                        btn_Inscribir.Enabled = true;

                        CargarActividades();
                    }

                    //dgvActividades.Visible = true;
                    //btn_Inscribir.Enabled = true;

                    //CargarActividades();
                }
                else
                {
                    MessageBox.Show("DNI inexistente");

                    dgvActividades.Visible = false;
                    btn_Inscribir.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cadena != null && cadena.State == ConnectionState.Open)
                {
                    cadena.Close();
                }
            }
        }

        private void btn_Inscribir_Click(object sender, EventArgs e)
        {
            MySqlConnection cadena = null;

            try
            {
                cadena = Conexion.getInstancia().CrearConexion();
                cadena.Open();
                foreach (DataGridViewRow fila in dgvActividades.Rows)
                {
                    if (fila.Cells["Seleccionar"].Value != null && Convert.ToBoolean(fila.Cells["Seleccionar"].Value))
                    {
                        int idActividad = Convert.ToInt32(fila.Cells["idActividades"].Value);

                        string query = @"INSERT INTO socio_actividad (idCliente, idActividad, fechaInscripcion)
                                        VALUES (@idCliente, @idActividad, NOW())";

                        MySqlCommand comando = new MySqlCommand(query, cadena);
                        comando.Parameters.AddWithValue("@idCliente", idClienteActual);
                        comando.Parameters.AddWithValue("@idActividad", idActividad);
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Inscripción realizada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cadena != null && cadena.State == ConnectionState.Open)
                {
                    cadena.Close();
                }
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void dgvActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
