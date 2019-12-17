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

        public void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo se admiten números.");
            }
        }//

        public  void SoloLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo se admiten letras.");
            }
        }
        public bool VerificarCampos()
       {
           bool vacio = false;

            if (string.IsNullOrEmpty(txtCedula.Text)) {
                lbCedula.Visible = true;              
                vacio= true;
            }
            else
            {
                lbCedula.Visible = false;              
            }
               
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                lbNombre.Visible = true;              
                vacio = true;
            }
            else
            {
                lbNombre.Visible = false;               
            }

         
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                lbApellidos.Visible = true;              
                vacio = true;
            }
            else
            {
                lbApellidos.Visible = false;
                
            }

            if ((DateTime.Now.Year - Convert.ToDateTime(txtFechaNacimiento.Text).Year) < 18)
            {
                lbFechaNacimiento.Visible = true;               
                vacio = true;
            }
            else
            {
                lbFechaNacimiento.Visible = false;                
            }

            if (cbSexo.SelectedIndex == 0)
            {
                lbSexo.Visible = true;                           
                vacio = true;
            }
            else
            {
                lbSexo.Visible = false;              
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


           

            lbCedula.Visible = false;
            lbNombre.Visible = false;
            lbApellidos.Visible = false;
            lbFechaNacimiento.Visible = false;
            lbSexo.Visible = false;
            lbEdad.Visible = false;
        }


        public bool ShowConfirmation()
        {
            string message = "¿Desea agregar al paciente cédula: " + txtCedula.Text + "  " + " nombre:  " + txtNombre.Text + " ?";
            DialogResult boton = MessageBox.Show(message, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (boton == DialogResult.OK)
            {
                return true;
            }

            return false;
        }

        public Paciente GetPaciente()
        {
           
            return new Paciente(txtCedula.Text,txtNombre.Text,txtApellidos.Text,txtFechaNacimiento.Text,
            Convert.ToInt16(txtEdad.Text), cbSexo.SelectedItem.ToString());
            

        }

        public void MensajeInformativo(string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK);
        }

       

        private void txtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtEdad.Text = Convert.ToString( DateTime.Today.Year - txtFechaNacimiento.Value.Year);
        }

        private void FRM_AgregarPaciente_Load(object sender, EventArgs e)
        {

        }

        //private void groupBox1_Enter(object sender, EventArgs e)
        //{

        //}
    }
}
