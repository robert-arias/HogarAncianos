using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HogarAncianos.View;
using HogarAncianos.Controller;
using HogarAncianos.Model;
using System.Windows.Forms;

namespace HogarAncianos.Controller
{
    class ModificarPacienteController
    {
        private FRM_ModificarPaciente frm_ModificarPaciente;
        private ConnectionDB connectionDB;
        public ModificarPacienteController(FRM_ModificarPaciente frm_ModificarPaciente)
        {
            this.frm_ModificarPaciente = frm_ModificarPaciente;
            connectionDB = new ConnectionDB();
          
            AgregarEventosModificarPaciente();
            
        }

        private void AgregarEventosModificarPaciente()
        {
            frm_ModificarPaciente.btnModificar.Click += new EventHandler(ModificarPaciente);
            frm_ModificarPaciente.btnVerificar.Click += new EventHandler(VerificarCedulaPaciente);
            frm_ModificarPaciente.txtCedula.KeyDown += new KeyEventHandler(VerificarCedulaPacienteEnter);
            frm_ModificarPaciente.btnLimpiar.Click += new EventHandler(Limpiar);
            frm_ModificarPaciente.txtCedula.KeyPress += new KeyPressEventHandler(ValidarCedula);
            frm_ModificarPaciente.txtEdad.KeyPress += new KeyPressEventHandler(ValidarEdad);
            frm_ModificarPaciente.txtNombre.KeyPress += new KeyPressEventHandler(ValidarNombre);
            frm_ModificarPaciente.txtApellidos.KeyPress += new KeyPressEventHandler(ValidarApellidos);

        }

        public void ValidarCedula(object sender, KeyPressEventArgs e)
        {
            frm_ModificarPaciente.SoloNumeros(e);
        }

        public void ValidarEdad(object sender, KeyPressEventArgs e)
        {
            frm_ModificarPaciente.SoloNumeros(e);
        }

        public void ValidarNombre(object sender, KeyPressEventArgs e)
        {
            frm_ModificarPaciente.SoloLetras(e);
        }

        public void ValidarApellidos(object sender, KeyPressEventArgs e)
        {
            frm_ModificarPaciente.SoloLetras(e);
        }

        private void llenarCampos()
        {
            if (connectionDB.GetPaciente(frm_ModificarPaciente.GetCedula()).Tables[0].Rows.Count != 0)
            {
                frm_ModificarPaciente.llenarCampos(connectionDB.GetPaciente(frm_ModificarPaciente.GetCedula()));
                frm_ModificarPaciente.ActivarCampos();
            }
        }

        private void VerificarCedulaPaciente(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frm_ModificarPaciente.GetCedula()))
            {
                if (frm_ModificarPaciente.GetCedula().Length >= 9)
                {
                    if (connectionDB.ExisteCedulaPaciente(frm_ModificarPaciente.GetCedula()))
                    {
                        llenarCampos();
                        
                    }
                    else
                    {
                        frm_ModificarPaciente.MensajeError("La cédula de identidad ingresada no se encuentra en los registros.");
                    }
                }
                else
                {
                    frm_ModificarPaciente.MensajeError("El campo \"número de cédula\" se encuentra vacío o se ingresaron" +
                   " menos de 9 dígitos.");
                }

            }
            else
            {
                frm_ModificarPaciente.MensajeError("El campo \"número de cédula\" se encuentra vacío.");

            }

        }


        public void VerificarCedulaPacienteEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(frm_ModificarPaciente.GetCedula()))
                {
                    if (frm_ModificarPaciente.GetCedula().Length >= 9)
                    {
                        if (connectionDB.ExisteCedulaPaciente(frm_ModificarPaciente.GetCedula()))
                        {
                            llenarCampos();

                        }
                        else
                        {
                            frm_ModificarPaciente.MensajeError("La cédula de identidad ingresada no se encuentra en los registros.");
                        }
                    }
                    else
                    {
                        frm_ModificarPaciente.MensajeError("El campo \"número de cédula\" se encuentra vacío o se ingresaron" +
                       " menos de 9 dígitos.");
                    }

                }
                else
                
                    frm_ModificarPaciente.MensajeError("El campo \"número de cédula\" se encuentra vacío.");

                

                e.SuppressKeyPress = true; //remove ding windows sound.

            }
        }

        private void Limpiar(object sender, EventArgs e)
        {
            frm_ModificarPaciente.EstadoInicial();
        }

        

        private void ModificarPaciente(object sender, EventArgs e)
        {
            if (!frm_ModificarPaciente.VerificarCampos())
            {
                if (frm_ModificarPaciente.ShowConfirmation())
                {
                    if (connectionDB.UpdatePaciente(frm_ModificarPaciente.GetPaciente()))
                    {
                        frm_ModificarPaciente.ShowMessage("Paciente modificado con  éxito.");
                        frm_ModificarPaciente.EstadoInicial();

                    }
                    else
                    {
                        frm_ModificarPaciente.MensajeError("No se ha modificado al paciente.");
                    }
                   
                }
                else
                {
                    frm_ModificarPaciente.MensajeError("No se ha modificado al paciente.");
                }
              
            }
            else
            {
                frm_ModificarPaciente.MensajeError("Algunos campos se encuentran vacíos." +
                    "\nLos campos con el asterisco (*) rojo son aquellos que deben ser modificados.");
            }

        }



    }
}
