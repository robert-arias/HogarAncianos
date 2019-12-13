using HogarAncianos.Model;
using HogarAncianos.View;
using System;
using System.Data;
using System.Windows.Forms;

namespace HogarAncianos.Controller {

    public class LoginController {

        FRM_Login frm_Login;
        ConnectionDB db;

        public LoginController(FRM_Login frm_Login) {
            this.frm_Login = frm_Login;
            db = new ConnectionDB();
            AgregarEventos();
        }

        private void AgregarEventos() {
            frm_Login.btnIniciarSesion.Click += new EventHandler(Login);
            frm_Login.txtContrasenia.KeyDown += new KeyEventHandler(LoginEnter);
        }

        private void Login(object sender, EventArgs e) {
            IniciarSesion();
        }

        private void LoginEnter(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                IniciarSesion();
                e.SuppressKeyPress = true; //remove ding windows sound.
            }
        }

        private void IniciarSesion() {
            if (!frm_Login.VerificarCampos()) {
                DataTable user = db.GetUsuario(frm_Login.GetUsername());
                if (user.Rows.Count > 0) {
                    if (frm_Login.CheckPassword(user)) {
                        frm_Login.ShowMessage("Hola, " + user.Rows[0][0].ToString() + ".\n" +
                            "Se ha ingresado al sistema correctamente");
                        frm_Login.EstadoInicial();
                    }
                    else
                        frm_Login.ShowMessage("El usuario o la contraseña ingresada son incorrectas.");
                }
                else
                    frm_Login.ShowMessage("El usuario o la contraseña ingresada son incorrectas.");
            }
        }

    }
}
