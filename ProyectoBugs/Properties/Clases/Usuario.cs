using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Proyecto2.Clases
{   
    //atributos propiedades y metodos
    public class Usuario
    {   
        //mismos nombres que en la BD
        int id_usuario;
        string n_usuario;
        string password;
        string email;
        int id_perfil;

        //metodos get y set
        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        public string N_usuario
        {
            get { return n_usuario; }
            set { n_usuario = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Id_perfil
        {
            get { return id_perfil; }
            set { id_perfil = value; }
        }

        public int validarUsuario(string nombre,string clave)
        {   
            DataTable tabla = new DataTable() ;
            //creamos la consulta que queremos hacer concatenando los valores que necesitamos
            string consultaSQL = "SELECT * FROM Users "+"WHERE n_usuario= '"+nombre+"' AND password= '"+clave+"'";
            Datos oBD = new Datos();
            tabla = oBD.consultar(consultaSQL);
            //verificamos si la tabla tiene algo
            if (tabla.Rows.Count > 0)
                //devuelve la columna y fila 0, lo que seria el id_usuario
                return Convert.ToInt32(tabla.Rows[0][0]);
            else
                //si esta vacia devuelve 0
                return 0;
        }
     }
}
