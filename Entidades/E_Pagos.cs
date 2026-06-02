using Club_Deportivo.Vistas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_Pagos
    {
        private int idPagos;
        private int idCuota;
        private int idClientes;
        private double monto;
        private DateTime? fechaPago;
        private int nroComprobante;
        private double formaPago;
        public int IdPagos
        {
            get { return idPagos; }
            set { idPagos = value; }
        }
        public int IdCuota
        {
            get { return idCuota; }
            set { idCuota = value; }
        }
        public int IdClientes
        {
            get { return idClientes; }
            set { idClientes = value; }
        }
        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        public DateTime? FechaPago
        {
            get { return fechaPago; }
            set { fechaPago = value; }
        }
        public int NroComprobante
        {
            get { return nroComprobante; }
            set { nroComprobante = value; }
        }
        public double FormaPago
        {
            get { return formaPago; }
            set { formaPago = value; }
        }
    }
}
