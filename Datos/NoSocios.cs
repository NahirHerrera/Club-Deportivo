using Club_Deportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Club_Deportivo.Datos
{
    internal class NoSocios
    {
        public string Nuevo_NoSocio(E_NoSocio persona)
        {
            string salida;

            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                string query =
                @"INSERT INTO NoSocios
                (Nombre,Apellido,TipoDoc,Documento,
                 FechaVisita,Actividad,CostoActividad)

                VALUES
                (@Nom,@Ape,@TipoDoc,@Doc,
                 @Fecha,@Actividad,@Costo)";

                MySqlCommand cmd =
                    new MySqlCommand(query, sqlCon);

                cmd.Parameters.AddWithValue(
                    "@Nom",
                    persona.Nombre);

                cmd.Parameters.AddWithValue(
                    "@Ape",
                    persona.Apellido);

                cmd.Parameters.AddWithValue(
                    "@TipoDoc",
                    persona.TipoDoc);

                cmd.Parameters.AddWithValue(
                    "@Doc",
                    persona.Documento);

                cmd.Parameters.AddWithValue(
                    "@Fecha",
                    persona.FechaVisita);

                cmd.Parameters.AddWithValue(
                    "@Actividad",
                    persona.Actividad);

                cmd.Parameters.AddWithValue(
                    "@Costo",
                    persona.CostoActividad);

                sqlCon.Open();

                cmd.ExecuteNonQuery();

                salida = "OK";
            }

            catch (Exception ex)
            {
                salida = ex.Message;
            }

            finally
            {
                if (sqlCon.State ==
                    ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return salida;
        }
    }
}