using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_InscripcionActividad
    {
        // Identificador único de la inscripcion
        public int idInscripcion { get; set; }

        // Relaciona la inscripcion en la actividad con un cliente
        public int idCliente { get; set; }

        // Relaciona la inscripcion en la actividad con una actividad
        public int idActividad { get; set; }

        // Atributos de la inscripcion en la actividad
        public string? formaPago { get; set; }
        public decimal monto { get; set; }
        public DateTime fechaInscripcion { get; set; }

    }
}
