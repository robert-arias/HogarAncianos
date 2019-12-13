using HogarAncianos.Model;
using HogarAncianos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HogarAncianos.Controller {

    public class ModificarEmpleadoController {

        FRM_ModificarEmpleado frm_ModificarEmpleado;
        ConnectionDB db;

        public ModificarEmpleadoController(FRM_ModificarEmpleado frm_ModificarEmpleado) {
            this.frm_ModificarEmpleado = frm_ModificarEmpleado;
            db = new ConnectionDB();
            AgregarEventos();
        }

        private void AgregarEventos() {
            frm_ModificarEmpleado.btnVerificar.Click += new EventHandler(VerificarCedula);
            frm_ModificarEmpleado.btnLimpiar.Click += new EventHandler(EstadoInicial);
            frm_ModificarEmpleado.btnAgregarCorreo.Click += new EventHandler(AgregarCorreo);
            frm_ModificarEmpleado.btnEliminarCorreo.Click += new EventHandler(EliminarCorreo);
            frm_ModificarEmpleado.btnModificar.Click += new EventHandler(ModificarEmpleado);
            frm_ModificarEmpleado.txtCedula.KeyDown += new KeyEventHandler(VerificarCedulaEnter);
            frm_ModificarEmpleado.txtCorreo.KeyDown += new KeyEventHandler(AgregarCorreoEnter);
        }

        private void VerificarCedula(object sender, EventArgs e) {
            VerificandoCedula();
        }

        private void VerificarCedulaEnter(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                VerificandoCedula();
        }

        private void EstadoInicial(object sender, EventArgs e) {
            frm_ModificarEmpleado.EstadoInicial();
        }

        private void AgregarCorreo(object sender, EventArgs e) {
            frm_ModificarEmpleado.AgregarCorreo();
        }

        private void AgregarCorreoEnter(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                frm_ModificarEmpleado.AgregarCorreo();
                e.SuppressKeyPress = true; //remove ding windows sound.
            }
        }

        private void EliminarCorreo(object sender, EventArgs e) {
            frm_ModificarEmpleado.EliminarCorreo();
        }

        private void ModificarEmpleado(object sender, EventArgs e) {
            if (!frm_ModificarEmpleado.VerificarCampos()) {
                if (frm_ModificarEmpleado.ShowConfirmation()) {
                    if (db.ModificarEmpleado(frm_ModificarEmpleado.GetEmpleado())) {
                        frm_ModificarEmpleado.ShowMessage("Se ha modificado el empleado con éxito.");
                        frm_ModificarEmpleado.EstadoInicial();
                    }
                    else
                        frm_ModificarEmpleado.ShowMessage("Se ha producido un error.\nVerifique los datos.");
                }
            }
            else {
                frm_ModificarEmpleado.ShowMessage("Algunos campos se encuentran vacíos." +
                    "\nLos campos con el asterisco (*) rojo son aquellos que deben ser modificados.");
            }
        }

        private void VerificandoCedula() {
            if (!string.IsNullOrEmpty(frm_ModificarEmpleado.GetCedula()) &&
                frm_ModificarEmpleado.GetCedula().Length >= 9) {
                if (!db.ExisteCedula(frm_ModificarEmpleado.GetCedula())) {
                    frm_ModificarEmpleado.LlenarCampos(db.GetEmpleado(frm_ModificarEmpleado.GetCedula()));
                    frm_ModificarEmpleado.ActivarCampos();
                }
                else
                    frm_ModificarEmpleado.ShowMessage("La cédula de identidad ingresada no se encuentra en los " +
                        "registros.");
            }
            else
                frm_ModificarEmpleado.ShowMessage("El campo \"número de cédula\" se encuentra vacío.");
        }

    }
}
