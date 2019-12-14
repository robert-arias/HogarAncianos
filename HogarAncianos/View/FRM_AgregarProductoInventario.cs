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
    public partial class FRM_AgregarProductoInventario : Form
    {
        private AgregarProductoInventarioController agregarProductoInventarioController;
        public FRM_AgregarProductoInventario()
        {
            InitializeComponent();
            agregarProductoInventarioController = new AgregarProductoInventarioController(this);
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

        public void llenarCampos(DataSet data)
        {
            txbNombreProducto.Text = data.Tables[0].Rows[0][0].ToString();
            if (data.Tables[0].Rows[0][1].ToString().Equals("Higiene personal"))
                rbHigienePersonal.Checked = true;
            else
                rbLimpieza.Checked = true;
        }

        public void ActivarCampos()
        {
            txbIdentificadorProducto.Enabled = false;
            btAgregar.Enabled = true;
            btVerificar.Enabled = false;
            txbCantidad.Enabled = true;

        }
        public void EstadoInicial()
        {
            txbIdentificadorProducto.Enabled = true;
            txbNombreProducto.Enabled = false;
            rbHigienePersonal.Enabled = false;
            rbLimpieza.Enabled = false;
            btAgregar.Enabled = false;
            btVerificar.Enabled = true;
            btLimpiar.Enabled = false;
            rbHigienePersonal.Checked = true;
            txbCantidad.Enabled = false;

            txbIdentificadorProducto.Text = "";
            txbNombreProducto.Text = "";
            txbCantidad.Text = "0";
        }
        public bool VerificarCampos()
        {
           try
            {
                Convert.ToInt32(txbCantidad.Text);
                return true;
            }
            catch (FormatException e)
            {
                return false;
            }
        }

        public Inventario_Productos GetProductoInventario()
        {
           
            return new Inventario_Productos(txbIdentificadorProducto.Text, Convert.ToInt32(txbCantidad.Text),
                dtpFecha.Text);
        }


    }
}
