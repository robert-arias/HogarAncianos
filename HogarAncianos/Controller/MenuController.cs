using HogarAncianos.View;
using System;

namespace HogarAncianos.Controller {
    public class MenuController {

        //Yanily Jiménez

        private FRM_MenuPrincipal frm_MenuPrincipal;
        private FRM_AgregarEmpleado frm_AgregarEmpleado;
        private FRM_BuscarEmpleados frm_BuscarEmpleados;
        private FRM_AgregarMedicamento frm_AgregarMedicamento;
        private FRM_AgregarPaciente frm_AgregarPaciente;
        private FRM_ModificarPaciente frm_ModificarPaciente;
        private FRM_ModificarMedicamento frm_ModificarMedicamento;
        private FRM_AgregarUsuario frm_AgregarUsuario;
        private FRM_ModificarUsuario frm_ModificarUsuario;
        private FRM_Login frm_login; 

        public MenuController(FRM_MenuPrincipal menuPrincipal) {
            frm_MenuPrincipal = menuPrincipal;
            frm_AgregarEmpleado = new FRM_AgregarEmpleado();
            frm_BuscarEmpleados = new FRM_BuscarEmpleados();
            frm_AgregarPaciente = new FRM_AgregarPaciente();
            frm_AgregarMedicamento = new FRM_AgregarMedicamento();
            frm_login = new FRM_Login();
            frm_ModificarPaciente = new FRM_ModificarPaciente();
            frm_ModificarMedicamento = new FRM_ModificarMedicamento();
            frm_ModificarUsuario = new FRM_ModificarUsuario();
            frm_AgregarUsuario = new FRM_AgregarUsuario();
            AgregarEventos();
        }

        private void AgregarEventos() {
            //Empleados
            frm_MenuPrincipal.mi_EmpleadosAgregar.Click += new EventHandler(OpenAgregarEmpleado);
            frm_MenuPrincipal.mi_EmpleadosBuscar.Click += new EventHandler(OpenBuscarEmpleados);
            frm_AgregarEmpleado.FormClosed += CerrarAgregarEmpleado;
            frm_BuscarEmpleados.FormClosed += CerrarBuscarEmpleados;
            frm_AgregarEmpleado.btnCancelar.Click += new EventHandler(CancelarAgregar);

            //Productos de Limpieza

            //Medicamentos 
            frm_MenuPrincipal.mi_MedicamentosAgregar.Click += new EventHandler(OpenAgregarMedicamento);
            frm_MenuPrincipal.mi_MedicamentosModificar.Click += new EventHandler(OpenModificarMedicamento);
            frm_AgregarMedicamento.FormClosed += CerrarAgregarMedicamento;
           // frm_AgregarMedicamento.btnCancelar.Click += new EventHandler(CancelarAgregar);

            //Pacientes 
            frm_MenuPrincipal.mi_pacientesAgregar.Click += new EventHandler(OpenAgregarPaciente);
            frm_AgregarPaciente.FormClosed += CerrarAgregarPaciente;
            frm_AgregarPaciente.btnCancelar.Click += new EventHandler(CancelarAgregar);
            frm_MenuPrincipal.mi_pacientesModificar.Click += new EventHandler(OpenModificarPaciente);


            //Login 
            frm_MenuPrincipal.mi_Login_IniciarSesion.Click += new EventHandler(OpenIniciarSesion);
           frm_login.FormClosed += CerrarLogin;

            //Usuarios
            frm_MenuPrincipal.mi_UsuariosAgregar.Click += new EventHandler(OpenAgregarUsuarios);
            frm_MenuPrincipal.mi_UsuariosModificar.Click += new EventHandler(OpenModificarUsuarios);

            //Prescripcion Medicamentos 




        }

        //Metodos Login

        private void OpenIniciarSesion(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_login.ShowDialog();       
        }

        private void CerrarLogin(object sender, EventArgs e)
        {
            frm_login.Close();
            frm_MenuPrincipal.Show();
        }
        //Metodos Empleados 

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

        private void OpenModificarMedicamento(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_ModificarMedicamento.ShowDialog();
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

        private void OpenModificarPaciente(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_ModificarPaciente.ShowDialog();
        }


        //Usuarios

        private void OpenAgregarUsuarios(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_AgregarUsuario.ShowDialog();

        }

        private void OpenModificarUsuarios(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_ModificarUsuario.ShowDialog();

        }

    }
}
