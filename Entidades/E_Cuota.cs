using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_Cuota
    {
        private int idCuota;
        private int idClientes;
        private double monto;
        private DateTime? fechaVencimiento;
        private string? estado;

        public int IdCuota
        {
            get { return IdCuota; }
            set { idCuota = value; }
        }
        public int IdClientes
        {
            get { return IdClientes; }
            set { idClientes = value; }
        }
        public double Monto
        {
            get { return Monto; }
            set { monto = value; }
        }
        public DateTime? FechaVencimiento
        {
            get { return FechaVencimiento; }
            set { fechaVencimiento = value; }
        }
        public string? Estado
        {
            get { return Estado; }
            set { estado = value; }
        }
    }
}
