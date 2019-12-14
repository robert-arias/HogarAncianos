using HogarAncianos.Controller;
using HogarAncianos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HogarAncianos.View {
    public partial class FRM_BuscarProductos : Form {

        BuscarProductosController controller;
        ConnectionDB db;

        public FRM_BuscarProductos() {
            InitializeComponent();
            controller = new BuscarProductosController(this);
            db = new ConnectionDB();
        }

        public void ActivarFechas() {
            dtpIngreso.Enabled = true;
            dtpSalida.Enabled = true;

            rbHigiene.Enabled = false;
            rbLimipieza.Enabled = false;
            rbHigiene.Checked = true;

            txtBuscar.Enabled = true;
            txtBuscar.Text = "";

            lbHistorialSalidas.Visible = true;
            lbHistorialEntradas.Visible = true;

            dgvSalidas.Visible = true;
            dgvEntradas.Visible = true;

            LimpiarResultados();
        }

        public void ActivarTipos() {
            rbHigiene.Enabled = true;
            rbLimipieza.Enabled = true;

            dtpIngreso.Enabled = false;
            dtpSalida.Enabled = false;

            txtBuscar.Enabled = false;
            txtBuscar.Text = "Higiene personal";

            lbHistorialSalidas.Visible = false;
            lbHistorialEntradas.Visible = false;

            dgvSalidas.Visible = false;
            dgvEntradas.Visible = false;

            LimpiarResultados();
        }

        public void DesactivarCampos() {
            dtpIngreso.Enabled = false;
            dtpSalida.Enabled = false;

            rbHigiene.Enabled = false;
            rbLimipieza.Enabled = false;
            rbHigiene.Checked = true;

            txtBuscar.Enabled = true;
            txtBuscar.Text = "";

            lbHistorialSalidas.Visible = false;
            lbHistorialEntradas.Visible = false;

            dgvSalidas.Visible = false;
            dgvEntradas.Visible = false;

            LimpiarResultados();
        }

        public void ShowMessage(string message, string title) {
            MessageBox.Show(message, title);
        }

        public bool VerificarCampos() {
            if (rbIdentificador.Checked)
                txtBuscar.Text = new string(txtBuscar.Text.Where(x => !char.IsWhiteSpace(x) 
                                                            && char.IsLetterOrDigit(x)).ToArray());
            return string.IsNullOrEmpty(txtBuscar.Text);
        }

        public string GetBusqueda() {
            if (rbIdentificador.Checked)
                return $"select *  from Productos_Higiene where identificador_producto = '{txtBuscar.Text}'";
            else if (rbTipo.Checked)
                return $"select *  from Productos_Higiene where tipo_producto = '{txtBuscar.Text}'";
            else
                return $"select *  from Productos_Higiene where nombre_producto like '%{txtBuscar.Text}%'";
        }

        public string GetEntradas() {
            string query = $"select * from Inventario_Productos where identificador_producto = '{txtBuscar.Text}'";

            return dtpIngreso.Checked ? (query += $" and fecha_ingreso = '{dtpIngreso.Text}'") : query;
        }

        public string GetSalidas() {
            string query = $"select * from Salida_Productos where identificador_producto = '{txtBuscar.Text}'";

            return dtpIngreso.Checked ? (query += $" and fecha_salida = '{dtpSalida.Text}'") : query;
        }

        public void ResultadoBusqueda(DataSet resultados) {
            LimpiarResultados();
            if (resultados != null) {
                if (resultados.Tables["Productos_Higiene"].Rows.Count > 0)
                    LlenarResultadosProductos(resultados.Tables["Productos_Higiene"]);
                else
                    ShowMessage("No se han encontrado resultados para la busqueda especificada.", "Mensaje");

                if (resultados.Tables["Inventario_Productos"].Rows.Count > 0)
                    LlenarResultadosEntradas(resultados.Tables["Inventario_Productos"]);

                if (resultados.Tables["Salida_Productos"].Rows.Count > 0)
                    LlenarResultadosSalidas(resultados.Tables["Salida_Productos"]);
            }
            else
                ShowMessage("No se han encontrado resultados para la busqueda especificada.", "Mensaje");
        }

        private void LlenarResultadosProductos(DataTable resultados) {
            foreach (DataRow dataRow in resultados.Rows) {
                int i = dgvProductos.Rows.Add();
                DataGridViewRow row = dgvProductos.Rows[i];
                row.Cells["identificador"].Value = dataRow[0].ToString();
                row.Cells["nombre"].Value = dataRow[1].ToString();
                row.Cells["tipo"].Value = dataRow[2].ToString();
                row.Cells["descripcion"].Value = dataRow[3].ToString();
                row.Cells["cantidad"].Value = dataRow[4].ToString();
            }
        }

        private void LlenarResultadosEntradas(DataTable resultados) {
            foreach (DataRow dataRow in resultados.Rows) {
                int i = dgvEntradas.Rows.Add();
                DataGridViewRow row = dgvEntradas.Rows[i];
                row.Cells["fecha_ingreso"].Value = dataRow[3].ToString();
                row.Cells["cantidad_ingresada"].Value = dataRow[2].ToString();
            }
        }

        private void LlenarResultadosSalidas(DataTable resultados) {
            foreach (DataRow dataRow in resultados.Rows) {
                int i = dgvSalidas.Rows.Add();
                DataGridViewRow row = dgvSalidas.Rows[i];
                row.Cells["fecha_salida"].Value = dataRow[3].ToString();
                row.Cells["cantidad_extraida"].Value = dataRow[2].ToString();
                row.Cells["nombre_empleado"].Value = db.GetNombreCompletoEmpleado(dataRow[4].ToString());
            }
        }

        public void EstadoInicial() {
            rbIdentificador.Checked = true;
            dtpIngreso.Enabled = true;
            dtpSalida.Enabled = true;

            rbHigiene.Enabled = false;
            rbLimipieza.Enabled = false;
            rbHigiene.Checked = true;

            txtBuscar.Enabled = true;
            txtBuscar.Text = "";

            lbHistorialSalidas.Visible = true;
            lbHistorialEntradas.Visible = true;

            dgvSalidas.Visible = true;
            dgvEntradas.Visible = true;

            LimpiarResultados();
        }

        private void LimpiarResultados() {
            do {
                foreach (DataGridViewRow row in dgvProductos.Rows) {
                    dgvProductos.Rows.Remove(row);
                }
            } while (dgvProductos.Rows.Count >= 1);

            do {
                foreach (DataGridViewRow row in dgvEntradas.Rows) {
                    dgvEntradas.Rows.Remove(row);
                }
            } while (dgvEntradas.Rows.Count >= 1);

            do {
                foreach (DataGridViewRow row in dgvSalidas.Rows) {
                    dgvSalidas.Rows.Remove(row);
                }
            } while (dgvSalidas.Rows.Count >= 1);
        }

    }
}
