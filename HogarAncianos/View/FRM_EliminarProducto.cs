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

namespace HogarAncianos.View
{
    public partial class FRM_EliminarProducto : Form
    {

        private EliminarProductoController controller;

        public FRM_EliminarProducto()
        {
            InitializeComponent();
            controller = new EliminarProductoController(this);
        }

        public string GetIdentificador()
        {
            txbIdentificadorProducto.Text = new string(txbIdentificadorProducto.Text.Where(x => !char.IsWhiteSpace(x)
            && char.IsLetterOrDigit(x)).ToArray());
            return txbIdentificadorProducto.Text;
        }

        public void ActivarCampos()
        {
            btVerificar.Enabled = false;
            btEliminar.Enabled = true;
            btCancelar.Enabled = true;
            txbIdentificadorProducto.Enabled = true;
        }

        public void LlenarCampos(DataSet data)
        {
            txbNombre.Text = data.Tables[0].Rows[0][1].ToString();
            txbDescripcion.Text = data.Tables[0].Rows[0][3].ToString();
            if (data.Tables[0].Rows[0][2].ToString().Equals("Higiene personal"))
                rbHigienePersonal.Checked = true;
            else
                rbLimpieza.Checked = true;
            txbCantidad.Text = data.Tables[0].Rows[0][4].ToString();
        }

        public void ShowMessage(string message, string tipo)
        {
            MessageBox.Show(message, tipo);
        }

        public void EstadoInicial()
        {
            btVerificar.Enabled = true;
            btEliminar.Enabled = false;
            btCancelar.Enabled = true;
            txbIdentificadorProducto.Enabled = true;

            txbCantidad.Text = "0";
            txbDescripcion.Text = "";
            txbIdentificadorProducto.Text = "";
            txbNombre.Text = "";
        }

        public int GetCantidad()
        {
            return Convert.ToInt32(txbCantidad.Text);
        }

        public bool ShowConfirmation()
        {
            string message = "¿Desea eliminar el producto " + txbNombre.Text + "?";
            DialogResult boton = MessageBox.Show(message, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (boton == DialogResult.OK)
            {
                return true;
            }

            return false;
        }

    }
}
