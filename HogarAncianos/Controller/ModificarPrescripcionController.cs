using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HogarAncianos.View;
using HogarAncianos.Model;
using System.Windows.Forms;

namespace HogarAncianos.Controller
{
    
    public class ModificarPrescripcionController
    {
        ConnectionDB connection;
        FRM_ModificarPrescripcion fRM_ModificarPrescripcion;
      
        public ModificarPrescripcionController(FRM_ModificarPrescripcion fRM_ModificarPrescripcion)
        {
            connection = new ConnectionDB();
            this.fRM_ModificarPrescripcion = fRM_ModificarPrescripcion;
            AgregarEventos();
            fRM_ModificarPrescripcion.EstadoInicial();
          
        }












        public void AgregarEventos()
        {
            fRM_ModificarPrescripcion.btnVerificarPaciente.Click += new EventHandler(VerificarPaciente);
            fRM_ModificarPrescripcion.txtCedulaPaciente.KeyDown += new KeyEventHandler(VerificarCedulaEnter);
            fRM_ModificarPrescripcion.btnSeleccionar.Click += new EventHandler(Seleccionar);
            fRM_ModificarPrescripcion.btnSeleccionarMedicamento.Click += new EventHandler(SeleccionarMedicamento);
            fRM_ModificarPrescripcion.btnLimpiar.Click += new EventHandler(Limpiar);
            fRM_ModificarPrescripcion.btnModificar.Click += new EventHandler(ModificarMedicamento);
            fRM_ModificarPrescripcion.txtCantidadPrescritaNueva.KeyPress += new KeyPressEventHandler(ValidarCantidad);
            fRM_ModificarPrescripcion.txtCedulaPaciente.KeyPress += new KeyPressEventHandler(ValidarCedula);

        }

        public void ValidarCantidad(object sender, KeyPressEventArgs e)
        {
            fRM_ModificarPrescripcion.SoloNumeros(e);
        }

        public void ValidarCedula(object sender, KeyPressEventArgs e)
        {
            fRM_ModificarPrescripcion.SoloNumeros(e);
        }

        public void Limpiar(object sender, EventArgs e)
        {
            fRM_ModificarPrescripcion.EstadoInicial();
        }

        public void SeleccionarMedicamento(object sender, EventArgs e)
        {
            if (fRM_ModificarPrescripcion.IndexMedicamento() > -1)
            {
                fRM_ModificarPrescripcion.llenarCampos(connection.GetDatosMedicamento_Prescripcion(fRM_ModificarPrescripcion.GetCodigoMedicamento(fRM_ModificarPrescripcion.IndexMedicamento()),fRM_ModificarPrescripcion.GetNumPrescripcion(fRM_ModificarPrescripcion.IndexMedicamento())));
                fRM_ModificarPrescripcion.labelCantidadDisponible.Text = connection.GetNombre_CantidadDisponible_Medicamento(fRM_ModificarPrescripcion.GetCodigoMedicamento(fRM_ModificarPrescripcion.IndexMedicamento())).Tables[0].Rows[0][1].ToString();
              
         
                fRM_ModificarPrescripcion.ActivarCamposSeleccionMedicamentos();
            }
            else
            {
                fRM_ModificarPrescripcion.MensajeError("No ha seleccionado ningun medicamento");
            }
        }

        public void Seleccionar(object sender, EventArgs e)
        {
            if (fRM_ModificarPrescripcion.Index() > -1)
            {
                fRM_ModificarPrescripcion.FilldtgMedicamentos(connection.GetPrescripciones_MedicamentosUnPaciente(fRM_ModificarPrescripcion.GetNum()));
                fRM_ModificarPrescripcion.ActivarCamposSeleccionPrescripcion();
            }
            else
            {
                fRM_ModificarPrescripcion.MensajeError("No ha seleccionado ninguna prescripcion");
            }
        }

        public void VerificarCedulaEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (fRM_ModificarPrescripcion.VerificarPaciente())
                {
                    if (connection.ExisteCedulaPaciente(fRM_ModificarPrescripcion.GetCedula()))
                    {
                        fRM_ModificarPrescripcion.txtNombrePaciente.Text = connection.GetNombrePaciente(fRM_ModificarPrescripcion.GetCedula()).Tables[0].Rows[0][0].ToString() + " " + connection.GetNombrePaciente(fRM_ModificarPrescripcion.GetCedula()).Tables[0].Rows[0][1].ToString();
                        fRM_ModificarPrescripcion.FilldtgPrescripciones(connection.GetPrescripcionesUnPaciente(fRM_ModificarPrescripcion.GetCedula()));
                        fRM_ModificarPrescripcion.ActivarCamposCedula();
                    }
                    else
                    {
                        fRM_ModificarPrescripcion.MensajeError("El número de cédula ingresado no se encuentra en los registros ");
                    }

                }
                else
                {
                    fRM_ModificarPrescripcion.MensajeError("El campo \"número de cédula\" se encuentra vacío o se ingresaron" +
                   " menos de 9 dígitos.");
                }

                e.SuppressKeyPress = true; //remove ding windows sound.
            }

        }

        public void VerificarPaciente(object sender, EventArgs e)
        {
            if (fRM_ModificarPrescripcion.VerificarPaciente())
            {
                if (connection.ExisteCedulaPaciente(fRM_ModificarPrescripcion.GetCedula()))
                {
                    fRM_ModificarPrescripcion.txtNombrePaciente.Text = connection.GetNombrePaciente(fRM_ModificarPrescripcion.GetCedula()).Tables[0].Rows[0][0].ToString() + " " + connection.GetNombrePaciente(fRM_ModificarPrescripcion.GetCedula()).Tables[0].Rows[0][1].ToString();
                    fRM_ModificarPrescripcion.FilldtgPrescripciones(connection.GetPrescripcionesUnPaciente(fRM_ModificarPrescripcion.GetCedula()));
                    fRM_ModificarPrescripcion.ActivarCamposCedula();
                }
                else
                {
                    fRM_ModificarPrescripcion.MensajeError("El número de cédula ingresado no se encuentra en los registros ");
                }

            }
            else
            {
                fRM_ModificarPrescripcion.MensajeError("El campo \"número de cédula\" se encuentra vacío o se ingresaron" +
               " menos de 9 dígitos.");
            }

        }

      

        public void ModificarMedicamento(object sender, EventArgs e)
        {

            if (fRM_ModificarPrescripcion.VerificarMedicamentos())
            {
                 if (int.Parse(fRM_ModificarPrescripcion.txtCantidadPrescritaNueva.Text) <= int.Parse(fRM_ModificarPrescripcion.labelCantidadDisponible.Text)+int.Parse(fRM_ModificarPrescripcion.txtCantidad.Text))
                 { 

                    if (connection.UpdateCantidadDisponible_CantidadPrescrita( fRM_ModificarPrescripcion.GetCodigo(),fRM_ModificarPrescripcion.GetCantidaModificada(),
                    fRM_ModificarPrescripcion.GetCantidadAnterior()))
                    {
                            if (connection.Update_Cantidad_Feha(fRM_ModificarPrescripcion.GetMedicamentoModificado()))
                            {
                                fRM_ModificarPrescripcion.MensajeInformativo("Prescripción modificada exitosamente.");
                                fRM_ModificarPrescripcion.EstadoInicialDespuesDeModificar();
                            }
                            else
                            {
                            fRM_ModificarPrescripcion.MensajeError("La  prescripción no ha sido modificada.");
                            }


                    }
                    else
                    {
                        fRM_ModificarPrescripcion.MensajeError("La  prescripción no ha sido modificada.");
                    }
                }
                else
                {
                    fRM_ModificarPrescripcion.MensajeError("La cantidad prescrita es mayor que la cantidad disponible ");
                }
            }
            else
            {
                    fRM_ModificarPrescripcion.MensajeError("Verifique los datos, hay campos que se encuentran vacios.");
              
            }

        }

        


    }
}
