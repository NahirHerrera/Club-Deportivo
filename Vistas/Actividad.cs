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
    // Formulario encargado de gestionar la inscripción de clientes
    // a las actividades disponibles del club.
    public partial class Actividad : Form
    {
        // Almacena al cliente encontrado, mediante busqueda por DNI
        private int idClienteActual;

        // Indica si el cliente encontrado es socio o no, para determinar
        private bool esSocioActual;

        public Actividad()
        {
            InitializeComponent();
        }

        // Al iniciar el formulario se ocultan las actividades
        // y se deshabilita la inscripción hasta validar un cliente.
        private void Actividad_Load(object sender, EventArgs e)
        {
            dgvActividades.Visible = false;
            btn_Inscribir.Enabled = false;
        }

        // Obtiene las actividades registradas en la base de datos
        // y las carga en el DataGridView.
        private void CargarActividades()
        {
            MySqlConnection cadena = null;

            try
            {
                cadena = Conexion.getInstancia().CrearConexion();

                // Consulta las actividades disponibles, mostrando su ID, nombre y costo diario.
                string query = "SELECT idActividades, nombreActividad, costo_pase_diario FROM actividades";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, cadena);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                dgvActividades.DataSource = tabla;

                // Agrega una columna de selección si no existe, para permitir marcar las actividades a inscribir.
                if (!dgvActividades.Columns.Contains("Seleccionar"))
                {
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

                    chk.Name = "Seleccionar";
                    chk.HeaderText = "Seleccionar";

                    dgvActividades.Columns.Insert(0, chk);
                }
            }

            // Maneja cualquier error que pueda ocurrir durante la conexión o consulta a la base de datos.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Asegura que la conexión se cierre correctamente después de la operación, evitando posibles fugas de recursos.
            finally
            {
                if (cadena != null && cadena.State == ConnectionState.Open)
                {
                    cadena.Close();
                }
            }
        }

        // Busca un cliente por DNI y valida si puede inscribirse a actividades según su condición.
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            MySqlConnection cadena = null;

            try
            {
                cadena = Conexion.getInstancia().CrearConexion();

                // Consulta para encontrar al cliente por su DNI, obteniendo su ID, nombre y apellido.
                string query = @"SELECT idClientes, nombre, apellido FROM clientes WHERE dni = @dni";
                MySqlCommand comando = new MySqlCommand(query, cadena);
                comando.Parameters.AddWithValue("@dni", txt_DNI.Text);
                cadena.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    // Si se encuentra el cliente, se almacena su ID para futuras consultas y se muestra un mensaje con su nombre completo.
                    int idCliente = Convert.ToInt32(reader["idClientes"]);
                    idClienteActual = idCliente;

                    MessageBox.Show("Cliente encontrado: " +
                        reader["nombre"].ToString() + " " +
                        reader["apellido"].ToString());

                    reader.Close();

                    // Consulta para verificar si el cliente es socio, buscando su ID en la tabla de socios.
                    string querySocio = @"SELECT * FROM socios WHERE idClientes = @idCliente";
                    MySqlCommand cmdSocio = new MySqlCommand(querySocio, cadena);
                    cmdSocio.Parameters.AddWithValue("@idCliente", idCliente);
                    MySqlDataReader readerSocio = cmdSocio.ExecuteReader();

                    // Si el cliente es socio, se verifica el estado de su última cuota para determinar si puede inscribirse a actividades.
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

                    // Si el cliente es socio, se verifica el estado de su última cuota para determinar si puede inscribirse a actividades.
                    if (esSocioActual)
                    {
                        // Consulta para obtener el estado de la última cuota del cliente, ordenando por fecha para obtener la más reciente.
                        string queryCuota = @"SELECT Estado FROM cuota WHERE idClientes = @idCliente ORDER BY idCuota DESC LIMIT 1";
                        MySqlCommand cmdCuota = new MySqlCommand(queryCuota, cadena);
                        cmdCuota.Parameters.AddWithValue("@idCliente", idClienteActual);
                        object estado = cmdCuota.ExecuteScalar();

                        // Si el estado de la última cuota es "Pagado", se permite al socio inscribirse a actividades.
                        // De lo contrario, se muestra un mensaje indicando que tiene cuotas pendientes.
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

                    // Si el cliente no es socio, se permite inscribirse a actividades sin necesidad de validar cuotas,
                    // mostrando las actividades disponibles.
                    else
                    {
                        dgvActividades.Visible = true;
                        btn_Inscribir.Enabled = true;

                        CargarActividades();
                    }


                }

                // Si no se encuentra el cliente, se muestra un mensaje
                // indicando que el DNI es inexistente y se ocultan las actividades y se deshabilita la inscripción.
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

        // Inscribe al cliente a las actividades seleccionadas, insertando registros en la tabla de socio_actividad.
        private void btn_Inscribir_Click(object sender, EventArgs e)
        {
            MySqlConnection cadena = null;

            // Recorre las filas del DataGridView para identificar las actividades seleccionadas por el cliente.
            try
            {
                cadena = Conexion.getInstancia().CrearConexion();
                cadena.Open();
                foreach (DataGridViewRow fila in dgvActividades.Rows)
                {

                    // Verifica si la fila tiene la columna "Seleccionar" marcada, indicando que el cliente desea inscribirse a esa actividad.
                    if (fila.Cells["Seleccionar"].Value != null && Convert.ToBoolean(fila.Cells["Seleccionar"].Value))
                    {
                        int idActividad = Convert.ToInt32(fila.Cells["idActividades"].Value);

                        // Inserta un nuevo registro en la tabla socio_actividad para asociar al cliente
                        // con la actividad seleccionada, utilizando la fecha actual para la inscripción.
                        string query = @"INSERT INTO socio_actividad (idCliente, idActividad, fechaInscripcion)
                                        VALUES (@idCliente, @idActividad, NOW())";

                        // Se utiliza un comando parametrizado para evitar inyecciones SQL y asegurar la integridad de los datos.
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
