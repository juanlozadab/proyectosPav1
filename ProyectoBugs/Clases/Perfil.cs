using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ProyectoBugs.Clases
{
    class Perfil
    {
        private int id_perfil;
        Datos obd = new Datos();
        public int Id_perfil
        {
            get { return id_perfil; }
            set { id_perfil = value; }
        }
        private string n_perfil;

        public string N_perfil
        {
            get { return n_perfil; }
            set { n_perfil = value; }
        }
        public DataTable recuperarPerfiles()
        {
            return
            obd.consultarTabla("Perfiles");

               }

    }
}
