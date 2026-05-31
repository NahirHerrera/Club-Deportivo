using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    // Clase base que representa a cualquier cliente del club.
    // Contiene los datos comunes utilizados por socios y no socios.
    public class E_Clientes
    {
        // Identificador único del cliente
        public int idClientes {  get; set; }

        // Datos personales
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? tipoDoc {  get; set; }
        public string? dni { get; set; }

        // Indica si presentó apto físico
        public bool aptoFisico { get; set; }


        // Constructor que inicializa los datos básicos del cliente
        public E_Clientes (int id, string nombre, string apellido, string tipoDoc, string dni, bool aptoFisico)
        {
            this.idClientes = id;
            this.nombre = nombre;
            this.apellido = apellido;  
            this.tipoDoc = tipoDoc;
            this.dni = dni;
            this.aptoFisico = aptoFisico;
        }

        // Método virtual que permite generar la información de inscripción.
        // Puede ser sobrescrito por las clases de herencia.
        public virtual string generarInscripcion()
        {
            return "$Cliente: {nombre} {apellido} - DNI: {dni} - Apto Físico: {aptoFisico}";
        }

        // Método virtual para gestionar el pago.
        // Será redefinido por Socios y NoSocios según sus reglas de negocio.
        public virtual double pagarCuota()
        {
            return 0;       
        }
    }
}
