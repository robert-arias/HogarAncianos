using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HogarAncianos.Controller;
using HogarAncianos.Model;

namespace HogarAncianos.View
{
    public partial class FRM_ModificarProductosHigiene : Form
    {
        private ModificarProductoHigieneController modificarProductoHigieneControlle;
        public FRM_ModificarProductosHigiene()
        {
            InitializeComponent();
            modificarProductoHigieneControlle = new ModificarProductoHigieneController(this);
        }

        public string GetIdentificador()
        {
            txbIdentificadorProducto.Text = new string(txbIdentificadorProducto.Text.Where(x => !char.IsWhiteSpace(x)
            && char.IsLetterOrDigit(x)).ToArray());
            return txbIdentificadorProducto.Text;
        }

        public void llenarCampos(DataSet data)
        {
            txbNombreProducto.Text = data.Tables[0].Rows[0][1].ToString();
            txbDescripcion.Text = data.Tables[0].Rows[0][3].ToString();
            if (data.Tables[0].Rows[0][2].ToString().Equals("Higiene personal"))
                rbHigienePersonal.Checked = true;
            else
                rbLimpieza.Checked = true;
        }

        public void EstadoInicial()
        {
            txbIdentificadorProducto.Enabled = true;
            txbNombreProducto.Enabled = false;
            txbDescripcion.Enabled = false;
            rbHigienePersonal.Enabled = false;
            rbLimpieza.Enabled = false;
            rbHigienePersonal.Checked = true;
            btModificar.Enabled = false;
            btVerificar.Enabled = true;
            btLimpiar.Enabled = true;
            btCancelar.Enabled = true;


            txbIdentificadorProducto.Text = "";
            txbNombreProducto.Text = "";
            txbDescripcion.Text = "";
            
        }


        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Advertencia");
        }

        public void ActivarCampos()
        {
            txbIdentificadorProducto.Enabled = false;
            txbNombreProducto.Enabled = true;
            txbDescripcion.Enabled = true;
            rbHigienePersonal.Enabled = true;
            rbLimpieza.Enabled = true;
            btModificar.Enabled = true;
            btVerificar.Enabled = false;
            btLimpiar.Enabled = true;
            btCancelar.Enabled = true;
        }

        public bool VerificarCampos()
        {
            return string.IsNullOrEmpty(txbNombreProducto.Text) || string.IsNullOrEmpty(txbDescripcion.Text);
           

        }

        public Productos_Higiene GetProductoHigiene()
        {
            string tipo;
            if (rbHigienePersonal.Checked)
                tipo = "Higiene personal";
            else
                tipo = "Limpieza";
            return new Productos_Higiene(txbIdentificadorProducto.Text, txbNombreProducto.Text, tipo,
                txbDescripcion.Text, 0);
        }

        public bool ShowConfirmation()
        {
            string message = "¿Desea modificar el producto " + txbNombreProducto.Text + "?";
            DialogResult boton = MessageBox.Show(message, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (boton == DialogResult.OK)
            {
                return true;
            }

            return false;
        }


    }
}
