using HogarAncianos.Controller;
using HogarAncianos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HogarAncianos.View
{
    public partial class FRM_ConsultaPrescripcion : Form
    {

        BuscarPrescripcionController buscarPrescripcionController;
        ConnectionDB connectionDB;

        public FRM_ConsultaPrescripcion()
        {
            InitializeComponent();


            buscarPrescripcionController = new BuscarPrescripcionController(this);
            connectionDB = new ConnectionDB();
        }//fin del constructor


        public void EstadoInicial()
        {
            checkBoxFechaCaducidad.Checked = false;
            checkBoxCodigoMedicamento.Checked = false;
            txtCedulaPaciente.Text = "";
            checkBoxFechaCaducidad.Enabled = true;
            checkBoxFechaCaducidad.Enabled = true;
            txtCodigoMedicamento.Text = "";
            txtCodigoMedicamento.Enabled = false;// desactivar campo codigo medicamento
            dateTimeFechaCaducidad.Enabled = false;
            Limpiar();//metodo limpiar

        }//fin del metodo estado inicial 

        public void Limpiar()
        {

            do
            {
                foreach (DataGridViewRow row in dtgConsultaPrescripcion.Rows)
                {
                    dtgConsultaPrescripcion.Rows.Remove(row);
                }

            } while (dtgConsultaPrescripcion.Rows.Count >= 1);


        }//fin del metodo limpiar data grid view


        public void activarDesactivarBuscarPorCodigo()
        {
            if (checkBoxCodigoMedicamento.Checked)
            {
                txtCodigoMedicamento.Enabled = true;
            }
            else
            {

                txtCodigoMedicamento.Enabled = false;
            }
        }//fin del metodo activar/desactivar busqueda por codigo

        public void activarDesactivarBuscarPorFecha()
        {
            if (checkBoxFechaCaducidad.Checked)
            {
                dateTimeFechaCaducidad.Enabled = true;
            }
            else
            {
                dateTimeFechaCaducidad.Enabled = false;
            }

        }//fin del metodo activar/ desactivar fecha


        public void MensajeInformativo(string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//fin de mensaje Informativo

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }//fin de mensaje error


        public string GetBusquedaPrescripcion()
        {
            string query = "";

            if (string.IsNullOrEmpty(txtCedulaPaciente.Text) && checkBoxFechaCaducidad.Checked)
            {
                query = $"select p.num, p.cedula_paciente, pm.codigo_medicamento, pm.cantidad_prescrita, pm.fecha_caducidad from Prescripcion_Medicamento pm, Prescripcion p where pm.cedula_paciente = '{txtCedulaPaciente.Text}' and pm.fecha_caducidad = '{dateTimeFechaCaducidad.Text}' and pm.num=p.num";
            }
            else if (string.IsNullOrEmpty(txtCedulaPaciente.Text) && checkBoxCodigoMedicamento.Checked)
            {
                query = $"select p.num, p.cedula_paciente, pm.codigo_medicamento, pm.cantidad_prescrita, pm.fecha_caducidad from Prescripcion_Medicamento pm, Prescripcion p where pm.cedula_paciente = '{txtCedulaPaciente.Text}' and pm.codigo_medicamento = '{txtCodigoMedicamento.Text}' and pm.num=p.num";
            }
            else if (string.IsNullOrEmpty(txtCedulaPaciente.Text) && checkBoxFechaCaducidad.Checked && checkBoxCodigoMedicamento.Checked)
            {
                query = $"select p.num, p.cedula_paciente, pm.codigo_medicamento, pm.cantidad_prescrita, pm.fecha_caducidad from Prescripcion_Medicamento pm, Prescripcion p where pm.cedula_paciente = '{txtCedulaPaciente.Text}' and pm.fecha_caducidad = '{dateTimeFechaCaducidad.Text}' and pm.codigo_medicamento = '{txtCodigoMedicamento.Text}' and pm.num=p.num";
            }
            else if (string.IsNullOrEmpty(txtCedulaPaciente.Text))
            {
                //query = $"select * from Prescripcion_Medicamento";
                query = $"select p.num, p.cedula_paciente, pm.codigo_medicamento, pm.cantidad_prescrita, pm.fecha_caducidad from Prescripcion_Medicamento pm, Prescripcion p where pm.cedula_paciente = '{txtCedulaPaciente.Text}' and pm.num=p.num";
            }

            Console.WriteLine(query + "Revisar");
            return query;
        }//fin de metodo GetBusquedaPrescripcion 
        //

        public void FillBusqueda(DataSet prescripcion)
        {
            dtgConsultaPrescripcion.DataSource = prescripcion.Tables[0];
        }// fin del metodo llenar data grid view 

        public bool verificar()
        {
            bool verificar = false;
            if (!string.IsNullOrEmpty(txtCedulaPaciente.Text))
            {
                verificar = true;

            }
            else if (string.IsNullOrEmpty(txtCedulaPaciente.Text) && checkBoxFechaCaducidad.Checked && checkBoxCodigoMedicamento.Checked)
            {
                verificar = false;
            }

            return verificar;
        }//fin del metodo verificar 









    }//fin de la clase 
}//fin del namespace
