using System;
using System.Windows.Forms;
using HogarAncianos.Model;
using HogarAncianos.View;

namespace HogarAncianos.Controller {
    public class AgregarEmpleadosController {

        private FRM_AgregarEmpleado frm_AgregarEmpleados;
        private ConnectionDB db;

        public AgregarEmpleadosController(FRM_AgregarEmpleado frm_AgregarEmpleados) {
            this.frm_AgregarEmpleados = frm_AgregarEmpleados;
            AgregarEventos();
            db = new ConnectionDB();
        }

        private void AgregarEventos() {
            frm_AgregarEmpleados.btnVerificar.Click += new EventHandler(VerificarCedula);
            frm_AgregarEmpleados.txtCedula.KeyDown += new KeyEventHandler(VerificarCedulaEnter);
            frm_AgregarEmpleados.btnAgregarCorreo.Click += new EventHandler(AgregarCorreo);
            frm_AgregarEmpleados.txtCorreo.KeyDown += new KeyEventHandler(AgregarCorreoEnter);
            frm_AgregarEmpleados.btnLimpiar.Click += new EventHandler(Limpiar);
        }

        private void VerificarCedula(object sender, EventArgs e) {
            //Aquí debe verificar en la base de datos si existe la cédula.
            if (!String.IsNullOrEmpty(frm_AgregarEmpleados.GetCedula()) &&
                frm_AgregarEmpleados.GetCedula().Length >= 9) {
                frm_AgregarEmpleados.ActivarCampos();
            }
            else
                frm_AgregarEmpleados.ShowMessage("El campo \"número de cédula\" se encuentra vacío.");
        }

        private void VerificarCedulaEnter(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (!String.IsNullOrEmpty(frm_AgregarEmpleados.GetCedula()) &&
                frm_AgregarEmpleados.GetCedula().Length >= 9) {
                    frm_AgregarEmpleados.ActivarCampos();
                }
                else
                    frm_AgregarEmpleados.ShowMessage("El campo \"número de cédula\" se encuentra vacío.");
                e.SuppressKeyPress = true; //remove ding windows sound.
            }
        }

        private void AgregarCorreo(object sender, EventArgs e) {
            frm_AgregarEmpleados.AgregarCorreo();
        }

        private void AgregarCorreoEnter(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                frm_AgregarEmpleados.AgregarCorreo();
                e.SuppressKeyPress = true; //remove ding windows sound.
            }
        }

        private void Limpiar(object sender, EventArgs e) {
            frm_AgregarEmpleados.EstadoInicial();
        }

    }
}
