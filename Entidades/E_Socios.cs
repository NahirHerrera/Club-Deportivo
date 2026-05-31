using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    // Clase que representa a un socio del club.
    // Hereda los datos generales definidos en E_Clientes.
    public class E_Socios : E_Clientes
    {
        // Numero de carnet del socio 
        public int nroCarnet {  get; set; }

        // Fecha de vencimiento de la cuota
        public DateTime fecha_vencimiento_cuota {  get; set; }

        // Monto de la cuota a pagar.
        public double montoCuota { get; set; }

        // Constructor que inicializa los datos heredados de E_Clientes y los datos específicos de E_Socios.
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
