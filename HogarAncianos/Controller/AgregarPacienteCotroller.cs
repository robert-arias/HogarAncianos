using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HogarAncianos.Model;
using HogarAncianos.View;

namespace HogarAncianos.Controller
{
    class AgregarPacienteCotroller
    {
        private FRM_AgregarPaciente frm_AgregarPaciente;
        private ConnectionDB connectionDB;

        public AgregarPacienteCotroller(FRM_AgregarPaciente frm_AgregarPaciente)
        {
            this.frm_AgregarPaciente = frm_AgregarPaciente;
            AgregarEventosPaciente();
            connectionDB = new ConnectionDB();
        }

        

        private void AgregarEventosPaciente()
        {
            frm_AgregarPaciente.btnAgregar.Click += new EventHandler(AgregarPaciente);
            frm_AgregarPaciente.btnVerificar.Click += new EventHandler(VerificarCedulaPaciente);
            frm_AgregarPaciente.txtCedula.KeyDown += new KeyEventHandler(VerificarCedulaPacienteEnter);
            frm_AgregarPaciente.btnLimpiar.Click += new EventHandler(Limpiar);
         

        }



        private void VerificarCedulaPaciente(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frm_AgregarPaciente.GetCedula()))
            {
                 if (frm_AgregarPaciente.GetCedula().Length >= 9)
                 {
                    if (!connectionDB.ExisteCedulaPaciente(frm_AgregarPaciente.GetCedula()))
                    {
                        frm_AgregarPaciente.ActivarCampos();
                    }
                    else
                    {
                        frm_AgregarPaciente.ShowMessage("La cédula de identidad ingresada se encuentra en los registros.");
                    }

                }
                else
                {
                    frm_AgregarPaciente.ShowMessage("Faltan digitos.");
                } 

            }
            else
            {
                frm_AgregarPaciente.ShowMessage("El campo \"número de cédula\" se encuentra vacío.");

            }    
    
        }


        public void VerificarCedulaPacienteEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(frm_AgregarPaciente.GetCedula()))
                {
                    if (frm_AgregarPaciente.GetCedula().Length >= 9)
                    {
                        if (!connectionDB.ExisteCedulaPaciente(frm_AgregarPaciente.GetCedula()))
                        {
                            frm_AgregarPaciente.ActivarCampos();
                        }
                        else
                        {
                            frm_AgregarPaciente.ShowMessage("La cédula de identidad ingresada se encuentra en los registros.");
                        }

                    }
                    else
                    {
                        frm_AgregarPaciente.ShowMessage("Faltan digitos.");
                    }

                }
                else
                
                    frm_AgregarPaciente.ShowMessage("El campo \"número de cédula\" se encuentra vacío.");
                   e.SuppressKeyPress = true; //remove ding windows sound.

            }
        }

        private void Limpiar(object sender, EventArgs e)
        {
            frm_AgregarPaciente.EstadoInicial();
        }

        private void AgregarPaciente(object sender, EventArgs e)
        {
            if (!frm_AgregarPaciente.VerificarCampos())
            {
                if(frm_AgregarPaciente.ShowMessage2("¿Esta seguro de añadir el paciente?"))
                {
                    if (connectionDB.AgregarPaciente(frm_AgregarPaciente.GetPaciente()))
                    {
                        frm_AgregarPaciente.ShowMessage("Se ha agregado al nuevo paciente con éxito.");
                        frm_AgregarPaciente.EstadoInicial();
                    }
                    else
                    {
                        frm_AgregarPaciente.ShowMessage("Se ha producido un error.\nVerifique los datos.");

                    }
                }
              
            }
            else
            {
                frm_AgregarPaciente.ShowMessage("Algunos campos se encuentran vacíos." +
                    "\nLos campos con el asterisco (*) rojo son aquellos que deben ser modificados.");
            }
        }
   

    }
}
