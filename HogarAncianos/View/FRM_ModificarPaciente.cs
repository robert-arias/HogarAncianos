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
            cbSexo.SelectedItem= data.Tables[0].Rows[0][5].ToString();

            Console.WriteLine(data.Tables[0].Rows[0][1].ToString()+"LLenar campos");
       }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK);
        }

        public bool VerificarCampos()
        {
            bool vacio = false;

         
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
                lbEdad.Visible = true;
                lbEdad.ForeColor = Color.Red;
                lbFechaNacimiento.ForeColor = Color.Red;
                vacio = true;
            }
            else
            {
                lbFechaNacimiento.Visible = false;
                lbFechaNacimiento.ForeColor = Color.Black;
                lbEdad.Visible = false;
                lbEdad.ForeColor = Color.Black;
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
            cbSexo.Text = "";

        }


        public void ActivarCampos()
        {
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

           
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtFechaNacimiento.Enabled = true;
            txtEdad.Enabled = false;
            cbSexo.Enabled = true;
    
        }

        public Paciente GetPaciente()
        {
            //Console.WriteLine("MIERDAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+cbCedulaIdentidad.GetItemText(cbCedulaIdentidad.SelectedItem), txtNombre.Text, txtApellidos.Text, txtFechaNacimiento.Text,
         
            // Convert.ToInt16(txtEdad.Text), cbSexo.SelectedItem.ToString() + "ELLLLL PACIENTE QUE SE VA A MODIFICAR  METODO GET PACIENTEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");

            return new Paciente(txtCedula.Text, txtNombre.Text, txtApellidos.Text, txtFechaNacimiento.Text,
            Convert.ToInt16(txtEdad.Text), cbSexo.SelectedItem.ToString());

            //cbCedulaIdentidad.GetItemText(cbCedulaIdentidad.SelectedItem)
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
