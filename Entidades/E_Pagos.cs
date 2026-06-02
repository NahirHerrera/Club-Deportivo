using Club_Deportivo.Vistas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_Pagos
    {
        //// Identificador único del pago
        public int idPagos { get; set; }

        // Relaciona el pago con una cuota
        public int idCuota { get; set; }

        // Relaciona el pago con un cliente
        public int idClientes { get; set; }

        // Atributos del pago
        public decimal monto { get; set; }
        public DateTime? fechaPago { get; set; }
        public int nroComprobante { get; set; }
        public decimal formaPago { get; set; }
    }
}
