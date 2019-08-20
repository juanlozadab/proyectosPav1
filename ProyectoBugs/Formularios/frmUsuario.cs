using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBugs.Clases;
namespace ProyectoBugs.Formularios
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        Perfil oPerfil = new Perfil();
        Usuario oUsuario = new Usuario();
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.habilitar(false);
            this.cboPerfil.DataSource = oPerfil.recuperarPerfiles();
            this.cboPerfil.DisplayMember = "n_perfil";
            this.cboPerfil.ValueMember = "id_perfil";
            this.grdUsuario.DataSource = oUsuario.recuperarUsuarios();

            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.limpiar();
            this.habilitar(true);
            this.txtNombre.Focus();

        }
        private void limpiar()
        {
            txtId.Text = "";
            txtNombre.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            cboPerfil.SelectedIndex = -1;

        }
        private void habilitar(bool x)
        {
            //txtId.Enabled = x;
            txtNombre.Enabled = x;
            txtPassword.Enabled = x;
            txtEmail.Enabled = x;
            cboPerfil.Enabled = x;
            btnGuardar.Enabled = x;
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            oUsuario.N_usuario = txtNombre.Text;
            oUsuario.Password = txtPassword.Text;
            oUsuario.Email = txtEmail.Text;
            oUsuario.Id_perfil = Convert.ToInt32( cboPerfil.SelectedValue);
            
            if (oUsuario.validarDatosUsuario())
            {
                oUsuario.grabarUsuario();
                
            }
            

            this.habilitar(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
            this.habilitar(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.habilitar(true);
            //this.txtId.Enabled = false;
            this.txtNombre.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
