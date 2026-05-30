using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_Socios : E_Clientes
    {
        public int nroCarnet {  get; set; }
        public DateTime fecha_vencimiento_cuota {  get; set; } 
        public double montoCuota { get; set; }

        public E_Socios(int id, string nombre, string apellido, string tipoDoc, string dni, bool aptoFisico) : base(id, nombre, apellido, tipoDoc, dni, aptoFisico) { }
        public override string generarInscripcion()
        {
            return "$SOCIO: {nombre} {apellido} - Carnet: {nroCarnet}";
        }
        public override double pagarCuota()
        {
            return montoCuota;
        }
        public void obtenerCarnet() { }
    }
}
