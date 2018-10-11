using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicio4.model
{
    public class Usuario
    {
        int id;
        String nombreCompleto;
        String correo;
        String contrasenia;

        public int Id { get => id; set => id = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
    }
}