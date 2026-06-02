using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_Carnet
    {
        //Identificador único del carnet
        public int idCarnet { get; set; }

        // Atributos del carnet
        public int nroCarnet { get; set; }
        public DateTime? fechaEmision { get; set; }

        // Relaciona el carnet con un cliente
        public int idClientes { get; set; }
    }
}
