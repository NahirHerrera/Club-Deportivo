using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Club_Deportivo.Datos;

namespace Club_Deportivo;

public partial class Comprobante : Form
{
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
}
