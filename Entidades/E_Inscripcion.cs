using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_Inscripcion
    {
        // Identificador único de la inscripcion
        public int idInscripcion { get; set; }

        // Relaciona la inscripcion con un cliente
        public int idClientes { get; set; }

        // Atributo de la inscripcion
        public DateTime? fecha { get; set; }
    }
}