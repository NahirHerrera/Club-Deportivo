using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Datos
{
    // Clase para el comprobante de pago de los socios del club
    public class DatosComprobante
    {
        public int NSocio;
        public string? nombre;
        public string? apellido;
        public float monto;
        public string? forma_pago;
        public DateTime fechaPago;
    }
}
