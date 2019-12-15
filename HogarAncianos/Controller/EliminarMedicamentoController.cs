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
    public class EliminarMedicamentoController
    {
        FRM_EliminarMedicamento fRM_EliminarMedicamento;
        ConnectionDB connectionDB;
        public EliminarMedicamentoController(FRM_EliminarMedicamento fRM_EliminarMedicamento)
        {
            this.fRM_EliminarMedicamento = fRM_EliminarMedicamento;
            this.connectionDB = new ConnectionDB();
            AgregarEventosMedicamentos();
        }



        private void AgregarEventosMedicamentos()
        {
            fRM_EliminarMedicamento.btnEliminar.Click += new EventHandler(ElminarMedicamento);
            fRM_EliminarMedicamento.btnVerificar.Click += new EventHandler(VerificarCodigoMedicamento);
            fRM_EliminarMedicamento.btnVerificar.KeyDown += new KeyEventHandler(VerificarCodigoMedicamentoEnter);
            fRM_EliminarMedicamento.btnLimpiar.Click += new EventHandler(Limpiar);


        }

      

        private void ElminarMedicamento(object sender, EventArgs e)
        {
            if (!fRM_EliminarMedicamento.VerificarCampos())
            {
                if (connectionDB.ExisteMedicamentoEnPrescripcion(fRM_EliminarMedicamento.GetCodigo()) > 0)
                {
                    if (fRM_EliminarMedicamento.ShowConfirmation1())
                    {

                        if (connectionDB.DeletePrescripcion(fRM_EliminarMedicamento.GetCodigo(), connectionDB.GetPrescripciones_Medicamentos()))
                        {

                                if (connectionDB.DeleteMedicamento(fRM_EliminarMedicamento.GetCodigo()))
                                {
                                    fRM_EliminarMedicamento.ShowMessage("Medicamento eliminado con exito.");
                                    fRM_EliminarMedicamento.EstadoInicial();
                                }
                                else
                                {
                                    fRM_EliminarMedicamento.ShowMessage("El medicamento no se elimino de los registros ");
                                }

                        }
                        else
                        {
                            fRM_EliminarMedicamento.ShowMessage("El medicamento no se elimino de los registros.");
                        }
                    }
                    else
                    {
                        fRM_EliminarMedicamento.ShowMessage("El medicamento no se elimino de los registros.");
                    }
                  
                }
                else
                {
                    if (fRM_EliminarMedicamento.ShowConfirmation())
                    {
                        if (connectionDB.DeleteMedicamento(fRM_EliminarMedicamento.GetCodigo()))
                        {
                            fRM_EliminarMedicamento.ShowMessage("Medicamento eliminado con exito ");
                            fRM_EliminarMedicamento.EstadoInicial();
                        }
                        else
                        {
                            fRM_EliminarMedicamento.ShowMessage("El medicamento no se elimino.");
                        }
                    }
                    else
                    {
                        fRM_EliminarMedicamento.ShowMessage("El medicamento no se elimino.");
                    }
                   
                }
               
            }
            else
            {
                fRM_EliminarMedicamento.MensajeError("El campo \"código de medicamento\" se encuentra vacío.");
            }

        }

        public void VerificarCodigoMedicamentoEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(fRM_EliminarMedicamento.GetCodigo()))
                {

                    if (connectionDB.ExisteCodigoMedicamento(fRM_EliminarMedicamento.GetCodigo()))
                    {
                        llenarCampos();
                        fRM_EliminarMedicamento.ActivarCampo();
                    }
                    else
                    {
                        fRM_EliminarMedicamento.ShowMessage("El codigo de medicamento ingresado no se encuentra en los registros.");
                    }

                }
                else
                {
                    fRM_EliminarMedicamento.ShowMessage("El campo \"codigo de medicamento\" se encuentra vacío.");

                }
                e.SuppressKeyPress = true; //remove ding windows sound.

            }
        }


        private void VerificarCodigoMedicamento(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fRM_EliminarMedicamento.GetCodigo()))
            {

                if (connectionDB.ExisteCodigoMedicamento(fRM_EliminarMedicamento.GetCodigo()))
                {

                    llenarCampos();
                    fRM_EliminarMedicamento.ActivarCampo();
                }
                else
                {
                    fRM_EliminarMedicamento.ShowMessage("El codigo de medicamento ingresado no se encuentra en los registros.");
                }

            }
            else
            {
                fRM_EliminarMedicamento.ShowMessage("El campo \"codigo de medicamento\" se encuentra vacío.");

            }

        }

        public void llenarCampos()
        {
            if (connectionDB.GetMedicamento(fRM_EliminarMedicamento.GetCodigo()).Tables[0].Rows.Count != 0)
            {
                fRM_EliminarMedicamento.llenarCampos(connectionDB.GetMedicamento(fRM_EliminarMedicamento.GetCodigo()));              
            }

        }

        private void Limpiar(object sender, EventArgs e)
        {
            fRM_EliminarMedicamento.EstadoInicial();
        }



    }
}
