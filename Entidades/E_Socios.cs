using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_Socios : E_Clientes
    {
        public int nroCarnet {  get; set; }
        public DateTime fecha_vencimiento_cuota {  get; set; } 
    }
}
