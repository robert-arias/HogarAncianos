using HogarAncianos.Controller;
using System;
using System.Windows.Forms;

namespace HogarAncianos.View {
    public partial class FRM_AgregarEmpleado : Form {

        private AgregarEmpleadosController agregarEmpleadosController;

        public FRM_AgregarEmpleado() {
            InitializeComponent();
            agregarEmpleadosController = new AgregarEmpleadosController(this);
            //int index = cbPuesto.FindString("Seleccionar");
            cbPuesto.Text = "Seleccionar";
        }

        public string GetCedula() {
            return txtCedula.Text;
        }

        public void ShowMessage(string message) {
            MessageBox.Show(message);
        }

        public void ActivarCampos() {
            txtCedula.Enabled = false;
            btnVerificar.Enabled = false;
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtFechaNacimiento.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            txtCorreo.Enabled = true;
            btnAgregarCorreo.Enabled = true;
            dgvCorreos.Enabled = true;
            cbPuesto.Enabled = true;
            txtHorario.Enabled = true;
            txtSalario.Enabled = true;
            txtFechaContratacion.Enabled = true;
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        public void EstadoInicial() {
            txtCedula.Enabled = true;
            btnVerificar.Enabled = true;
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtFechaNacimiento.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtCorreo.Enabled = false;
            btnAgregarCorreo.Enabled = false;
            dgvCorreos.Enabled = false;
            cbPuesto.Enabled = false;
            txtHorario.Enabled = false;
            txtSalario.Enabled = false;
            txtFechaContratacion.Enabled = false;
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;

            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtFechaNacimiento.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            btnAgregarCorreo.Text = "";
            dgvCorreos.Text = "";
            txtHorario.Text = "";
            txtSalario.Text = "";
            txtFechaContratacion.Text = "";

            do {
                foreach (DataGridViewRow row in dgvCorreos.Rows) {
                    dgvCorreos.Rows.Remove(row);
                }
            } while (dgvCorreos.Rows.Count >= 1);
        }

        public void AgregarCorreo() {
            if (!String.IsNullOrEmpty(txtCorreo.Text) && CorreoValido(txtCorreo.Text)) {
                dgvCorreos.Rows.Add(txtCorreo.Text);
                txtCorreo.Text = "";
            }
            else
                ShowMessage("Correo no válido.");
        }

        private bool CorreoValido(string correo) {
            try {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == correo;
            }
            catch {
                return false;
            }
        }
    }
}
