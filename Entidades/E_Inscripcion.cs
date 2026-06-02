using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_Inscripcion
    {
        private int idInscripcion;
        private int idClientes;
        private DateTime? fecha;

        public int IdInscripcion
        {
            get { return idInscripcion; }
            set { idInscripcion = value; }
        }
        public int IdClientes
        {
            get { return idClientes; }
            set { idClientes = value; }
        }
        public DateTime? Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}