using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Deportivo.Entidades
{
    // Entidad utilizada para representar a los usuarios
    // autorizados a ingresar al sistema.
    public class E_Usuario
    {
        // Identificador único del usuario en la base de datos.
        public int idUsuario { get; set; }

        // Nombre de usuario utilizado para el inicio de sesión.
        public string? Usuario { get; set; }

        // Contraseña asociada al usuario para el inicio de sesión.
        public string? Password { get; set; }
    }
}

