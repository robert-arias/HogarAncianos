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

        public void NuevosCamposResultados() {
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

        public void ActivarBuscarPor() {
            dtpFechaContratacion.Enabled = true;
            cbPuestoTrabajo.Enabled = true;
            cbEstadoLaboral.Enabled = true;
        }
    }
}
