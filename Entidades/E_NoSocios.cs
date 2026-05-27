using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_NoSocios : E_Clientes
    {
        public int idActividades {  get; set; }
        public DateTime fechaActividad { get; set; }

    }
}
