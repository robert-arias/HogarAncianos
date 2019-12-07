using HogarAncianos.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HogarAncianos.Controller {
    public class MenuController {

        private FRM_MenuPrincipal frm_MenuPrincipal;
        private FRM_AgregarEmpleado frm_AgregarEmpleado;
        private FRM_ModificarEmpleado frm_ModificarEmpleado;
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
            frm_ModificarEmpleado = new FRM_ModificarEmpleado();
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
            frm_MenuPrincipal.mi_EmpleadosModificar.Click += new EventHandler(OpenModificarEmpleado);
            frm_MenuPrincipal.mi_EmpleadosBuscar.Click += new EventHandler(OpenBuscarEmpleados);
            frm_MenuPrincipal.mi_EmpleadosReporte.Click += new EventHandler(OpenReporteEmpleados);
            frm_AgregarEmpleado.FormClosed += CerrarAgregarEmpleado;
            frm_ModificarEmpleado.FormClosed += CerrarModificarEmpleado;
            frm_BuscarEmpleados.FormClosed += CerrarBuscarEmpleados;
            frm_AgregarEmpleado.btnCancelar.Click += new EventHandler(CancelarAgregar);

            //Productos de Limpieza

            //Medicamentos 
          
            frm_MenuPrincipal.mi_MedicamentosAgregar.Click += new EventHandler(OpenAgregarMedicamento);
            frm_AgregarMedicamento.FormClosed += CerrarAgregarMedicamento;
            frm_AgregarMedicamento.btnCancelar.Click += new EventHandler(CancelarAgregarMedicamento);

            frm_MenuPrincipal.mi_MedicamentosModificar.Click += new EventHandler(OpenModificarMedicamento);
            frm_ModificarMedicamento.FormClosed += CerrarModificarMedicamento;
            frm_ModificarMedicamento.btnCancelar.Click += new EventHandler(CancelarModificarMedicamento);


            //Pacientes 
            frm_MenuPrincipal.mi_pacientes.DropDownItemClicked += new ToolStripItemClickedEventHandler(color);
            frm_MenuPrincipal.mi_pacientes.MouseDown += new MouseEventHandler(color);
            frm_MenuPrincipal.mi_pacientes.MouseLeave += new EventHandler(colorCambio);

            frm_MenuPrincipal.mi_pacientesAgregar.Click += new EventHandler(OpenAgregarPaciente);


            frm_AgregarPaciente.FormClosed += CerrarAgregarPaciente;
            frm_AgregarPaciente.btnCancelar.Click += new EventHandler(CancelarAgregarPaciente);

            frm_MenuPrincipal.mi_pacientesModificar.Click += new EventHandler(OpenModificarPaciente);
            frm_ModificarPaciente.FormClosed += CerrarModificarPaciente;
            frm_ModificarPaciente.btnCancelar.Click += new EventHandler(CancelarModificarPaciente);


            //Usuarios
            frm_MenuPrincipal.mi_UsuariosAgregar.Click += new EventHandler(OpenAgregarUsuarios);
            frm_AgregarUsuario.FormClosed += CerrarAgregarUsuario;
            frm_AgregarUsuario.btnCancelar.Click += new EventHandler(CancelarAgregarUsuario);

            frm_MenuPrincipal.mi_UsuariosModificar.Click += new EventHandler(OpenModificarUsuarios);
            frm_ModificarUsuario.FormClosed += CerrarModificarUsuario;
            frm_ModificarUsuario.btnCancelar.Click += new EventHandler(CancelarModificarUsuario);

            //Prescripcion Medicamentos 

            //Login 
            frm_MenuPrincipal.mi_Login_IniciarSesion.Click += new EventHandler(OpenIniciarSesion);
            frm_login.FormClosed += CerrarLogin;


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

        private void OpenModificarEmpleado(object sender, EventArgs e) {
            frm_MenuPrincipal.Hide();
            frm_ModificarEmpleado.ShowDialog();
        }

        private void OpenBuscarEmpleados(object sender, EventArgs e) {
            frm_MenuPrincipal.Hide();
            frm_BuscarEmpleados.Text = "Buscar empleados";
            frm_BuscarEmpleados.ShowDialog();
        }

        private void OpenReporteEmpleados(object sender, EventArgs e) {
            frm_MenuPrincipal.Hide();
            frm_BuscarEmpleados.Text = "Realizar reporte";
            frm_BuscarEmpleados.ShowDialog();
        }

        private void CerrarAgregarEmpleado(object sender, EventArgs e) {
            frm_AgregarEmpleado.Close();
            frm_MenuPrincipal.Show();
            frm_AgregarEmpleado.EstadoInicial();
        }

        private void CerrarModificarEmpleado(object sender, EventArgs e) {
            frm_ModificarEmpleado.Close();
            frm_MenuPrincipal.Show();
            //frm_ModificarEmpleado.EstadoInicial();
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
            frm_AgregarMedicamento.EstadoInicial();
            frm_MenuPrincipal.Show();
        }
        private void CancelarAgregarMedicamento(object sender, EventArgs e)
        {
            frm_AgregarMedicamento.Close();
            frm_AgregarMedicamento.EstadoInicial();
            frm_MenuPrincipal.Show();
            
        }

        private void OpenModificarMedicamento(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_ModificarMedicamento.ShowDialog();
        }
        private void CerrarModificarMedicamento(object sender, EventArgs e)
        {
            frm_ModificarMedicamento.Close();
          //  frm_ModificarMedicamento.EstadoInicial();
            frm_MenuPrincipal.Show();
        }
        private void CancelarModificarMedicamento(object sender, EventArgs e)
        {
            frm_ModificarMedicamento.Close();
           // frm_ModificarMedicamento.EstadoInicial();
            frm_MenuPrincipal.Show();

        }

        //Metodos Paciente 
        private void color(object sender, EventArgs e)       
        {
            frm_MenuPrincipal.mi_pacientes.ForeColor = Color.Black;
        }
        private void colorCambio(object sender, EventArgs e)
        {
            frm_MenuPrincipal.mi_pacientes.ForeColor = Color.White;
        }

        private void OpenAgregarPaciente(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_AgregarPaciente.ShowDialog();

        }
        private void CerrarAgregarPaciente(object sender, EventArgs e)
        {
            frm_AgregarPaciente.Close();
            frm_AgregarPaciente.EstadoInicial();
            frm_MenuPrincipal.Show();
           

        }

        private void CancelarAgregarPaciente(object sender, EventArgs e)
        {
            frm_AgregarPaciente.Close();
            frm_AgregarPaciente.EstadoInicial();
            frm_MenuPrincipal.Show();
            
        }

        private void OpenModificarPaciente(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_ModificarPaciente.ShowDialog();
        }

        private void CerrarModificarPaciente(object sender, EventArgs e)
        {
            frm_ModificarPaciente.Close();
            frm_MenuPrincipal.Show();
            frm_ModificarPaciente.EstadoInicial();
        }

        private void CancelarModificarPaciente(object sender, EventArgs e)
        {
            frm_ModificarPaciente.Close();
            frm_MenuPrincipal.Show();
            frm_ModificarPaciente.EstadoInicial();
        }



        //Usuarios

        private void OpenAgregarUsuarios(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_AgregarUsuario.ShowDialog();

        }

        private void CerrarAgregarUsuario(object sender, EventArgs e)
        {
            frm_AgregarUsuario.Close();
            frm_AgregarUsuario.EstadoInicial();
            frm_MenuPrincipal.Show();
        }

        private void CancelarAgregarUsuario(object sender, EventArgs e)
        {
            frm_AgregarUsuario.Close();
           frm_AgregarUsuario.EstadoInicial();
            frm_MenuPrincipal.Show();
        }

        private void OpenModificarUsuarios(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_ModificarUsuario.ShowDialog();

        }

        private void CerrarModificarUsuario(object sender, EventArgs e)
        {
            frm_ModificarUsuario.Close();
            frm_ModificarUsuario.EstadoInicial();
            frm_MenuPrincipal.Show();
        }

        private void CancelarModificarUsuario(object sender, EventArgs e)
        {
            frm_ModificarUsuario.Close();
            frm_ModificarUsuario.EstadoInicial();
            frm_MenuPrincipal.Show();
        }

    }
}
