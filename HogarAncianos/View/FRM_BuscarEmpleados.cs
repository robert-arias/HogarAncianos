using HogarAncianos.Controller;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HogarAncianos.View {
    public partial class FRM_BuscarEmpleados : Form {

        private BuscarEmpleadosController controller;
        private DataSet cacheBusqueda;
        private DataSet cacheCorreos;

        public FRM_BuscarEmpleados() {
            InitializeComponent();
            cacheBusqueda = null;
            cacheCorreos = null;
            ddlPuesto.Text = "Seleccionar";
            ddlEstadoLaboral.Text = "Seleccionar";
            dgvResultados.AllowUserToResizeColumns = true;
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

            if (sender == cbCorreo) {
                if (cbCorreo.Checked) {
                    DataGridViewComboBoxColumn correos = new DataGridViewComboBoxColumn();
                    dgvResultados.Columns.Add(correos);
                    correos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    correos.HeaderText = "Correos";
                    correos.MinimumWidth = 147;
                    correos.Name = "Correos";
                    correos.ReadOnly = true;
                }
                else
                    dgvResultados.Columns.Remove("Correos");
            }
        }

        public void ShowMessage(string message) {
            MessageBox.Show(message, "Advertencia");
        }

        public void ActivarBuscarPor() {
            dtpFechaContratacion.Enabled = true;
            cbPuestoTrabajo.Enabled = true;
            cbEstadoLaboral.Enabled = true;
        }

        public void EstadoInicial() {
            txtBuscar.Text = "";
            rbCedula.Checked = true;
            DesactivarBuscarPor();
            cbTelefono.Checked = false;
            cbDireccion.Checked = false;
            cbSalario.Checked = false;
            cbCorreo.Checked = false;
            cbFechaContratacion.Checked = false;
            do {
                foreach (DataGridViewRow row in dgvResultados.Rows) {
                    dgvResultados.Rows.Remove(row);
                }
            } while (dgvResultados.Rows.Count >= 1);
            if (dgvResultados.Columns.Contains("Telefono"))
                dgvResultados.Columns.Remove("Telefono");
            if (dgvResultados.Columns.Contains("Direccion"))
                dgvResultados.Columns.Remove("Direccion");
            if (dgvResultados.Columns.Contains("Salario"))
                dgvResultados.Columns.Remove("Salario");
            if (dgvResultados.Columns.Contains("FechaContratacion"))
                dgvResultados.Columns.Remove("FechaContratacion");
            if (dgvResultados.Columns.Contains("Correos"))
                dgvResultados.Columns.Remove("Correos");
        }

        public bool VerificarCampos() {
            bool wrong = false;

            if (rbCedula.Checked)
                txtBuscar.Text = new string(txtBuscar.Text.Where(x => char.IsWhiteSpace(x)
                                                                        || char.IsDigit(x)).ToArray());

            if (string.IsNullOrEmpty(txtBuscar.Text))
                wrong = true;

            if (rbNombre.Checked || rbApellidos.Checked) {
                if (cbPuestoTrabajo.Checked && ddlPuesto.SelectedIndex == 0)
                    wrong = true;
                if (cbEstadoLaboral.Checked && ddlEstadoLaboral.SelectedIndex == 0)
                    wrong = true;
            }
            return wrong;
        }

        public void LimpiarBusquedas() {
            do {
                foreach (DataGridViewRow row in dgvResultados.Rows) {
                    dgvResultados.Rows.Remove(row);
                }
            } while (dgvResultados.Rows.Count >= 1);
        }

        public string GetBusqueda() {
            if (rbCedula.Checked)
                return $"select *  from empleados where cedula = '{txtBuscar.Text}'";
            else if (rbNombre.Checked) {
                Console.WriteLine("Entró");
                return GetConditions($"select * from empleados where nombre like '%{txtBuscar.Text}%'");
            }
            else
                return GetConditions($"select * from empleados where apellidos like '%{txtBuscar.Text}%'");
        }

        private string GetConditions(string query) {
            if (dtpFechaContratacion.Checked)
                return query += $" and fecha_contratacion = '{dtpFechaContratacion.Text}'";

            if (cbPuestoTrabajo.Checked)
                return query += $" and puesto_trabajo = '{ddlPuesto.GetItemText(ddlPuesto.SelectedItem)}'";

            if (cbEstadoLaboral.Checked) {
                if (ddlEstadoLaboral.SelectedIndex == 1)
                    query += $" and estado_laboral = 'A'";
                else
                    query += $" and estado_laboral = 'I'";

                return query;
            }

            return query;
        }

        public void RealizarBusqueda(DataSet resultados) {
            if (resultados != null) {
                if (resultados.Tables[0].Rows.Count > 0) {
                    cacheBusqueda = resultados;
                    int i = dgvResultados.Rows.Add();
                    DataGridViewRow row = dgvResultados.Rows[i];
                    row.Cells["Cedula"].Value = resultados.Tables[0].Rows[0][0].ToString();
                    row.Cells["Nombre"].Value = resultados.Tables[0].Rows[0][1].ToString();
                    row.Cells["Apellidos"].Value = resultados.Tables[0].Rows[0][2].ToString();
                    row.Cells["FechaNacimiento"].Value = resultados.Tables[0].Rows[0][3].ToString();
                    row.Cells["PuestoTrabajo"].Value = resultados.Tables[0].Rows[0][6].ToString();
                    row.Cells["Horario"].Value = resultados.Tables[0].Rows[0][7].ToString();
                    row.Cells["EstadoLaboral"].Value = resultados.Tables[0].Rows[0][10].ToString();
                }
                else
                    ShowMessage("No se han encontrado resultados");
            }
            else
                ShowMessage("No se han encontrado resultados.");
        }
    }
}
