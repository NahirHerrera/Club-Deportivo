using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_Actividades
    {
        private int idActividades;
        private string? nombreActividad;
        private double costoPaseDiario;

        public int IdActividades
        {
            get { return idActividades; }
            set { idActividades = value; }
        }
        public string? NombreActividad
        {
            get { return nombreActividad; }
            set { nombreActividad = value; }
        }
        public double CostoPaseDiario
        {
            get { return costoPaseDiario; }
            set { costoPaseDiario = value; }
        }
    }
}
   
