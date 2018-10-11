using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ejercicio3.Model
{
    public class DAO_Nota : Conexion, IDAO<Nota>


    {
        public DAO_Nota() : base("notasCSharp")
        {
        }

        public void Create(Nota ob)
        {
            Ejecutar("INSERT INTO nota VALUES ("+ob.Valor+");");
        }

        public void Delete(int id)
        {
            Ejecutar("DELETE FROM nota WHERE id="+id+"; ");
        }

        public DataTable Read()
        {
            DataTable dt = null;

            dt = Ejecutar("SELECT * FROM nota;");

            return dt;

        }

        public void Update(Nota ob)
        {
            Ejecutar("UPDATE nota SET valor="+ob.Valor+" WHERE id="+ob.Id+" ;");
        }

        public int GetCantNotas()
        {
            int cant = 0;

            
            DataTable dt= Ejecutar("SELECT COUNT(*) FROM nota;");

            cant = int.Parse(dt.Rows[0][0].ToString());


            return cant;

        }



        public int GetCantAzules()
        {
            int cant = 0;

            DataTable dt = Ejecutar("SELECT COUNT(*) FROM nota WHERE valor >= 40;");

            cant = int.Parse(dt.Rows[0][0].ToString());

            return cant;


        }

        public int GetCantRojos()
        {
            int cant = 0;

            DataTable dt = Ejecutar("SELECT COUNT(*) FROM nota WHERE valor < 40;");

            cant = int.Parse(dt.Rows[0][0].ToString());

            return cant;


        }


        public int GetNotaMasAlta()
        {
            int valor=0;

            DataTable dt = Ejecutar("SELECT MAX(valor) FROM nota;");

            valor = int.Parse(dt.Rows[0][0].ToString());

            return valor;
        }

        public int GetNotaMasBaja()
        {
            int valor = 0;

            DataTable dt = Ejecutar("SELECT MIN(valor) FROM nota;");

            valor = int.Parse(dt.Rows[0][0].ToString());

            return valor;

        }

        public int GetCantSietes()
        {
            int cant = 0;

            DataTable dt = Ejecutar("SELECT COUNT(*) FROM nota WHERE valor = 70;");

            cant = int.Parse(dt.Rows[0][0].ToString());

            return cant;

        }


        public double GetPromedioDelCurso()
        {
            double cant = 0;

            DataTable dt = Ejecutar("SELECT AVG(valor) FROM nota;");

            cant = double.Parse(dt.Rows[0][0].ToString());

            return cant;

        }





    }
}