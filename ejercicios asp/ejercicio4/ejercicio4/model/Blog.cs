using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicio4.model
{
    public class Blog
    {
        int id;
        String titulo;
        String texto;
        String etiquetas;
        Usuario usu;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Texto { get => texto; set => texto = value; }
        public string Etiquetas { get => etiquetas; set => etiquetas = value; }
        public Usuario Usu { get => usu; set => usu = value; }
    }
}