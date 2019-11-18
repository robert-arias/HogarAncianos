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
            FillPacientes();
            AgregarEventosModificarPaciente();
        }

        private void AgregarEventosModificarPaciente()
        {
            //frm_AgregarPaciente.btnAgregar.Click += new EventHandler(AgregarPaciente);
            //frm_AgregarPaciente.btnVerificar.Click += new EventHandler(VerificarCedulaPaciente);
            //frm_AgregarPaciente.txtCedula.KeyDown += new KeyEventHandler(VerificarCedulaPacienteEnter);
            //frm_AgregarPaciente.btnLimpiar.Click += new EventHandler(Limpiar);

            frm_ModificarPaciente.cbCedulaIdentidad.SelectedIndexChanged += new EventHandler(llenarCampos);

        }

        private void FillPacientes()
        {
            frm_ModificarPaciente.FillPacientes(connectionDB.GetAllPacientes());
        }

        private void llenarCampos(object sender, EventArgs e)
        {
            if (connectionDB.GetPaciente(frm_ModificarPaciente.GetCedula())!= null)
            {
                frm_ModificarPaciente.llenarCampos(connectionDB.GetPaciente(frm_ModificarPaciente.GetCedula()));
            }
        }

    }
}
