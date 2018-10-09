using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace ejercicio_2
{
    /// <summary>
    /// Descripción breve de CalcularDistancia
    /// </summary>
    public class CalcularDistancia :  IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "texto/normal";

            int x1=int.Parse(context.Request.Params["x1"]);
            int y1 = int.Parse(context.Request.Params["y1"]);
            int x2 = int.Parse(context.Request.Params["x2"]);
            int y2 = int.Parse(context.Request.Params["y2"]);


            Punto p1 = new Punto();
            Punto p2 = new Punto();

            p1.X = x1;
            p1.Y = y1;

            p2.X = x2;
            p2.Y = y2;

            

            double distancia = Math.Sqrt(Math.Pow((p2.X - p1.X),2)+Math.Pow((p2.Y-p1.Y),2));


            context.Session["distancia"]=distancia;

            context.Response.Redirect("Resultado.aspx");


        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}