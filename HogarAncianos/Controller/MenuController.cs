using HogarAncianos.View;
using System;

namespace HogarAncianos.Controller {
    public class MenuController {

        private FRM_MenuPrincipal frm_MenuPrincipal;
        private FRM_AgregarEmpleado frm_AgregarEmpleado;

        public MenuController(FRM_MenuPrincipal menuPrincipal) {
            this.frm_MenuPrincipal = menuPrincipal;
            frm_AgregarEmpleado = new FRM_AgregarEmpleado();
            AgregarEventos();
        }

        private void AgregarEventos() {
            frm_MenuPrincipal.mi_EmpleadosAgregar.Click += new EventHandler(OpenAgregarEmpleado);
            frm_AgregarEmpleado.FormClosed += CerrarAgregarEmpleado;
            frm_AgregarEmpleado.btnCancelar.Click += new EventHandler(CancelarAgregar);
        }

        private void OpenAgregarEmpleado(object sender, EventArgs e) {
            frm_MenuPrincipal.Hide();
            frm_AgregarEmpleado.ShowDialog();
        }

        private void CerrarAgregarEmpleado(object sender, EventArgs e) {
            frm_AgregarEmpleado.Close();
            frm_MenuPrincipal.Show();
            frm_AgregarEmpleado.EstadoInicial();
        }

        private void CancelarAgregar(object sender, EventArgs e) {
            frm_AgregarEmpleado.Close();
            frm_MenuPrincipal.Show();
            frm_AgregarEmpleado.EstadoInicial();
        }

    }
}
