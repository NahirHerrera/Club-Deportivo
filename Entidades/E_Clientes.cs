using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    public class E_Clientes
    {
        public int idClientes {  get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? tipoDoc {  get; set; }
        public string? dni { get; set; } 
        public bool aptoFisico { get; set; }

        public E_Clientes (int id, string nombre, string apellido, string tipoDoc, string dni, bool aptoFisico)
        {
            this.idClientes = id;
            this.nombre = nombre;
            this.apellido = apellido;  
            this.tipoDoc = tipoDoc;
            this.dni = dni;
            this.aptoFisico = aptoFisico;
        }

        public virtual string generarInscripcion()
        {
            return "$Cliente: {nombre} {apellido} - DNI: {dni} - Apto Físico: {aptoFisico}";
        }
        public virtual double pagarCuota()
        {
            return 0;       
        }
    }
}
