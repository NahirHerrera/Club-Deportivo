using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    internal abstract class E_Cliente
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string TipoDoc { get; set; }

        public string Documento { get; set; }

        public abstract string ObtenerTipoCliente();
    }
}
