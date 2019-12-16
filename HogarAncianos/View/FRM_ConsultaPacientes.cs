using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using HogarAncianos.Controller;
using HogarAncianos.Model;

namespace HogarAncianos.View
{
    public partial class FRM_ConsultaPacientes : Form
    {
        BuscarPacientesController buscarPacientesController;
        FRM_ReportePacientes frm_ReportePacientes;
        public FRM_ConsultaPacientes()
        {
            InitializeComponent();
            frm_ReportePacientes = new FRM_ReportePacientes(); ;
            buscarPacientesController = new BuscarPacientesController(this);
        }

        public void RealizarReporte()
        {
            DataSetPacientes dataSetPacientes = new DataSetPacientes();
            int fila = dtgPacientes.Rows.Count - 1;
            for (int i = 0; i <= fila; i++)
            {
                dataSetPacientes.Tables[0].Rows.Add
                    (new object[] {

                          dtgPacientes[0, i].Value.ToString(),
                          dtgPacientes[1, i].Value.ToString(),
                          dtgPacientes[2, i].Value.ToString(),
                          dtgPacientes[3, i].Value.ToString(),
                          dtgPacientes[4, i].Value.ToString(),
                          dtgPacientes[5, i].Value.ToString()


                    }
                    );
            }

            ReportDocument report = new ReportDocument();
            string fileName = "View\\CrystalReportPacientes.rpt";
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, fileName);
            Console.WriteLine(path);
            report.Load(path);
            report.SetDataSource(dataSetPacientes);
            frm_ReportePacientes.crystalReportViewer1.ReportSource = report;
            frm_ReportePacientes.ShowDialog();
        }

        public void EstadoInicial()
        {
            

            txtBuscar.Text = "";
            checkBoxEdad.Enabled = true;
            checkBoxNombre.Enabled = true;
            checkBoxSexo.Enabled = true;
            checkBoxApellidos.Enabled = true;
            checkBoxCedula.Enabled = true;
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            rbFemenino.Enabled = false;
            rbFemenino.Enabled = false;

            
            checkBoxEdad.Checked = false;
            checkBoxSexo.Checked = false;
            checkBoxCedula.Checked = false;
            checkBoxNombre.Checked = false;
            checkBoxApellidos.Checked = false;

            LimpiarBusqueda();



        }
        
        public void LimpiarBusqueda()
        {

            do
            {
                foreach (DataGridViewRow row in dtgPacientes.Rows)
                {
                    dtgPacientes.Rows.Remove(row);
                }
            } while (dtgPacientes.Rows.Count >= 1);
        }

        public void ActivarDesactivarBuscarPorCedula()
        {
            if (checkBoxCedula.Checked)
            {
                rbFemenino.Checked = false;
                rbMasculino.Checked = false;
                 rbFemenino.Enabled = false;
                rbMasculino.Enabled = false;

                checkBoxEdad.Enabled = false;
                checkBoxNombre.Enabled = false;
                checkBoxSexo.Enabled = false;
                checkBoxApellidos.Enabled = false;

                checkBoxEdad.Checked = false;
                checkBoxNombre.Checked = false;
                checkBoxSexo.Checked = false;
                checkBoxApellidos.Checked = false;
            }
            else
            {
                checkBoxEdad.Enabled = true;
                checkBoxNombre.Enabled = true;
                checkBoxSexo.Enabled = true;
                checkBoxApellidos.Enabled = true;
            }

        }

        public void ActivarDesactivarBuscarPorNombre()
        {
            if (checkBoxNombre.Checked)
            {
                rbFemenino.Checked = false;
                rbMasculino.Checked = false;
                checkBoxEdad.Enabled = false;
                checkBoxCedula.Enabled = false;
                checkBoxSexo.Enabled = false;
                checkBoxApellidos.Enabled = false;
                rbFemenino.Enabled = false;
                rbMasculino.Enabled = false;

                checkBoxEdad.Checked = false;
                checkBoxCedula.Checked = false;
                checkBoxSexo.Checked = false;
                checkBoxApellidos.Checked = false;
            }
            else
            {
                checkBoxEdad.Enabled = true;
                checkBoxCedula.Enabled = true;
                checkBoxSexo.Enabled = true;
                checkBoxApellidos.Enabled = true;
            }

        }

        public void ActivarDesactivarBuscarPorApellido()
        {
            if (checkBoxApellidos.Checked)
            {
                rbFemenino.Checked = false;
                rbMasculino.Checked = false;
                checkBoxEdad.Enabled = false;
                checkBoxNombre.Enabled = false;
                checkBoxSexo.Enabled = false;
                checkBoxCedula.Enabled = false;
                rbFemenino.Enabled = false;
                rbMasculino.Enabled = false;

                checkBoxEdad.Checked = false;
                checkBoxNombre.Checked = false;
                checkBoxSexo.Checked = false;
                checkBoxCedula.Checked = false;
            }
            else
            {
                checkBoxEdad.Enabled = true;
                checkBoxNombre.Enabled = true;
                checkBoxSexo.Enabled = true;
                checkBoxCedula.Enabled = true;
            }

        }
        public void ActivarDesactivarBuscarPorEdad()
        {
            if (checkBoxEdad.Checked)
            {
                checkBoxCedula.Enabled = false;
                checkBoxNombre.Enabled = false;
                checkBoxApellidos.Enabled = false;
            }
            else
            {
                checkBoxCedula.Enabled = true;
                checkBoxNombre.Enabled = true;
                checkBoxApellidos.Enabled = true;
            }

        }

        public void ActivarDesactivarBuscarPorSexo()
        {
            if (checkBoxSexo.Checked)
            {
                gbSexo.Enabled = true;
                checkBoxCedula.Enabled = false;
                checkBoxNombre.Enabled = false;
                checkBoxApellidos.Enabled = false;
                rbFemenino.Checked = true;
                rbMasculino.Checked = false;
                rbFemenino.Enabled = true;
                rbMasculino.Enabled = true;
            }
            else
            {
                rbFemenino.Checked = false;
                rbMasculino.Checked = false;
                gbSexo.Enabled = false;
                checkBoxCedula.Enabled = true;
                checkBoxNombre.Enabled = true;
                checkBoxApellidos.Enabled = true;
               
            }

        }


        public void MensajeInformativo (string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje," Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    
       

        public string GetBusquedaPacientes()
        {
                                  
            if (checkBoxCedula.Checked)
           

                     return $"select * from Pacientes where cedula= '{txtBuscar.Text}'";
              
                         
            else if (checkBoxEdad.Checked && rbFemenino.Checked)
            
                return  $"select * from Pacientes where edad = {txtBuscar.Text} and sexo= 'Femenino'";
                
            
            else if (checkBoxEdad.Checked && rbMasculino.Checked)
            
                return  $"select * from Pacientes where edad = {txtBuscar.Text} and sexo='Masculino'";
              
            
            else if (checkBoxNombre.Checked)
                return $"select * from Pacientes where nombre like '%{txtBuscar.Text}%'";
              
                       
            else if (checkBoxApellidos.Checked)
                return $"select * from Pacientes where apellidos like '%{txtBuscar.Text}%'";
               
            else if (checkBoxEdad.Checked)
                return  $"select * from Pacientes where edad = {txtBuscar.Text}";
               
           
            else if (rbFemenino.Checked)
            
                return  $"select * from Pacientes where sexo = 'Femenino'";
            
            else if (rbMasculino.Checked) 
                return $"select * from Pacientes where sexo = 'Masculino'";

            return "";
        }

      

        public void FillBusqueda(DataSet pacientes)
        {
            dtgPacientes.DataSource = pacientes.Tables[0];
        }

        public bool verificar()
        {
            bool verificar = false;
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                if(!checkBoxCedula.Checked && !checkBoxNombre.Checked && !checkBoxApellidos.Checked && !checkBoxEdad.Checked && !checkBoxSexo.Checked)
                {
                    verificar = false;
                    txtBuscar.Text = "";
                }
                else
                {
                    verificar = true;
                }
                
                
            }
            else if (string.IsNullOrEmpty(txtBuscar.Text) && checkBoxSexo.Checked && checkBoxEdad.Checked)
            {
                verificar = false;
                txtBuscar.Text = "";
            }
            else if (string.IsNullOrEmpty(txtBuscar.Text) && checkBoxSexo.Checked)
            {
                if(rbFemenino.Checked || rbMasculino.Checked)
                {
                    verificar = true;
                }
            }
           
                //{
                //    verificar = false;
                //    txtBuscar.Text = "";
                //}
                Console.WriteLine("Resultado del metodo verificar"+verificar);
            return verificar;

        }

      
    }
}
