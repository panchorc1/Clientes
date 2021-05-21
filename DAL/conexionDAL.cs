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
        private string CadenaConexion = "Data Source=DESKTOP-6MQABRN; Initial Catalog = clientes; Integrated Security = True";
        SqlConnection Conexion;

        public SqlConnection EstablecerConexion()
        {
             this.Conexion = new SqlConnection(this.CadenaConexion);
            return this.Conexion;
        }
        /*Metodo INSER, DELETE, UPDATE*/
        public bool ejecutarComandosSinRetornoDatos(string strComando)
        {
            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.CommandText = strComando;
                Comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        /*SELECT (Retorno de datos)*/

    }


}