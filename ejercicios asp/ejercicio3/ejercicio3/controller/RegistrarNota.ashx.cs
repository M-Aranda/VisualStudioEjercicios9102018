using ejercicio3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicio3.controller
{
    /// <summary>
    /// Descripción breve de RegistrarNota
    /// </summary>
    public class RegistrarNota : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "texto/normal";
            int valor = int.Parse(context.Request.Params["nota"]);
            Nota nota = new Nota();
            nota.Valor = valor;
            DAO_Nota dn = new DAO_Nota();
            dn.Create(nota);

            context.Response.Redirect("../Indice.aspx");
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}