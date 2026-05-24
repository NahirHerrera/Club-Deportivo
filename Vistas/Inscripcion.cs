using Club_Deportivo.Datos;
using Club_Deportivo.Entidades;
using System;
using System.Windows.Forms;

namespace Club_Deportivo.Vistas
{
    public partial class chkAptoFisico : Form
    {
        public chkAptoFisico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //VALIDACION DE CAMPOS REQUERIDOS
            if (nombreInput.Text == "" || apellidoInput.Text == "" ||
                documentoInput.Text == "" || tipoBox.Text == "")
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

                // Crear un nuevo objeto E_Socio y asignar los valores de los campos de entrada
                string respuesta;
                E_Socio socio = new E_Socio();
                socio.Nombre = nombreInput.Text;
                socio.Apellido = apellidoInput.Text;
                socio.Documento = documentoInput.Text;
                socio.TipoDoc = tipoBox.Text;

                // Llamar al método Nuevo_Socio de la clase Socios para guardar el nuevo socio en la base de datos

                Datos.Socios socios = new Datos.Socios();
                respuesta = socios.Nuevo_Socio(socio);

                // Validar la respuesta del método Nuevo_Socio para mostrar el mensaje correspondiente al usuario

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {

                    // Si el código es 1, significa que el socio ya existe en la base de datos
                    if (codigo == 1)
                    {
                        MessageBox.Show("SOCIO YA EXISTE",
                                        "AVISO DEL SISTEMA",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    else
                    {

                        // Si el código es diferente de 1, significa que el socio se almacenó con éxito en la base de datos
                        MessageBox.Show("Se almacenó con éxito el socio con el código Nro " + respuesta,
                                        "AVISO DEL SISTEMA",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        // Abrir la ventana Home y cerrar la ventana Inscripcion
                        Home home = new Home(nombreInput.Text);
                        home.Show();
                        this.Hide();
                    }
                }
            }
        }


        private void documentoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellidoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipoBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nombreInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home(nombreInput.Text);
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nombreInput.Text = "";
            apellidoInput.Text = "";
            documentoInput.Text = "";
            tipoBox.Text = "";
            nombreInput.Focus();
        }
    }
}
