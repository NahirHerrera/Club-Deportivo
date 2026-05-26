using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    internal class E_NoSocio : E_Cliente
    {
        public DateTime FechaVisita { get; set; }
        public string Actividad { get; set; }
        public decimal CostoActividad { get; set; }
        public override string ObtenerTipoCliente()
        {
            return "NO_SOCIO";
        }
    }
}
