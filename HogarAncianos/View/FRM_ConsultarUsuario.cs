using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using HogarAncianos.Controller;
using HogarAncianos.Model;

namespace HogarAncianos.View
{
    public partial class FRM_ConsultarUsuario : Form
    {
        private BuscarUsuarioController controller;
        private FRM_ReporteUsuarioPrueba reporteUsuarioPrueba;
        private ConnectionDB db;

        public FRM_ConsultarUsuario()
        {
            InitializeComponent();
            controller = new BuscarUsuarioController(this);
            reporteUsuarioPrueba = new FRM_ReporteUsuarioPrueba();
            db = new ConnectionDB();
        }

        public bool VerificarCampos() {
            if (rbUsuario.Checked) {
                txtBuscar.Text = new string(txtBuscar.Text.Where(x => !char.IsWhiteSpace(x)).ToArray());
                return string.IsNullOrEmpty(txtBuscar.Text);
            }
            else {
                txtBuscar.Text = new string(txtBuscar.Text.Where(x => !char.IsWhiteSpace(x)
                                                                    && char.IsDigit(x)).ToArray());
                return string.IsNullOrEmpty(txtBuscar.Text);
            }
        }

        public void ShowMessage(string message) {
            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string GetBusqueda() {
            if (rbUsuario.Checked)
                return $"select usuario, cedula_empleado from usuarios where usuario = '{txtBuscar.Text}'";
            else
                return $"select usuario, cedula_empleado from usuarios where cedula_empleado = '{txtBuscar.Text}'";
        }

        public void LlenarCampos(DataTable resultados) {
            LimpiarResultados();
            if (resultados != null) {
                if (resultados.Rows.Count > 0) {
                    foreach(DataRow dataRow in resultados.Rows) {
                        int i = dgvUsuarios.Rows.Add();
                        DataGridViewRow row = dgvUsuarios.Rows[i];
                        row.Cells["Usuario"].Value = dataRow[0].ToString();
                        DataTable empleado = db.GetEmpleadoUsuario(dataRow[1].ToString());
                        row.Cells["Rol"].Value = empleado.Rows[0][3].ToString();
                        row.Cells["Empleado"].Value = empleado.Rows[0][1].ToString() + " " + empleado.Rows[0][2].ToString();
                    }
                }
                else
                    ShowMessage("No se han encontrado resultados.");
            }
        }

        public void EstadoInicial() {
            txtBuscar.Text = "";
            LimpiarResultados();
        }

        private void LimpiarResultados() {
            do {
                foreach (DataGridViewRow row in dgvUsuarios.Rows) {
                    dgvUsuarios.Rows.Remove(row);
                }
            } while (dgvUsuarios.Rows.Count >= 1);
        }

            public void RealizarReporte() {
            DataSetUsuario dataSetUsuario = new DataSetUsuario();
            int fila = dgvUsuarios.Rows.Count - 2;   
            for (int i = 0; i <= fila; i++) {
                dataSetUsuario.Tables[0].Rows.Add
                    (new object[] {    dgvUsuarios[0, i].Value.ToString(),
                           dgvUsuarios[1, i].Value.ToString(),
                           dgvUsuarios[2, i].Value.ToString()}
                    );
            }

            ReportDocument report = new ReportDocument();
            string fileName = "View\\CrystalReportsUsuario.rpt";
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, fileName);
            Console.WriteLine(path);
            report.Load(path);
            report.SetDataSource(dataSetUsuario);
            reporteUsuarioPrueba.crystalReportViewer1.ReportSource = report;
            reporteUsuarioPrueba.ShowDialog();
        }

    }
}
