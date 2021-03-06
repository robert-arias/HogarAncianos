﻿using System;
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
            frm_AgregarPaciente.txtCedula.KeyPress += new KeyPressEventHandler(ValidarCedula);
            frm_AgregarPaciente.txtEdad.KeyPress += new KeyPressEventHandler(ValidarEdad);
            frm_AgregarPaciente.txtNombre.KeyPress += new KeyPressEventHandler(ValidarNombre);
            frm_AgregarPaciente.txtApellidos.KeyPress += new KeyPressEventHandler(ValidarApellidos);

        }


        public void ValidarCedula(object sender, KeyPressEventArgs e)
        {
            frm_AgregarPaciente.SoloNumeros(e);
        }

        public void ValidarEdad(object sender, KeyPressEventArgs e)
        {
            frm_AgregarPaciente.SoloNumeros(e);
        }

        public void ValidarNombre(object sender, KeyPressEventArgs e)
        {
            frm_AgregarPaciente.SoloLetras(e);
        }

        public void ValidarApellidos(object sender, KeyPressEventArgs e)
        {
            frm_AgregarPaciente.SoloLetras(e);
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
                        frm_AgregarPaciente.MensajeError("La cédula de identidad ingresada se encuentra en los registros.");
                    }

                }
                else
                {
                    frm_AgregarPaciente.MensajeError("El campo \"número de cédula\" se encuentra vacío o se ingresaron" +
                   " menos de 9 dígitos.");
                } 

            }
            else
            {
                frm_AgregarPaciente.MensajeError("El campo \"número de cédula\" se encuentra vacío.");

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
                            frm_AgregarPaciente.MensajeError("La cédula de identidad ingresada se encuentra en los registros.");
                        }

                    }
                    else
                    {
                        frm_AgregarPaciente.MensajeError("El campo \"número de cédula\" se encuentra vacío o se ingresaron" +
                       " menos de 9 dígitos.");
                    }

                }
                else
                
                    frm_AgregarPaciente.MensajeError("El campo \"número de cédula\" se encuentra vacío.");

                
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
                if (frm_AgregarPaciente.ShowConfirmation())
                {
                    if (connectionDB.AgregarPaciente(frm_AgregarPaciente.GetPaciente()))
                    {
                        frm_AgregarPaciente.MensajeInformativo("Se ha agregado al nuevo paciente con éxito.");
                        frm_AgregarPaciente.EstadoInicial();
                    }
                    else
                    {
                        frm_AgregarPaciente.MensajeError("Se ha producido un error.\nVerifique los datos.");

                    }
                }
                else
                {
                    frm_AgregarPaciente.MensajeInformativo("Se ha agregado al nuevo paciente con éxito.");
                }
              
            }
            else
            {
                frm_AgregarPaciente.MensajeError("Algunos campos se encuentran vacíos." +
                    "\nLos campos con el asterisco (*) rojo son aquellos que deben ser modificados.");
            }
        }
   

    }
}
