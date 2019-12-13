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
    public partial class FRM_AgregarProductosHigiene : Form
    {
        private  AgregarProductoHigieneController agregarProductoHigieneControlle;

        public FRM_AgregarProductosHigiene()
        {
            InitializeComponent();
            agregarProductoHigieneControlle = new AgregarProductoHigieneController(this);
        }

        public string GetIdentificador()
        {
            txbIdentificadorProducto.Text = new string(txbIdentificadorProducto.Text.Where(x => !char.IsWhiteSpace(x)
            && char.IsLetterOrDigit(x)).ToArray());
            return txbIdentificadorProducto.Text;
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
            btAgregar.Enabled = true;
            btVerificar.Enabled = true;
        }

        public void EstadoInicial()
        {
            txbIdentificadorProducto.Enabled = true;
            txbNombreProducto.Enabled = false;
            txbDescripcion.Enabled = false;
            rbHigienePersonal.Enabled = false;
            rbLimpieza.Enabled = false;
            btAgregar.Enabled = false;
            btVerificar.Enabled = true;
            btLimpiar.Enabled = false;
            rbHigienePersonal.Checked = true;

            txbIdentificadorProducto.Text = "";
            txbNombreProducto.Text = "";
            txbDescripcion.Text = "";
        }

        public bool VerificarCampos()
        {
            return string.IsNullOrEmpty(txbCantidad.Text) || string.IsNullOrEmpty(txbDescripcion.Text); 
            
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


    }
}
