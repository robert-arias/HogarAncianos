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
            return new Medicamento(txtCodigo.Text, txtNombre.Text, txtMedida.Text, cbCategoria.SelectedItem.ToString(),
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
            txtCantidadDisponible.Enabled = true;
           

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
            txtCantidadDisponible.Enabled = false;
            txtCantidadPrescrita.Enabled = false;

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtMedida.Text = "";
            cbCategoria.SelectedIndex = 0;
            txtCantidadDisponible.Text = "";
           

            btnAgregar.Enabled = false;
            btnVerificar.Enabled = true;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = true;


            lbCodigo.ForeColor = Color.Black;
            lbNombre.ForeColor = Color.Black;
            txtMedida.ForeColor = Color.Black;
            cbCategoria.ForeColor = Color.Black;
            txtCantidadDisponible.ForeColor = Color.Black;
            txtCantidadPrescrita.ForeColor = Color.Black;

            lbCodigo.Visible = false;
            lbNombre.Visible = false;
            lbUnidadMedida.Visible = false;
            lbCategoria.Visible = false;
            lbCantidadDisponible.Visible = false;
            lbCantidadPrescrita.Visible = false;
        }

        public bool VerificarCampos()
        {
            bool vacio = false;

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                lbCodigo.Visible = true;
                lbCodigo.ForeColor = Color.Red;

                vacio = true;
            }
            else
            {
                lbCodigo.Visible = false;
                lbCodigo.ForeColor = Color.Black;
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


            if (cbCategoria.SelectedIndex==0)
            {
                lbCategoria.Visible = true;
                lbCategoria.ForeColor = Color.Red;
                vacio = true;
            }
            else
            {
                lbCategoria.Visible = false;
                lbCategoria.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(txtMedida.Text))
            {
                lbUnidadMedida.Visible = true;
                lbUnidadMedida.ForeColor = Color.Red;
                vacio = true;
            }
            else
            {
                lbUnidadMedida.Visible = false;
                lbUnidadMedida.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(txtCantidadDisponible.Text))
            {
                
                lbCantidadDisponible.Visible = true;
                lbCantidadDisponible.ForeColor = Color.Red;              
                vacio = true;

            }
            else
            {
                lbCantidadDisponible.Visible = false;
                lbCantidadDisponible.ForeColor = Color.Black;
            }
          

            return vacio;
        }



    }
}
