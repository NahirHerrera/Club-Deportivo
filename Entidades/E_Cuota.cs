using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_Cuota
    {
        // Identificador único de la cuota
        public int idCuota { get; set; }

        // Relaciona la cuota con un cliente
        public int idClientes { get; set; }

        // Atributos de la cuota
        public decimal monto { get; set; }
        public DateTime? fechaVencimiento { get; set; }

        // Indica estado de la cuota
        public string? estado { get; set; }
    }
}
