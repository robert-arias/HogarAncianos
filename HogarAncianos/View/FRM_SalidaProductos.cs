using HogarAncianos.Controller;
using HogarAncianos.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace HogarAncianos.View {
    public partial class FRM_SalidaProductos : Form
    {
        private SalidaProductosController salidaProductosController;
        
        private Usuario usuario;

        public FRM_SalidaProductos()
        {
            InitializeComponent();
            salidaProductosController = new SalidaProductosController(this);
            usuario = null;
            
        }

        public void SetEmpleado(Usuario usuario) {
            this.usuario = usuario;
            ConnectionDB connection = new ConnectionDB();
            string nombreCompleto = connection.GetNombreCompletoEmpleado(usuario.cedula);
            txbCedula.Text = usuario.cedula;
            txbNombreCompleto.Text = nombreCompleto;
        }

        public string GetIdentificador()
        {
            txbIdentificadorProducto.Text = new string(txbIdentificadorProducto.Text.Where(x => !char.IsWhiteSpace(x)
            && char.IsLetterOrDigit(x)).ToArray());
            return txbIdentificadorProducto.Text;
        }
        public void EstadoInicial()
        { 
            txbIdentificadorProducto.Enabled = true;
            txbNombre.Enabled = false;
            rbHigienePersonal.Enabled = false;
            rbLimpieza.Enabled = false;
            rbHigienePersonal.Checked = true;
            btSustraer.Enabled = false;
            btVerificar.Enabled = true;
            btLimpiar.Enabled = true;
            dtpFecha.Enabled = false;
            txbCantidadSustraer.Enabled = false;
            txbCantidadExistente.Enabled = false;
            btCancelar.Enabled = true;

            
            txbCantidadSustraer.Text = "0";
            txbCantidadExistente.Text = "0";
            txbIdentificadorProducto.Text = "";
            txbNombre.Text = "";
            
        }
        public bool VericarCantidad()
        {
            int c = Convert.ToInt32(txbCantidadSustraer.Text);
            int e = Convert.ToInt32(txbCantidadExistente.Text);
            return (e - c) >= 0;
        }

        
        public void LlenarCampos(DataSet data)
        {
            txbNombre.Text = data.Tables[0].Rows[0][1].ToString();
            if (data.Tables[0].Rows[0][2].ToString().Equals("Higiene personal"))
                rbHigienePersonal.Checked = true;
            else
                rbLimpieza.Checked = true;

            txbCantidadExistente.Text = data.Tables[0].Rows[0][4].ToString();
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Advertencia");
        }

        public void ActivarCampos()
        {
            txbIdentificadorProducto.Enabled = true;
            txbNombre.Enabled = false;
            rbHigienePersonal.Enabled = false;
            rbLimpieza.Enabled = false;
            btSustraer.Enabled = true;
            btVerificar.Enabled = true;
            btLimpiar.Enabled = true;
            dtpFecha.Enabled = false;
            txbCantidadSustraer.Enabled = true;
            txbCantidadExistente.Enabled = false;
            btCancelar.Enabled = true;
        }

        public bool VerificarCampos()
        {

            try
            {
                Convert.ToInt32(txbCantidadSustraer.Text);
                return true;
            }
            catch (FormatException e)
            {
                return false;
            }

        }
        public bool ShowConfirmation()
        {
            string message = "¿Desea sustraer la cantidad " + txbCantidadSustraer.Text + ", \n del producto " + txbNombre.Text + "?";
            DialogResult boton = MessageBox.Show(message, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (boton == DialogResult.OK)
            {
                return true;
            }

            return false;
        }

        public Salida_Productos GetSalidaProducto()
        {
            return new Salida_Productos(txbIdentificadorProducto.Text, Convert.ToInt32(txbCantidadSustraer.Text),dtpFecha.Text,txbCedula.Text );
        }

    }
}
