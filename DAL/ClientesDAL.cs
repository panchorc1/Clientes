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
           return conexion.ejecutarComandosSinRetornoDatos("insert into te_clientes values ('001','"+oClientesBLL.cli_nombre1+"'," +
               "'Edgardo','Rodriguez','Colindres','','Jalapa','33123785','','2996363802101','12-13-1993')");
        }
    }
}
