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
            cbCedulaIdentidad.Text = "Seleccionar";
            cbSexo.Text = "Seleccionar";
        }

        public void FillPacientes(DataSet pacientes)
        {            
            cbCedulaIdentidad.DataSource = pacientes.Tables[0];
            cbCedulaIdentidad.DisplayMember = "cedula";
            cbCedulaIdentidad.ValueMember = "cedula";
        }

        public string GetCedula()
        {
            string cedula="";
            if (cbCedulaIdentidad.SelectedIndex != 0)
            {
                Console.WriteLine(cbCedulaIdentidad.GetItemText(cbCedulaIdentidad.SelectedItem) + "METODO GET CEDULA");
                cedula = cbCedulaIdentidad.GetItemText(cbCedulaIdentidad.SelectedItem);

            }

            return cedula;
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

       public void EstadoInicial()
       {
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = true;

            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtFechaNacimiento.Enabled = false;
           // txtEdad.Enabled= 


       }


        public void ActivarCampos()
        {

        }
        
    }
}
