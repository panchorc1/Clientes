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
            LlegarGid();
        }

        /*public FormClientes()
        {
            InitializeComponent();
        }*/

        //BOTON DE AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            /*conexionDAL conexion = new conexionDAL();*/
            MessageBox.Show("Conectado..." );
            //Clase DAL Clientes.. Objeto que tiene la informacion de la GUI

            oClientesDAL.Agregar(RecuperarInformacion());
            LlegarGid();
        }
        private ClientesBLL RecuperarInformacion()
        {
            ClientesBLL oClientesBLL = new ClientesBLL();
           // int ID = 0; int.TryParse(cli_nombre1.Text, out ID);
           // oClientesBLL.cli_nombre1 = ID;

            oClientesBLL.cli_nombre1 = cli_nombre1.Text;

            /*MessageBox.Show(oClientesBLL.cli_nombre1.ToString());
            MessageBox.Show(oClientesBLL.cli_apellido1.ToString());*/

            return oClientesBLL;

        }

        private void dataClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            cli_codigo_cliente.Text = dataClientes.Rows[indice].Cells[0].Value.ToString();
            cli_apellido1.Text = dataClientes.Rows[indice].Cells[1].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oClientesDAL.Eliminar(RecuperarInformacion());
            LlegarGid();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            oClientesDAL.Actualizar(RecuperarInformacion());
            LlegarGid();
        }

        public void LlegarGid()
        {
            dataClientes.DataSource = oClientesDAL.MostrarClientes().Tables[0];
        }
        public void LimpiarEntradas()
        {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnBuscar.Enabled = false;
        }

    }
}
