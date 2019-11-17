using HogarAncianos.View;
using System;

namespace HogarAncianos.Controller {
    public class MenuController {

        private FRM_MenuPrincipal frm_MenuPrincipal;
        private FRM_AgregarEmpleado frm_AgregarEmpleado;
        private FRM_BuscarEmpleados frm_BuscarEmpleados;
        private FRM_AgregarMedicamento frm_AgregarMedicamento;
        private FRM_AgregarPaciente frm_AgregarPaciente;

        public MenuController(FRM_MenuPrincipal menuPrincipal) {
            frm_MenuPrincipal = menuPrincipal;
            frm_AgregarEmpleado = new FRM_AgregarEmpleado();
            frm_BuscarEmpleados = new FRM_BuscarEmpleados();
            frm_AgregarPaciente = new FRM_AgregarPaciente();
            frm_AgregarMedicamento = new FRM_AgregarMedicamento();
            AgregarEventos();
        }

        private void AgregarEventos() {
            frm_MenuPrincipal.mi_EmpleadosAgregar.Click += new EventHandler(OpenAgregarEmpleado);
            frm_MenuPrincipal.mi_EmpleadosBuscar.Click += new EventHandler(OpenBuscarEmpleados);
            frm_AgregarEmpleado.FormClosed += CerrarAgregarEmpleado;
            frm_BuscarEmpleados.FormClosed += CerrarBuscarEmpleados;
            frm_AgregarEmpleado.btnCancelar.Click += new EventHandler(CancelarAgregar);

            //Medicamentos 
            frm_MenuPrincipal.mi_MedicamentosAgregar.Click += new EventHandler(OpenAgregarMedicamento);
            frm_AgregarMedicamento.FormClosed += CerrarAgregarMedicamento;
           // frm_AgregarMedicamento.btnCancelar.Click += new EventHandler(CancelarAgregar);

            //Pacientes 
            frm_MenuPrincipal.mi_pacientesAgregar.Click += new EventHandler(OpenAgregarPaciente);
            frm_AgregarPaciente.FormClosed += CerrarAgregarPaciente;
            frm_AgregarPaciente.btnCancelar.Click += new EventHandler(CancelarAgregar);
        }

        private void OpenAgregarEmpleado(object sender, EventArgs e) {
            frm_MenuPrincipal.Hide();
            frm_AgregarEmpleado.ShowDialog();
        }

        private void OpenBuscarEmpleados(object sender, EventArgs e) {
            frm_MenuPrincipal.Hide();
            frm_BuscarEmpleados.ShowDialog();
        }

        private void CerrarAgregarEmpleado(object sender, EventArgs e) {
            frm_AgregarEmpleado.Close();
            frm_MenuPrincipal.Show();
            frm_AgregarEmpleado.EstadoInicial();
        }

        private void CerrarBuscarEmpleados(object sender, EventArgs e) {
            frm_BuscarEmpleados.Close();
            frm_BuscarEmpleados.EstadoInicial();
            frm_MenuPrincipal.Show();
        }

        private void CancelarAgregar(object sender, EventArgs e) {
            frm_AgregarEmpleado.Close();
            frm_MenuPrincipal.Show();
            frm_AgregarEmpleado.EstadoInicial();
        }


        //Metodos Medicamento
        private void OpenAgregarMedicamento(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_AgregarMedicamento.ShowDialog();
        }
        private void CerrarAgregarMedicamento(object sender, EventArgs e)
        {
            frm_AgregarMedicamento.Close();
            frm_MenuPrincipal.Show();
        }
        private void CancelarAgregarMedicamento(object sender, EventArgs e)
        {
            frm_AgregarMedicamento.Close();
            frm_AgregarMedicamento.Show();
         //   frm_AgregarMedicamento.EstadoInicial();
        }

        //Metodos Paciente 

        private void OpenAgregarPaciente(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_AgregarPaciente.ShowDialog();

        }
        private void CerrarAgregarPaciente(object sender, EventArgs e)
        {
            frm_AgregarPaciente.Close();
            frm_MenuPrincipal.Show();
            frm_AgregarPaciente.EstadoInicial();

        }
        private void CancelarAgregarPaciente(object sender, EventArgs e)
        {
            frm_AgregarPaciente.Close();
            frm_MenuPrincipal.Show();
            frm_AgregarPaciente.EstadoInicial();
        }



      
    }
}
