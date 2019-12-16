using HogarAncianos.Model;
using HogarAncianos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            frm_consultarPrescripcion.EstadoInicial();

        }//fin del constructor

        public void AgregarEventos()
        {
            frm_consultarPrescripcion.btnBuscar.Click += new EventHandler(RealizarBusqueda);
            frm_consultarPrescripcion.txtCedulaPaciente.KeyDown += new KeyEventHandler(RealizarBusquedaEnter);
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
            frm_consultarPrescripcion.RealizarReporte();
        }//metodo para los reportes

        public void RealizarBusqueda(object sender, EventArgs e)
        {
            frm_consultarPrescripcion.Limpiar();
            if (frm_consultarPrescripcion.verificar())
            {
                if (frm_consultarPrescripcion.GetBusquedaPrescripcion() != "")
                {
                    if (connectionDB.GetBusquedaPrescripcion(frm_consultarPrescripcion.GetBusquedaPrescripcion())!=null)
                    {
                        if (connectionDB.GetBusquedaPrescripcion(frm_consultarPrescripcion.GetBusquedaPrescripcion()).Tables[0].Rows.Count >= 1)
                        {
                            frm_consultarPrescripcion.FillBusqueda(connectionDB.GetBusquedaPaciente(frm_consultarPrescripcion.GetBusquedaPrescripcion()));

                        }
                        else
                        {
                            frm_consultarPrescripcion.MensajeInformativo("No se han encontrado resultados para la búsqueda especificada.");
                        }

                    }
                    else
                    {
                        frm_consultarPrescripcion.MensajeError("No se han encontrado resultados.");
                    }
                   
                }
                else
                {
                    frm_consultarPrescripcion.MensajeError("No se han encontrado resultados.");
                }
            }
            else
            {
                frm_consultarPrescripcion.MensajeError("Verifique los datos ingresados ");
            }
               

            

        }//metodo de busqueda

        public void RealizarBusquedaEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frm_consultarPrescripcion.Limpiar();
                if (frm_consultarPrescripcion.verificar())
                {
                    if (frm_consultarPrescripcion.GetBusquedaPrescripcion() != "")
                    {
                        if (connectionDB.GetBusquedaPrescripcion(frm_consultarPrescripcion.GetBusquedaPrescripcion()) != null)
                        {
                            if (connectionDB.GetBusquedaPrescripcion(frm_consultarPrescripcion.GetBusquedaPrescripcion()).Tables[0].Rows.Count >= 1)
                            {
                                frm_consultarPrescripcion.FillBusqueda(connectionDB.GetBusquedaPaciente(frm_consultarPrescripcion.GetBusquedaPrescripcion()));

                            }
                            else
                            {
                                frm_consultarPrescripcion.MensajeInformativo("No se han encontrado resultados para la búsqueda especificada.");
                            }

                        }
                        else
                        {
                            frm_consultarPrescripcion.MensajeError("No se han encontrado resultados.");
                        }

                    }
                    else
                    {
                        frm_consultarPrescripcion.MensajeError("No se han encontrado resultados.");
                    }
                }
                else
                
                    frm_consultarPrescripcion.MensajeError("Verifique los datos ingresados ");
                e.SuppressKeyPress = true; //remove ding windows sound.


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
            if (connectionDB.GetAllPrescripciones().Tables[0].Rows.Count>0)
            {
                frm_consultarPrescripcion.FillBusqueda(connectionDB.GetAllPrescripciones());
            }
            else
            {
                frm_consultarPrescripcion.MensajeError("No se han encontrado resultados.");
            }
            
        }//metodo que devuelve todas las prescripciones 




    }//fin de la clase
}//fin del namespace
