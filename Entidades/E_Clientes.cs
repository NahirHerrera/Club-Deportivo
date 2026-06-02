using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
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
