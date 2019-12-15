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
    public partial class FRM_ModificarPaciente : Form
    {
        private ModificarPacienteController modificarPacienteController;
        public FRM_ModificarPaciente() 
        {
            InitializeComponent();
            modificarPacienteController = new ModificarPacienteController(this);
            cbSexo.Text = "Seleccionar";
            EstadoInicial();
           
        }

       public string GetCedula()
       {
            return txtCedula.Text;
       }

       public void llenarCampos(DataSet data)
       {
            txtNombre.Text = data.Tables[0].Rows[0][1].ToString() ;
            txtApellidos.Text= data.Tables[0].Rows[0][2].ToString();
            txtFechaNacimiento.Text= data.Tables[0].Rows[0][3].ToString();
            txtEdad.Text= data.Tables[0].Rows[0][4].ToString();
            cbSexo.SelectedItem = data.Tables[0].Rows[0][5].ToString();

            Console.WriteLine(data.Tables[0].Rows[0][5].ToString() + "LLenar campos SEXO ");
       }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK);
        }

        public bool VerificarCampos()
        {
            bool vacio = false;

            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                lbCedula.Visible = true;
                vacio = true;
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


            return vacio;
        }

        private void txtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtEdad.Text = Convert.ToString(DateTime.Today.Year - txtFechaNacimiento.Value.Year);
        }

        public void EstadoInicial()
       {
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = true;
            btnVerificar.Enabled = true;

            txtCedula.Enabled=true;
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtFechaNacimiento.Enabled = false;
            txtEdad.Enabled = false;
            cbSexo.Enabled = false;

            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtFechaNacimiento.Text = "";
            txtEdad.Text = "";
            cbSexo.SelectedItem = "Seleccionar";

        }


        public void ActivarCampos()
        {
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            txtCedula.Enabled = false;
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtFechaNacimiento.Enabled = true;
            txtEdad.Enabled = false;
            cbSexo.Enabled = true;
    
        }

        public Paciente GetPaciente()
        {
            

            return new Paciente(txtCedula.Text, txtNombre.Text, txtApellidos.Text, txtFechaNacimiento.Text,
            Convert.ToInt16(txtEdad.Text), cbSexo.SelectedItem.ToString());

          
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

        public void SoloLetras(KeyPressEventArgs v)
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

        public void MensajeInformativo(string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public bool ShowConfirmation()
        {
            string message = "¿Desea modificar la informacion del paciente cédula: " + txtCedula.Text + "  " + " nombre:  " + txtNombre.Text + " ?";
            DialogResult boton = MessageBox.Show(message, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (boton == DialogResult.OK)
            {
                return true;
            }

            return false;
        }
        private void FRM_ModificarPaciente_Load(object sender, EventArgs e)
        {

        }































        //public void FillPacientes(DataSet pacientes)
        //{

        //    cbCedulaIdentidad.DataSource = pacientes.Tables[0];
        //    cbCedulaIdentidad.DisplayMember = "cedula";
        //    cbCedulaIdentidad.ValueMember = "cedula";

        //}

        //public string GetCedula()
        //{
        //    string cedula="";
        //    if (cbCedulaIdentidad.SelectedIndex != 0)
        //    {
        //        Console.WriteLine(cbCedulaIdentidad.GetItemText(cbCedulaIdentidad.SelectedItem) + "METODO GET CEDULA");
        //        cedula = cbCedulaIdentidad.GetItemText(cbCedulaIdentidad.SelectedItem);

        //    }

        //    return cedula;
        //}

    }
}
