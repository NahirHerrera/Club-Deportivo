using Club_Deportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Club_Deportivo;

public partial class Comprobante : Form
{
    // Método para exportar el formulario a PDF utilizando la impresora "Microsoft Print to PDF"
    private void ExportarFormularioAPdf()
    {
        PrintDocument pd = new PrintDocument();
        pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
        pd.PrintPage += LineasImpresion;
        PrintDialog pdDialog = new PrintDialog();
        pdDialog.Document = pd;

        if (pdDialog.ShowDialog() == DialogResult.OK)
        {
            pd.Print();
        }
    }

    // Método para dibujar el formulario en la página de impresión
    private void LineasImpresion(object sender, PrintPageEventArgs e)
    {
        Bitmap bmp = new Bitmap(this.Width, this.Height);
        this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
        e.Graphics.DrawImage(bmp, 0, 0);
    }

    //  Constructor que recibe un objeto DatosComprobante para mostrar la información en el formulario
    public Comprobante(DatosComprobante doc)
    {
        InitializeComponent();

        lbl_NSocio.Text = doc.NSocio.ToString();
        lbl_Nombre.Text = doc.nombre;
        lbl_Apellido.Text = doc.apellido;
        lbl_Monto.Text = doc.monto.ToString();
        lbl_FormaPago.Text = doc.forma_pago;
        lbl_Periodo.Text = doc.periodo.ToString();
    }

    private void btnImprimir_Click(object sender, EventArgs e)
    {
        btnImprimir.Visible = false;
        this.Refresh();
        ExportarFormularioAPdf();
        btnImprimir.Visible = true;
    }
}
