
using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Club_Deportivo.Entidades
{
    internal class E_Inscripcion
    {
        public int IdInscripcion { get; set; }

        public DateTime Fecha { get; set; }

        public int IdSocio { get; set; }

        public int IdActividad { get; set; }

        public string Estado { get; set; }
    }
}
