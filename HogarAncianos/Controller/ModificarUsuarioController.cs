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
   public class ModificarUsuarioController
    {
        private FRM_ModificarUsuario frm_ModificarUsuario;
        private ConnectionDB db;

        public ModificarUsuarioController(FRM_ModificarUsuario frm_ModificarUsuario)
        {
            this.frm_ModificarUsuario = frm_ModificarUsuario;
            db = new ConnectionDB();
            AgregarEventosModificarUsuario();
        }

        private void AgregarEventosModificarUsuario()
        {
            frm_ModificarUsuario.btnVerificarUsuario.Click += new EventHandler(VerificarUsuario);
            frm_ModificarUsuario.txtUsuario.KeyDown += new KeyEventHandler(VerificarUsuarioEnter);
            frm_ModificarUsuario.btnVerificarContrasenia.Click += new EventHandler(VerificarContrasenia);
            frm_ModificarUsuario.txtContraseniaActual.KeyDown += new KeyEventHandler(VerificarContraseniaEnter);
            frm_ModificarUsuario.btnModificar.Click += new EventHandler(ModificarUsuario);
            frm_ModificarUsuario.btnLimpiar.Click += new EventHandler(Limpiar);
            frm_ModificarUsuario.cbMostrarContrasenia.CheckedChanged += new EventHandler(MostrarContrasenia);
        }

        private void MostrarContrasenia(object sender, EventArgs e) {
            frm_ModificarUsuario.MostrarContrasenia();
        }

        private void VerificarUsuario(object sender, EventArgs e) {
            VerificarUsuario();
        }

        private void VerificarUsuarioEnter(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                VerificarUsuario();
                e.SuppressKeyPress = true; //remove ding windows sound.
            }
        }

        private void VerificarUsuario() {
            if (!frm_ModificarUsuario.VerificarUsuario()) {
                if (db.ExisteUsuario(frm_ModificarUsuario.txtUsuario.Text)) {
                    frm_ModificarUsuario.LlenarRol(db.GetUsuario(frm_ModificarUsuario.txtUsuario.Text));
                    frm_ModificarUsuario.ActivarContraseniaActual();
                }
                else
                    frm_ModificarUsuario.ShowMessage("El usuario ingresado no existe en los registros.", "Mensaje");
            }
            else
                frm_ModificarUsuario.ShowMessage("El campo de usuario no puede estar vacido.", "Mensaje");
        }

        private void VerificarContrasenia(object sender, EventArgs e) {
            VerificarContrasenia();
        }

        private void VerificarContraseniaEnter(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                VerificarContrasenia();
                e.SuppressKeyPress = true; //remove ding windows sound.
            }
        }

        private void VerificarContrasenia() {
            if (frm_ModificarUsuario.CheckPassword())
                frm_ModificarUsuario.ActivarContraseniaNueva();
            else
                frm_ModificarUsuario.ShowMessage("La contraseña actual es incorrecta.", "Advertencia");
        }

        private void Limpiar(object sender, EventArgs e) {
            frm_ModificarUsuario.EstadoInicial();
        }

        private void ModificarUsuario(object sender, EventArgs e) {
            if (!frm_ModificarUsuario.VerificarCampos()) {
                if (frm_ModificarUsuario.ShowConfirmation()) {
                    if (db.UpdateUsuario(frm_ModificarUsuario.GetUsuario())) {
                        frm_ModificarUsuario.EstadoInicial();
                        frm_ModificarUsuario.ShowMessage("Se ha modificado el usuario con éxito", "Mensaje");
                    }
                    else
                        frm_ModificarUsuario.ShowMessage("Ha ocurrido un error.", "Advertencia");
                }
            }
            else
                frm_ModificarUsuario.ShowMessage("Verifique los datos.", "Advertencia");
        }

    }
}
