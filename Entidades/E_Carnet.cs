using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_Carnet
    {
        private int idCarnet;
        private int nroCarnet;
        private DateTime? fechaEmision;
        private int idClientes;

        public int IdCarnet
        {
            get { return idCarnet; }
            set { idCarnet = value; }
        }
        public int NroCarnet
        {  
           get { return nroCarnet; } 
           set { nroCarnet = value; }
        }
        public DateTime? FechaEmision
        {
            get { return fechaEmision; }
            set { fechaEmision = value; }
        }
        public int IdClientes
        {
            get { return idClientes; }
            set { idClientes = value; }
        }
    }
}
