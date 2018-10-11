using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace ejercicio4.model
{
    public class Conexion
    {
        private SqlConnection con;
        private SqlCommand sen;
        public SqlDataReader rs;

        public Conexion(String bd)
        {
            con = new SqlConnection(
                    "Data Source=localhost;" +
                    "Initial Catalog=" + bd + "; " +
                    "Integrated Security=true; "


                /*ejercicio4NETASP
                 * Este es el que se usa en clases, el anterior es para windows authentication, que uso en casa
                 *
                "Data Source=localhost;" +
                "Initial Catalog=" + bd + "; " +
                "User id=sa; " +
                "Password=123456;"
                 */
                );

        }

        public DataTable Ejecutar(String query)
        {
            Console.WriteLine("QUERY=" + query);
            DataTable dt = null;

            con.Open();
            sen = new SqlCommand(query, con);

            if (query.ToLower().Contains("select"))
            {
                rs = sen.ExecuteReader();
                dt = new DataTable();
                dt.Load(rs);
            }
            else
            {
                sen.ExecuteNonQuery();
            }
            Cerrar();
            return dt;
        }

        public void Cerrar()
        {
            con.Close();
        }


    }
}