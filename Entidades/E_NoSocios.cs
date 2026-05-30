using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_NoSocios : E_Clientes
    {
        public int idActividades {  get; set; }
        public DateTime fechaActividad { get; set; }
        public double montoCuota { get; set; }

        public E_NoSocios(int id, string nombre, string apellido, string tipoDoc, string dni, bool aptoFisico) : base(id, nombre, apellido, tipoDoc, dni, aptoFisico) { }
        
        public override string generarInscripcion()
        {
            return "$NO SOCIO: {nombre} {apellido} - DNI: {dni} - Fecha: {fechaActividad:dd/MM/yyyy}";
        }
        public override double pagarCuota()
        {
            return montoCuota;
        }
        public void consultarCartilla() { }
    }
}
