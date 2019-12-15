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

        public string GetCedula() {
            txtCedula.Text = new string(txtCedula.Text.Where(x => !char.IsWhiteSpace(x)
                                                                    && char.IsDigit(x)).ToArray());
            return txtCedula.Text;
        }

        public void ActivarCampoUsuario() {
            txtCedula.Enabled = false;
            txtUsuario.Enabled = true;
        }

        public void AgregarInformacionEmpleado(DataTable empleado) {
            txtNombre.Text = empleado.Rows[0][1].ToString() + " " + empleado.Rows[0][2].ToString();
            txtRol.Text = empleado.Rows[0][3].ToString();
        }

        public bool ShowConfirmation() {
            string message = "¿Desea modificar el usuario: " + txtUsuario.Text + "?";
            DialogResult boton = MessageBox.Show(message, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            return boton == DialogResult.OK;
        }

        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string GetNombreUsuario()
        {
            txtUsuario.Text = new string(txtUsuario.Text.Where(x => !char.IsWhiteSpace(x)).ToArray());
            return txtUsuario.Text;
        }
        public Usuario GetUsuario()
        {
            //Encrypt password
            byte[] passwordBytes = Encoding.Unicode.GetBytes(txtContrasenia.Text);
            var hasher = System.Security.Cryptography.SHA256.Create();
            byte[] hashedBytes = hasher.ComputeHash(passwordBytes);

            return new Usuario(txtUsuario.Text, hashedBytes, txtCedula.Text);
        }

        public void ActivarCampos()
        {
            txtUsuario.Enabled = false;
            txtContrasenia.Enabled = true;
            checkBoxMostrarDatos.Enabled = true;

            btnAgregar.Enabled = true;
            btnCancelar.Enabled = true;
            btnVerificar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        public void EstadoInicial()
        {
            txtCedula.Enabled = true;
            txtUsuario.Enabled = false;
            txtContrasenia.Enabled = false;
            checkBoxMostrarDatos.Enabled = false;

            btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;
            btnVerificar.Enabled = true;
            btnLimpiar.Enabled = true;

            txtCedula.Text = "";
            txtNombre.Text = "";
            txtRol.Text = "";
            txtUsuario.Text = "";
            txtContrasenia.Text = "";

        }

        public bool VerificarCampos()
        {
            bool verificar = false;
            txtUsuario.Text = new string(txtUsuario.Text.Where(x => !char.IsWhiteSpace(x)).ToArray());

            if (string.IsNullOrEmpty(txtContrasenia.Text))
            {
                lbContrasenia.ForeColor = Color.Red;
                verificar = true;
            }
            else
            {
                lbContrasenia.ForeColor = Color.White;

            }

            return verificar;

        }

        public void MostrarContrasenia()
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
