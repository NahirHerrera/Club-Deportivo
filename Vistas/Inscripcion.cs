using Club_Deportivo.Datos;
using Club_Deportivo.Entidades;
using System;
using System.Windows.Forms;

namespace Club_Deportivo.Vistas
{
    public partial class Inscripcion : Form
    {
        public Inscripcion()
        {
            InitializeComponent();
        }
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Home home = new Home(nombreInput.Text);
            home.Show();
            this.Hide();
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            nombreInput.Text = "";
            apellidoInput.Text = "";
            documentoInput.Text = "";
            cmbTipoDoc.Text = "";
            cmbTipoCliente.Text = "";
            nombreInput.Focus();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            //VALIDACION DE CAMPOS REQUERIDOS
            if (string.IsNullOrWhiteSpace(nombreInput.Text) ||
                string.IsNullOrWhiteSpace(apellidoInput.Text) ||
                string.IsNullOrWhiteSpace(documentoInput.Text) ||
                cmbTipoDoc.SelectedIndex == -1 ||
                cmbTipoCliente.SelectedIndex == -1)
            {

                // Mostrar mensaje de error si algún campo requerido está vacío
                MessageBox.Show("Debe completar los datos requeridos (*)",
                                "AVISO DEL SISTEMA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            //Validar que presente apto físico antes del registro
            else if (!chkAF.Checked)
            {
                MessageBox.Show("No se puede acceder al registro. El apto físico es un requisito excluyente.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                // Crear un nuevo objeto E_Cliente y asignar los valores de los campos de entrada
                string respuesta;

                E_Clientes cliente = new E_Clientes();
                cliente.nombre = nombreInput.Text.Trim();
                cliente.apellido = apellidoInput.Text.Trim();
                cliente.tipoDoc = cmbTipoDoc.Text.Trim();
                cliente.dni = documentoInput.Text.Trim();

                bool esSocio = (cmbTipoCliente.Text == "Socios");

                // Llamar al método Nuevo_Socio de la clase Socios para guardar el nuevo socio en la base de datos

                Datos.Clientes objetoDatos = new Datos.Clientes();
                respuesta = objetoDatos.RegistrarCliente(
                    cliente.nombre,
                    cliente.apellido,
                    cliente.tipoDoc,
                    cliente.dni,
                    chkAF.Checked,
                    esSocio,
                    1
                );

                // Validar la respuesta del método Nuevo_Socio para mostrar el mensaje correspondiente al usuario
                if (int.TryParse(respuesta, out int codigo))
                {
                    // Si el código es 1, significa que el cliente ya existe en la base de datos
                    if (codigo == 1)
                    {
                        MessageBox.Show("¡Este cliente ya se encuentra registrado!",
                                        "AVISO DEL SISTEMA",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    else
                    {

                        // Si el código es diferente de 1, significa que el socio se almacenó con éxito en la base de datos
                        string tipo = esSocio ? "Socio" : "No Socio";
                        MessageBox.Show($"Se almacenó con éxito el {tipo} con el código Nro " + respuesta,
                                        "AVISO DEL SISTEMA",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        // Abrir la ventana Home y cerrar la ventana Inscripcion
                        Home home = new Home(nombreInput.Text);
                        home.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
