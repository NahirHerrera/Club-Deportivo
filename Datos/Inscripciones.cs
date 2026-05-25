using System;
using System.Collections.Generic;
using System.Text;

using Club_Deportivo.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace Club_Deportivo.Datos
{
    internal class Inscripciones
    {
        public void NuevaInscripcion( E_Inscripcion ins)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                string query = @"INSERT INTO inscripcion(
                Fecha,
                IdSocio,
                IdActividad,
                Estado)

                VALUES(
                @Fecha,
                @IdSocio,
                @IdActividad,
                @Estado)";

                MySqlCommand cmd = new MySqlCommand(query,sqlCon);

                cmd.Parameters.AddWithValue("@Fecha",ins.Fecha);

                cmd.Parameters.AddWithValue("@IdSocio",ins.IdSocio);

                cmd.Parameters.AddWithValue("@IdActividad",ins.IdActividad);

                cmd.Parameters.AddWithValue("@Estado",ins.Estado);

                sqlCon.Open();

                cmd.ExecuteNonQuery();
            }

            finally
            {
                if (
                sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
