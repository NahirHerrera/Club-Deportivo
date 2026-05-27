using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_Clientes
    {
        public int idClientes {  get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? tipoDoc {  get; set; }
        public string? dni { get; set; } 
        public bool aptoFisico { get; set; }
    }
}
