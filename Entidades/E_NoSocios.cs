using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_NoSocios : E_Clientes
    {
        private int idActividades;
        private DateTime fechaActividad;
        private double montoCuota;
        public int IdActividades
        { 
            get { return IdActividades; }
            set { idActividades = value; }
        }
        public DateTime FechaActividad
        {
            get { return FechaActividad; }
            set { fechaActividad = value; }
        }
        public double MontoCuota
        {
            get { return MontoCuota; }
            set { montoCuota = value; }
        }
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
