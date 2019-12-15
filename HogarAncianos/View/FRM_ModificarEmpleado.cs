using HogarAncianos.Controller;
using HogarAncianos.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HogarAncianos.View {
    public partial class FRM_ModificarEmpleado : Form {

        private ModificarEmpleadoController controller;

        public FRM_ModificarEmpleado() {
            InitializeComponent();
            controller = new ModificarEmpleadoController(this);
            cbPuesto.Text = "Seleccionar";
        }

        public string GetCedula() {
            txtCedula.Text = new string(txtCedula.Text.Where(x => !char.IsWhiteSpace(x)
                                                                    && char.IsDigit(x)).ToArray());
            return txtCedula.Text;
        }

        public void ShowMessage(string message, string title) {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LlenarCampos(DataSet empleado) {
            txtNombre.Text = empleado.Tables["Empleado"].Rows[0][1].ToString();
            txtApellidos.Text = empleado.Tables["Empleado"].Rows[0][2].ToString();
            txtFechaNacimiento.Text = empleado.Tables["Empleado"].Rows[0][3].ToString();
            txtTelefono.Text = empleado.Tables["Empleado"].Rows[0][4].ToString();
            txtDireccion.Text = empleado.Tables["Empleado"].Rows[0][5].ToString();
            cbPuesto.SelectedIndex = cbPuesto.FindString(empleado.Tables["Empleado"].Rows[0][6].ToString());
            txtHorario.Text = empleado.Tables["Empleado"].Rows[0][7].ToString();
            txtSalario.Text = empleado.Tables["Empleado"].Rows[0][8].ToString();
            txtFechaContratacion.Text = empleado.Tables["Empleado"].Rows[0][9].ToString();
            if (empleado.Tables["Empleado"].Rows[0][10].ToString().Equals("A"))
                rbActivo.Checked = true;
            else
                rbInactivo.Checked = true;

            foreach(DataRow correo in empleado.Tables["Correos"].Rows) {
                int i = dgvCorreos.Rows.Add();
                DataGridViewRow row = dgvCorreos.Rows[i];
                row.Cells["Correo"].Value = correo[0].ToString();
            }
        }

        public void ActivarCampos() {
            txtCedula.Enabled = false;
            btnVerificar.Enabled = false;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            txtCorreo.Enabled = true;
            btnAgregarCorreo.Enabled = true;
            dgvCorreos.Enabled = true;
            cbPuesto.Enabled = true;
            txtHorario.Enabled = true;
            txtSalario.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminarCorreo.Enabled = true;
            rbActivo.Enabled = true;
            rbInactivo.Enabled = true;
            btnCancelar.Enabled = true;
        }

        public void EstadoInicial() {
            txtCedula.Enabled = true;
            btnVerificar.Enabled = true;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtCorreo.Enabled = false;
            btnAgregarCorreo.Enabled = false;
            dgvCorreos.Enabled = false;
            cbPuesto.Enabled = false;
            txtHorario.Enabled = false;
            txtSalario.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminarCorreo.Enabled = false;
            rbActivo.Enabled = false;
            rbInactivo.Enabled = false;
            rbActivo.Checked = true;

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

        public void EliminarCorreo() {
            try {
                int selectedIndex = dgvCorreos.CurrentCell.RowIndex;
                if (selectedIndex > -1) {
                    dgvCorreos.Rows.RemoveAt(selectedIndex);
                    dgvCorreos.Refresh(); // if needed
                }
            }
            catch (NullReferenceException) {
                ShowMessage("Debe seleccionar el correo a eliminar.", "Mensaje");
            }
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

        private bool VerificarCorreo(string correo) {
            foreach (DataGridViewRow row in dgvCorreos.Rows) {
                return row.Cells["Correo"].Value.ToString().Equals(correo);
            }
            return false;
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

        public bool VerificarCampos() {
            try {
                bool empty = false;

                if (string.IsNullOrEmpty(txtNombre.Text)) {
                    empty = true;
                    lbNombre.ForeColor = Color.Red;
                }

                if (string.IsNullOrEmpty(txtApellidos.Text)) {
                    empty = true;
                    lbApellidos.ForeColor = Color.Red;
                }

                if ((DateTime.Now.Year - Convert.ToDateTime(txtFechaNacimiento.Text).Year) < 18) {
                    empty = true;
                    lbFechaNacimiento.ForeColor = Color.Red;
                }

                if (string.IsNullOrEmpty(txtTelefono.Text)) {
                    empty = true;
                    lbTelefono.ForeColor = Color.Red;
                }

                if (string.IsNullOrEmpty(txtDireccion.Text)) {
                    empty = true;
                    lbDireccion.ForeColor = Color.Red;
                }

                if (cbPuesto.SelectedIndex == 0) {
                    empty = true;
                    lbPuesto.ForeColor = Color.Red;
                }

                if (string.IsNullOrEmpty(txtHorario.Text)) {
                    empty = true;
                    lbHorario.ForeColor = Color.Red;
                }

                if (string.IsNullOrEmpty(txtSalario.Text)) {
                    empty = true;
                    lbSalario.ForeColor = Color.Red;
                }
                Convert.ToDouble(txtSalario.Text);

                if ((DateTime.Now.Date < Convert.ToDateTime(txtFechaContratacion.Text).Date)) {
                    empty = true;
                    lbFechaContratacion.ForeColor = Color.Red;
                }

                return empty;
            }
            catch (FormatException e) {
                lbSalario.ForeColor = Color.Red;
                Debug.WriteLine(e.ToString());
                return true;
            }
        }

        public bool ShowConfirmation() {
            string message = "¿Desea modificar el empleado " + txtNombre.Text + " " + txtApellidos.Text + "?";
            DialogResult boton = MessageBox.Show(message, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (boton == DialogResult.OK) {
                return true;
            }

            return false;
        }

        public Empleado GetEmpleado() {
            string[] correos = new string[dgvCorreos.Rows.Count];

            foreach (DataGridViewRow row in dgvCorreos.Rows) {
                correos[row.Index] = row.Cells["Correo"].Value.ToString();
            }

            return new Empleado(txtCedula.Text, txtNombre.Text, txtApellidos.Text, txtFechaNacimiento.Text,
                txtTelefono.Text, txtDireccion.Text, correos, cbPuesto.GetItemText(cbPuesto.SelectedItem),
                txtHorario.Text, Convert.ToDouble(txtSalario.Text), txtFechaContratacion.Text,
                (rbActivo.Checked ? "A" : "I"));
        }

    }
}
