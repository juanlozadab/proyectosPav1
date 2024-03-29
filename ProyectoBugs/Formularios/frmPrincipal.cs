﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBugs.Clases;

namespace ProyectoBugs
{
    public partial class frmPrincipal : Form
    {
        Usuario usuarioActual;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {   //asigna el frm a fl
            frmLogin fl;
            fl = new frmLogin();

            //muestra el formulario
            fl.ShowDialog();
            //asignamos el usuario obtenido en el frmLogin
            this.usuarioActual = fl.MiUsuario;

            if (this.usuarioActual.Id_usuario == 0)
                this.Close();
            else
                this.Text = this.Text + " Usuario: " + this.usuarioActual.N_usuario;

            //garbage collector
            fl.Dispose();
        }
    }
}
