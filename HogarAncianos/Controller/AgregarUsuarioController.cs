using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HogarAncianos.View;
using HogarAncianos.Model;
using System.Windows.Forms;
namespace HogarAncianos.Controller
{
    class AgregarUsuarioController
    {
        private FRM_AgregarUsuario frm_AgregarUsuario;
        private ConnectionDB connection;

        public AgregarUsuarioController(FRM_AgregarUsuario frm_AgregarUsuario)
        {
            this.frm_AgregarUsuario = frm_AgregarUsuario;
            connection = new ConnectionDB();
            AgregarEventosUsuarios();
        }

        public void AgregarEventosUsuarios()
        {
            frm_AgregarUsuario.btnVerificarCedula.Click += new EventHandler(VerificarCedula);
            frm_AgregarUsuario.btnAgregar.Click += new EventHandler(AgregarUsuario);
            frm_AgregarUsuario.btnVerificar.Click += new EventHandler(VerificarUsuarioBoton);
            frm_AgregarUsuario.txtUsuario.KeyDown += new KeyEventHandler(VerificarUsuarioEnter);
            frm_AgregarUsuario.btnLimpiar.Click += new EventHandler(Limpiar);
            frm_AgregarUsuario.txtCedula.KeyDown += new KeyEventHandler(VerificarCedulaEnter);
            frm_AgregarUsuario.checkBoxMostrarDatos.CheckedChanged += new EventHandler(MostrarContrasenia);
        }

        private void VerificarCedula(object sender, EventArgs e) {
            VerificarCedula();
        }

        private void MostrarContrasenia(object sender, EventArgs e) {
            frm_AgregarUsuario.MostrarContrasenia();
        }

        public void VerificarCedulaEnter(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                VerificarCedula();
                e.SuppressKeyPress = true; //remove ding windows sound.
            }
        }

        private void VerificarCedula() {
            if (!string.IsNullOrEmpty(frm_AgregarUsuario.GetCedula()) && frm_AgregarUsuario.GetCedula().Length >= 9) {
                if (!connection.ExisteCedula(frm_AgregarUsuario.GetCedula())) {
                    if (connection.ExisteUsuarioConCedula(frm_AgregarUsuario.GetCedula())) {
                        frm_AgregarUsuario.ActivarCampoUsuario();
                        frm_AgregarUsuario.AgregarInformacionEmpleado(connection.GetEmpleadoUsuario(
                            frm_AgregarUsuario.GetCedula()));
                    }
                    else {
                        frm_AgregarUsuario.ShowMessage("El empleado con la cédula ingresada ya posee un usuario.", "Mensaje");

                    }
                }
                else
                    frm_AgregarUsuario.ShowMessage("La cédula ingresada no existe.", "Mensaje");
            }
            else
                frm_AgregarUsuario.ShowMessage("El formato de la cédula es incorrecto.", "Advertencia");
        }

        public void VerificarUsuarioEnter(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                VerificarUsuario();
                e.SuppressKeyPress = true; //remove ding windows sound.
            }
        }

        public void VerificarUsuarioBoton(object sender, EventArgs e) {
            VerificarUsuario();
        }

        private void VerificarUsuario() {
            if (!connection.ExisteUsuario(frm_AgregarUsuario.GetNombreUsuario())) {
                frm_AgregarUsuario.ActivarCampos();
            }
            else {
                frm_AgregarUsuario.ShowMessage("El usuario ingresado se encuentra en los registros.", "Mensaje");

            }
        }

        public void Limpiar(object sender, EventArgs e)
        {
            frm_AgregarUsuario.EstadoInicial();
        }

        public void AgregarUsuario(object sender, EventArgs e)
        {
            if (!frm_AgregarUsuario.VerificarCampos())
            {
                if (frm_AgregarUsuario.ShowConfirmation()) {
                    if (connection.AgregarUsuario(frm_AgregarUsuario.GetUsuario())) {
                        frm_AgregarUsuario.ShowMessage("El usuario ha sido agregado exitósamente.", "Mensaje");
                        frm_AgregarUsuario.EstadoInicial();
                    }
                    else
                        frm_AgregarUsuario.ShowMessage("Ha ocurrido un error.", "Advertencia");
                }
            }
            else
            {

                frm_AgregarUsuario.ShowMessage("Algunos campos se encuentran vacíos." +
                    "\nLos campos con el asterisco (*) rojo son aquellos que deben ser modificados.", "Advertencia");
            }
        }

    }
}
