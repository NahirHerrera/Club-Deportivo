using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
	internal class E_NoSocio : E_Usuario
	{
		public DateTime FechaVista { get; set; }
		public string Actividad { get; set; }
		public decimal CostoActividad { get; set; }
		public override string ObtenerRol()
		{
			return "NO_SOCIO";
		}
	}
} 
