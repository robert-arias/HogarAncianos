using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HogarAncianos.Model;
using HogarAncianos.Controller;

namespace HogarAncianos.View
{
    public partial class FRM_AgregarUsuario : Form
    {
        AgregarUsuarioController agregarUsuarioController;
        public FRM_AgregarUsuario()
        {
            InitializeComponent();
            agregarUsuarioController = new AgregarUsuarioController(this);
            EstadoInicial();
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK);
        }

        public string GetNombreUsuario()
        {
            return txtUsuario.Text;
        }
        public Usuario GetUsuario()
        {
            return new Usuario(txtUsuario.Text,txtContrasenia.Text,cbRol.GetItemText(cbRol.SelectedItem));
        }

        public void ActivarCampos()
        {
            txtUsuario.Enabled = false;
            txtContrasenia.Enabled = true;
            cbRol.Enabled = true;
            checkBoxMostrarDatos.Enabled = true;

            btnAgregar.Enabled = true;
            btnCancelar.Enabled = true;
            btnVerificar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        public void EstadoInicial()
        { 
            txtUsuario.Enabled = true;
            txtContrasenia.Enabled = false;
            cbRol.Enabled = false;
            checkBoxMostrarDatos.Enabled = false;

            btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;
            btnVerificar.Enabled = true;
            btnLimpiar.Enabled = true;


            txtUsuario.Text = "";
            txtContrasenia.Text = "";
            cbRol.SelectedIndex = 0;

        }

        public bool VerificarCampos()
        {
            bool verificar = false;

            if (string.IsNullOrEmpty(txtContrasenia.Text))
            {
                lbContrasenia.ForeColor = Color.Red;
                verificar = true;
            }
            else
            {
                lbContrasenia.ForeColor = Color.Black;

            }

            if (cbRol.SelectedIndex==0)
            {
                cbRol.ForeColor = Color.Red;
                verificar = true;
            }
            else
            {
                cbRol.ForeColor = Color.Black;

            }

            return verificar;

        }

        private void checkBoxMostrarDatos_CheckedChanged(object sender, EventArgs e)
        {
            string contrasenia = txtContrasenia.Text;
            if (checkBoxMostrarDatos.Checked)
            {
                txtContrasenia.UseSystemPasswordChar = false;
                txtContrasenia.Text = contrasenia;
            }
            else
            {
                txtContrasenia.UseSystemPasswordChar = true;
                txtContrasenia.Text = contrasenia;
            }
                          
        }
    }
}
