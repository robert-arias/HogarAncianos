using HogarAncianos.Controller;
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

        public FRM_BuscarProductos() {
            InitializeComponent();
            controller = new BuscarProductosController(this);
        }

        public void ActivarFechas() {
            dtpIngreso.Enabled = true;
            dtpSalida.Enabled = true;

            rbHigiene.Enabled = false;
            rbLimipieza.Enabled = false;
            rbHigiene.Checked = true;

            txtBuscar.Enabled = true;
            txtBuscar.Text = "";
        }

        public void ActivarTipos() {
            rbHigiene.Enabled = true;
            rbLimipieza.Enabled = true;

            dtpIngreso.Enabled = false;
            dtpSalida.Enabled = false;

            txtBuscar.Enabled = false;
            txtBuscar.Text = "Higiene personal";
        }

        public void DesactivarCampos() {
            dtpIngreso.Enabled = false;
            dtpSalida.Enabled = false;

            rbHigiene.Enabled = false;
            rbLimipieza.Enabled = false;
            rbHigiene.Checked = true;

            txtBuscar.Enabled = true;
            txtBuscar.Text = "";
        }

    }
}
