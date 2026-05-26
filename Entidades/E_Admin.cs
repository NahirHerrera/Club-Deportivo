using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    internal class E_Admin
    {
        public int IdUsuario { get; set; }

        public string Usuario { get; set; }

        public string Password { get; set; }

        public string ObtenerRol()
        {
            return "ADMIN";
        }
    }
}
