using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace clientes.DAL
{
    class conexionDAL
    {
        public bool PruebaConexion()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-6MQABRN; Initial Catalog=clientes; Integrated Security=True");
                SqlCommand Comando = new SqlCommand();

                Comando.CommandText = "select * from clientes";
                Comando.Connection = Conexion;
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();

                return true;
            }
            catch
            {
                return false;
            }
    }   }
}
