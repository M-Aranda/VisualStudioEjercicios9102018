using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;


namespace ejercicio1
{
    /// <summary>
    /// Descripción breve de Calculadora
    /// </summary>
    public class Calculadora : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext c)
        {
            c.Response.ContentType = "texto/normal";

            int primerValor=int.Parse(c.Request.Params["primerNumero"]);
            int segundoValor = int.Parse(c.Request.Params["segundoNumero"]);
            String operacion = c.Request.Params["operacion"];

            int resultado = 0;

            if (operacion == "sumar")
            {
                resultado = primerValor + segundoValor;
            }else if (operacion == "restar")
            {
                resultado = primerValor - segundoValor;
            }
            else if (operacion == "multiplicar")
            {
                resultado = primerValor * segundoValor;
            }
            else if (operacion == "dividir")
            {
                resultado = primerValor / segundoValor;
            }

            
            c.Session["res"] = resultado;
            c.Response.Redirect("Resultado.aspx");


        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}