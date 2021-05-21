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
        public FormClientes()
        {
            InitializeComponent();
        }

        //BOTON DE AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //RecuperarInforamcion();
            conexionDAL conexion = new conexionDAL();
            MessageBox.Show("Conectado..." + conexion.ejecutarComandosSinRetornoDatos("select * from clientes"));
        }
        private void RecuperarInformacion()
        {
            ClientesBLL oClientes = new ClientesBLL();
            int ID = 0; int.TryParse(cli_nombre1.Text, out ID);
            oClientes.cli_nombre1 = ID;
        }
    }
}
