using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Club_Deportivo.Vistas
{
    public partial class Carnet : Form
    {
        private string _nombreSocio;
        private string _numeroSocio;
        public Carnet()
        {
            InitializeComponent();
        }
        //Aporta los datos del socio al carnet
        public Carnet(string nombreCompleto, string numeroSocio)
        {
            InitializeComponent();
            _nombreSocio = nombreCompleto;
            _numeroSocio = numeroSocio;
        }
        private void Carnet_Load (object sender, EventArgs e)
        {
            label3.Text = "";
            label2.Text = "";
            label3.Text = _nombreSocio;
            label2.Text = _numeroSocio;
        }
    }
}
