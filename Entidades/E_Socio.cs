using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    internal class E_Socio : E_Cliente
    {
        public string EstadoCuota { get; set; }

        public override string ObtenerTipoCliente()
        {
            return "SOCIO";
        }

        public bool PuedeRealizarActividad()
        {
            return EstadoCuota == "Pagado";
        }

    }
}