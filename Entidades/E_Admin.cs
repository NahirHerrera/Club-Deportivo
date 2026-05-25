using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    internal class E_Admin : E_Usuario
    {
        public override string ObtenerRol()
        {
            return "ADMIN";
        }
    }
}
