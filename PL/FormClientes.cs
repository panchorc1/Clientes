using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clientes.BLL;
using clientes.DAL;

namespace clientes.PL
{
    public partial class FormClientes : Form
    {
        ClientesDAL oClientesDAL;
        public FormClientes()
        {
            oClientesDAL = new ClientesDAL();
            InitializeComponent();
        }

        public FormClientes()
        {
            InitializeComponent();
        }

        //BOTON DE AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            /*conexionDAL conexion = new conexionDAL();*/
            MessageBox.Show("Conectado..." );
            //Clase DAL Clientes.. Objeto que tiene la informacion de la GUI

            oClientesDAL.Agregar(RecuperarInformacion());
        }
        private ClientesBLL RecuperarInformacion()
        {
            ClientesBLL oClientesBLL = new ClientesBLL();
            int ID = 0; int.TryParse(cli_nombre1.Text, out ID);
            oClientesBLL.cli_nombre1 = ID;

            oClientesBLL.cli_nombre1 = cli_nombre1.Text;

            /*MessageBox.Show(oClientesBLL.cli_nombre1.ToString());
            MessageBox.Show(oClientesBLL.cli_apellido1.ToString());*/

            return oClientesBLL

        }
    }
}
