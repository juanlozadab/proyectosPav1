using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregamos librerias para usar los componentes que proponen
//manipulacion de datos
using System.Data;
using System.Data.OleDb;


namespace Proyecto2.Clases
{
    class Datos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        //@ para inhibir algunos comandos de control
        //agregamos la contraseña a la cadena
        private String cadenaConexion = @"Provider=SQLNCLI11;Data Source=MAQUIS;User ID=avisuales1;Initial Catalog=BD_bugs;Password=avisuales1";

        private void conectar ()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            //deficion de comandos DML
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        private void desconectar()
        {
            conexion.Close();
        }
        //contenedores de Data
        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            //lo primero que tiene que hacer es conectarse
            this.conectar();
            comando.CommandText = consultaSQL;
            //la tabla se carga segun lo que devuelve el comando
            tabla.Load(comando.ExecuteReader());
            //no es recomendable mantener la conexion a la bd abierta todo el tiempo
            this.desconectar();
            //devuelve la tabla
            return tabla;
        }
    }
}
