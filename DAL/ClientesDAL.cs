using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using clientes.BLL;

namespace clientes.DAL
{
    class ClientesDAL
    {
        conexionDAL conexion;
        public ClientesDAL()
        {
            conexion = new conexionDAL();
        }

        public bool Agregar(ClientesBLL oClientesBLL)
        {
            SqlCommand SQLComando = new SqlCommand("Insert into de_cliente values(@Clientes)");

            SQLComando.Parameters.Add("@Clientes", SqlDbType.VarChar).Value=oClientesBLL.cli_codigo_cliente;

            //return conexion.ejecutarComandosSinRetornoDatos(SQLComando);

           // return conexion.ejecutarComandosSinRetornoDatos("insert into te_clientes values ('001','" + oClientesBLL.cli_nombre1 + "'," +
             //   "'Edgardo','Rodriguez','Colindres','','Jalapa','33123785','','2996363802101','12-13-1993')");
        }

        public int Eliminar (ClientesBLL oClientesBLL) {

            conexion.ejecutarComandosSinRetornoDatos("delete from te_clientes where cli_codigo_cliente =" + oClientesBLL.cli_codigo_cliente);


            return 1;

            }

        public int Actualizar(ClientesBLL oClientesBLL)
        {

            conexion.ejecutarComandosSinRetornoDatos("update te_clientes " +
                "set de_clientes ='"+oClientesBLL.cli_nombre1+ "', '" + oClientesBLL.cli_nombre2 + "','"+oClientesBLL.cli_nombre1+ "'," +
                "'" + oClientesBLL.cli_apellido1 + "','" + oClientesBLL.cli_apellido2+ "','" + oClientesBLL.cli_apellido_casada + "'," +
                "'" + oClientesBLL.cli_direccion + "','" + oClientesBLL.cli_telefono1 + "','" + oClientesBLL.cli_telefono2 + "'," +
                "'" + oClientesBLL.cli_identificacion + "','" + oClientesBLL.cli_fecha_nacimiento + 
                "'where cli_codigo_cliente =" + oClientesBLL.cli_codigo_cliente);


            return 1;

        }

        public DataSet MostrarClientes()
        {
            SqlCommand Sentencia = new SqlCommand("Select * from te_clientes");

            return conexion.EjecutarSentencia(Sentencia);
        }
    }
}
