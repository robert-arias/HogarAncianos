using System;
using HogarAncianos.Model;
using HogarAncianos.View;

namespace HogarAncianos.Controller {
    public class BuscarEmpleadosController {

        private FRM_BuscarEmpleados frm_BuscarEmpleados;
        private ConnectionDB connection;

        public BuscarEmpleadosController(FRM_BuscarEmpleados frm_BuscarEmpleados) {
            this.frm_BuscarEmpleados = frm_BuscarEmpleados;
            connection = new ConnectionDB();
            AgregarEventos();
        }

        private void AgregarEventos() {
            frm_BuscarEmpleados.rbCedula.CheckedChanged += new EventHandler(BuscarPorCedula);
            frm_BuscarEmpleados.rbNombre.CheckedChanged += new EventHandler(BuscarPorNombre_Apellidos);
            frm_BuscarEmpleados.cbPuestoTrabajo.CheckedChanged += new EventHandler(CambiarEstadoDDLs);
            frm_BuscarEmpleados.cbEstadoLaboral.CheckedChanged += new EventHandler(CambiarEstadoDDLs);
            frm_BuscarEmpleados.cbTelefono.CheckedChanged += new EventHandler(NuevoCamposResultados);
        }

        private void BuscarPorCedula(object sender, EventArgs e) {
            frm_BuscarEmpleados.DesactivarBuscarPor();
        }

        private void BuscarPorNombre_Apellidos(object sender, EventArgs e) {
            frm_BuscarEmpleados.ActivarBuscarPor();
        }

        private void CambiarEstadoDDLs(object sender, EventArgs e) {
            frm_BuscarEmpleados.CambiarEstadoDDLs();
        }

        private void NuevoCamposResultados(object sender, EventArgs e) {
            frm_BuscarEmpleados.NuevosCamposResultados();
        }

    }
}
