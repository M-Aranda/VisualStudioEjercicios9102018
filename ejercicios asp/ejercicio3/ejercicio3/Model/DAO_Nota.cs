using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ejercicio3.Model
{
    public class DAO_Nota : Conexion, IDAO<Nota>


    {
        public DAO_Nota(string bd) : base("notasCSharp")
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
            Ejecutar("UPDATE nota SET valor="+ob.Valor+" WHERE id="+ob.Id+" ");
        }
    }
}