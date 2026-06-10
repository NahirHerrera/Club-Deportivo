using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_Actividades
    {
        // Identificador único de la actividad
        public int idActividades { get; set; }

        // Atributos de la actividad
        public string? nombreActividad { get; set; }
        public double costoPaseDiario { get; set; }
    }
}
   
