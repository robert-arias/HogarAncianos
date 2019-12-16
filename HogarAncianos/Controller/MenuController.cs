using HogarAncianos.Model;
using HogarAncianos.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HogarAncianos.Controller {
    public class MenuController {

        private FRM_MenuPrincipal frm_MenuPrincipal;

        //Empleados
        private FRM_AgregarEmpleado frm_AgregarEmpleado;
        private FRM_ModificarEmpleado frm_ModificarEmpleado;
        private FRM_BuscarEmpleados frm_BuscarEmpleados;
          
        //Paciente
        private FRM_AgregarPaciente frm_AgregarPaciente;
        private FRM_ConsultaPacientes frm_ConsultaPacientes;
        private FRM_ModificarPaciente frm_ModificarPaciente;

        //Medicamentos
        private FRM_AgregarMedicamento frm_AgregarMedicamento;
        private FRM_ConsultaMedicamentos frm_ConsultaMedicamentos;
        private FRM_EliminarMedicamento frm_EliminarMedicamento;
        private FRM_ModificarMedicamento frm_ModificarMedicamento;

        //Usuarios
        private FRM_AgregarUsuario frm_AgregarUsuario;
        private FRM_ModificarUsuario frm_ModificarUsuario;
        private FRM_EliminarUsuario frm_EliminarUsuario;
        private FRM_ConsultarUsuario frm_ConsultarUsuario;

        //Productos de Higiene
        private FRM_AgregarProductoInventario frm_AgregarProductoInventario;
        private FRM_BuscarProductos frm_BuscarProducto;
        private FRM_ModificarProductosHigiene frm_ModificarProductos;
        private FRM_EliminarProducto frm_EliminarProducto;
        private FRM_AgregarProductosHigiene frm_AgregarProductosHigiene;
        private FRM_SalidaProductos frm_SalidaProductos;

        //Prescripciones 
        private FRM_AgregarPrescripcion frm_AgregarPrescripcion;
        private FRM_ModificarPrescripcion frm_ModificarPrescripcion;
        private FRM_ConsultaPrescripcion frm_ConsultaPrescripcion;
        private FRM_EliminarPrescripcion frm_EliminarPrescripcion;

        //Login
        private FRM_Login frm_Login;
        private Usuario LOGGED_USER;
               
        public MenuController(FRM_MenuPrincipal menuPrincipal) {
            frm_MenuPrincipal = menuPrincipal;
         
            //Empleados
            frm_AgregarEmpleado = new FRM_AgregarEmpleado();
            frm_ModificarEmpleado = new FRM_ModificarEmpleado();
            frm_BuscarEmpleados = new FRM_BuscarEmpleados();

            //Productos higiene
            frm_AgregarProductosHigiene = new FRM_AgregarProductosHigiene();
            frm_ModificarProductos = new FRM_ModificarProductosHigiene();
            frm_AgregarProductoInventario = new FRM_AgregarProductoInventario();
            frm_EliminarProducto = new FRM_EliminarProducto();
            frm_SalidaProductos = new FRM_SalidaProductos();
            frm_BuscarProducto = new FRM_BuscarProductos();

            //Pacientes 
            frm_AgregarPaciente = new FRM_AgregarPaciente();
            frm_ModificarPaciente = new FRM_ModificarPaciente();
            frm_ConsultaPacientes = new FRM_ConsultaPacientes();

            //Medicamentos
            frm_AgregarMedicamento = new FRM_AgregarMedicamento();
            frm_ModificarMedicamento = new FRM_ModificarMedicamento();
            frm_ConsultaMedicamentos = new FRM_ConsultaMedicamentos();
            frm_EliminarMedicamento = new FRM_EliminarMedicamento();

            //Login
            frm_Login = new FRM_Login();
         
           //Usuario
            frm_ModificarUsuario = new FRM_ModificarUsuario();
            frm_AgregarUsuario = new FRM_AgregarUsuario();
            frm_ConsultarUsuario = new FRM_ConsultarUsuario();
            frm_EliminarUsuario = new FRM_EliminarUsuario();

            //Prescripcion
            frm_EliminarPrescripcion= new  FRM_EliminarPrescripcion();
            frm_AgregarPrescripcion= new  FRM_AgregarPrescripcion();
            frm_ModificarPrescripcion= new FRM_ModificarPrescripcion();
            frm_ConsultaPrescripcion= new  FRM_ConsultaPrescripcion();

            AgregarEventos();
        }

        private void AgregarEventos() {
            //Empleados
            frm_MenuPrincipal.mi_EmpleadosAgregar.Click += new EventHandler(OpenAgregarEmpleado);
            frm_MenuPrincipal.mi_EmpleadosModificar.Click += new EventHandler(OpenModificarEmpleado);
            frm_MenuPrincipal.mi_EmpleadosBuscar.Click += new EventHandler(OpenBuscarEmpleados);
            
            frm_AgregarEmpleado.FormClosed += CerrarAgregarEmpleado;
            frm_ModificarEmpleado.FormClosed += CerrarModificarEmpleado;
            frm_BuscarEmpleados.FormClosed += CerrarBuscarEmpleados;
            frm_AgregarEmpleado.btnCancelar.Click += new EventHandler(CancelarAgregarEmpleado);
            frm_ModificarEmpleado.btnCancelar.Click += new EventHandler(CancelarModificarEmpleado);

            //Productos de Limpieza
            frm_MenuPrincipal.mi_ProductosLimpiezaAgregar.Click += new EventHandler(OpenAgregarProductoHigiene);
            frm_AgregarProductosHigiene.FormClosed += CerrarAgregarProductoHigiene;
            frm_AgregarProductosHigiene.btCancelar.Click += new EventHandler(CerrarAgregarProductoHigiene);
            frm_MenuPrincipal.mi_ProductosLimpiezaModificar.Click += new EventHandler(OpenModificarProductoHigiene);
            frm_ModificarProductos.FormClosed += CerrarModificarProductoHigiene;
            frm_ModificarProductos.btCancelar.Click += new EventHandler(CerrarModificarProductoHigiene);
            frm_MenuPrincipal.mi_ProductosLimpiezaAgregarInventario.Click += new EventHandler(OpenAgregarProductoHigieneInventario);
            frm_AgregarProductoInventario.FormClosed += CerrarAgregarProductoHigieneInventario;
            frm_AgregarProductoInventario.btCancelar.Click += new EventHandler(CerrarAgregarProductoHigieneInventario);
            frm_MenuPrincipal.mi_ProductosLimpiezaEliminar.Click += new EventHandler(OpenEliminarProductosLimpieza);
            frm_EliminarProducto.FormClosed += CerrarEliminarProductosLimpieza;
            frm_EliminarProducto.btCancelar.Click += new EventHandler(CerrarEliminarProductosLimpieza);
            frm_MenuPrincipal.mi_ProductosLimpiezaSalidaInventario.Click += new EventHandler(OpenSalidaProductosLimpieza);
            frm_SalidaProductos.FormClosed += CerrarSalidaProductosLimpieza;
            frm_SalidaProductos.btCancelar.Click += new EventHandler(CerrarSalidaProductosLimpieza);
            frm_MenuPrincipal.mi_ProductosLimpiezaBuscar.Click += new EventHandler(OpenBuscarProductos);
            frm_BuscarProducto.FormClosed += CerrarBuscarProductos;

            //Medicamentos 

            frm_MenuPrincipal.mi_MedicamentosAgregar.Click += new EventHandler(OpenAgregarMedicamento);
            frm_AgregarMedicamento.FormClosed += CerrarAgregarMedicamento;
            frm_AgregarMedicamento.btnCancelar.Click += new EventHandler(CancelarAgregarMedicamento);

            frm_MenuPrincipal.mi_MedicamentosModificar.Click += new EventHandler(OpenModificarMedicamento);
            frm_ModificarMedicamento.FormClosed += CerrarModificarMedicamento;
            frm_ModificarMedicamento.btnCancelar.Click += new EventHandler(CancelarModificarMedicamento);

            frm_MenuPrincipal.mi_MedicamentosBuscar.Click += new EventHandler(OpenConsultarMedicamentos);
            frm_ConsultaMedicamentos.FormClosed += CerrarConsultarMedicamentos;

            frm_MenuPrincipal.mi_MedicamentosEliminar.Click += new EventHandler(OpenEliminarMedicamentos);
            frm_EliminarMedicamento.FormClosed += CerrarEliminarMedicamentos;
            frm_EliminarMedicamento.btnCancelar.Click += new EventHandler(CancelarEliminarMedicamentos);

            //Pacientes
            frm_MenuPrincipal.mi_pacientesAgregar.Click += new EventHandler(OpenAgregarPaciente);
            frm_AgregarPaciente.FormClosed += CerrarAgregarPaciente;
            frm_AgregarPaciente.btnCancelar.Click += new EventHandler(CancelarAgregarPaciente);

            frm_MenuPrincipal.mi_pacientesModificar.Click += new EventHandler(OpenModificarPaciente);
            frm_ModificarPaciente.FormClosed += CerrarModificarPaciente;
            frm_ModificarPaciente.btnCancelar.Click += new EventHandler(CancelarModificarPaciente);

            frm_MenuPrincipal.mi_pacientesBuscar.Click += new EventHandler(OpenConsultarPaciente);
            frm_ConsultaPacientes.FormClosed += CerrarConsultarPaciente;

            //Usuarios
            frm_MenuPrincipal.mi_UsuariosAgregar.Click += new EventHandler(OpenAgregarUsuarios);
            frm_AgregarUsuario.FormClosed += CerrarAgregarUsuario;
            frm_AgregarUsuario.btnCancelar.Click += new EventHandler(CancelarAgregarUsuario);

            frm_MenuPrincipal.mi_UsuariosModificar.Click += new EventHandler(OpenModificarUsuarios);
            frm_ModificarUsuario.FormClosed += CerrarModificarUsuario;
            frm_ModificarUsuario.btnCancelar.Click += new EventHandler(CancelarModificarUsuario);

            frm_MenuPrincipal.mi_UsuariosBuscar.Click += new EventHandler(OpenConsultarUsuario);
            frm_ConsultarUsuario.FormClosed += CerrarConsultarUsuario;

            //Prescripcion Medicamentos 
            frm_MenuPrincipal.mi_PrescripcionBuscar.Click += new EventHandler(OpenConsultarPrescripcion);
            frm_ConsultaPrescripcion.FormClosed += CerrarConsultarPrescripcion;

            frm_MenuPrincipal.mi_PrescripcionaAgregar.Click += new EventHandler(OpenAgregarPrescripcion);
            frm_AgregarPrescripcion.FormClosed += CerrarAgregarPrescripcion;
            frm_AgregarPrescripcion.btnCancelar.Click += new EventHandler(CancelarAgregarPrescripcion);


           
           

            frm_MenuPrincipal.mi_PrescripcionModificar.Click += new EventHandler(OpenModificarPrescripcion);
            frm_ModificarPrescripcion.FormClosed += CerrarModificarPrescripcion;
            frm_ModificarPrescripcion.btnCancelar.Click += new EventHandler(CancelarModificarPrescripcion);


            //Login 
            frm_MenuPrincipal.mi_Login_IniciarSesion.Click += new EventHandler(OpenIniciarSesion);
            frm_Login.FormClosed += CerrarLogin;
            frm_MenuPrincipal.mi_Login_CerrarSesion.Click += new EventHandler(CerrarSesion);
            frm_Login.btnIniciarSesion.Click += new EventHandler(Login);
            frm_Login.txtContrasenia.KeyDown += new KeyEventHandler(LoginEnter);
        }

        //Metodos Login

        private void OpenIniciarSesion(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_Login.ShowDialog();       
        }

        private void CerrarLogin(object sender, EventArgs e)
        {
            frm_Login.Close();
            frm_MenuPrincipal.Show();
            frm_Login.EstadoInicial();
            LOGGED_USER = frm_Login.GetUsuario();
            EnableMenuItems();
            if (LOGGED_USER != null)
                frm_MenuPrincipal.lbUsuario.Text = "Usuario: " + LOGGED_USER.nombreUsuario;
        }

        private void CerrarSesion(object sender, EventArgs e) {
            if (LOGGED_USER != null) {
                string message = "¿Seguro que desea cerrar sesión?";
                DialogResult boton = MessageBox.Show(message, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (boton == DialogResult.OK) {
                    LOGGED_USER = null;
                    DisableMenuItems();
                    frm_Login.SetUsuario();
                    frm_MenuPrincipal.lbUsuario.Text = "";
                }
                LOGGED_USER = frm_Login.GetUsuario();
                EnableMenuItems();
            }
            else
                MessageBox.Show("No ha iniciado sesión.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Login(object sender, EventArgs e) {
            if (frm_Login.IniciarSesion()) {
                frm_Login.Close();
                frm_MenuPrincipal.Show();
                LOGGED_USER = frm_Login.GetUsuario();
                EnableMenuItems();
                if (LOGGED_USER != null)
                    frm_MenuPrincipal.lbUsuario.Text = "Usuario: " + LOGGED_USER.nombreUsuario;
            }
        }

        private void LoginEnter(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (frm_Login.IniciarSesion()) {
                    frm_Login.Close();
                    frm_MenuPrincipal.Show();
                    LOGGED_USER = frm_Login.GetUsuario();
                    EnableMenuItems();
                    if (LOGGED_USER != null)
                        frm_MenuPrincipal.lbUsuario.Text = "Usuario: " + LOGGED_USER.nombreUsuario;
                }
                e.SuppressKeyPress = true; //remove ding windows sound.
            }
        }

        //Metodos limpieza
        private void OpenAgregarProductoHigiene(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_AgregarProductosHigiene.ShowDialog();
        }

        private void CerrarAgregarProductoHigiene(object sender, EventArgs e)
        {
            frm_AgregarProductosHigiene.Close();
            frm_MenuPrincipal.Show();
            frm_AgregarProductosHigiene.EstadoInicial();
        }
        private void CerrarModificarProductoHigiene(object sender, EventArgs e)
        {
            frm_ModificarProductos.Close();
            frm_MenuPrincipal.Show();
            frm_ModificarProductos.EstadoInicial();
        }

        private void OpenModificarProductoHigiene(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_ModificarProductos.ShowDialog();
        }

        private void OpenAgregarProductoHigieneInventario(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_AgregarProductoInventario.ShowDialog();
        }

        private void OpenEliminarProductosLimpieza(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_EliminarProducto.ShowDialog();
        }

        private void OpenSalidaProductosLimpieza(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_SalidaProductos.SetEmpleado(LOGGED_USER);
            frm_SalidaProductos.ShowDialog();
        }

        private void OpenBuscarProductos(object sender, EventArgs e) {
            frm_MenuPrincipal.Hide();
            frm_BuscarProducto.ShowDialog();
        }

        private void CerrarSalidaProductosLimpieza(object sender, EventArgs e)
        {
            frm_SalidaProductos.Close();
            frm_MenuPrincipal.Show();
            frm_SalidaProductos.EstadoInicial();
        }

        private void CerrarBuscarProductos(object sender, EventArgs e) {
            frm_BuscarProducto.Close();
            frm_MenuPrincipal.Show();
            frm_BuscarProducto.EstadoInicial();
        }

        private void CerrarAgregarProductoHigieneInventario(object sender, EventArgs e)
        {
            frm_AgregarProductoInventario.Close();
            frm_MenuPrincipal.Show();
           frm_AgregarProductoInventario.EstadoInicial();
        }

        private void CerrarEliminarProductosLimpieza(object sender, EventArgs e)
        {
            frm_EliminarProducto.Close();
            frm_MenuPrincipal.Show();
            frm_EliminarProducto.EstadoInicial();
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
            frm_ModificarEmpleado.EstadoInicial();
        }

        private void CerrarBuscarEmpleados(object sender, EventArgs e) {
            frm_BuscarEmpleados.Close();
            frm_BuscarEmpleados.EstadoInicial();
            frm_MenuPrincipal.Show();
        }

        private void CancelarAgregarEmpleado(object sender, EventArgs e) {
            frm_AgregarEmpleado.Close();
            frm_MenuPrincipal.Show();
            frm_AgregarEmpleado.EstadoInicial();
        }

        private void CancelarModificarEmpleado(object sender, EventArgs e) {
            frm_ModificarEmpleado.Close();
            frm_MenuPrincipal.Show();
            frm_ModificarEmpleado.EstadoInicial();
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
          frm_ModificarMedicamento.EstadoInicial();
            frm_MenuPrincipal.Show();
        }
        private void CancelarModificarMedicamento(object sender, EventArgs e)
        {
            frm_ModificarMedicamento.Close();
            frm_ModificarMedicamento.EstadoInicial();
            frm_MenuPrincipal.Show();

        }

        private void OpenConsultarMedicamentos(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_ConsultaMedicamentos.ShowDialog();

        }

        private void CerrarEliminarMedicamentos(object sender, EventArgs e)
        {
            frm_EliminarMedicamento.Close();
           
            frm_MenuPrincipal.Show();
            frm_EliminarMedicamento.EstadoInicial();
        }

        private void CancelarEliminarMedicamentos(object sender, EventArgs e)
        {
            frm_EliminarMedicamento.Close();
           
            frm_MenuPrincipal.Show();
            frm_EliminarMedicamento.EstadoInicial();
        }


        private void OpenEliminarMedicamentos(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_EliminarMedicamento.ShowDialog();

        }

        private void CerrarConsultarMedicamentos(object sender, EventArgs e)
        {
            frm_ConsultaMedicamentos.Close();
            frm_MenuPrincipal.Show();
        }





        //Metodos Paciente 
        private void OpenConsultarPaciente(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_ConsultaPacientes.ShowDialog();

        }

        private void CerrarConsultarPaciente(object sender, EventArgs e)
        {
            frm_ConsultaPacientes.Close();
            frm_MenuPrincipal.Show();
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



        private void OpenConsultarUsuario(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_ConsultarUsuario.ShowDialog();

        }

        private void CerrarConsultarUsuario(object sender, EventArgs e)
        {
            frm_ConsultarUsuario.Close();
            frm_ConsultarUsuario.EstadoInicial();
            frm_MenuPrincipal.Show();
        }


        //Prescripciones 
        private void OpenConsultarPrescripcion(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_ConsultaPrescripcion.ShowDialog();

        }

        private void CerrarConsultarPrescripcion(object sender, EventArgs e)
        {
            frm_ConsultaPrescripcion.Close(); 
            frm_MenuPrincipal.Show();
        }

        private void OpenAgregarPrescripcion(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_AgregarPrescripcion.ShowDialog();

        }

        private void CerrarAgregarPrescripcion(object sender, EventArgs e)
        {
            frm_AgregarPrescripcion.Close();
            frm_MenuPrincipal.Show();
            frm_AgregarPrescripcion.EstadoInicial();
        }


        private void CancelarAgregarPrescripcion(object sender, EventArgs e)
        {
            frm_AgregarPrescripcion.Close();
            frm_MenuPrincipal.Show();
            frm_AgregarPrescripcion.EstadoInicial();
        }
      

        private void OpenEliminarPrescripcion(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_EliminarPrescripcion.ShowDialog();

        }

        private void CerrarEliminarPrescripcion(object sender, EventArgs e)
        {
            frm_EliminarPrescripcion.Close();
            frm_MenuPrincipal.Show();
        }

        private void OpenModificarPrescripcion(object sender, EventArgs e)
        {
            frm_MenuPrincipal.Hide();
            frm_ModificarPrescripcion.ShowDialog();

        }

        private void CerrarModificarPrescripcion(object sender, EventArgs e)
        {
            frm_ModificarPrescripcion.Close();
            frm_MenuPrincipal.Show();
            frm_ModificarPrescripcion.EstadoInicial();
        }

        private void CancelarModificarPrescripcion(object sender, EventArgs e)
        {
            frm_ModificarPrescripcion.Close();
            frm_MenuPrincipal.Show();
            frm_ModificarPrescripcion.EstadoInicial();
        }


        private void EnableMenuItems() {
            /*
             * CAMBIAR ESTO, VERIFICAR DE MEJOR MANERA, PRINCIPALMENTE CUANDO EL USUARIO NO ES NI ADMIN NI ENFERMERA
             * SOLO PUEDE SACAR PRODUCTOS E INGRESARLOS, DEBO PONER LOS OTROS MI ESCONDIDOS.
             */

            if (LOGGED_USER != null) {
                ConnectionDB db = new ConnectionDB();
                string rol = db.GetPuestoTrabajo(LOGGED_USER.cedula);
                if (LOGGED_USER.cedula.Equals("0") || rol.Equals("Administradora")) {
                    frm_MenuPrincipal.mi_Empleados.Visible = true;
                    frm_MenuPrincipal.mi_ProductosLimpieza.Visible = true;
                    frm_MenuPrincipal.mi_pacientes.Visible = true;
                    frm_MenuPrincipal.mi_Medicamentos.Visible = true;
                    frm_MenuPrincipal.mi_Prescripcion.Visible = true;
                    frm_MenuPrincipal.mi_Usuarios.Visible = true;
                }
                else if (rol.Equals("Enfermera")) {
                    frm_MenuPrincipal.mi_pacientes.Visible = true;
                    frm_MenuPrincipal.mi_Medicamentos.Visible = true;
                    frm_MenuPrincipal.mi_Prescripcion.Visible = true;
                }
                else
                    frm_MenuPrincipal.mi_ProductosLimpieza.Visible = true;
            }
        }

        private void DisableMenuItems() {
            frm_MenuPrincipal.mi_Empleados.Visible = false;
            frm_MenuPrincipal.mi_ProductosLimpieza.Visible = false;
            frm_MenuPrincipal.mi_pacientes.Visible = false;
            frm_MenuPrincipal.mi_Medicamentos.Visible = false;
            frm_MenuPrincipal.mi_Prescripcion.Visible = false;
            frm_MenuPrincipal.mi_Usuarios.Visible = false;
        }

    }
}
