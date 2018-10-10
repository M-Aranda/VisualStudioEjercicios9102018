using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ejercicio3.Model
{
    /// <summary>
    /// Description of Conexion.
    /// </summary>
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
