using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    internal class E_Actividad
    {
        public int IdActividad { get; set; }
        public string Nombre { get; set; }
        public TimeSpan Horario { get; set; }
    }
}