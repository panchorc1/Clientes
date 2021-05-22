﻿using System;
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
            //SOBRECARGA
            public bool ejecutarComandosSinRetornoDatos(SqlCommand SQLComando)
            {
                try
                {
                    SqlCommand Comando = SQLComando;
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
        public DataSet EjecutarSentencia(SqlCommand sqlComando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter Adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando = sqlComando;
                Comando.Connection = EstablecerConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                return DS;
            }
            catch
            {
                return DS;

           
            }

        }

    }


}