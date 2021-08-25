using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace rrhh2
{
    class Conexion
    {
        public static SqlConnection getConexion()
        {
            try
            {
                SqlConnection cn = new SqlConnection(@"Data Source=10.10.231.30;Initial Catalog=rrhh;Persist Security Info=True;User ID=sa;Password=Sa2011");

                //cn.Open();
                
                return cn;
            }
            catch (Exception ex)
            {
                //return null;
                throw new ArgumentException("Error al conectar", ex);
            }
        }


    }
}
