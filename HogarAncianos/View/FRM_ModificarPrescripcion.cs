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
    public partial class FRM_ModificarPrescripcion : Form
    {
        ModificarPrescripcionController modificarPrescripcionController;
        public FRM_ModificarPrescripcion()
        {
            InitializeComponent();
            modificarPrescripcionController = new ModificarPrescripcionController(this);
        }

        public  void SoloNumeros(KeyPressEventArgs v)
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
















        public void EstadoInicial()
        {
            txtCedulaPaciente.Enabled = true;
            txtNombrePaciente.Enabled = false;
            txtCodigo.Enabled = false;
            txtFechaCaducidad.Enabled = false;
            txtCantidad.Enabled = false;
            txtCantidadPrescritaNueva.Enabled = false;

            txtCantidadPrescritaNueva.Text = "";
            txtCedulaPaciente.Text = "";
            txtNombrePaciente.Text = "";
            txtCodigo.Text = "";
            txtFechaCaducidad.Text = "";
            txtCantidad.Text = "";
            labelCantidadDisponible.Text = "";
            labelPrescripcion.Text = "";
            LimpiarBusquedaMedicamentos();
            LimpiarBusquedaPrescripciones();

            btnSeleccionar.Enabled = false;
            btnSeleccionarMedicamento.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;

        }

        public void ActivarCamposSeleccionPrescripcion()
        {
            btnSeleccionarMedicamento.Enabled = true;
        }

        public void ActivarCamposCedula()
        {
            btnSeleccionar.Enabled = true;
            txtCedulaPaciente.Enabled = false;
        }

        public void ActivarCamposSeleccionMedicamentos()
        {
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            txtFechaCaducidad.Enabled = true;
            txtCantidad.Enabled = false;
            txtCantidadPrescritaNueva.Enabled = true;
        }



        public void FilldtgMedicamentos(DataSet medicamentos)
        {
            dtgMedicamento.DataSource=medicamentos.Tables[0];
        }

        public int Index()
        {
            return dtgPrescripciones.CurrentCell.RowIndex;
        }

        public int GetNum()
        {
            return int.Parse(dtgPrescripciones.CurrentCell.Value.ToString());
        }

        public void llenarCampos(DataSet medicamento)
        {
            labelPrescripcion.Text= medicamento.Tables[0].Rows[0][0].ToString(); 
            txtCodigo.Text = medicamento.Tables[0].Rows[0][1].ToString(); 
            txtFechaCaducidad.Text= medicamento.Tables[0].Rows[0][2].ToString();
            txtCantidad.Text= medicamento.Tables[0].Rows[0][3].ToString();
            txtCantidadPrescritaNueva.Text = medicamento.Tables[0].Rows[0][3].ToString();

        }

        

        public string GetCodigoMedicamento(int fila)
        {
            return dtgMedicamento[1,fila].Value.ToString();
        }
        public int GetNumPrescripcion(int fila)
        {
          
            return int.Parse(dtgMedicamento[0, fila].Value.ToString());
        }




        public void FilldtgPrescripciones(DataSet prescripciones)
        {
            dtgPrescripciones.DataSource = prescripciones.Tables[0];
        }
        public void MensajeInformativo(string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool VerificarPaciente()
        {
            if (!string.IsNullOrEmpty(txtCedulaPaciente.Text) && txtCedulaPaciente.Text.Length >= 9)
            {

                return true;
            }

            return false;
        }
        public void LimpiarBusquedaPrescripciones()
        {
            do
            {
                foreach (DataGridViewRow row in dtgPrescripciones.Rows)
                {
                    dtgPrescripciones.Rows.Remove(row);
                }
            } while (dtgPrescripciones.Rows.Count >= 1);
        }

        public void LimpiarBusquedaMedicamentos()
        {
            do
            {
                foreach (DataGridViewRow row in dtgMedicamento.Rows)
                {
                    dtgMedicamento.Rows.Remove(row);
                }
            } while (dtgMedicamento.Rows.Count >= 1);
        }

        

        public string GetCedula()
        {
            return txtCedulaPaciente.Text;
        }


        public Prescripcion_Medicamentos GetMedicamentoModificado()
        {

            return new Prescripcion_Medicamentos(int.Parse(labelPrescripcion.Text),txtCodigo.Text,txtFechaCaducidad.Text,int.Parse(txtCantidadPrescritaNueva.Text));

        }

        public int IndexMedicamento()
        {
            return dtgMedicamento.CurrentCell.RowIndex;
        }
        public string GetCodigo()
        {
            return txtCodigo.Text;
        }

        public int GetNumPrescripcion()
        {
            return int.Parse(labelPrescripcion.Text);
        }

        public int GetCantidaModificada()
        {
            return int.Parse(txtCantidadPrescritaNueva.Text);
        }

        public int GetCantidadAnterior()
        {
           
            return int.Parse(txtCantidad.Text);
        }


        public void EstadoInicialDespuesDeModificar()
        {
            labelPrescripcion.Text = "";
            txtCodigo.Text = "";
            txtFechaCaducidad.Text = "";
            txtCantidad.Text = "";
            labelCantidadDisponible.Text = "";
            txtCantidadPrescritaNueva.Text = "";

            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            txtFechaCaducidad.Enabled = false;
            txtCantidad.Enabled = false;
        }

        public bool VerificarMedicamentos()
        {
            if (!string.IsNullOrEmpty(labelPrescripcion.Text) && !string.IsNullOrEmpty(txtCantidadPrescritaNueva.Text) && !string.IsNullOrEmpty(txtCodigo.Text) && !string.IsNullOrEmpty(txtFechaCaducidad.Text))
                return true;
            else
                return false;
        }

       
    }
}
