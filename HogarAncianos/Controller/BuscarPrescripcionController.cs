using HogarAncianos.Model;
using HogarAncianos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogarAncianos.Controller
{
    public class BuscarPrescripcionController
    {
        FRM_ConsultaPrescripcion frm_consultarPrescripcion;
        ConnectionDB connectionDB;

        public BuscarPrescripcionController(FRM_ConsultaPrescripcion frm_consultarPrescripcion)
        {
            this.connectionDB = new ConnectionDB();
            this.frm_consultarPrescripcion = frm_consultarPrescripcion;
            AgregarEventos();

        }//fin del constructor

        public void AgregarEventos()
        {
            frm_consultarPrescripcion.btnBuscar.Click += new EventHandler(RealizarBusqueda);
            frm_consultarPrescripcion.btnCancelar.Click += new EventHandler(EstadoInicial);
            frm_consultarPrescripcion.checkBoxFechaCaducidad.Click += new EventHandler(activarDesactivarFechaCaducidad);
            frm_consultarPrescripcion.checkBoxCodigoMedicamento.Click += new EventHandler(activarDesactivarCodigo);
            frm_consultarPrescripcion.btnTodosLosResultados.Click += new EventHandler(TodoslasPrescripciones);
            frm_consultarPrescripcion.btnReporteMedicamentos.Click += new EventHandler(Reporte);

        }//fin del metodo que agrega los eventos
        //---------------------
        //--------------------------
        //-------------------------

        public void Reporte(object sender, EventArgs e)
        {
            //   falta
        }//metodo para los reportes

        public void RealizarBusqueda(object sender, EventArgs e)
        {


            if (connectionDB.GetBusquedaPrescripcion(frm_consultarPrescripcion.GetBusquedaPrescripcion()).Tables[0].Rows.Count >= 1)
            {
                frm_consultarPrescripcion.FillBusqueda(connectionDB.GetBusquedaPaciente(frm_consultarPrescripcion.GetBusquedaPrescripcion()));

            }
            else
            {
                frm_consultarPrescripcion.MensajeInformativo("No se han encontrado resultados para la búsqueda especificada.");
            }

        }//metodo de busqueda

        public void EstadoInicial(object sender, EventArgs e)
        {
            frm_consultarPrescripcion.EstadoInicial();
        }//metodo de estado inicial

        public void activarDesactivarFechaCaducidad(object sender, EventArgs e)
        {
            frm_consultarPrescripcion.activarDesactivarBuscarPorFecha();
        }//metodo activar desactivar check box fecha 

        public void activarDesactivarCodigo(object sender, EventArgs e)
        {
            frm_consultarPrescripcion.activarDesactivarBuscarPorCodigo();
        }//metodo activar desactivar codigo

        public void TodoslasPrescripciones(object sender, EventArgs e)
        {
            frm_consultarPrescripcion.FillBusqueda(connectionDB.GetAllPrescripciones());
        }//metodo que devuelve todas las prescripciones 




    }//fin de la clase
}//fin del namespace
