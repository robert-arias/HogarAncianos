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
    public partial class FRM_AgregarPrescripcion : Form
    {
        AgregarPrescripcionController agregarPrescripcionController;
        ConnectionDB connectionDB;

        public FRM_AgregarPrescripcion()
        {
            InitializeComponent();
            agregarPrescripcionController = new AgregarPrescripcionController(this);
            connectionDB = new ConnectionDB();


        }
        public void LimpiarBusqueda()
        {
            do
            {
                foreach (DataGridViewRow row in dtgMedicamento.Rows)
                {
                    dtgMedicamento.Rows.Remove(row);
                }
            } while (dtgMedicamento.Rows.Count >= 1);
        }
        public void ActivarCampos()
        {

            txtCantidad.Enabled = true;
            txtFechaCaducidad.Enabled = true;
            txtCedula.Enabled = false;
            txtCodigo.Enabled = true;

           
            btnVerificarMedicamento.Enabled = true;
            btnEliminarmMedicamento.Enabled = true;
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        public void ActivarAgregarMedicamento()
        {
            btnAgregarMedicamento.Enabled = true;
            txtCantidad.Enabled = true;
            txtFechaCaducidad.Enabled = true;
        }

        public void EstadoInicial()
        {
            txtNombrePaciente.Enabled = false;
            txtNombre.Enabled = false;
            txtCantidad.Enabled = false;
            txtFechaCaducidad.Enabled = false;
            txtCedula.Enabled = true;
            txtCodigo.Enabled = false;
            labelCantidadDisponible.Text = "";


            btnAgregarMedicamento.Enabled = false;
            btnVerificarMedicamento.Enabled = false;
            btnEliminarmMedicamento.Enabled = false;
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;
            btnVerificarPaciente.Enabled = true;
            btnLimpiar.Enabled = true;

            txtNombrePaciente.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtFechaCaducidad.Text = "";
            txtCedula.Text = "";
            txtCodigo.Text = "";

            LimpiarBusqueda();



        }


        public void EstadoInicialMedicamento()
        {
            
            txtNombre.Enabled = false;
            txtCantidad.Enabled = false;
            txtFechaCaducidad.Enabled = false;     
          
          


            btnAgregarMedicamento.Enabled = false;
            btnVerificarMedicamento.Enabled = true;
                                      
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtFechaCaducidad.Text = "";          
            txtCodigo.Text = "";
            labelCantidadDisponible.Text = "";




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
            if (!string.IsNullOrEmpty(txtCedula.Text))
            {

                return true;
            }

            return false;
        }

        public void ActualizarCantidad(string codigo, int cantidad)
        {

            foreach (DataGridViewRow row in dtgMedicamento.Rows)
            {

                if (row.Cells["Codigo"].Value.ToString().Equals(codigo))
                {
                    dtgMedicamento[row.Cells["CantidadPrescrita"].ColumnIndex, row.Index].Value = int.Parse(dtgMedicamento[2, row.Index].Value.ToString()) + cantidad;
                    dtgMedicamento.Refresh();

                }


            }
        }

        public int RetornarCantidadDisponible(string codigo)
        {
            int cantidadObtenida = 0;

            foreach (DataGridViewRow row in dtgMedicamento.Rows)
            {

                if (row.Cells["Codigo"].Value.ToString().Equals(codigo))
                {
                    cantidadObtenida = int.Parse(dtgMedicamento[2, row.Index].Value.ToString());
                    

                }


            }


            return cantidadObtenida;
        }

        public bool VerificarMedicamento(string codigo)
        {
            foreach (DataGridViewRow row in dtgMedicamento.Rows)
            {
                if (row.Cells["Codigo"].Value.ToString().Equals(codigo))
                {
                    return true;
                }

            }
            return false;
        }

        public string GetCodigo()
        {
            return txtCodigo.Text;
        }

        public string GetCedula()
        {
            return txtCedula.Text;
        }


        public void AgregarMedicamento()
        {
            if (!VerificarMedicamento(txtCodigo.Text))
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtCantidad.Text) && !string.IsNullOrEmpty(txtFechaCaducidad.Text))
                {


                    if (int.Parse(txtCantidad.Text) <= int.Parse(labelCantidadDisponible.Text))
                    {
                        dtgMedicamento.Rows.Add(txtCodigo.Text, txtNombre.Text, txtCantidad.Text, txtFechaCaducidad.Text);
                        //connectionDB.UpdateCantidadDisponibleMedicamento(txtCodigo.Text, int.Parse(txtCantidad.Text));
                        //labelCantidadDisponible.Text = connectionDB.GetNombre_CantidadDisponible_Medicamento(GetCodigo()).Tables[0].Rows[0][1].ToString();

                        txtCodigo.Text = "";
                        txtNombre.Text = "";
                        txtCantidad.Text = "";
                        txtFechaCaducidad.Text = "";
                        labelCantidadDisponible.Text = "";

                    }
                    else
                    {
                        MensajeError("La cantidad prescrita es mayor que la cantidad disponible ");
                    }

                }
                else
                {
                    MensajeError("Hay campos vacios");
                }
            }
            else
            {
                txtFechaCaducidad.Enabled = false;
                ActualizarCantidad(txtCodigo.Text, int.Parse(txtCantidad.Text));
                Console.WriteLine("Entro al else");
            }


        }

        public Prescripcion GetPrescripcion()
        {
            return new Prescripcion(int.Parse(tbNumero.Text), txtCedula.Text);
        }

        public List<Prescripcion_Medicamentos> GetPrescripcionMedicamentos()
        {
            List<Prescripcion_Medicamentos> lista_medicamentos = new List<Prescripcion_Medicamentos>();

            foreach (DataGridViewRow row in dtgMedicamento.Rows)
            {

                Prescripcion_Medicamentos medicamento = new Prescripcion_Medicamentos();
                medicamento.num = int.Parse(tbNumero.Text);
                medicamento.codigo_medicamento = row.Cells["Codigo"].Value.ToString();
                medicamento.fecha_caducidad = row.Cells["Fecha"].Value.ToString();
                medicamento.cantidad_prescrita = int.Parse(row.Cells["CantidadPrescrita"].Value.ToString());

                lista_medicamentos.Add(medicamento);
            }

            return lista_medicamentos;
        }



        public void EliminarMedicamento()
        {

            int index = dtgMedicamento.CurrentCell.RowIndex;
            if (index > -1)
            {
                dtgMedicamento.Rows.RemoveAt(index);
                dtgMedicamento.Refresh();
            }
        }


        public static void SoloNumeros(KeyPressEventArgs v)
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
                MessageBox.Show("Solo Numeros");
            }
        }

        public static void SoloLetras(KeyPressEventArgs v)
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
                MessageBox.Show("Solo Letras");
            }
        }




    }




}
