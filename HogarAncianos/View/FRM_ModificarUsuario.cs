using HogarAncianos.Controller;
using HogarAncianos.Model;
using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HogarAncianos.View {
    public partial class FRM_ModificarUsuario : Form
    {
        private ModificarUsuarioController modificarUsuarioController;
        private ConnectionDB db;

        public FRM_ModificarUsuario()
        {
            InitializeComponent();
            EstadoInicial();
            modificarUsuarioController = new  ModificarUsuarioController(this);
            db = new ConnectionDB();
        }

        public bool VerificarUsuario() {
            return string.IsNullOrEmpty(txtUsuario.Text);
        }


        public void LlenarRol(DataTable data)
        {
            txtRol.Text = db.GetEmpleadoUsuario(data.Rows[0][2].ToString()).Rows[0][3].ToString(); 
        }

        public bool CheckPassword() {
            DataTable user = db.GetUsuario(txtUsuario.Text);

            byte[] passwordBytes = Encoding.Unicode.GetBytes(txtContraseniaActual.Text);
            var hasher = System.Security.Cryptography.SHA256.Create();
            byte[] hashedBytes = hasher.ComputeHash(passwordBytes);

            return Convert.ToBase64String(hashedBytes).Equals(Convert.ToBase64String((byte[])user.Rows[0][1]));
        }

        public bool ShowConfirmation() {
            string message = "¿Desea modificar el usuario: " + txtUsuario.Text + "?";
            DialogResult boton = MessageBox.Show(message, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            return boton == DialogResult.OK;
        }

        public void ShowMessage(string message, string title) {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ActivarContraseniaActual() {
            txtUsuario.Enabled = false;
            btnVerificarUsuario.Enabled = false;
            btnVerificarContrasenia.Enabled = true;
            txtContraseniaActual.Enabled = true;
        }

        public void ActivarContraseniaNueva() {
            btnVerificarContrasenia.Enabled = false;
            txtContraseniaNueva.Enabled = true;
            cbMostrarContrasenia.Enabled = true;
            btnModificar.Enabled = true;
            txtContraseniaActual.Enabled = false;
        }

        public void EstadoInicial() {
            txtUsuario.Enabled = true;
            btnVerificarUsuario.Enabled = true;
            btnVerificarContrasenia.Enabled = false;
            txtContraseniaActual.Enabled = false;

            btnVerificarContrasenia.Enabled = false;
            txtContraseniaNueva.Enabled = false;
            cbMostrarContrasenia.Enabled = false;
            cbMostrarContrasenia.Checked = false;
            btnModificar.Enabled = false;

            txtContraseniaActual.Text = "";
            txtUsuario.Text = "";
            txtRol.Text = "";
            lbContraseniaNueva.ForeColor = Color.White;
            txtContraseniaNueva.Text = "";
        }

        public bool VerificarCampos() {
            if (string.IsNullOrEmpty(txtContraseniaNueva.Text)) {
                lbContraseniaNueva.ForeColor = Color.Red;
                return true;
            }
            else {
                lbContraseniaNueva.ForeColor = Color.White;
                return false;
            }

        }

        public Usuario GetUsuario() {
            byte[] passwordBytes = Encoding.Unicode.GetBytes(txtContraseniaNueva.Text);
            var hasher = System.Security.Cryptography.SHA256.Create();
            byte[] hashedBytes = hasher.ComputeHash(passwordBytes);

            return new Usuario(txtUsuario.Text, hashedBytes, txtRol.Text);
        }

        public void MostrarContrasenia()
        {
            string contrasenia = txtContraseniaNueva.Text;
            if (cbMostrarContrasenia.Checked)
            {
                txtContraseniaNueva.UseSystemPasswordChar = false;
                txtContraseniaNueva.Text = contrasenia;
            }
            else
            {
                txtContraseniaNueva.UseSystemPasswordChar = true;
                txtContraseniaNueva.Text = contrasenia;
            }

        }

    }
}
