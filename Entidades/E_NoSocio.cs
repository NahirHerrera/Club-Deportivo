using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    internal class E_NoSocio : E_Persona
    {
        public DateTime FechaVisita { get; set; }
        public decimal CostoActividad { get; set; }

        // Asociación
        public E_Actividad Actividad { get; set; }

        public override string ObtenerTipoPersona()
        {
            return "No Socio";
        }
    }
}
