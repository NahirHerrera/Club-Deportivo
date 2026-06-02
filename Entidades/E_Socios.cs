using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    // Clase que representa a un socio del club.
    // Hereda los datos generales definidos en E_Clientes.
    public class E_Socios : E_Clientes
    {
        private int nroCarnet;
        private DateTime fecha_vencimiento_cuota;
        private double montoCuota;
        public int NroCarnet
        {
            get { return nroCarnet; }
            set { nroCarnet = value; }
        }
        public DateTime Fecha_vencimiento_cuota
        {
            get { return fecha_vencimiento_cuota; }
            set { fecha_vencimiento_cuota = value; }
        }
        public double MontoCuota
        {
            get { return montoCuota; }
            set { montoCuota = value; }
        }
        public E_Socios(int id, string nombre, string apellido, string tipoDoc, string dni, bool aptoFisico) : base(id, nombre, apellido, tipoDoc, dni, aptoFisico) { }

        // Genera la informacion de inscripcion del socio, incluyendo su nombre, apellido y numero de carnet.
        public override string generarInscripcion()
        {
            return "$SOCIO: {nombre} {apellido} - Carnet: {nroCarnet}";
        }

        // Devuelve el importe de la cuota a pagar por el socio.
        public override double pagarCuota()
        {
            return montoCuota;
        }

        // Permite emitir el carnet del socio, mostrando su numero de carnet y fecha de vencimiento de la cuota.
        public void obtenerCarnet() { }
    }
}
