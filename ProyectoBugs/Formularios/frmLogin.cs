using ProyectoBugs.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBugs
{
    public partial class frmLogin : Form
    {
        Usuario miUsuario = new Usuario();

        public Usuario MiUsuario
        {
            get { return miUsuario; }
            set { miUsuario = value; }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
          /*  if (MessageBox.Show("Esta seguro de abandonar la aplicacion..."
                                , "Saliendo"
                                , MessageBoxButtons.YesNo
                                , MessageBoxIcon.Question
                                , MessageBoxDefaultButton.Button2
                                ) == System.Windows.Forms.DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            //Cierra el formulario
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {   //falta validar txt por si estan vacias

            //se genero un constructor por defecto en la clase usuario
            
            MiUsuario.N_usuario = txtUsuario.Text;
            MiUsuario.Password = txtContraseña.Text;

            miUsuario.Id_usuario = miUsuario.validarUsuario(MiUsuario.N_usuario, MiUsuario.Password);
            //verificamos si la tabla contiene algo
            if (miUsuario.Id_usuario == 0)
            {
                MessageBox.Show("Usuario invalido");
                //limpiar cajas de texto
                txtUsuario.Text = "";
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
            else
            {   
                this.Close();
            }
                
        }
    }
}
