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
    
    class AgregarMedicamentoController
    {
        private FRM_AgregarMedicamento frm_AgregarMedicamento;
        private ConnectionDB connectionDB;

        public AgregarMedicamentoController (FRM_AgregarMedicamento frm_agregarMedicamento)
        {
            this.frm_AgregarMedicamento = frm_agregarMedicamento;
            AgregarEventosMedicamentos();
            connectionDB = new ConnectionDB();
            
           
        }
        private void AgregarEventosMedicamentos()
        {
            frm_AgregarMedicamento.btnAgregar.Click += new EventHandler(AgregarMedicamento);
            frm_AgregarMedicamento.btnVerificar.Click += new EventHandler(VerificarCodigoMedicamento);
            frm_AgregarMedicamento.txtCodigo.KeyDown += new KeyEventHandler(VerificarCodigoMedicamentoEnter);
            frm_AgregarMedicamento.btnLimpiar.Click += new EventHandler(Limpiar);
            frm_AgregarMedicamento.txtCantidadDisponible.KeyPress += new KeyPressEventHandler(ValidarCantidadDisponible);
            frm_AgregarMedicamento.txtMedida.KeyPress += new KeyPressEventHandler(ValidarMedida);
        }

        public void ValidarCantidadDisponible(object sender, KeyPressEventArgs e)
        {
            frm_AgregarMedicamento.SoloNumeros(e);
        }

        public void ValidarMedida(object sender, KeyPressEventArgs e)
        {
            frm_AgregarMedicamento.SoloNumeros(e);
        }

        private void VerificarCodigoMedicamento(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frm_AgregarMedicamento.GetCodigo()))
            {
                
                    if (!connectionDB.ExisteCodigoMedicamento(frm_AgregarMedicamento.GetCodigo()))
                    {
                        frm_AgregarMedicamento.ActivarCampos();
                    }
                    else
                    {
                        frm_AgregarMedicamento.MensajeError("El código de medicamento ingresado no se encuentra en los registros.");
                    }             

            }
            else
            {
                frm_AgregarMedicamento.MensajeError("El campo \"código de medicamento\" se encuentra vacío.");

            }

        }


        public void VerificarCodigoMedicamentoEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(frm_AgregarMedicamento.GetCodigo()))
                {

                    if (!connectionDB.ExisteCodigoMedicamento(frm_AgregarMedicamento.GetCodigo()))
                    {
                        frm_AgregarMedicamento.ActivarCampos();
                    }
                    else
                    {
                        frm_AgregarMedicamento.MensajeError("El código de medicamento ingresado no se encuentra en los registros.");
                    }

                }
                else
                {
                    frm_AgregarMedicamento.MensajeError("El campo \"código de medicamento\" se encuentra vacío.");

                }
                e.SuppressKeyPress = true; //remove ding windows sound.

            }
        }

        private void Limpiar(object sender, EventArgs e)
        {
            frm_AgregarMedicamento.EstadoInicial();
        }

        private void AgregarMedicamento(object sender, EventArgs e)
        {
            if (!frm_AgregarMedicamento.VerificarCampos())
            {
                if (frm_AgregarMedicamento.ShowConfirmation())
                {
                    if (connectionDB.AgregarMedicamento(frm_AgregarMedicamento.GetMedicamento()))
                    {
                        frm_AgregarMedicamento.MensajeInformativo("Se ha agregado el nuevo medicamento con éxito.");
                        frm_AgregarMedicamento.EstadoInicial();
                    }
                    else
                    {
                        frm_AgregarMedicamento.ShowMessage("Se ha producido un error.\nVerifique los datos.");

                    }
                }
                else
                {
                    frm_AgregarMedicamento.MensajeError("No se ha agregado el medicamento.");
                }

            }
            else
            {
                frm_AgregarMedicamento.ShowMessage("Algunos campos se encuentran vacíos." +
                    "\nLos campos con el asterisco (*) rojo son aquellos que deben ser modificados.");
            }
        }


    }
}
