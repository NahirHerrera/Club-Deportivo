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
        private string _nombreSocio;
        private string _numeroSocio;

        public Carnet(string nombreCompleto, string numeroSocio)
        {
            InitializeComponent();

            _nombreSocio = nombreCompleto;
            _numeroSocio = numeroSocio;

            label3.Text = _nombreSocio;
            label2.Text = _numeroSocio;
        }

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

        private void LineasImpresion(object sender, PrintPageEventArgs e)
        {
            this.Refresh();
            Application.DoEvents();

            Bitmap bmp = new Bitmap(this.Width, this.Height);

            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnImprimirCarnet_Click(object sender, EventArgs e)
        {
            btnImprimirCarnet.Visible = false;

            this.Refresh();

            ExportarFormularioAPdf();

            btnImprimirCarnet.Visible = true;
        }
    }
}