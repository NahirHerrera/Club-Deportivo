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

        // ***************************************************************************************************
        // ********************* METODOS AUXILIARES DEL FORMULARIO ACTIVIDAD *********************************
        // ***************************************************************************************************

        // Metodo que Oculta los controles relacionados con las actividades y la inscripción, mostrando solo el campo de búsqueda por DNI.
        private void OcultarControles()
        {
            dgvActividades.Visible = false;

            btn_Inscribir.Visible = false;
            btn_PagarInscribir.Visible = false;
            btn_Inscripcion.Visible = false;

            groupBox1.Visible = false;
        }

        // Método que obtiene la forma de pago seleccionada por el usuario, verificando cuál de las opciones de pago está marcada.
        private string ObtenerFormaPago()
        {
            if (rd_Efectivo.Checked)
                return "Efectivo";

            if (rd_Tarjeta.Checked)
                return "Tarjeta";

            if (rd_Transferencia.Checked)
                return "Transferencia";

            return "";
        }

        // Método que registra la inscripción del cliente a las actividades seleccionadas,
        // insertando un registro en la tabla de inscripciones para cada actividad marcada.
        private bool RegistrarInscripcion(string formaPago, bool socio)
        {
            MySqlConnection cadena = null; 
            bool seInserto = false;

            try
            {
                cadena = Conexion.getInstancia().CrearConexion();
                cadena.Open();

                // Recorre cada fila del DataGridView de actividades para verificar cuáles han sido seleccionadas por el usuario.
                foreach (DataGridViewRow fila in dgvActividades.Rows)
                {
                    if (fila.Cells["Seleccionar"].Value != null && Convert.ToBoolean(fila.Cells["Seleccionar"].Value))
                    {
                        int idActividad = Convert.ToInt32(fila.Cells["idActividades"].Value);
                        decimal monto = socio ? 0: Convert.ToDecimal(fila.Cells["costo_pase_diario"].Value);

                        // Consulta de inserción para registrar la inscripción del cliente a la actividad seleccionada,
                        // incluyendo la forma de pago y el monto correspondiente.
                        string query = @"INSERT INTO inscripcion_actividad(idCliente, idActividad, formaPago, monto, fechaInscripcion)
                                        VALUES (@idCliente, @idActividad, @formaPago, @monto, NOW())";

                        MySqlCommand comando = new MySqlCommand(query, cadena);

                        comando.Parameters.AddWithValue("@idCliente", idClienteActual);
                        comando.Parameters.AddWithValue("@idActividad", idActividad);
                        comando.Parameters.AddWithValue("@formaPago", formaPago);
                        comando.Parameters.AddWithValue("@monto", monto);

                        // Se intenta ejecutar la inserción, y se maneja la excepción específica de clave duplicada (1062)
                        try
                        {
                            comando.ExecuteNonQuery();
                            seInserto = true;
                        }
                        catch (MySqlException ex)
                        {
                            if (ex.Number == 1062)
                            {
                                MessageBox.Show("El cliente ya está inscripto en esta actividad");
                            }
                            else
                            {
                                throw;
                            }
                        }
                    }
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

            return seInserto;
        }

        // ***************************************************************************************************
        // **************************** FIN DEL BLOQUE DE METODOS ********************************************
        // ***************************************************************************************************




        // Al iniciar el formulario se ocultan las actividades
        // y se deshabilita la inscripción hasta validar un cliente.
        private void Actividad_Load(object sender, EventArgs e)
        {
            OcultarControles();
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


                // Agrega una columna de selección de CHECK si no existe, para permitir marcar las actividades a inscribir.
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
                            btn_Inscribir.Enabled = true;
                            dgvActividades.Visible = true;
                            btn_Inscribir.Visible = true;
                            btn_PagarInscribir.Visible = false;
                            groupBox1.Visible = false;
                            btn_Inscripcion.Visible = false;

                            CargarActividades();
                        }
                        else
                        {
                            MessageBox.Show("El socio posee cuotas pendientes");

                            OcultarControles();
                            btn_Inscribir.Enabled = false;
                        }
                    }

                    // Si el cliente no es socio, se permite inscribirse a actividades sin necesidad de validar cuotas,
                    // mostrando las actividades disponibles.
                    else
                    {
                        OcultarControles();

                        dgvActividades.Visible = true;
                        btn_PagarInscribir.Visible = true;

                        CargarActividades();
                    }


                }

                // Si no se encuentra el cliente, se muestra un mensaje
                // indicando que el DNI es inexistente y se ocultan las actividades y se deshabilita la inscripción.
                else
                {
                    MessageBox.Show("DNI inexistente");
                    OcultarControles();
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

        // Registra la inscripción del socio a las actividades seleccionadas,
        // sin necesidad de procesar un pago, ya que los socios no pagan por las actividades.
        private void btn_Inscribir_Click(object sender, EventArgs e)
        {
            bool resultado = RegistrarInscripcion("Socio", true);

            if (resultado)
            {
                MessageBox.Show("Inscripción realizada correctamente");
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

        // Calcula el total a pagar por las actividades seleccionadas, sumando el costo diario de cada una para los NO SOCIOS
        private decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvActividades.Rows)
            {
                if (fila.Cells["Seleccionar"].Value != null && Convert.ToBoolean(fila.Cells["Seleccionar"].Value))
                {
                    total += Convert.ToDecimal(fila.Cells["costo_pase_diario"].Value);
                }
            }

            return total;
        }

        // Muestra el total a pagar por las actividades seleccionadas y
        // habilita el grupo de opciones de pago para que el cliente pueda elegir su forma de pago.
        private void btn_PagarInscribir_Click(object sender, EventArgs e)
        {
            decimal total = CalcularTotal();

            if (total == 0)
            {
                MessageBox.Show( "Debe seleccionar al menos una actividad");
                return;
            }

            lbl_Total.Text = "TOTAL A PAGAR: $" + total;
            groupBox1.Visible = true;
            btn_Inscripcion.Visible = true;
        }

        // Registra la inscripción del cliente a las actividades seleccionadas,
        // insertando registros en la tabla de inscripciones con la forma de pago y el monto correspondiente para los NO SOCIOS.
        private void btn_Inscripcion_Click(object sender, EventArgs e)
        {

            // Verifica que el cliente haya seleccionado una forma de pago antes de registrar la inscripción.
            if (!rd_Efectivo.Checked &&
                !rd_Tarjeta.Checked &&
                !rd_Transferencia.Checked)
            {
                MessageBox.Show("Seleccione una forma de pago");
                return;
            }

            string formaPago = ObtenerFormaPago();
            bool resultado = RegistrarInscripcion(formaPago, false);

            if (resultado)
            {
                MessageBox.Show("Pago e inscripción realizados correctamente");
            }
        }
    }
}