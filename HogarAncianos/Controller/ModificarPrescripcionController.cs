using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HogarAncianos.View;
using HogarAncianos.Model;

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
            fRM_ModificarPrescripcion.btnSeleccionar.Click += new EventHandler(Seleccionar);
            fRM_ModificarPrescripcion.btnSeleccionarMedicamento.Click += new EventHandler(SeleccionarMedicamento);
            fRM_ModificarPrescripcion.btnLimpiar.Click += new EventHandler(Limpiar);

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
                    fRM_ModificarPrescripcion.MensajeError("La cedula ingresada no existe");
                }
            }
            else
            {
                fRM_ModificarPrescripcion.MensajeError("Hay campos vacios");
            }
           
        }

        


    }
}
