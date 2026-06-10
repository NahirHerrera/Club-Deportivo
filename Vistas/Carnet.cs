using Club_Deportivo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace Club_Deportivo.Vistas
{
    public partial class Carnet : Form
    {
        // Variables para almacenar los datos del socio en el carnet
        private string _nombreSocio;
        private string _numeroSocio;

        // Constructor del form carnet. Recibe nombre y numero del socio
        public Carnet(string nombreCompleto, string numeroSocio)
        {
            InitializeComponent();

            _nombreSocio = nombreCompleto;
            _numeroSocio = numeroSocio;

            // Asigna los datos de los labels de la interfaz gráfica
            label3.Text = _nombreSocio;
            label2.Text = _numeroSocio;
        }
        // Método que configura las propiedades de impresión para generar el PDF
        private void ExportarFormularioAPdf()
        {
            PrintDocument pd = new PrintDocument();

            pd.PrinterSettings.PrinterName =
                "Microsoft Print to PDF";

            pd.PrintPage += LineasImpresion;

            PrintDialog pdDialog = new PrintDialog();

            pdDialog.Document = pd;

            if (pdDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
        // Método que se dispara al hacer Click, para imprimir o exportar el carnet
        private void btnImprimirCarnet_Click(object sender, EventArgs e)
        {
            btnImprimirCarnet.Visible = false;

            this.Refresh();

            ExportarFormularioAPdf();

            btnImprimirCarnet.Visible = true;
        }
        // Método que se ejecuta cuando el objeto PrintDocument solicita los gráficos para la página
        private void LineasImpresion(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Capturar el fondo (imagen del carnet)

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            g.DrawImage(bmp, 0, 0);

            // Mostrar los datos del socio en los labels
            Font fuente = new Font("Arial", 8, FontStyle.Regular);
            Brush pincel = Brushes.Black;

            // Coordenadas para los labels en el formulario
            g.DrawString(_nombreSocio, fuente, pincel, new PointF(300, 263));
            g.DrawString(_numeroSocio.ToString(), fuente, pincel, new RectangleF(335, 305, 200, 20));
        }
    }
}