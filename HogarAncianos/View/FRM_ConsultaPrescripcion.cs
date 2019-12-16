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
            txtFechaCaducidad.Enabled = false;
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
                txtFechaCaducidad.Enabled = true;
            }
            else
            {
                txtFechaCaducidad.Enabled = false;
            }

        }//fin del metodo activar/ desactivar fecha




        public string GetBusquedaPrescripcion()
        {
            string query = "";

            if (!string.IsNullOrEmpty(txtCedulaPaciente.Text) && checkBoxFechaCaducidad.Checked)
            {
                query = $"select  pa.nombre ,m.nombre_medicamento, p.num, p.cedula_paciente, pm.codigo_medicamento, pm.cantidad_prescrita, pm.fecha_caducidad from Medicamentos m, Prescripcion_Medicamentos pm, Prescripcion p ,  Pacientes pa where p.cedula_paciente = '{txtCedulaPaciente.Text}' and pm.fecha_caducidad = '{ txtFechaCaducidad.Text}' and pm.num=p.num and m.codigo_Medicamento= pm.codigo_Medicamento , pa.cedula= p.cedula_paciente";
            }
            else if (!string.IsNullOrEmpty(txtCedulaPaciente.Text) && checkBoxCodigoMedicamento.Checked && !string.IsNullOrEmpty(txtCodigoMedicamento.Text))
            {
                query = $"select pa.nombre, m.nombre_medicamento, p.num, p.cedula_paciente, pm.codigo_medicamento, pm.cantidad_prescrita, pm.fecha_caducidad from Medicamentos m, Prescripcion_Medicamentos pm, Prescripcion p ,  Pacientes pa where p.cedula_paciente = '{txtCedulaPaciente.Text}' and pm.codigo_medicamento = '{txtCodigoMedicamento.Text}' and pm.num=p.num and m.codigo_Medicamento= pm.codigo_Medicamento,pa.cedula= p.cedula_paciente";
            }
            else if (!string.IsNullOrEmpty(txtCedulaPaciente.Text) && !checkBoxFechaCaducidad.Checked && !checkBoxCodigoMedicamento.Checked && string.IsNullOrEmpty(txtCodigoMedicamento.Text))
            {
                query = $"select pa.nombre, m.nombre_medicamento, p.num, p.cedula_paciente, pm.codigo_medicamento, pm.cantidad_prescrita, pm.fecha_caducidad from Medicamentos m, Prescripcion_Medicamentos pm, Prescripcion p , Pacientes pa  where p.cedula_paciente = '{txtCedulaPaciente.Text}' and pm.num=p.num, pa.cedula= p.cedula_paciente";
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
            if (string.IsNullOrEmpty(txtCedulaPaciente.Text) && (checkBoxFechaCaducidad.Checked || checkBoxCodigoMedicamento.Checked))
            {
                verificar = false;

            }
            else if (!string.IsNullOrEmpty(txtCedulaPaciente.Text) && !checkBoxFechaCaducidad.Checked && !checkBoxCodigoMedicamento.Checked)
            {
                verificar = true;
            }
            else if (!string.IsNullOrEmpty(txtCedulaPaciente.Text) && checkBoxFechaCaducidad.Checked)
            {
                verificar = true;
            }

            else if (!string.IsNullOrEmpty(txtCedulaPaciente.Text) && checkBoxCodigoMedicamento.Checked)
            {
                if (!string.IsNullOrEmpty(txtCodigoMedicamento.Text))
                {
                    verificar = true;
                }
                else
                {
                    verificar = false;
                }
                
            }


            return verificar;
        }//fin del metodo verificar 



        public void MensajeInformativo(string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FRM_ConsultaPrescripcion_Load(object sender, EventArgs e)
        {

        }
    }//fin de la clase 
}//fin del namespace
