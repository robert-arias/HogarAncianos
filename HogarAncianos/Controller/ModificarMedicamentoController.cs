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
    class ModificarMedicamentoController
    {
        FRM_ModificarMedicamento frm_ModificarMedicamento;
        private ConnectionDB connectionDB;
        public ModificarMedicamentoController(FRM_ModificarMedicamento frm_ModificarMedicamento)
        {
            this.frm_ModificarMedicamento = frm_ModificarMedicamento; ;
            connectionDB = new ConnectionDB();
            AgregarEventosMedicamentos();
        }

      
        public void llenarCampos()
        {
            if (connectionDB.GetMedicamento(frm_ModificarMedicamento.GetCodigo()).Tables[0].Rows.Count != 0)
            {
                frm_ModificarMedicamento.llenarCampos(connectionDB.GetMedicamento(frm_ModificarMedicamento.GetCodigo()));
                frm_ModificarMedicamento.ActivarCampos();
            }
            
        }


        private void AgregarEventosMedicamentos()
        {
            frm_ModificarMedicamento.btnModificar.Click += new EventHandler(ModificarMedicamento);
            frm_ModificarMedicamento.btnVerificar.Click += new EventHandler(VerificarCodigoMedicamento);
            frm_ModificarMedicamento.txtCodigo.KeyDown += new KeyEventHandler (VerificarCodigoMedicamentoEnter);
            frm_ModificarMedicamento.btnLimpiar.Click += new EventHandler(Limpiar);
            frm_ModificarMedicamento.txtCantidadDisponible.KeyPress += new KeyPressEventHandler(ValidarCantidadDisponible);
            frm_ModificarMedicamento.txtMedida.KeyPress += new KeyPressEventHandler(ValidarMedida);



        }

        public void ValidarCantidadDisponible(object sender, KeyPressEventArgs e)
        {
            frm_ModificarMedicamento.SoloNumeros(e);
        }

        public void ValidarMedida(object sender, KeyPressEventArgs e)
        {
            frm_ModificarMedicamento.SoloNumeros(e);
        }

        private void ModificarMedicamento(object sender, EventArgs e)
        {
            if (!frm_ModificarMedicamento.VerificarCampos())
            {
                if (frm_ModificarMedicamento.ShowConfirmation())
                {
                    connectionDB.UpdateMedicamento(frm_ModificarMedicamento.GetMedicamento());
                    frm_ModificarMedicamento.MensajeInformativo("Medicamento modificado con éxito");
                    frm_ModificarMedicamento.EstadoInicial();
                }
                else
                {
                    frm_ModificarMedicamento.MensajeError("No se ha modificado el medicamento.");
                }
                
            }
            else
            {
                frm_ModificarMedicamento.MensajeError("Algunos campos se encuentran vacíos." +
                    "\nLos campos con el asterisco (*) rojo son aquellos que deben ser modificados.");
            }

        }



        private void VerificarCodigoMedicamento(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frm_ModificarMedicamento.GetCodigo()))
            {

                if (connectionDB.ExisteCodigoMedicamento(frm_ModificarMedicamento.GetCodigo()))
                {

                    llenarCampos();

                }
                else
                {
                    frm_ModificarMedicamento.MensajeError("El código de medicamento ingresado no se encuentra en los registros.");
                }

            }
            else
            {
                frm_ModificarMedicamento.MensajeError("El campo \"código de medicamento\" se encuentra vacío.");

            }

        }


        public void VerificarCodigoMedicamentoEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(frm_ModificarMedicamento.GetCodigo()))
                {

                    if (connectionDB.ExisteCodigoMedicamento(frm_ModificarMedicamento.GetCodigo()))
                    {

                        llenarCampos();

                    }
                    else
                    {
                        frm_ModificarMedicamento.MensajeError("El código de medicamento ingresado no se encuentra en los registros.");
                    }

                }
                else
                {
                    frm_ModificarMedicamento.MensajeError("El campo \"código de medicamento\" se encuentra vacío.");

                }
                e.SuppressKeyPress = true; //remove ding windows sound.

            }
        }

        private void Limpiar(object sender, EventArgs e)
        {
            frm_ModificarMedicamento.EstadoInicial();
        }
    }
}
