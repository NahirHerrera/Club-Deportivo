using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    // Clase base que representa a cualquier cliente del club.
    // Contiene los datos comunes utilizados por socios y no socios.
    public class E_Clientes
    {
        private int idClientes;
        private string? nombre;
        private string? apellido;
        private string? tipoDoc;
        private string? dni;
        private bool aptoFisico;
        public int IdClientes
        {
            get { return idClientes; }
            set { idClientes = value; }
        }
        public string? Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string? Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string? TipoDoc
        {
            get { return tipoDoc; }
            set { tipoDoc = value; }
        }
        public string? Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public bool AptoFisico
        {
            get { return aptoFisico; }
            set { aptoFisico = value; }
        }
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
