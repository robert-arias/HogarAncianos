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
    public partial class FRM_AgregarMedicamento : Form
    {
        private AgregarMedicamentoController agregarMedicamentoController;
        public FRM_AgregarMedicamento()
        {
            InitializeComponent();
            agregarMedicamentoController = new AgregarMedicamentoController(this);
            EstadoInicial();
        }

        public Medicamento GetMedicamento()
        {         
            return new Medicamento(txtCodigo.Text, txtNombre.Text, txtMedida.Text +"  "+cbUnidadMedida.SelectedItem  , cbCategoria.SelectedItem.ToString(),
            Convert.ToInt32(txtCantidadDisponible.Text), Convert.ToInt32(txtCantidadPrescrita.Text));

        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Advertencia");
        }

        public bool ShowMessage2(string menssage)
        {
            DialogResult boton = MessageBox.Show(menssage, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (boton == DialogResult.OK)
            {
                return true;
            }

            return false;
        }
        public string GetCodigo()
        {
            return txtCodigo.Text;
        }

        public void ActivarCampos()
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = true;
            txtMedida.Enabled = true;
            cbCategoria.Enabled = true;
            txtNombre.Enabled = true;
            txtCantidadDisponible.Enabled = true;
            cbUnidadMedida.Enabled = true;
            btnAgregar.Enabled = true;
            btnVerificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

        }

        public void EstadoInicial()
        {
            txtCodigo.Enabled = true;
            txtNombre.Enabled = false;
            txtMedida.Enabled = false;
            cbCategoria.Enabled = false;
            txtMedida.Enabled = false;
            txtCantidadPrescrita.Enabled = false;
            cbUnidadMedida.Enabled = false;
            cbUnidadMedida.SelectedIndex = 0;
            txtCantidadDisponible.Enabled = false;
            txtCantidadDisponible.Text = "";

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtMedida.Text = "";
            cbCategoria.SelectedIndex = 0;
            txtMedida.Text = "";
           

            btnAgregar.Enabled = false;
            btnVerificar.Enabled = true;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = true;


            

            lbCodigo.Visible = false;
            lbNombre.Visible = false;
            lbUnidadMedida.Visible = false;
            lbCategoria.Visible = false;
            lbCantidadDisponible.Visible = false;
           
        }

        public bool VerificarCampos()
        {
            bool vacio = false;

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                lbCodigo.Visible = true;
                vacio = true;
            }
            else
            {
                lbCodigo.Visible = false;
               
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


            if (cbCategoria.SelectedIndex==0)
            {
                lbCategoria.Visible = true;
             
                vacio = true;
            }
            else
            {
                lbCategoria.Visible = false;
               
            }

            if (string.IsNullOrEmpty(txtMedida.Text) && cbUnidadMedida.SelectedIndex==0 || !string.IsNullOrEmpty(txtMedida.Text) && cbUnidadMedida.SelectedIndex == 0 || 
                string.IsNullOrEmpty(txtMedida.Text) && cbUnidadMedida.SelectedIndex != 0)
            {
                lbUnidadMedida.Visible = true;
               
                vacio = true;
            }
            else
            {
                lbUnidadMedida.Visible = false;
               
            }

            if (string.IsNullOrEmpty(txtCantidadDisponible.Text))
            {
                
                lbCantidadDisponible.Visible = true;
                         
                vacio = true;

            }
            else
            {
                lbCantidadDisponible.Visible = false;
               
            }
          

            return vacio;
        }

        public bool ShowConfirmation()
        {
            string message = "¿Desea agregar el medicamento código: " + txtCodigo.Text + "  " + " nombre:  " + txtNombre.Text + " ?";
            DialogResult boton = MessageBox.Show(message, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (boton == DialogResult.OK)
            {
                return true;
            }

            return false;
        }
        public void MensajeInformativo(string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

       
        
    }
}
