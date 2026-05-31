using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    // Clase que representa a los clientes no socios del club.
    // Hereda los datos comunes definidos en E_Clientes.
    public class E_NoSocios : E_Clientes
    {
        // Actividad en la que participa el no socio
        public int idActividades {  get; set; }

        // Fecha de la actividad para la cual se inscribe el no socio
        public DateTime fechaActividad { get; set; }

        // Monto de la cuota que debe pagar el no socio por participar en la actividad
        public double montoCuota { get; set; }

        // Constructor que inicializa los datos del no socio, incluyendo los heredados de E_Clientes.
        public E_NoSocios(int id, string nombre, string apellido, string tipoDoc, string dni, bool aptoFisico) : base(id, nombre, apellido, tipoDoc, dni, aptoFisico) { }

        // Genera la información de inscripción específica para no socios, incluyendo la fecha de la actividad.
        public override string generarInscripcion()
        {
            return "$NO SOCIO: {nombre} {apellido} - DNI: {dni} - Fecha: {fechaActividad:dd/MM/yyyy}";
        }

        // Devuelve el monto de la cuota que debe pagar el no socio por participar en la actividad.
        public override double pagarCuota()
        {
            return montoCuota;
        }

        // Permite consultar la cartilla de actividades disponibles para no socios.
        // Este método puede ser implementado para mostrar las actividades y sus detalles.
        public void consultarCartilla() { }
    }
}
