using HogarAncianos.Controller;
using System;
using System.Windows.Forms;

namespace HogarAncianos.View {
    public partial class FRM_BuscarEmpleados : Form {

        private BuscarEmpleadosController controller;

        public FRM_BuscarEmpleados() {
            InitializeComponent();
            ddlPuesto.Text = "Seleccionar";
            ddlEstadoLaboral.Text = "Seleccionar";
            controller = new BuscarEmpleadosController(this);
        }

        public void DesactivarBuscarPor() {
            dtpFechaContratacion.Enabled = false;
            cbPuestoTrabajo.Enabled = false;
            cbEstadoLaboral.Enabled = false;

            if (dtpFechaContratacion.Checked) {
                dtpFechaContratacion.Checked = false;
            }

            if (cbPuestoTrabajo.Checked) {
                cbPuestoTrabajo.Checked = false;
                CambiarEstadoDDLs();
            }

            if (cbEstadoLaboral.Checked) {
                cbEstadoLaboral.Checked = false;
                CambiarEstadoDDLs();
            }
        }

        public void CambiarEstadoDDLs() {
            if (cbPuestoTrabajo.Checked)
                ddlPuesto.Enabled = true;
            else {
                ddlPuesto.Enabled = false;
                ddlPuesto.SelectedIndex = 0;
                ddlPuesto.Text = "Seleccionar";
            }

            if (cbEstadoLaboral.Checked)
                ddlEstadoLaboral.Enabled = true;
            else {
                ddlEstadoLaboral.Enabled = false;
                ddlEstadoLaboral.SelectedIndex = 0;
                ddlEstadoLaboral.Text = "Seleccionar";
            }
        }

        public void NuevosCamposResultados(object sender) {
            if (sender == cbTelefono) {
                if (cbTelefono.Checked) {
                    DataGridViewColumn telefono = new DataGridViewColumn();
                    dgvResultados.Columns.Add(telefono);
                    telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    telefono.HeaderText = "Número de teléfono";
                    telefono.MinimumWidth = 147;
                    telefono.Name = "Telefono";
                    telefono.ReadOnly = true;
                }
                else
                    dgvResultados.Columns.Remove("Telefono");
            }

            if (sender == cbDireccion) {
                if (cbDireccion.Checked) {
                    DataGridViewColumn direccion = new DataGridViewColumn();
                    dgvResultados.Columns.Add(direccion);
                    direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    direccion.HeaderText = "Dirección";
                    direccion.MinimumWidth = 147;
                    direccion.Name = "Direccion";
                    direccion.ReadOnly = true;
                }
                else
                    dgvResultados.Columns.Remove("Direccion");
            }

            if (sender == cbSalario) {
                if (cbSalario.Checked) {
                    DataGridViewColumn salario = new DataGridViewColumn();
                    dgvResultados.Columns.Add(salario);
                    salario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    salario.HeaderText = "Salario";
                    salario.MinimumWidth = 147;
                    salario.Name = "Salario";
                    salario.ReadOnly = true;
                }
                else
                    dgvResultados.Columns.Remove("Salario");
            }

            if (sender == cbFechaContratacion) {
                if (cbFechaContratacion.Checked) {
                    DataGridViewColumn fechaContratacion = new DataGridViewColumn();
                    dgvResultados.Columns.Add(fechaContratacion);
                    fechaContratacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    fechaContratacion.HeaderText = "Fecha de contratación";
                    fechaContratacion.MinimumWidth = 147;
                    fechaContratacion.Name = "FechaContratacion";
                    fechaContratacion.ReadOnly = true;
                }
                else
                    dgvResultados.Columns.Remove("FechaContratacion");
            }
        }

        public void ActivarBuscarPor() {
            dtpFechaContratacion.Enabled = true;
            cbPuestoTrabajo.Enabled = true;
            cbEstadoLaboral.Enabled = true;
        }
    }
}
