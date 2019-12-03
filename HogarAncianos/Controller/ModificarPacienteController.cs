using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HogarAncianos.View;
using HogarAncianos.Controller;
using HogarAncianos.Model;

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
            frm_ModificarPaciente.btnLimpiar.Click += new EventHandler(limpiar);        
          ////  frm_ModificarPaciente.cbCedulaIdentidad.SelectedIndexChanged += new EventHandler(llenarCampos);
            //frm_ModificarPaciente.btnModificar.Click += new EventHandler(ModificarPaciente);

        }

        //private void FillPacientes()
        //{
        //    frm_ModificarPaciente.FillPacientes(connectionDB.GetAllPacientes());
        //}

        private void limpiar(object sender, EventArgs e)
        {
            frm_ModificarPaciente.EstadoInicial();
        }

        private void llenarCampos(object sender, EventArgs e)
        {
            if (connectionDB.GetPaciente(frm_ModificarPaciente.GetCedula()).Tables[0].Rows.Count!=0)
            {
                frm_ModificarPaciente.llenarCampos(connectionDB.GetPaciente(frm_ModificarPaciente.GetCedula()));
                frm_ModificarPaciente.ActivarCampos();
            }
        }

        //private void ModificarPaciente(object sender, EventArgs e)
        //{
        //    if (!frm_ModificarPaciente.VerificarCampos())
        //    {
        //        connectionDB.UpdatePaciente(frm_ModificarPaciente.GetPaciente());
        //        frm_ModificarPaciente.ShowMessage("Paciente modificado con exito");
        //        frm_ModificarPaciente.EstadoInicial();
        //        FillPacientes();


        //    }
        //    else
        //    {
        //        frm_ModificarPaciente.ShowMessage("Espacios vacios ");
        //    }

        //}

        

    }
}
