using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HogarAncianos.Model;
using HogarAncianos.Controller;
namespace HogarAncianos.View
{
    public partial class FRM_AgregarPaciente : Form
    {
        private AgregarPacienteCotroller agregarPacienteCotroller;
        public FRM_AgregarPaciente()
        {
            InitializeComponent();
            agregarPacienteCotroller = new AgregarPacienteCotroller(this);
            EstadoInicial();
            cbSexo.Text = "Seleccionar";
        }

      
    public bool VerificarCampos()
       {
           bool vacio = false;

            if (string.IsNullOrEmpty(txtCedula.Text)) {
                lbCedula.Visible = true;
                lbCedula.ForeColor = Color.Red;

                vacio= true;
            }
            else
            {
                lbCedula.Visible = false;
                lbCedula.ForeColor = Color.Black;
            }
               
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                lbNombre.Visible = true;
                lbNombre.ForeColor = Color.Red;
                vacio = true;
            }
            else
            {
                lbNombre.Visible = false;
                lbNombre.ForeColor = Color.Black;
            }

         
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                lbApellidos.Visible = true;
                lbApellidos.ForeColor = Color.Red;
                vacio = true;
            }
            else
            {
                lbApellidos.Visible = false;
                lbApellidos.ForeColor = Color.Black;
            }

            if ((DateTime.Now.Year - Convert.ToDateTime(txtFechaNacimiento.Text).Year) < 18)
            {
                lbFechaNacimiento.Visible = true;
                lbFechaNacimiento.ForeColor = Color.Red;
                vacio = true;
            }
            else
            {
                lbFechaNacimiento.Visible = false;
                lbFechaNacimiento.ForeColor = Color.Black;
            }

            if (cbSexo.SelectedIndex == 0)
            {
                lbSexo.Visible = true;
                lbSexo.ForeColor = Color.Red;               
                vacio = true;
            }
            else
            {
                lbSexo.Visible = false;
                lbSexo.ForeColor = Color.Black;
            }


            return vacio ;
        }

        public string GetCedula()
        {
            return txtCedula.Text;
        }

        public void ActivarCampos()
        {
            txtCedula.Enabled = false;
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtFechaNacimiento.Enabled = true;      
            cbSexo.Enabled = true;

            btnAgregar.Enabled = true;
            btnVerificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

        }
        public void EstadoInicial()
        {
            txtCedula.Enabled = true;
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtFechaNacimiento.Enabled = false;
            txtEdad.Enabled = false;
            cbSexo.Enabled = false;

            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtFechaNacimiento.Text="" ;
            txtEdad.Text = "0";
            cbSexo.SelectedIndex = 0;


            btnAgregar.Enabled = false;
            btnVerificar.Enabled = true;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = true;


            lbCedula.ForeColor = Color.Black;
            lbNombre.ForeColor = Color.Black;
            lbApellidos.ForeColor = Color.Black;
            lbFechaNacimiento.ForeColor = Color.Black;
            lbEdad.ForeColor = Color.Black;
            lbSexo.ForeColor = Color.Black;

            lbCedula.Visible = false;
            lbNombre.Visible = false;
            lbApellidos.Visible = false;
            lbFechaNacimiento.Visible = false;
            lbSexo.Visible = false;
            lbEdad.Visible = false;
        }

        public Paciente GetPaciente()
        {
           
            return new Paciente(txtCedula.Text,txtNombre.Text,txtApellidos.Text,txtFechaNacimiento.Text,
            Convert.ToInt16(txtEdad.Text), cbSexo.SelectedItem.ToString());
            

        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK);
        }

        public bool ShowMessage2(string menssage)
        {
            DialogResult boton= MessageBox.Show(menssage, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (boton == DialogResult.OK)
            {
                return true;
            }

            return false;
        }

        private void txtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtEdad.Text = Convert.ToString( DateTime.Today.Year - txtFechaNacimiento.Value.Year);
        }
    }
}
