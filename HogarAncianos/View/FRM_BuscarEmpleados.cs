﻿using CrystalDecisions.CrystalReports.Engine;
using HogarAncianos.Controller;
using HogarAncianos.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HogarAncianos.View {
    public partial class FRM_BuscarEmpleados : Form {

        FRM_ReporteEmpleados FRM_ReporteEmpleados;
        private BuscarEmpleadosController controller;
        private ConnectionDB db;
        private DataTable cacheBusqueda;

        public FRM_BuscarEmpleados() {
            InitializeComponent();
            cacheBusqueda = null;
            ddlPuesto.Text = "Seleccionar";
            ddlEstadoLaboral.Text = "Seleccionar";
            dgvResultados.AllowUserToResizeColumns = true;
            FRM_ReporteEmpleados = new FRM_ReporteEmpleados();
            db = new ConnectionDB();
            controller = new BuscarEmpleadosController(this, db);
        }

        public void RealizarReporte()
        {
            DataSetEmpleados dataSetEmpleados = new DataSetEmpleados();
            int fila = dgvResultados.Rows.Count - 1;
            Console.WriteLine(fila + "fila");

            if (dgvResultados.Columns.Count - 1 > 0)             
            {
                string telefono="-";
                string direccion = "-";
                string correo = "-";
                string salario="-";
                string fecha="-";

                    for (int i = 0; i <= fila; i++)
                    {

                            if (dgvResultados.Columns.Contains("Telefono"))
                            {
                                    telefono=dgvResultados["Telefono", i].Value.ToString();
                            }
                            else
                            {
                               telefono="-";
                            }

                            if (dgvResultados.Columns.Contains("Direccion"))
                            {
                                     direccion= dgvResultados["Direccion", i].Value.ToString();
                             }
                            else
                            {
                                direccion = "-";
                            }
                            if (dgvResultados.Columns.Contains("Salario"))
                            {
                                 salario= dgvResultados["Salario", i].Value.ToString();
                            }
                            else
                            {
                                salario= "-";
                            }
                           if (dgvResultados.Columns.Contains("Correos"))
                            {
                                  correo= dgvResultados["Correos", i].Value.ToString();
                            }
                            else
                            {
                               correo = "-";
                            }
                            if (dgvResultados.Columns.Contains("FechaContratacion"))
                            {
                                    fecha = dgvResultados["FechaContratacion", i].Value.ToString();
                            }
                            else
                            {
                                fecha = "-";
                            }



                    dataSetEmpleados.Tables[0].Rows.Add
                            (new object[] {

                              dgvResultados[0, i].Value.ToString(),
                              dgvResultados[1, i].Value.ToString(),
                              dgvResultados[2, i].Value.ToString(),
                              dgvResultados[3, i].Value.ToString(),
                              dgvResultados[4, i].Value.ToString(),
                              dgvResultados[5, i].Value.ToString(),
                              dgvResultados[6, i].Value.ToString(),                                                                                  
                              telefono,
                              direccion,
                              correo,
                              salario,
                              fecha


                            }
                            );
                    }


                ReportDocument report = new ReportDocument();
                string fileName = "View\\CrystalReportEmpleados.rpt";
                string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, fileName);
                Console.WriteLine(path);
                report.Load(path);
                report.SetDataSource(dataSetEmpleados);
                FRM_ReporteEmpleados.crystalReportViewer1.ReportSource = report;
                FRM_ReporteEmpleados.ShowDialog();
            }

            else
            {
                ShowMessage("No hay resultados que reportar", "Mensaje");
            }
        

           

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
                    DataGridViewColumn telefono = new DataGridViewTextBoxColumn();
                    dgvResultados.Columns.Add(telefono);
                    telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    telefono.HeaderText = "Número de teléfono";
                    telefono.MinimumWidth = 147;
                    telefono.Name = "Telefono";
                    telefono.ReadOnly = true;

                    if (cacheBusqueda != null) {
                        LimpiarBusquedas();
                        ResultadoBusqueda(cacheBusqueda);
                    }
                }
                else
                    dgvResultados.Columns.Remove("Telefono");
            }

            if (sender == cbDireccion) {
                if (cbDireccion.Checked) {
                    DataGridViewColumn direccion = new DataGridViewTextBoxColumn();
                    dgvResultados.Columns.Add(direccion);
                    direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    direccion.HeaderText = "Dirección";
                    direccion.MinimumWidth = 147;
                    direccion.Name = "Direccion";
                    direccion.ReadOnly = true;

                    if (cacheBusqueda != null) {
                        LimpiarBusquedas();
                        ResultadoBusqueda(cacheBusqueda);
                    }
                }
                else
                    dgvResultados.Columns.Remove("Direccion");
            }

            if (sender == cbSalario) {
                if (cbSalario.Checked) {
                    DataGridViewColumn salario = new DataGridViewTextBoxColumn();
                    dgvResultados.Columns.Add(salario);
                    salario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    salario.HeaderText = "Salario";
                    salario.MinimumWidth = 147;
                    salario.Name = "Salario";
                    salario.ReadOnly = true;

                    if (cacheBusqueda != null) {
                        LimpiarBusquedas();
                        ResultadoBusqueda(cacheBusqueda);
                    }
                }
                else
                    dgvResultados.Columns.Remove("Salario");
            }

            if (sender == cbFechaContratacion) {
                if (cbFechaContratacion.Checked) {
                    DataGridViewColumn fechaContratacion = new DataGridViewTextBoxColumn();
                    dgvResultados.Columns.Add(fechaContratacion);
                    fechaContratacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    fechaContratacion.HeaderText = "Fecha de contratación";
                    fechaContratacion.MinimumWidth = 147;
                    fechaContratacion.Name = "FechaContratacion";
                    fechaContratacion.ReadOnly = true;

                    if (cacheBusqueda != null) {
                        LimpiarBusquedas();
                        ResultadoBusqueda(cacheBusqueda);
                    }
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
                    correos.MinimumWidth = 200;
                    correos.Name = "Correos";
                    correos.ReadOnly = false;

                    if (cacheBusqueda != null) {
                        LimpiarBusquedas();
                        ResultadoBusqueda(cacheBusqueda);
                    }
                }
                else
                    dgvResultados.Columns.Remove("Correos");
            }
        }

        public void ShowMessage(string message, string title) {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            LimpiarBusquedas();

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

            cacheBusqueda = null;
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
            else if (rbNombre.Checked)
                return GetConditions($"select * from empleados where nombre like '%{txtBuscar.Text}%'");
            else
                return GetConditions($"select * from empleados where apellidos like '%{txtBuscar.Text}%'");
        }

        private string GetConditions(string query) {
            if (dtpFechaContratacion.Checked)
                query += $" and fecha_contratacion = '{dtpFechaContratacion.Text}'";

            if (cbPuestoTrabajo.Checked)
                query += $" and puesto_trabajo = '{ddlPuesto.GetItemText(ddlPuesto.SelectedItem)}'";

            if (cbEstadoLaboral.Checked) {
                if (ddlEstadoLaboral.SelectedIndex == 1)
                    query += $" and estado_laboral = 'A'";
                else
                    query += $" and estado_laboral = 'I'";
            }

            return query;
        }

        public void ResultadoBusqueda(DataTable resultados) {
            if (resultados != null) {
                if (resultados.Rows.Count > 0) {

                    foreach (DataRow dataRow in resultados.Rows) {
                        if (!dataRow[0].ToString().Equals("0")) {
                            cacheBusqueda = resultados;
                            int i = dgvResultados.Rows.Add();
                            DataGridViewRow row = dgvResultados.Rows[i];
                            row.Cells["Cedula"].Value = dataRow[0].ToString();
                            row.Cells["Nombre"].Value = dataRow[1].ToString();
                            row.Cells["Apellidos"].Value = dataRow[2].ToString();
                            row.Cells["FechaNacimiento"].Value = dataRow[3].ToString();
                            row.Cells["PuestoTrabajo"].Value = dataRow[6].ToString();
                            row.Cells["Horario"].Value = dataRow[7].ToString();
                            row.Cells["EstadoLaboral"].Value = dataRow[10].ToString();

                            if (dgvResultados.Columns.Contains("Telefono"))
                                row.Cells["Telefono"].Value = dataRow[4].ToString();
                            if (dgvResultados.Columns.Contains("Direccion"))
                                row.Cells["Direccion"].Value = dataRow[5].ToString();
                            if (dgvResultados.Columns.Contains("Salario"))
                                row.Cells["Salario"].Value = dataRow[8].ToString();
                            if (dgvResultados.Columns.Contains("FechaContratacion"))
                                row.Cells["FechaContratacion"].Value = dataRow[9].ToString();
                            if (dgvResultados.Columns.Contains("Correos")) {
                                DataTable dtCorreos = db.GetCorreosEmpleado(dataRow[0].ToString());
                                DataGridViewComboBoxCell correosCell = (row.Cells["Correos"] as DataGridViewComboBoxCell);
                                AddComboBoxCell(dtCorreos, correosCell);
                            }
                        }
                    }
                }
                else
                    ShowMessage("No se han encontrado resultados para la búsqueda especificada.", "Mensaje");
            }
            else
                ShowMessage("No se han encontrado resultados para la busqueda especificada.", "Mensaje");
        }

        private void AddComboBoxCell(DataTable correos, DataGridViewComboBoxCell ccc) {
            if (correos.Rows.Count > 0) {
                foreach (DataRow x in correos.Rows) {
                    ccc.Items.Add(x[0]);
                }
                ccc.Value = correos.Rows[0][0].ToString();
            }
            else {
                ccc.Items.Add("Sin correos.");
                ccc.Value = "Sin correos.";
            }
        }

    }
}
