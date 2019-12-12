using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HogarAncianos.View;
using HogarAncianos.Model;

namespace HogarAncianos.Controller
{
    class BuscarPacientesController
    {
        ConnectionDB connectionDB;
        FRM_ConsultaPacientes frm_ConsultaPacientes;
        public BuscarPacientesController(FRM_ConsultaPacientes frm_ConsultaPacientes)
        {
            this.frm_ConsultaPacientes = frm_ConsultaPacientes;
            connectionDB = new ConnectionDB();
            AgregarEventos();
           
        }

        public void AgregarEventos()
        {
            frm_ConsultaPacientes.btnCancelar.Click += new EventHandler(EstadoInicial);
           frm_ConsultaPacientes.btnBuscar.Click += new EventHandler(RealizarBusqueda);
            frm_ConsultaPacientes.checkBoxSexo.Click += new EventHandler(ActivarDesactivarSexo);
            frm_ConsultaPacientes.checkBoxCedula.Click += new EventHandler(ActivarDesactivarCedula);
            frm_ConsultaPacientes.checkBoxNombre.Click += new EventHandler(ActivarDesactivarNombre);
            frm_ConsultaPacientes.checkBoxEdad.Click += new EventHandler(ActivarDesactivarEdad);
            frm_ConsultaPacientes.checkBoxApellidos.Click += new EventHandler(ActivarDesactivarApellidos);
            frm_ConsultaPacientes.btnTodosLosResultados.Click += new EventHandler(TodosLosPacientes);
            frm_ConsultaPacientes.btnReportePacientes.Click += new EventHandler(Reporte);
        }

        public void Reporte(object sender, EventArgs e)
        {
            frm_ConsultaPacientes.RealizarReporte();
        }

        public void EstadoInicial(object sender, EventArgs e)
        {
            frm_ConsultaPacientes.EstadoInicial();
        }

        public void TodosLosPacientes(object sender, EventArgs e)
        {
            frm_ConsultaPacientes.FillBusqueda(connectionDB.GetAllPacientes());
           
        }

        public void ActivarDesactivarCedula(object sender, EventArgs e)
        {
            frm_ConsultaPacientes.ActivarDesactivarBuscarPorCedula();
        }

        public void ActivarDesactivarNombre(object sender, EventArgs e)
        {
            frm_ConsultaPacientes.ActivarDesactivarBuscarPorNombre();
        }

        public void ActivarDesactivarApellidos(object sender, EventArgs e)
        {
            frm_ConsultaPacientes.ActivarDesactivarBuscarPorApellido();
        }

        public void ActivarDesactivarEdad(object sender, EventArgs e)
        {
            frm_ConsultaPacientes.ActivarDesactivarBuscarPorEdad();
        }

        public void ActivarDesactivarSexo(object sender, EventArgs e)
        {
            frm_ConsultaPacientes.ActivarDesactivarBuscarPorSexo();
        }

      
        public void RealizarBusqueda(object sender, EventArgs e)
        {
            if (frm_ConsultaPacientes.verificar())
            {
                if (connectionDB.GetBusquedaPaciente(frm_ConsultaPacientes.GetBusquedaPacientes()).Tables[0].Rows.Count >= 1)
                {
                    frm_ConsultaPacientes.FillBusqueda(connectionDB.GetBusquedaPaciente(frm_ConsultaPacientes.GetBusquedaPacientes()));
                   
                }
                else
                {
                    frm_ConsultaPacientes.MensajeInformativo("No se han encontrado resultados para la búsqueda especificada.");
                }
               
            }
            else
            {
                frm_ConsultaPacientes.MensajeError("Verifique que todos los datos selecccionados e ingresados " +
                    "sean correctos.");
            } 

        }
    }
}
