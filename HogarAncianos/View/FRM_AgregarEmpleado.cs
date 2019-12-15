using HogarAncianos.Controller;
using HogarAncianos.Model;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HogarAncianos.View {
    public partial class FRM_AgregarEmpleado : Form {

        private AgregarEmpleadosController agregarEmpleadosController;

        public FRM_AgregarEmpleado() {
            InitializeComponent();
            agregarEmpleadosController = new AgregarEmpleadosController(this);
            cbPuesto.Text = "Seleccionar";
        }

        public string GetCedula() {
            txtCedula.Text = new string(txtCedula.Text.Where(x => !char.IsWhiteSpace(x)
                                                                    && char.IsDigit(x)).ToArray());
            return txtCedula.Text;
        }

        public bool ShowConfirmation() {
            string message = "¿Desea agregar al empleado " + txtNombre.Text + " " + txtApellidos.Text + "?";
            DialogResult boton = MessageBox.Show(message, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (boton == DialogResult.OK) {
                return true;
            }

            return false;
        }

        public void ShowMessage(string message, string title) {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btnEliminarCorreo.Enabled = true;
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
            btnEliminarCorreo.Enabled = false;

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
            cbPuesto.SelectedIndex = 0;
            cbPuesto.Text = "Seleccionar";

            lbNombre.ForeColor = Color.White;
            lbApellidos.ForeColor = Color.White;
            lbFechaNacimiento.ForeColor = Color.White;
            lbTelefono.ForeColor = Color.White;
            lbDireccion.ForeColor = Color.White;
            lbPuesto.ForeColor = Color.White;
            lbHorario.ForeColor = Color.White;
            lbSalario.ForeColor = Color.White;

            do {
                foreach (DataGridViewRow row in dgvCorreos.Rows) {
                    dgvCorreos.Rows.Remove(row);
                }
            } while (dgvCorreos.Rows.Count >= 1);
        }

        public void AgregarCorreo() {
            if (!VerificarCorreo(txtCorreo.Text)) {
                if (!String.IsNullOrEmpty(txtCorreo.Text) && CorreoValido(txtCorreo.Text)) {
                    dgvCorreos.Rows.Add(txtCorreo.Text);
                    txtCorreo.Text = "";
                }
                else
                    ShowMessage("Correo no válido.", "Advertencia");
            }
            else
                ShowMessage("El correo ingresado ya existe en la lista.", "Mensaje");
        }

        private bool VerificarCorreo(string correo) {
            foreach (DataGridViewRow row in dgvCorreos.Rows) {
                return row.Cells["Correo"].Value.ToString().Equals(correo);
            }
            return false;
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

        public void EliminarCorreo() {
            try {
                int selectedIndex = dgvCorreos.CurrentCell.RowIndex;
                if (selectedIndex > -1) {
                    dgvCorreos.Rows.RemoveAt(selectedIndex);
                    dgvCorreos.Refresh(); // if needed
                }
            }
            catch (NullReferenceException ) {
                ShowMessage("Debe seleccionar el correo a eliminar.", "Mensaje");
            }
        }

        public bool VerificarCampos() {
            try {
                bool empty = false;

                if (string.IsNullOrEmpty(txtNombre.Text)) {
                    empty = true;
                    lbNombre.ForeColor = Color.Red;
                }
                else
                    lbNombre.ForeColor = Color.White;

                if (string.IsNullOrEmpty(txtApellidos.Text)) {
                    empty = true;
                    lbApellidos.ForeColor = Color.Red;
                }
                else
                    lbApellidos.ForeColor = Color.White;

                if ((DateTime.Now.Year - Convert.ToDateTime(txtFechaNacimiento.Text).Year) < 18) {
                    empty = true;
                    lbFechaNacimiento.ForeColor = Color.Red;
                }
                else
                    lbFechaNacimiento.ForeColor = Color.White;

                if (string.IsNullOrEmpty(txtTelefono.Text)) {
                    empty = true;
                    lbTelefono.ForeColor = Color.Red;
                }
                else
                    lbTelefono.ForeColor = Color.White;

                if (string.IsNullOrEmpty(txtDireccion.Text)) {
                    empty = true;
                    lbDireccion.ForeColor = Color.Red;
                }
                else
                    lbDireccion.ForeColor = Color.White;

                if (cbPuesto.SelectedIndex == 0) {
                    empty = true;
                    lbPuesto.ForeColor = Color.Red;
                }
                else
                    lbPuesto.ForeColor = Color.White;

                if (string.IsNullOrEmpty(txtHorario.Text)) {
                    empty = true;
                    lbHorario.ForeColor = Color.Red;
                }
                else
                    lbHorario.ForeColor = Color.White;

                if (string.IsNullOrEmpty(txtSalario.Text)) {
                    empty = true;
                    lbSalario.ForeColor = Color.Red;
                }
                else
                    lbSalario.ForeColor = Color.White;

                if ((DateTime.Now.Date < Convert.ToDateTime(txtFechaContratacion.Text).Date)) {
                    empty = true;
                    lbFechaContratacion.ForeColor = Color.Red;
                }
                else
                    lbFechaContratacion.ForeColor = Color.White;

                Convert.ToDouble(txtSalario.Text);

                return empty;
            } catch (FormatException e) {
                lbSalario.ForeColor = Color.Red;
                return true;
            }
        }

        public Empleado GetEmpleado() {
            string[] correos = new string[dgvCorreos.Rows.Count];

            foreach (DataGridViewRow row in dgvCorreos.Rows) {
                correos[row.Index] = row.Cells["Correo"].Value.ToString();
            }

            return new Empleado(txtCedula.Text, txtNombre.Text, txtApellidos.Text, txtFechaNacimiento.Text,
                txtTelefono.Text, txtDireccion.Text, correos, cbPuesto.GetItemText(cbPuesto.SelectedItem),
                txtHorario.Text, Convert.ToDouble(txtSalario.Text), txtFechaContratacion.Text, "A");
        }
    }
}
