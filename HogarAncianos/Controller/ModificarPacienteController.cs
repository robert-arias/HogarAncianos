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
           // FillPacientes();
            AgregarEventosModificarPaciente();
            
        }

        private void AgregarEventosModificarPaciente()
        {
            frm_ModificarPaciente.btnModificar.Click += new EventHandler(ModificarPaciente);
            frm_ModificarPaciente.btnVerificar.Click += new EventHandler(VerificarCedulaPaciente);
            frm_ModificarPaciente.txtCedula.KeyDown += new KeyEventHandler(VerificarCedulaPacienteEnter);
            frm_ModificarPaciente.btnLimpiar.Click += new EventHandler(Limpiar);     
     
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
                        frm_ModificarPaciente.ShowMessage("La cédula de identidad ingresada no se encuentra en los registros.");
                    }
                }
                else
                {
                    frm_ModificarPaciente.ShowMessage("Faltan digitos.");
                }

            }
            else
            {
                frm_ModificarPaciente.ShowMessage("El campo \"número de cédula\" se encuentra vacío.");

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
                            frm_ModificarPaciente.ShowMessage("La cédula de identidad ingresada no se encuentra en los registros.");
                        }

                    }
                    else
                    {
                        frm_ModificarPaciente.ShowMessage("Faltan digitos.");
                    }

                }
                else

                    frm_ModificarPaciente.ShowMessage("El campo \"número de cédula\" se encuentra vacío.");

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
                connectionDB.UpdatePaciente(frm_ModificarPaciente.GetPaciente());
                frm_ModificarPaciente.ShowMessage("Paciente modificado con exito");
                frm_ModificarPaciente.EstadoInicial();
            }
            else
            {
                frm_ModificarPaciente.ShowMessage("Espacios vacios ");
            }

        }



    }
}
